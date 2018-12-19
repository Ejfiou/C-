using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySchool.Model;
using MySchool.ViewModel;

namespace MySchool.DALMSSQL
{
    public class DALTeacher
    {
        private DBHelper helper = new DBHelper();

        public IEnumerable<Teacher> QueryAll()
        {
            string strSQL = "SELECT [TeacherGUID],[LoginId],[LoginPwd],[UserStateId],[TeacherName],[Sex],[Birthday],[Subject].[SubjectGUID],[SubjectName],[GradeGuid]FROM [dbo].[Teacher]"
                + " LEFT JOIN [Subject] ON [Teacher].[SubjectGUID]=[Subject].[SubjectGUID]";
            using (IDataReader reader =helper.ExecuteReader(strSQL))
            {
                while (reader.Read())
                {
                    yield return new Teacher()
                    {
                        TeacherGuid = reader.GetString(reader.GetOrdinal("TeacherGuid")),
                        LoginId = reader.GetString(reader.GetOrdinal("LoginId")),
                        LoginPwd = reader.GetString(reader.GetOrdinal("LoginPwd")),
                        UserStateId = reader.GetInt32(reader.GetOrdinal("UserStateId")),
                        TeacherName = reader.GetString(reader.GetOrdinal("TeacherName")),
                        Sex = reader.IsDBNull(reader.GetOrdinal("Sex")) ? null : reader.GetString(reader.GetOrdinal("Sex")),
                        Birthday = reader.IsDBNull(reader.GetOrdinal("Birthday")) ? new Nullable<DateTime>() : reader.GetDateTime(reader.GetOrdinal("Birthday")),
                        SubjectGUID = reader.IsDBNull(reader.GetOrdinal("SubjectGUID")) ? null : reader.GetString(reader.GetOrdinal("SubjectGUID")),
                        Subject = new Subject()
                        {
                            SubjectGuid = reader.IsDBNull(reader.GetOrdinal("SubjectGuid"))?null: reader.GetString(reader.GetOrdinal("SubjectGuid")),
                            SubjectName = reader.IsDBNull(reader.GetOrdinal("SubjectName")) ? null : reader.GetString(reader.GetOrdinal("SubjectName")),
                            GradeGuid = reader.IsDBNull(reader.GetOrdinal("GradeGuid")) ? null : reader.GetString(reader.GetOrdinal("GradeGuid")),
                            
                        }
                     };
                   
                }
            }
        }

        public IEnumerable<Teacher> Query(TeacherQueryParameter parameter)
        {
            string strSQL = "SELECT [TeacherGUID],[LoginId],[LoginPwd],[UserStateId],[TeacherName],[Sex],[Birthday],[Subject].[SubjectGUID],[SubjectName],[GradeGuid]FROM [dbo].[Teacher]"
                + " LEFT JOIN [Subject] ON [Teacher].[SubjectGUID]=[Subject].[SubjectGUID]"
                + " where(charindex(@TeacherName,[TeacherName]) > 0 or Len(@TeacherName) = 0) and(sex = @sex or len(@sex) = 0)and(Teacher.SubjectGUID = @SubjectGUID or len(@SubjectGUID) = 0) order by LoginId";
            using (IDataReader reader = helper.ExecuteReader(strSQL,
                CommandType.Text,
                new SqlParameter("@TeacherName",parameter.TeacherName??""),
                new SqlParameter("@Sex", parameter.Sex ?? ""),
                new SqlParameter("@SubjectGUID", parameter.SubjectGUID ?? "")
                ))
            {
                while (reader.Read())
                {
                    yield return new Teacher()
                    {
                        TeacherGuid = reader.GetString(reader.GetOrdinal("TeacherGuid")),
                        LoginId = reader.GetString(reader.GetOrdinal("LoginId")),
                        LoginPwd = reader.GetString(reader.GetOrdinal("LoginPwd")),
                        UserStateId = reader.GetInt32(reader.GetOrdinal("UserStateId")),
                        TeacherName = reader.GetString(reader.GetOrdinal("TeacherName")),
                        Sex = reader.IsDBNull(reader.GetOrdinal("Sex")) ? null : reader.GetString(reader.GetOrdinal("Sex")),
                        Birthday = reader.IsDBNull(reader.GetOrdinal("Birthday")) ? new Nullable<DateTime>() : reader.GetDateTime(reader.GetOrdinal("Birthday")),
                        SubjectGUID = reader.IsDBNull(reader.GetOrdinal("SubjectGUID")) ? null : reader.GetString(reader.GetOrdinal("SubjectGUID")),
                        Subject = new Subject()
                        {
                            SubjectGuid = reader.IsDBNull(reader.GetOrdinal("SubjectGuid")) ? null : reader.GetString(reader.GetOrdinal("SubjectGuid")),
                            SubjectName = reader.IsDBNull(reader.GetOrdinal("SubjectName")) ? null : reader.GetString(reader.GetOrdinal("SubjectName")),
                            GradeGuid = reader.IsDBNull(reader.GetOrdinal("GradeGuid")) ? null : reader.GetString(reader.GetOrdinal("GradeGuid")),

                        }
                    };

                }
            }
        }

        public Task<IEnumerable<Teacher>> QueryAsync(TeacherQueryParameter parameter)
        {
            return Task<IEnumerable<Teacher>>.Run(() =>
            {
                return Query(parameter);
            });
        }

        public IEnumerable<Teacher> QueryPage(TeacherQueryParameter parameter)
        {
            int totalRows = 0;
            
            string strSQL = "with t as "
                + " (SELECT [TeacherGUID],[LoginId],[LoginPwd],[UserStateId],[TeacherName],[Sex],[Birthday],[Subject].[SubjectGUID],[SubjectName],[GradeGuid]FROM [dbo].[Teacher]"
                + " LEFT JOIN [Subject] ON [Teacher].[SubjectGUID]=[Subject].[SubjectGUID]"
                + " where(charindex(@TeacherName,[TeacherName]) > 0 or Len(@TeacherName) = 0) and(sex = @sex or len(@sex) = 0)and(Teacher.SubjectGUID = @SubjectGUID or len(@SubjectGUID) = 0))"
                + "SELECT Top (@pageMaxRowNumber) * ,'Total'=(select count(*) from t) from t"
                + " where loginId not in (select top ((@pageNumber - 1) * @pageMaxRowNumber) loginid from t order by LoginId) order by LoginId";
            using (IDataReader reader = helper.ExecuteReader(strSQL,
                CommandType.Text,
                new SqlParameter("@pageMaxRowNumber", parameter.PageMaxRowNumber),
                new SqlParameter("@pageNumber", parameter.PageNumber),
                new SqlParameter("@TeacherName", parameter.TeacherName ?? ""),
                new SqlParameter("@Sex", parameter.Sex ?? ""),
                new SqlParameter("@SubjectGUID", parameter.SubjectGUID ?? "")
                ))
            {
                while (reader.Read())
                {
                    totalRows = reader.GetInt32(reader.GetOrdinal("Total"));
                    parameter.PageTotalNumber =Convert.ToInt32(Math.Ceiling(totalRows *1.0 / parameter.PageMaxRowNumber));
                    yield return new Teacher()
                    {
                        TeacherGuid = reader.GetString(reader.GetOrdinal("TeacherGuid")),
                        LoginId = reader.GetString(reader.GetOrdinal("LoginId")),
                        LoginPwd = reader.GetString(reader.GetOrdinal("LoginPwd")),
                        UserStateId = reader.GetInt32(reader.GetOrdinal("UserStateId")),
                        TeacherName = reader.GetString(reader.GetOrdinal("TeacherName")),
                        Sex = reader.IsDBNull(reader.GetOrdinal("Sex")) ? null : reader.GetString(reader.GetOrdinal("Sex")),
                        Birthday = reader.IsDBNull(reader.GetOrdinal("Birthday")) ? new Nullable<DateTime>() : reader.GetDateTime(reader.GetOrdinal("Birthday")),
                        SubjectGUID = reader.IsDBNull(reader.GetOrdinal("SubjectGUID")) ? null : reader.GetString(reader.GetOrdinal("SubjectGUID")),
                        Subject = new Subject()
                        {
                            SubjectGuid = reader.IsDBNull(reader.GetOrdinal("SubjectGuid")) ? null : reader.GetString(reader.GetOrdinal("SubjectGuid")),
                            SubjectName = reader.IsDBNull(reader.GetOrdinal("SubjectName")) ? null : reader.GetString(reader.GetOrdinal("SubjectName")),
                            GradeGuid = reader.IsDBNull(reader.GetOrdinal("GradeGuid")) ? null : reader.GetString(reader.GetOrdinal("GradeGuid")),
                        }
                    };
                }
            }
        }

        public Task<IEnumerable<Teacher>> QueryPageAsync(TeacherQueryParameter parameter)
        {
            return Task<IEnumerable<Teacher>>.Run(() =>
            {
                return QueryPage(parameter);
            });
        }

        public int Add(Teacher teacher)
        {
            string strSQL = "insert into Teacher(TeacherGUID,LoginID,LogInPwd,UserStateID,TeacherName,sex,birthday,subjectGuid) values(@TeacherGUID,@LoginID,@LogInPwd,@UserStateID,@TeacherName,@sex,@birthday,@subjectGuid)";

            return helper.ExecuteNonQuery(strSQL,
                CommandType.Text,
                new SqlParameter("@TeacherGUID", teacher.TeacherGuid),
                new SqlParameter("@LoginID", teacher.LoginId),
                new SqlParameter("@LogInPwd", teacher.LoginPwd),
                new SqlParameter("@UserStateID", teacher.UserStateId),
                new SqlParameter("@TeacherName", teacher.TeacherName),
                new SqlParameter("@sex", teacher.Sex ?? (object)DBNull.Value),
                new SqlParameter("@birthday", teacher.Birthday ?? (object)DBNull.Value),

                new SqlParameter("@subjectGuid", teacher.SubjectGUID ?? (object)DBNull.Value)
                );
        }

        public Teacher QueryByPK(string guid)
        {
            Teacher teacher = null;
            string strSQL = "SELECT [LoginId],[UserStateid],TeacherGUID,LogInPwd,[Teacher].[SubjectGUID],[GradeGuid],[TeacherName],[Sex],[Birthday],[SubjectName]FROM [dbo].[Teacher]" +
                         "Left join[subject] on[Teacher].[SubjectGUID] =[Subject].[SubjectGUID]" +
                         "where teacherguid=@TeacherGuid";
            using (IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@TeacherGuid", guid)))
            {
                if (reader.Read())
                {
                    teacher = new Teacher()
                    {
                        TeacherGuid = reader.GetString(reader.GetOrdinal("TeacherGUID")),
                        LoginPwd = reader.GetString(reader.GetOrdinal("LoginPwd")),
                        LoginId = reader.GetString(reader.GetOrdinal("LoginId")),
                        UserStateId = reader.GetInt32(reader.GetOrdinal("UserStateId")),
                        TeacherName = reader.GetString(reader.GetOrdinal("TeacherName")),
                        Sex = reader.IsDBNull(reader.GetOrdinal("Sex")) ? null : reader.GetString(reader.GetOrdinal("Sex")),
                        Birthday = reader.IsDBNull(reader.GetOrdinal("Birthday")) ? new Nullable<DateTime>() : reader.GetDateTime(reader.GetOrdinal("Birthday")),
                        SubjectGUID = reader.IsDBNull(reader.GetOrdinal("SubjectGUID")) ? null : reader.GetString(reader.GetOrdinal("SubjectGUID")),
                        Subject = new Subject()
                        {
                            SubjectGuid = reader.IsDBNull(reader.GetOrdinal("SubjectGuid")) ? null : reader.GetString(reader.GetOrdinal("SubjectGuid")),
                            SubjectName = reader.IsDBNull(reader.GetOrdinal("SubjectName")) ? null : reader.GetString(reader.GetOrdinal("SubjectName")),
                            GradeGuid = reader.IsDBNull(reader.GetOrdinal("GradeGuid")) ? null : reader.GetString(reader.GetOrdinal("GradeGuid"))
                        }
                    };
                 }
            } 
            return teacher;
        }

        public int Modify(Teacher teacher)
        {
            int rows = 0;

            string strSQL = "update teacher set LoginID=@LoginID,LogInPwd=@LogInPwd,UserStateID=@UserStateID,TeacherName=@TeacherName,sex=@sex,birthday=@birthday,subjectGuid=@subjectGuid " +
                             "where teacherGuid = @TeacherGUID";

            rows = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                new SqlParameter("@TeacherGUID", teacher.TeacherGuid),
                new SqlParameter("@LoginID", teacher.LoginId),
                new SqlParameter("@UserStateID", teacher.UserStateId),
                new SqlParameter("@TeacherName", teacher.TeacherName),
                new SqlParameter("@LogInPwd", teacher.LoginPwd),
                new SqlParameter("@sex", teacher.Sex ?? (object)DBNull.Value),
                new SqlParameter("@birthday", teacher.Birthday ?? (object)DBNull.Value),
                new SqlParameter("@subjectGuid", teacher.SubjectGUID ?? (object)DBNull.Value));
           

                return rows;
        }

        public int Remove(Teacher teacher)
        {
            int rows = 0;

            string strSQL = "delete from teacher where TeacherGuid = @TeacherGUID";

            rows = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                new SqlParameter("@TeacherGUID", teacher.TeacherGuid));

            return rows;
        }


    }
}

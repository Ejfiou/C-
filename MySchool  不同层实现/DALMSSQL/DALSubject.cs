using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.Model;
using System.Data;
using System.Data.SqlClient;
namespace MySchool.DALMSSQL
{
    public class DALSubject
    {
        private DBHelper helper = new DBHelper();

        public IEnumerable<Subject> QueryAll()
        {
            //List<Subject> list = new List<Subject>();
            //List<Subject> list = null;

            string strSQL = "SELECT [SubjectGUID],[SubjectName],[GradeGUID]FROM [dbo].[Subject]";

            using (IDataReader reader = helper.ExecuteReader(strSQL,CommandType.Text))
            {
                while (reader.Read())
                {
                    //if (list == null)
                    //{
                    //    list = new List<Subject>();
                    //}
                    Subject subject = new Subject()
                    {
                        SubjectGuid = reader.GetString(reader.GetOrdinal("SubjectGuid")),
                        SubjectName = reader.GetString(reader.GetOrdinal("SubjectName")),
                        GradeGuid = reader.GetString(reader.GetOrdinal("GradeGuid"))
                    };

                    //list.Add(subject);
                    yield return subject;
                }
            }
            //return list;
        }

        public Task<IEnumerable<Subject>> QueryAllAsync()
        {
            return Task<object>.Run(() =>
            {
                return QueryAll();
            });
        }
    }
}

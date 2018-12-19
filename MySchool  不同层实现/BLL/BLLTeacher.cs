using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.DALMSSQL;
using MySchool.Model;
using MySchool.ViewModel;
namespace MySchool.BLL
{
    public class BLLTeacher
    {
        private  DALTeacher dalTeacher  = new DALTeacher();

        public IEnumerable<Teacher> QueryAll()
        {
            return dalTeacher.QueryAll();
        }

        public IEnumerable<Teacher> Query(TeacherQueryParameter parameter)
        {
            return dalTeacher.Query(parameter);
        }
        public Task<IEnumerable<Teacher>> QueryAsync(TeacherQueryParameter parameter)
        {
            return dalTeacher.QueryAsync(parameter);
        }

        public Task<IEnumerable<Teacher>> QueryPageAsync(TeacherQueryParameter parameter)
        {
            return dalTeacher.QueryPageAsync(parameter);
        }

        public int Add(Teacher teacher)
        {
            return dalTeacher.Add(teacher);
        }

        public Teacher QueryByPK(string guid)
        {
            return dalTeacher.QueryByPK(guid);
        }

        public int ModifyExcudePwd(Teacher teacher)
        {
            int rows = 0;

            Teacher oldTeacher = dalTeacher.QueryByPK(teacher.TeacherGuid);

            if (oldTeacher!=null)
            {
                teacher.LoginPwd = oldTeacher.LoginPwd;
                rows = dalTeacher.Modify(teacher);
            }
            
            return rows;
        }

        public int ModifyPwd(Teacher teacher)
        {
            int rows = 0;

            Teacher oldTeacher = dalTeacher.QueryByPK(teacher.TeacherGuid);

            if (oldTeacher != null)
            {
                oldTeacher.LoginPwd = teacher.LoginPwd;
                rows = dalTeacher.Modify(oldTeacher);
            }

            return rows;
        }

        public int Remove(Teacher teacher)
        {
            return dalTeacher.Remove(teacher);
        }
    }
}

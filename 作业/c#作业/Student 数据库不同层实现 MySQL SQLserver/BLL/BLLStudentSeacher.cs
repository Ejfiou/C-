using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.DALMySQL;
using Student.ModelStu;
using Student.ModelStuView;
namespace Student.BLL
{
    public class BLLStudentSeacher
    {
        private DALStudentSeacher dals = new DALStudentSeacher();
        public IEnumerable<Students> QueryAll(StudentQueryParameter p)
        {
            return dals.QueryAll(p);
        }

        public Task<IEnumerable<Students>> QueryAllAsync(StudentQueryParameter p)
        {
            return dals.QueryAllAsync(p);
        }

        public IEnumerable<Class> QueryClass()
        {
            return dals.QueryClass();
        }

        public IEnumerable<Students> QueryByStuGuid(StudentQueryParameter p)
        {
            return dals.QueryByStuGuid(p);
        }

        //public string SelectOldPwd(StudentQueryParameter p)
        //{
        //    return dals.SelectOldPwd(p);
        //}

        public bool Del(string stuGuid)
        {
            bool flag = false;
            if (dals.Delete(stuGuid) > 0)
            {
                flag = true;
            }
            return flag;
        }

        public bool Insert(Students stu)
        {
            bool flag = false;

            if (dals.Insert(stu) > 0)
            {
                flag = true;
            }
            return flag;
        }

        public bool UpdataPwd(string stuGuid, string pwd)
        {
            bool flag = false;
            int a = dals.UpdataPwd(stuGuid, pwd);

            if (a > 0)
            {
                flag = true;
            }
            return flag;
        }

        public bool Updata(Students stu)
        {
            bool flag = false;
            if (dals.Updata(stu) > 0)
            {
                flag = true;
            }
            return flag;
        }

    }
}

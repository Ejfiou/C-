using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySchool.Model;
using MySchool.DALMSSQL;
namespace MySchool.BLL
{
    public class BLLLogin
    {
        private DALAdmin dalAdmin = new DALAdmin();

        public bool Login(Admin adminQuery)
        {
            bool flag = false;

            Admin adminResult = dalAdmin.QueryFirst(adminQuery);

            if (adminResult != null)
            {
                if (adminResult.LoginPwd == adminQuery.LoginPwd)
                {
                    flag = true;                                       
                }
            }

            return flag;
        }
    }
}

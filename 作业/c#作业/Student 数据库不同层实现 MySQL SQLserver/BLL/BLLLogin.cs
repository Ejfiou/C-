using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.DALMySQL;
using Student.ModelStu;
namespace Student.BLL
{
    public class BLLLogin
    {
        private DALLogin log = new DALLogin();
        public bool Login(User u)
        {
            bool flag = false;

            if (log.Login(u)>0)
            {
                flag = true;
            }
            return flag;
        }
    }
}

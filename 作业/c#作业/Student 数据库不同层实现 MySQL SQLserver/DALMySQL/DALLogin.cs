using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Student.ModelStu;
using System.Data;
using Student.ModelStuView;
namespace Student.DALMySQL
{
    public class DALLogin
    {
        private DBHelper helper = new DBHelper();
        public int Login(User u)
        {
            string strSQL = "select COUNT(*) from Admin where LoginId = @loginId and LoginPwd = @loginPwd";

            int count = Convert.ToInt32(helper.ExecuteScalar(strSQL, CommandType.Text, new MySqlParameter("@loginId", u.LoginId),
                    new MySqlParameter("@loginPwd", u.LoginPwd)));
            return count;
        }
    }
}

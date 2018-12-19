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
    public class DALAdmin
    {
        private DBHelper helper = new DBHelper();

        public Admin QueryFirst(Admin adminQuery)
        {
            Admin adminResult = null;

            string strSQL = "SELECT [AdminGuid],[LoginId],[LoginPwd] FROM [dbo].[Admin]"+
                        "WHERE([LoginId] = @LoginId) AND([LoginPwd] = @LoginPwd or LEN(@LoginPwd) = 0)";

            using (IDataReader reader = helper.ExecuteReader(strSQL,
                CommandType.Text,
                new SqlParameter("@LoginId", adminQuery.LoginId ?? ""),
                new SqlParameter("@LoginPwd", adminQuery.LoginPwd ?? "")))
            {
                if (reader.Read())
                {
                    adminResult = new Admin() {
                        AdminGuid = reader.GetString(reader.GetOrdinal("AdminGuid")),
                        LoginId = reader.GetString(reader.GetOrdinal("LoginId")),
                        LoginPwd = reader.GetString(reader.GetOrdinal("LoginPwd"))
                    };
                }
            }
            return adminResult;
        }
    }
}

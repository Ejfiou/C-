using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    /// <summary>
    /// 数据仓库（数据库）
    /// </summary>
   public class Database
    {
        public Database()
        {
            this.users[0] = new User("admin", "admin", "管理员");
        }

        //学生信息数据存放
        //最多只能存放20个学生
        private Student[] students = new Student[20];
        /// <summary>
        /// 学生信息数据（学生信息表）
        /// </summary>
        public Student[] Students
        {
            get { return students;}
            set { students = value; }
        }

       
        // 登录用户信息数据存放
        //最多只能存放20个用户
        private User[] users = new User[20];
        public User[] Users
        {
            get { return users; }
            set { users = value; }
        }
    }
}

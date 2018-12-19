using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseSystem
{
     public class UserData
    {
        public UserData()
        {
            this.users[0] = new User("admin", "admin", "管理员");
            this.users[1] = new User("tom", "tom", "汤姆");
            this.users[2] = new User("123", "123", "123");
        }

        private User[] users = new User[20];
        public User[] Users
        {
            get { return users; }
            set { users = value; }
        }
    }
}

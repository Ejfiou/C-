using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public class UserStructDAO
    {
        public UserStructDAO()
        {

        }

        //得到数据仓库实例
        private Database db = new Database();

        public bool Insert(UserStruct user)
        {
            bool flag = false;

            //判断是否存在相同的用户名
            for (int i = 0; i < db.UsersStruct.Length; i++)
            {
                //判断当前位置i上是否有用户对象
                //if (db.UsersStruct[i] != null)//有用户对象
                if (!string.IsNullOrWhiteSpace(db.UsersStruct[i].Username))
                {
                    if (db.UsersStruct[i].Username == user.Username)
                    {
                        return flag;
                    }
                }
            }
            for (int i = 0; i < db.Users.Length; i++)
            {
                //判断当前位置i上是否有用户对象
                //if (db.UsersStruct[i] == null)//有用户对象
                if (string.IsNullOrWhiteSpace(db.UsersStruct[i].Username))
                {
                    db.UsersStruct[i] = user;
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public bool Updata(UserStruct user)
        {
            bool flag = false;

            for (int i = 0; i < db.UsersStruct.Length; i++)
            {
                //判断当前位置i上是否有用户对象
                if (!string.IsNullOrWhiteSpace(db.UsersStruct[i].Username))//有用户对象
                {
                    if (db.UsersStruct[i].Username==user.Username)
                    {
                        //修改用户信息
                        db.UsersStruct[i] = user;
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }

        public bool Delete(UserStruct user)
        {
            bool flag = false;

            for (int i = 0; i < db.UsersStruct.Length; i++)
            {
                //判断当前位置i上是否有用户对象
                if (!string.IsNullOrWhiteSpace(db.UsersStruct[i].Username))//有用户对象
                {
                    if (db.UsersStruct[i].Username == user.Username)
                    {
                        //修改用户信息
                        db.UsersStruct[i] = new UserStruct(null, null, null);
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }

        public UserStruct[] SelectAll()
        {
            UserStruct[] temp = null;

            int realUserCount = 0;
            for (int i = 0; i < db.UsersStruct.Length; i++)
            {
                //判断当前i位置上是否有用户对象
                if (!string.IsNullOrWhiteSpace(db.UsersStruct[i].Username))//有用户对象
                {
                    realUserCount++;
                }
            }

            if (realUserCount > 0)
            {
                temp = new UserStruct[realUserCount];//创建有多少少个用户的数组

                //将 用户信息数据中的用户信息写人到temp中
                int j = 0;//作为temp数组的下标
                for (int i = 0; i < db.UsersStruct.Length; i++)
                {
                    //判断当前i位置上是否有用户对象
                    if (!string.IsNullOrWhiteSpace(db.UsersStruct[i].Username))//有用户对象
                    {
                        //将db.Users的i位置上的用户对象赋值给temp的j位置
                        temp[j] = db.UsersStruct[i];
                        j++;
                    }
                }
            }

            return temp;
        }

        public UserStruct SelectByUsername(string username)
        {
            UserStruct temp=new UserStruct(null,null,null);

            for (int i = 0; i < db.UsersStruct.Length; i++)
            {
                //判断当前位置i上是否有用户对象
                if (!string.IsNullOrWhiteSpace(db.UsersStruct[i].Username))//没有用户对象
                {
                    if (db.Users[i].Username == username)
                    {
                        //查询用户信息
                        temp = db.UsersStruct[i];
                        break;
                    }
                }
            }

            return temp;

        }

        public UserStruct[] SelectByRealName(string realName)
        {
            UserStruct[] temp = null;

            int realUserByNameCount = 0;
            for (int i = 0; i < db.UsersStruct.Length; i++)
            {
                //判断当前i位置上是否有用户对象
                if(!string.IsNullOrWhiteSpace(db.UsersStruct[i].Username))//有用户对象
                {
                    if (db.UsersStruct[i].RealName == realName)
                    {
                        realUserByNameCount++;
                    }
                }
            }

            if (realUserByNameCount > 0)
            {
                temp = new UserStruct[realUserByNameCount];//创建有多少少个用户的数组

                //将 用户信息数据中的用户信息写人到temp中
                int j = 0;//作为temp数组的下标
                for (int i = 0; i < db.UsersStruct.Length; i++)
                {
                    //判断当前i位置上是否有用户对象
                    if (!string.IsNullOrWhiteSpace(db.UsersStruct[i].Username))//有用户对象
                    {
                        if (db.UsersStruct[i].RealName == realName)
                        {
                            //将db.Users的i位置上的用户对象赋值给temp的j位置
                            temp[j] = db.UsersStruct[i];
                            j++;
                        }
                    }
                }
            }

            return temp;
        }
    }
}

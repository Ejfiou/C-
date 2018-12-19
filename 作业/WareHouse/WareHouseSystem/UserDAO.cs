using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary1;
namespace WareHouseSystem
{
    /// <summary>
    /// 对于用户信息的数据访问对象
    ///（user database access object）
    /// </summary>
    public class UserDAO
    {
        public UserDAO()
        {

        }

        //得到数据仓库实例
        private UserData db = new UserData();

        /// <summary>
        /// 增加用户信息
        /// </summary>
        /// <param name="user">要新增用户信息</param>
        /// <returns>返回true表示增加成功，否则返回false表示增加失败</returns>
        public bool Insert(User user)
        {
            bool flag = false;

            //判断是否存在相同的用户名
            for(int i=0;i<db.Users.Length;i++)
            {
                //判断当前位置i上是否有用户对象
                if(db.Users[i]!=null)//有用户对象
                {
                    if(db.Users[i].Username==user.Username)
                    {
                        return flag;
                    }
                }
            }

            for (int i = 0; i < db.Users.Length; i++)
            {
                //判断当前位置i上是否有用户对象
                if (db.Users[i] == null)//有用户对象
                {
                    db.Users[i] = user;
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="user">修改后的新的用户信息数据</param>
        /// <returns>返回true表示修改成功；否则返回false表示修改失败</returns>
        public bool Updata(User user)
        {
            bool flag = false;

            for (int i = 0; i < db.Users.Length; i++)
            {
                //判断当前位置i上是否有用户对象
                if (db.Users[i] != null)//没有用户对象
                {
                    if (db.Users[i].Username == user.Username)
                    { 
                        //修改用户信息
                        db.Users[i] = user;
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns>返回true表示删除成功；否则返回false表示删除失败</returns>
        public bool Delete(User user)
        {
            bool flag = false;

            for (int i = 0; i < db.Users.Length; i++)
            {
                //判断当前位置i上是否有用户对象
                if (db.Users[i] != null)//没有用户对象
                {
                    if (db.Users[i].Username == user.Username)
                    {
                        //修改用户信息
                        db.Users[i] = null;
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }

        /// <summary>
        /// 查询所有的用户信息
        /// </summary>
        /// <returns>用户信息</returns>
        public User[] SelectAll()
        {
            User[] temp = null;

            int realUserCount = 0;
            for (int i = 0; i < db.Users.Length; i++)
            {
                //判断当前i位置上是否有用户对象
                if (db.Users[i] != null)//有用户对象
                {
                    realUserCount++;
                }
            }

            if (realUserCount > 0)
            {
                temp = new User[realUserCount];//创建有多少少个用户的数组

                //将 用户信息数据中的用户信息写人到temp中
                int j = 0;//作为temp数组的下标
                for (int i = 0; i < db.Users.Length; i++)
                {
                    //判断当前i位置上是否有用户对象
                    if (db.Users[i] != null)//有用户对象
                    {
                        //将db.Users的i位置上的用户对象赋值给temp的j位置
                        temp[j] = db.Users[i];
                        j++;
                    }
                }
            }

            return temp;
        }

        /// <summary>
        /// 按用户名查询对应的用户信息
        /// </summary>
        /// <param name="username">查询的用户名</param>
        /// <returns>对应的用户信息</returns>
        public User SelectByUsername(string username)
        {
            User temp = null;

            for (int i = 0; i < db.Users.Length; i++)
            {
                //判断当前位置i上是否有用户对象
                if (db.Users[i] != null)//没有用户对象
                {
                    if (db.Users[i].Username == username)
                    {
                        //查询用户信息
                        temp = db.Users[i];
                        break;
                    }
                }
            }

            return temp;

        }

        /// <summary>
        /// 按真实姓名查询对应的用户信息
        /// </summary>
        /// <param name="username">查询的姓名</param>
        /// <returns>对应的用户信息</returns>
        public User[] SelectByRealName(string realName)
        {
            User[] temp = null;

            int realUserByNameCount = 0;
            for (int i = 0; i < db.Users.Length; i++)
            {
                //判断当前i位置上是否有用户对象
                if (db.Users[i] != null)//有用户对象
                {
                    if (db.Users[i].RealName == realName)
                    {
                        realUserByNameCount++;
                    }
                }
            }

            if (realUserByNameCount > 0)
            {
                temp = new User[realUserByNameCount];//创建有多少少个用户的数组

                //将 用户信息数据中的用户信息写人到temp中
                int j = 0;//作为temp数组的下标
                for (int i = 0; i < db.Users.Length; i++)
                {
                    //判断当前i位置上是否有用户对象
                    if (db.Users[i] != null)//有用户对象
                    {
                        if (db.Users[i].RealName == realName)
                        {
                            //将db.Users的i位置上的用户对象赋值给temp的j位置
                            temp[j] = db.Users[i];
                            j++;
                        }
                    }
                }
            }

            return temp;
        }

    }
}

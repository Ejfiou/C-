using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    /// <summary>
    /// 对于人信息的数据访问对象
    /// （student database access object）
    /// </summary>
    public class PersonDAO
    {
        public PersonDAO()
        {

        }

        //得到数据仓库（数据库）实例
        private Database db = new Database();


        /// <summary>
        /// 增加人的信息
        /// </summary>
        /// <param name="per">新增人的信息</param>
        /// <returns>返回true表示增加成功；否则返回false表示增加失败</returns>
        public bool Insert(Person per)
        {
            bool flag = false;

            //判断是否存在有相同的主键
            for (int i = 0; i < db.People.Length; i++)
            {
                //判断当前i位置上是否有人对象
                if (db.People[i] != null)//有人对象
                {
                    if (db.People[i].PrimaryKey == per.PrimaryKey)
                    {
                        return flag;
                    }
                }
            }

            for (int i = 0; i < db.People.Length; i++)
            {
                //判断当前i位置上是否有人对象
                if (db.People[i] == null)//没有人对象
                {
                    db.People[i] = per;
                    flag = true;
                    break;
                }
            }

            return flag;
        }


        /// <summary>
        /// 修改人信息
        /// </summary>
        /// <param name="per">修改后的新的人的信息数据</param>
        /// <returns>返回true表示修改成功；否则返回false表示修改失败</returns>
        public bool Update(Person per)
        {
            bool flag = false;

            for (int i = 0; i < db.People.Length; i++)
            {
                //判断当前i位置上是否有人对象
                if (db.People[i] != null)//有人对象
                {
                    if (db.People[i].PrimaryKey == per.PrimaryKey)
                    {
                        //修改人信息
                        db.People[i] = per;
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }

        /// <summary>
        /// 删除人信息
        /// </summary>
        /// <param name="per">要删除的人对象</param>
        /// <returns>返回true表示删除成功；否则返回false表示删除失败</returns>
        public bool Delete(Person per)
        {
            bool flag = false;

            for (int i = 0; i < db.People.Length; i++)
            {
                //判断当前i位置上是否有人对象
                if (db.People[i] != null)//有人对象
                {
                    if (db.People[i].PrimaryKey == per.PrimaryKey)
                    {
                        //删除r人信息
                        db.People[i] = null;
                        flag = true;
                        break;
                    }
                }
            }
            return flag;
        }

        public Person[] SelectAll()
        {
            Person[] temp = null;

            int realPeopleCount = 0;
            for (int i=0; i<db.People.Length; i++)
            {
                //判断当前位置i上是否有人对象
                if (db.People[i] != null) //有人的对象
                {
                    realPeopleCount++;
                }
            }

            if (realPeopleCount > 0)
            {
                int j = 0;//作为temp数组的下标

                //将人信息数据（人信息表）中的热信息写人到temp中
                temp = new Person[realPeopleCount];//创建有多少个学生的数组

                //将人信息数据（人信息表）中的热信息写人到temp中
                for (int i=0; i<db.People.Length; i++)
                {
                    //判断当前i位置上是否有学生对象
                    if (db.People[i] != null)//有学生对象
                    {
                        //将db.Students的i位置上的学生对象赋值给temp的j位
                        temp[j] = db.People[i];
                        j++;
                    }
                }
            }
         
            return temp;
        }


        /// <summary>
        /// 按照主键查询对应的学生信息
        /// </summary>
        /// <param name="primaryKey">查询的主键</param>
        /// <returns>对应的人信息</returns>
        public Person SelectByPrimaryKey(string primaryKey)
        {
            Person temp = null;

            for (int i = 0; i < db.People.Length; i++)
            {
                //判断当前i位置上是否有人对象
                if (db.People[i] != null)//有人对象
                {
                    if (db.People[i].PrimaryKey == primaryKey)
                    {
                        //查出人信息
                        temp = db.People[i];
                        break;
                    }
                }
            }

            return temp;
        }

        /// <summary>
        /// 按照姓名查询对应的人信息
        /// </summary>
        /// <param name="name">查询的姓名</param>
        /// <returns>所有人信息的数组</returns>
        public Person[] SelectByName(string name)
        {
            Person[] temp = null;

            int realPeopleByNameCount = 0;
            for (int i = 0; i < db.People.Length; i++)
            {
                //判断当前位置i上是否有人对象
                if (db.People[i] != null) //有人的对象
                {
                    realPeopleByNameCount++;
                }
            }


            if (realPeopleByNameCount > 0)
            {
                temp = new Person[realPeopleByNameCount];
                int j = 0;
                for (int i = 0; i < db.People.Length; i++)
                {
                    //判断当前i位置上是否有人对象
                    if (db.People[i] != null)//有人对象
                    {
                        if (db.People[i].Name == name)
                        {
                            //查出人信息
                            temp[j] = db.People[i];
                            j++;
                        }
                    }
                }
            }

            return temp;
        }

    }
}

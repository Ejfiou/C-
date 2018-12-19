using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    /// <summary>
    /// 万事万物中的某种信息的数据访问对象
    /// （student database access object）
    /// </summary>
    public abstract class MyObjectDAO
    {
        public MyObjectDAO()
        {

        }

        //得到数据仓库（数据库）实例
        protected Database db = new Database();

        /// <summary>
        /// 增加某种信息
        /// </summary>
        /// <param name="per">新增的某种信息</param>
        /// <returns>返回true表示增加成功；否则返回false表示增加失败</returns>
        public bool Insert(IMyObject obj)
        {
            bool flag = false;

            //判断是否存在有相同的主键
            for (int i = 0; i < db.MyObjects.Length; i++)
            {
                //判断当前i位置上是否有某种对象
                if (db.MyObjects[i] != null)//有某种对象
                {
                    if (db.MyObjects[i].PrimaryKey == obj.PrimaryKey)
                    {
                        return flag;
                    }
                }
            }

            for (int i = 0; i < db.MyObjects.Length; i++)
            {
                //判断当前i位置上是否有某种对象
                if (db.MyObjects[i] == null)//没有某种对象
                {
                    db.MyObjects[i] = obj;
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        /// <summary>
        /// 修改某种信息
        /// </summary>
        /// <param name="per">修改后的新的某种信息数据</param>
        /// <returns>返回true表示修改成功；否则返回false表示修改失败</returns>
        public bool Update(IMyObject obj)
        {
            bool flag = false;

            for (int i = 0; i < db.MyObjects.Length; i++)
            {
                //判断当前i位置上是否有某种对象
                if (db.MyObjects[i] != null)//有某种对象
                {
                    if (db.MyObjects[i].PrimaryKey == obj.PrimaryKey)
                    {
                        //修改某种信息
                        db.MyObjects[i] = obj;
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }

        public bool Delete(IMyObject obj)
        {
            bool flag = false;

            for (int i = 0; i < db.MyObjects.Length; i++)
            {
                if (db.MyObjects[i] != null)
                {
                    if (db.MyObjects[i].PrimaryKey == obj.PrimaryKey)
                    {
                        //删除事物信息
                        db.MyObjects[i] = null;
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }

        public IMyObject[] SelectAll()
        {
            IMyObject[] temp = null;

            int realObjectCount = 0;
            for (int i = 0; i < db.MyObjects.Length; i++)
            {
                //判断当前位置i上是否有某种对象
                if (db.MyObjects[i] != null) //有某种的对象
                {
                    realObjectCount++;
                }
            }

            if (realObjectCount > 0)
            {
                int j = 0;//作为temp数组的下标

                //将某种信息数据中的热信息写人到temp中
                temp = new IMyObject[realObjectCount];//创建有多少个信息的数组

                //将某种信息数据中的信息写人到temp中
                for (int i = 0; i < db.MyObjects.Length; i++)
                {
                    //判断当前i位置上是否有信息对象
                    if (db.MyObjects[i] != null)//有某种信息对象
                    {
                        //将db.MyObjects[i];的i位置上的信息对象赋值给temp的j位
                        temp[j] = db.MyObjects[i];
                        j++;
                    }
                }
            }

            return temp;
        }

        /// <summary>
        /// 按照主键查询对应的某种信息
        /// </summary>
        /// <param name="primaryKey">查询的主键</param>
        /// <returns>对应的某种信息</returns>
        public IMyObject SelectByPrimaryKey(string primaryKey)
        {
            IMyObject temp = null;

            for (int i = 0; i < db.MyObjects.Length; i++)
            {
                //判断当前i位置上是否有某种对象
                if (db.MyObjects[i] != null)//有某种对象
                {
                    if (db.MyObjects[i].PrimaryKey == primaryKey)
                    {
                        //查出某种信息
                        temp = db.MyObjects[i];
                        break;
                    }
                }
            }

            return temp;
        }



        /// <summary>
        /// 按照名字查询对应的某种信息
        /// </summary>
        /// <param name="name">查询的名字</param>
        /// <returns>所有信息的数组</returns>
        public abstract IMyObject[] SelectByNonPrimaykey(IMyObject obj);


    }


}

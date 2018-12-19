using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public abstract class MyObjectDAOArrayList:IMyObjectDAO
    {
        public MyObjectDAOArrayList()
        {

        }

        //得到数据仓库（数据库）实例
        protected Database db = new Database();

        public bool Delete(IMyObject obj)
        {
            bool flag = false;

            for (int i = 0; i < db.MyObjectArrayList.Count; i++)
            {
                if(db.MyObjectArrayList[i] is IMyObject)
                {
                    if ((db.MyObjectArrayList[i] as IMyObject).PrimaryKey==obj.PrimaryKey)
                    {
                        db.MyObjectArrayList.RemoveAt(i);
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }

        public bool Insert(IMyObject obj)
        {
            bool flag = false;

            //判断是否存在有相同的主键
            for (int i = 0; i < db.MyObjectArrayList.Count; i++)
            {
                if (db.MyObjectArrayList[i] is IMyObject)
                {
                    if ((db.MyObjectArrayList[i] as IMyObject).PrimaryKey==obj.PrimaryKey)
                    {
                        return flag;
                    }
                }
            }

            int index = db.MyObjectArrayList.Add(obj);
            if (index > -1)
            {
                flag = true;
            }

            return flag;
        }

        public IMyObject[] SelectAll()
        {
            IMyObject[] temp = null;
            int realMyObjectCount = db.MyObjectArrayList.Count;

            if(realMyObjectCount >0)
            {
                temp = new IMyObject[realMyObjectCount];

                //for (int i = 0; i < db.MyObjectArrayList.Count; i++)
                //{
                //    if(db.MyObjectArrayList[i] is IMyObject)
                //    {
                //        temp[i] = db.MyObjectArrayList[i] as IMyObject;
                //    }                   
                //}
                db.MyObjectArrayList.CopyTo(temp, 0);
            }


            return temp;
                
        }

        public abstract IMyObject[] SelectByNonPrimaykey(IMyObject obj);
       
        public IMyObject SelectByPrimaryKey(string primaryKey)
        {
            IMyObject temp = null;

            for (int i = 0; i < db.MyObjectArrayList.Count; i++)
            {
                if (db.MyObjectArrayList[i] is IMyObject)
                {
                    if((db.MyObjectArrayList[i] as IMyObject).PrimaryKey == primaryKey)
                    {
                        temp = db.MyObjectArrayList[i] as IMyObject;
                        break;
                    }
                }
            }
            return temp;
        }

        public bool Update(IMyObject obj)
        {
            bool flag = false;

            for (int i = 0; i < db.MyObjectArrayList.Count; i++)
            {
                if (db.MyObjectArrayList[i] is IMyObject)
                {
                    if((db.MyObjectArrayList[i] as IMyObject).PrimaryKey==obj.PrimaryKey)
                    {
                        db.MyObjectArrayList[i] = obj;
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }
    }
}

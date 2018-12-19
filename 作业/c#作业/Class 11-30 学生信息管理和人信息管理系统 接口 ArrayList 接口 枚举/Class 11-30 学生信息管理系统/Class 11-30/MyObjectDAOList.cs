using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public abstract class MyObjectDAOList : IMyObjectDAO
    {
        public MyObjectDAOList()
        {

        }

        protected Database db = new Database();
        public bool Delete(IMyObject obj)
        {
            bool flag = false;

            for (int i = 0; i < db.MyobjectList.Count; i++)
            {
                if (db.MyobjectList[i].PrimaryKey == obj.PrimaryKey)
                {
                    db.MyobjectList.RemoveAt(i);
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public bool Insert(IMyObject obj)
        {
            bool flag = false;

            for (int i = 0; i < db.MyobjectList.Count; i++)
            {

                if (db.MyobjectList[i].PrimaryKey == obj.PrimaryKey)
                {
                    return flag;
                }

            }

            db.MyobjectList.Add(obj);
            flag = true;

            return flag;
        }

        public IMyObject[] SelectAll()
        {
            IMyObject[] temp = null;

            int realMyObjectCount = db.MyobjectList.Count;

            if (realMyObjectCount > 0)
            {
                temp = new IMyObject[realMyObjectCount];
                db.MyobjectList.CopyTo(temp, 0);
            }

            return temp;
        }

        public abstract IMyObject[] SelectByNonPrimaykey(IMyObject obj);


        public IMyObject SelectByPrimaryKey(string primaryKey)
        {
            IMyObject temp = null;

            for (int i = 0; i < db.MyobjectList.Count; i++)
            {
                if (db.MyobjectList[i].PrimaryKey == primaryKey)
                {
                    temp = db.MyobjectList[i];
                    break;
                }
            }

            return temp;
        }

        public bool Update(IMyObject obj)
        {
            bool flag = false;

            for (int i = 0; i < db.MyobjectList.Count; i++)
            {
                if (db.MyobjectList[i].PrimaryKey == obj.PrimaryKey)
                {
                    db.MyobjectList[i] = obj;
                    flag = true;
                    break;
                }
            }

            return flag;
        }
    }
}

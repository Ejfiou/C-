using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class_11_30
{
    public abstract class MyObjectDAOSorteList : IMyObjectDAO
    {
        public MyObjectDAOSorteList()
        {

        }

        public Database db = new Database();
        public bool Delete(IMyObject obj)
        {
            bool flag = false;

            if(db.MyObjectSorteList.ContainsKey(obj.PrimaryKey))
            {
                db.MyObjectSorteList.Remove(obj.PrimaryKey);
                flag = true;
            }

            return flag;
        }

        public bool Insert(IMyObject obj)
        {
            bool flag = false;

            if(db.MyObjectSorteList.ContainsKey(obj.PrimaryKey))
            {
                return flag;
            }
            db.MyObjectSorteList.Add(obj.PrimaryKey, obj);
            flag = true;

            return flag;
        }

        public IMyObject[] SelectAll()
        {
            IMyObject[] temp = null;

            int realMyObjectCount = db.MyObjectSorteList.Count;

            if(realMyObjectCount>0)
            {
                temp = new IMyObject[realMyObjectCount];
                //int j = 0;
                //for (int i = 0; i < db.MyObjectSorteList.Count; i++)
                //{
                //    temp[j] = db.MyObjectSorteList.GetByIndex(i) as IMyObject;
                //    j++;
                //}

                db.MyObjectSorteList.Values.CopyTo(temp, 0);
            }

            return temp;
        }

        public abstract IMyObject[] SelectByNonPrimaykey(IMyObject obj);
        

        public IMyObject SelectByPrimaryKey(string primaryKey)
        {
            IMyObject temp = null;

            if (db.MyObjectSorteList.ContainsKey(primaryKey))
            {
                if (db.MyObjectSorteList[primaryKey] is IMyObject)
                {
                    temp = db.MyObjectSorteList[primaryKey] as IMyObject;
                }
            }

            return temp;
        }

        public bool Update(IMyObject obj)
        {
            bool flag = false;

            if (db.MyObjectSorteList.ContainsKey(obj.PrimaryKey))
            {
                db.MyObjectSorteList[obj.PrimaryKey] = obj;
                flag = true;
            }

            return flag;
        }
    }
}

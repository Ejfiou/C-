using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public abstract class MyObjectDAODictionary : IMyObjectDAO
    {
        public MyObjectDAODictionary()
        {

        }

        protected Database db = new Database();
        public bool Delete(IMyObject obj)
        {
            bool flag = false;

            if (db.MyObjectDictionary.ContainsKey(obj.PrimaryKey))
            {
                db.MyObjectDictionary.Remove(obj.PrimaryKey);
                flag = true;  
            }


            return flag;
        }

        public bool Insert(IMyObject obj)
        {
            bool flag = false;

            if (db.MyObjectDictionary.ContainsKey(obj.PrimaryKey))
            {
                return flag;
            }
            db.MyObjectDictionary.Add(obj.PrimaryKey, obj);
            flag = true;

            return flag;
        }

        public IMyObject[] SelectAll()
        {
            IMyObject[] temp = null;

            int realMyObjectCount = db.MyObjectDictionary.Count;
            if (realMyObjectCount>0)
            {
                temp = new IMyObject[realMyObjectCount];
                db.MyObjectDictionary.Values.CopyTo(temp, 0);
            }

            return temp;
        }

        public abstract IMyObject[] SelectByNonPrimaykey(IMyObject obj);
        

        public IMyObject SelectByPrimaryKey(string primaryKey)
        {
            IMyObject temp = null;

            if(db.MyObjectDictionary.ContainsKey(primaryKey))
            {
                temp = db.MyObjectDictionary[primaryKey];
            }
            return temp;
        }

        public bool Update(IMyObject obj)
        {
            bool flag = false;

            if (db.MyObjectDictionary.ContainsKey(obj.PrimaryKey))
            {
                db.MyObjectDictionary[obj.PrimaryKey] = obj;
                flag = true;
            }

            return flag;
        }
    }
}

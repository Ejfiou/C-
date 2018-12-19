using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class_11_30
{
    /// <summary>
    /// Hashtable版本
    /// 对于万事万物中的某种信息数据访问对象
    /// </summary>
    public abstract class MyObjectDAOHashtable : IMyObjectDAO
    {
        public MyObjectDAOHashtable()
        {

        }

        public Database db = new Database();
        public bool Delete(IMyObject obj)
        {
            bool flag = false;

            if (db.MyObjectsHashtable.ContainsKey(obj.PrimaryKey))
            {
                db.MyObjectsHashtable.Remove(obj.PrimaryKey);
                flag = true;
            }

            return flag;
        }

        public bool Insert(IMyObject obj)
        {
            bool flag = false;

            if (db.MyObjectsHashtable.ContainsKey(obj.PrimaryKey))
            {
                return flag;
            }

            db.MyObjectsHashtable.Add(obj.PrimaryKey, obj);
            flag = true;

            return flag;
        }

        public IMyObject[] SelectAll()
        {
            IMyObject[] temp = null;

            int realMyObjectCount = db.MyObjectsHashtable.Count;

            if(realMyObjectCount>0)
            {
                temp = new IMyObject[realMyObjectCount];
                //int j = 0;
                //foreach (DictionaryEntry hash in db.MyObjectsHashtable)
                //{
                //    if (hash.Value is IMyObject)
                //    {
                //        temp[j] = hash.Value as IMyObject;
                //        j++;
                //    }
                //} 
                db.MyObjectsHashtable.Values.CopyTo(temp, 0);
            }

            return temp;
        }

        public abstract IMyObject[] SelectByNonPrimaykey(IMyObject obj);
       

        public IMyObject SelectByPrimaryKey(string primaryKey)
        {
            IMyObject temp = null;
            
            if(db.MyObjectsHashtable.ContainsKey(primaryKey))
            {
                if(db.MyObjectsHashtable[primaryKey] is IMyObject)
                {
                    temp = db.MyObjectsHashtable[primaryKey] as IMyObject;
                }                
            }
  

            return temp;
        }

        public bool Update(IMyObject obj)
        {
            bool flag = false;

            if (db.MyObjectsHashtable.ContainsKey(obj.PrimaryKey))
            {
                db.MyObjectsHashtable[obj.PrimaryKey] = obj;
                flag = true;
            }
                    
            return flag;
        }
    }
}

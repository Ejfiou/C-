using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class_11_30
{
    public abstract class MyObjectDAOHashtable : IMyObjectDAO
    {

        public Database db = new Database();
        public bool Delete(IMyObject obj)
        {
            bool flag = false;

            foreach (DictionaryEntry hash in db.Hash)
            {
                if (hash.Value is IMyObject)
                {
                    if ((hash.Value as IMyObject).PrimaryKey==obj.PrimaryKey)
                    {
                        db.Hash.Remove(hash.Key);
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

            foreach (DictionaryEntry hash in db.Hash)
            {
                if(hash.Value is IMyObject)
                {
                    if ((hash.Value as IMyObject).PrimaryKey == obj.PrimaryKey)
                    {
                        return flag;
                    }
                   
                }
            }

                db.Hash.Add(obj.PrimaryKey, obj);
                flag = true;



            return flag;
        }

        public IMyObject[] SelectAll()
        {
            IMyObject[] temp = null;

            int realMyObjectCount = db.Hash.Count;

            if(realMyObjectCount>0)
            {
                temp = new IMyObject[realMyObjectCount];
                int j = 0;

                    foreach (DictionaryEntry hash in db.Hash)
                    {
                        temp[j] = hash.Value as IMyObject;
                    j++;

                    }
                
                
            }

            return temp;
        }

        public abstract IMyObject[] SelectByNonPrimaykey(IMyObject obj);
       

        public IMyObject SelectByPrimaryKey(string primaryKeyy)
        {
            IMyObject temp = null;

            foreach (DictionaryEntry hash in db.Hash)
            {
                if(hash.Value is IMyObject)
                {
                    if((hash.Value as IMyObject).PrimaryKey == primaryKeyy)
                    {
                        temp = hash.Value as IMyObject;
                    }
                }
            }

            return temp;
        }

        public bool Update(IMyObject obj)
        {
            bool flag = false;

            foreach (DictionaryEntry hash in db.Hash)
            {
                if(hash.Value is IMyObject)
                {
                    if ((hash.Value as IMyObject).PrimaryKey==obj.PrimaryKey)
                    {
                        db.Hash[hash.Key] = obj;
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }
    }
}

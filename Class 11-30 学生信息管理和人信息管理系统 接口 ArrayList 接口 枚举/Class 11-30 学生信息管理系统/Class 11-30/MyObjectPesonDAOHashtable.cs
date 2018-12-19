using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Class_11_30
{
    public class MyObjectPesonDAOHashtable : MyObjectDAOHashtable
    {
        public MyObjectPesonDAOHashtable()
        {

        }
        public override IMyObject[] SelectByNonPrimaykey(IMyObject obj)
        {
            IMyObject[] temp = null;

            Hashtable tempHT = new Hashtable();
            foreach (DictionaryEntry hash in db.MyObjectsHashtable)
            {
                if (hash.Value is Person)
                {
                    if ((hash.Value as Person).Name.IndexOf((obj as Person).Name)>-1)
                    {
                        tempHT.Add(hash.Key, hash.Value);
                    }
                }
            }


            int realPersonByNameCount = tempHT.Count;

            if(realPersonByNameCount>0)
            {
                temp = new IMyObject[realPersonByNameCount];
                //int j = 0;
                //foreach (DictionaryEntry hash in tempHT)
                //{
                //    if (hash.Value is IMyObject)
                //    {                        
                //        temp[j] = hash.Value as IMyObject;
                //        j++;
                //    }
                //}
                tempHT.Values.CopyTo(temp, 0);
            }

            return temp;
        }
    }
}

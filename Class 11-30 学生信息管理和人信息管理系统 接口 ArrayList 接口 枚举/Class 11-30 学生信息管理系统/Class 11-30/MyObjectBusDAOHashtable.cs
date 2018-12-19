using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class_11_30
{
    public class MyObjectBusDAOHashtable : MyObjectDAOHashtable
    {
        public MyObjectBusDAOHashtable()
        {

        }
        public override IMyObject[] SelectByNonPrimaykey(IMyObject obj)
        {
            IMyObject[] temp = null;

            Hashtable tempHT = new Hashtable();
            foreach (DictionaryEntry hash in db.MyObjectsHashtable)
            {
                if (hash.Value is Bus)
                {
                    if ((hash.Value as Bus).BusLine.IndexOf((obj as Bus).BusLine) > -1)
                    {
                        tempHT.Add(hash.Key, hash.Value);
                    }
                }
            }


            int realBusByLineCount = tempHT.Count;

            if (realBusByLineCount > 0)
            {
                temp = new IMyObject[realBusByLineCount];
            
                tempHT.Values.CopyTo(temp, 0);
            }

            return temp;
        }
    }
}

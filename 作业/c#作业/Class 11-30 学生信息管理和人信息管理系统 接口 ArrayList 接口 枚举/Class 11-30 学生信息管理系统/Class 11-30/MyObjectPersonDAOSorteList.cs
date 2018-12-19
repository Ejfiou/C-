using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class_11_30
{
    public class MyObjectPersonDAOSorteList : MyObjectDAOSorteList
    {
        public MyObjectPersonDAOSorteList()
        {

        }
        public override IMyObject[] SelectByNonPrimaykey(IMyObject obj)
        {
            
            IMyObject[] temp = null;
            
            SortedList tempST = new SortedList();

            foreach (DictionaryEntry de in db.MyObjectSorteList)
            {
                if (de.Value is Person)
                {
                    if ((de.Value as Person).Name.IndexOf((obj as Person).Name) > -1)
                    {
                        tempST.Add(de.Key, de.Value);
                    }
                }                                      
            }

            int realPersonByNameCount = tempST.Count;

            if(realPersonByNameCount>0)
            {
                temp = new IMyObject[realPersonByNameCount];
                //int j = 0;
                //for (int i = 0; i < tempST.Count; i++)
                //{

                //    temp[j] = tempST.GetByIndex(i) as IMyObject;
                //    j++;
                //}
                tempST.Values.CopyTo(temp, 0);
            }

            return temp;
        }
    }
}

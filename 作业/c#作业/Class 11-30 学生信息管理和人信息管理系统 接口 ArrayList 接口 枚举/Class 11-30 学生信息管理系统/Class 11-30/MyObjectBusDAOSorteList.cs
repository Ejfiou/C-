using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class_11_30
{
    class MyObjectBusDAOSorteList : MyObjectDAOSorteList
    {
        public MyObjectBusDAOSorteList()
        {

        }

        public override IMyObject[] SelectByNonPrimaykey(IMyObject obj)
        {
            IMyObject[] temp = null;

            SortedList tempSL = new SortedList();
            foreach (DictionaryEntry sl in db.MyObjectSorteList)
            {
                if (sl.Value is Bus)
                {
                    if ((sl.Value as Bus).BusLine.IndexOf((obj as Bus).BusLine) > -1)
                    {
                        tempSL.Add(sl.Key, sl.Value);
                    }
                }
            }


            int realBusByLineCount = tempSL.Count;

            if (realBusByLineCount > 0)
            {
                temp = new IMyObject[realBusByLineCount];

                tempSL.Values.CopyTo(temp, 0);
            }

            return temp;
        }
    }
}

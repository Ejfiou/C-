using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class_11_30
{
    public class MyObjectBusDAOArrayList : MyObjectDAOArrayList
    {
        public override IMyObject[] SelectByNonPrimaykey(IMyObject obj)
        {
            IMyObject[] temp = null;

            ArrayList tempAl = new ArrayList();

            for (int i = 0; i < db.MyObjectArrayList.Count; i++)
            {
                if (db.MyObjectArrayList[i] is Bus)
                {
                    if ((db.MyObjectArrayList[i] as Bus).BusLine.IndexOf((obj as Bus).BusLine) > -1)
                    {
                        tempAl.Add(db.MyObjectArrayList[i]);
                    }
                }
            }

            int realBusByBusLineCount = tempAl.Count;
            if (realBusByBusLineCount > 0)
            {
                temp = new IMyObject[realBusByBusLineCount];
                tempAl.CopyTo(temp, 0);
            }

            return temp;
        }
    }
}

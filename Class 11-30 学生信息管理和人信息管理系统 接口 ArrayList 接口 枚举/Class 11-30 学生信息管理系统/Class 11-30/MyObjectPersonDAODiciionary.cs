using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public class MyObjectPersonDAODiciionary : MyObjectDAODictionary
    {
        public override IMyObject[] SelectByNonPrimaykey(IMyObject obj)
        {
            IMyObject[] temp = null;

            Dictionary<string, IMyObject> tempDR = new Dictionary<string, IMyObject>();

            foreach (KeyValuePair<string,IMyObject> dr in db.MyObjectDictionary)
            {
                if((dr.Value as Person).Name.IndexOf((obj as Person).Name)>-1)
                {
                    tempDR.Add(dr.Key, dr.Value);
                }
            }

            int realPersonByNameCount = tempDR.Count;

            if(realPersonByNameCount>0)
            {
                temp = new IMyObject[realPersonByNameCount];
                tempDR.Values.CopyTo(temp, 0);
            }

            return temp;
        }
    }
}

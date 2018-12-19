using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public class MyObjectBookDAO:MyObjectDAO
    {
        public MyObjectBookDAO()
        {

        }

        public override IMyObject[] SelectByNonPrimaykey(IMyObject obj)
        {
            IMyObject[] temp = null;

            int realBookByNameCount = 0;

            for (int i = 0; i < db.MyObjects.Length; i++)
            {
                if (db.MyObjects[i] != null)
                {
                    if((db.MyObjects[i] is Book) && (obj is Book))
                    {
                       if ((db.MyObjects[i] as Book).BookName == (obj as Book).BookName)
                        {
                            realBookByNameCount++;
                        }
                    }
                }
            }

            if (realBookByNameCount>0)
            {
                temp = new IMyObject[realBookByNameCount];

                int j = 0;

                for (int i=0;i<db.MyObjects.Length;i++)
                {
                    if (db.MyObjects[i] != null)
                    {
                        if ((db.MyObjects[i] is Book) && (obj is Book))
                        {
                            if ((db.MyObjects[i] as Book).BookName == (obj as Book).BookName)
                            {
                                temp[j] = db.MyObjects[i];
                                j++;
                            }
                        }
                    }
                }
            }

            return temp;
        }
    }
}

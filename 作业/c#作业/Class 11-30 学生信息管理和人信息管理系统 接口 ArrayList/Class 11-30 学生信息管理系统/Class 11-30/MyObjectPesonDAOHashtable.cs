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

            int realCount = db.Hash.Count;

            if(realCount>0)
            {
                temp = new IMyObject[realCount];
                int j = 0;
                foreach (DictionaryEntry hash in db.Hash)
                {
                    if (hash.Value is Person)
                    {
                        if ((hash.Value as Person).Name.IndexOf((obj as Person).Name)>-1)
                        {
                            temp[j] = hash.Value as Person;
                            j++;
                        }
                    }
                }
            }

            return temp;
        }
    }
}

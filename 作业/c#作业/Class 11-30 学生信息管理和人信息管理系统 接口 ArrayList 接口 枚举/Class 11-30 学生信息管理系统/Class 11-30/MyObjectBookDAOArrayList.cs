using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class_11_30
{
    public class MyObjectBookDAOArrayList : MyObjectDAOArrayList
    {
        public override IMyObject[] SelectByNonPrimaykey(IMyObject obj)
        {
            IMyObject[] temp = null;

            if (obj is Book)
            {
                if ((obj as Book).Author!=null)
                {
                    temp = SelectByAuthor(obj);
                }
                if ((obj as Book).BookName!=null)
                {
                    temp = SelectByBookName(obj);
                }
            }

            return temp;
        }

        public IMyObject[] SelectByAuthor(IMyObject obj)
        {
            IMyObject[] temp = null;

            ArrayList tempAL = new ArrayList();
            for (int i = 0; i < db.MyObjectArrayList.Count; i++)
            {
                if (db.MyObjectArrayList[i] is Book)
                {
                    if ((db.MyObjectArrayList[i] as Book).Author.IndexOf((obj as Book).Author) > -1)
                    {
                        tempAL.Add(db.MyObjectArrayList[i]);
                    }
                }
            }

            int realBookByAuthor = tempAL.Count;
            if(realBookByAuthor>0)
            {
                temp = new IMyObject[realBookByAuthor];
                tempAL.CopyTo(temp, 0);
            }
            return temp;
        }

        public IMyObject[] SelectByBookName(IMyObject obj)
        {
            IMyObject[] temp = null;

            ArrayList tempAL = new ArrayList();
            for (int i = 0; i < db.MyObjectArrayList.Count; i++)
            {
                if (db.MyObjectArrayList[i] is Book)
                {
                    if ((db.MyObjectArrayList[i] as Book).BookName.IndexOf((obj as Book).BookName) > -1)
                    {
                        tempAL.Add(db.MyObjectArrayList[i]);
                    }
                }
            }

            int realBookByBookName = tempAL.Count;
            if (realBookByBookName > 0)
            {
                temp = new IMyObject[realBookByBookName];
                tempAL.CopyTo(temp, 0);
            }
            return temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Class_11_30
{
    public class MyObjecBookDAOSorteList : MyObjectDAOSorteList
    {
        public override IMyObject[] SelectByNonPrimaykey(IMyObject obj)
        {
            IMyObject[] temp = null;

            if (obj is Book)
            {
                if ((obj as Book).Author !=null)
                {
                    temp = SelectByAuthor(obj);
                }
                if ((obj as Book).BookName != null)
                {
                    temp = SelectByBookName(obj);
                }
            }

            return temp;
        }

        public IMyObject[] SelectByAuthor(IMyObject obj)
        {
            IMyObject[] temp = null;

            SortedList tempST = new SortedList();

            foreach (DictionaryEntry de in db.MyObjectSorteList)
            {
                if (de.Value is Book)
                {
                    if((de.Value as Book).Author.IndexOf((obj as Book).Author)>-1)
                    {
                        tempST.Add(de.Key, de.Value);
                    }
                }
            }

            int realBookByAuthorCount = tempST.Count;

            if (realBookByAuthorCount>0)
            {
                temp = new IMyObject[realBookByAuthorCount];
                tempST.Values.CopyTo(temp, 0);
            }

            return temp;
        }

        public IMyObject[] SelectByBookName(IMyObject obj)
        {
            IMyObject[] temp = null;

            SortedList tempST = new SortedList();

            foreach (DictionaryEntry de in db.MyObjectSorteList)
            {
                if (de.Value is Book)
                {
                    if ((de.Value as Book).BookName.IndexOf((obj as Book).BookName) > -1)
                    {
                        tempST.Add(de.Key, de.Value);
                    }
                }
            }

            int realBookByBookNameCount = tempST.Count;

            if (realBookByBookNameCount > 0)
            {
                temp = new IMyObject[realBookByBookNameCount];
                tempST.Values.CopyTo(temp, 0);
            }

            return temp;
        }
    }
}

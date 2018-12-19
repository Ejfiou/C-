using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class_11_30
{
    public class MyObjectBookDAOHashtable : MyObjectDAOHashtable
    {
        public override IMyObject[] SelectByNonPrimaykey(IMyObject obj)
        {
            IMyObject[] temp = null;

            if (obj is Book)
            {
                if ((obj as Book).Author != null)
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

            Hashtable tempHT = new Hashtable();

            foreach (DictionaryEntry hash in db.MyObjectsHashtable)
            {
                if ((hash.Value as Book).Author.IndexOf((obj as Book).Author) > -1)
                {
                    tempHT.Add(hash.Key, hash.Value);
                }
            }

            int realBookByAuthorCount = tempHT.Count;

            if (realBookByAuthorCount > 0)
            {
                temp = new IMyObject[realBookByAuthorCount];
                tempHT.Values.CopyTo(temp, 0);
            }

            return temp;
        }

        public IMyObject[] SelectByBookName(IMyObject obj)
        {
            IMyObject[] temp = null;

            Hashtable tempHT = new Hashtable();

            foreach (DictionaryEntry hash in db.MyObjectsHashtable)
            {
                if ((hash.Value as Book).BookName.IndexOf((obj as Book).BookName) > -1)
                {
                    tempHT.Add(hash.Key, hash.Value);
                }
            }

            int realBookByBookNameCount = tempHT.Count;

            if (realBookByBookNameCount > 0)
            {
                temp = new IMyObject[realBookByBookNameCount];
                tempHT.Values.CopyTo(temp, 0);
            }

            return temp;
        }
    }
}

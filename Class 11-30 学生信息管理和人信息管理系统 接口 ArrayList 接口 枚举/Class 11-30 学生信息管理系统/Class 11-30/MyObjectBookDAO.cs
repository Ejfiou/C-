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

            if(obj is Book)
            {
                if((obj as Book).Author != null)
                {
                    //按作者
                    temp = SelectByAuthor(obj);
                }
                else if ((obj as Book).BookName != null)
                {
                    //按书名
                    temp = SelectByBookName(obj);
                }
            }

            return temp;
        }

        /// <summary>
        /// 按作者查询
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public IMyObject[] SelectByAuthor(IMyObject obj)
        {
            IMyObject[] temp = null;

            int realBookByNameCount = 0;

            for (int i = 0; i < db.MyObjects.Length; i++)
            {
                if (db.MyObjects[i] != null)
                {
                    if ((db.MyObjects[i] is Book) && (obj is Book))
                    {
                        if ((db.MyObjects[i] as Book).Author == (obj as Book).Author)
                        {
                            realBookByNameCount++;
                        }
                    }
                }
            }

            if (realBookByNameCount > 0)
            {
                temp = new IMyObject[realBookByNameCount];

                int j = 0;

                for (int i = 0; i < db.MyObjects.Length; i++)
                {
                    if (db.MyObjects[i] != null)
                    {
                        if ((db.MyObjects[i] is Book) && (obj is Book))
                        {
                            if ((db.MyObjects[i] as Book).Author == (obj as Book).Author)
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


        public IMyObject[] SelectByBookName(IMyObject obj)
        {
            IMyObject[] temp = null;

            int realBookByNameCount = 0;

            for (int i = 0; i < db.MyObjects.Length; i++)
            {
                if (db.MyObjects[i] != null)
                {
                    if ((db.MyObjects[i] is Book) && (obj is Book))
                    {
                        if ((db.MyObjects[i] as Book).BookName == (obj as Book).BookName)
                        {
                            realBookByNameCount++;
                        }
                    }
                }
            }

            if (realBookByNameCount > 0)
            {
                temp = new IMyObject[realBookByNameCount];

                int j = 0;

                for (int i = 0; i < db.MyObjects.Length; i++)
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

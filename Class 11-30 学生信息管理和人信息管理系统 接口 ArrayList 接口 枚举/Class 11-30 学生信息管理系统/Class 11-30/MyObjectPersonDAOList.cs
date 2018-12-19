using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public class MyObjectPersonDAOList : MyObjectDAOList
    {
        public MyObjectPersonDAOList()
        {
            base.iTools = new MyObjectPersonTools();
        }
            
        public override IMyObject[] SelectByNonPrimaykey(IMyObject obj)
        {
            IMyObject[] temp = null;

            db.LoadList(base.iTools);

            List<IMyObject> tempL = new List<IMyObject>();
            for (int i = 0; i < db.MyobjectList.Count; i++)
            {
                if(db.MyobjectList[i] is Person)
                {
                    if ((db.MyobjectList[i] as Person).Name.IndexOf((obj as Person).Name)>-1)
                    {
                        tempL.Add(db.MyobjectList[i]);
                    }
                }
            }

            int realPersonByNameCount = tempL.Count;
            if (realPersonByNameCount>0)
            {
                temp = new IMyObject[realPersonByNameCount];
                tempL.CopyTo(temp, 0);
            }
            return temp;
        }
    }
}

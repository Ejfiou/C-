using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class_11_30
{
    public class MyObjectPersonDAOArrayList:MyObjectDAOArrayList
    {
        public MyObjectPersonDAOArrayList()
        {

        }

        public override IMyObject[] SelectByNonPrimaykey(IMyObject obj)
        {
            //按姓名查询对应的人信息
            IMyObject[] temp = null;

            ArrayList tempAl = new ArrayList();//定义一个零时的集合
            for (int i = 0; i < db.MyObjectArrayList.Count; i++)
            {
                if (db.MyObjectArrayList[i] is Person)
                {
                    if ((db.MyObjectArrayList[i] as Person).Name.IndexOf((obj as Person).Name)> -1)
                    {
                        tempAl.Add(db.MyObjectArrayList[i]);
                    }
                }
            }

            //将临时的集合转化为要输出的IMyObject类型的数组
            int realPersonByNameCount = tempAl.Count;
            if(realPersonByNameCount > 0)
            {
                temp = new IMyObject[realPersonByNameCount];
                for (int i = 0; i < tempAl.Count; i++)
                {
                    if (tempAl[i] is IMyObject)
                    {
                        temp[i] = tempAl[i] as IMyObject;
                    }
                }
            }


            return temp;
        }
    }
}

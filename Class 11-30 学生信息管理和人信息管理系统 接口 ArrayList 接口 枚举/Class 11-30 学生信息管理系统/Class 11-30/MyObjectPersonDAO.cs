using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Class_11_30
{
    public class MyObjectPersonDAO:MyObjectDAO
    {
        public MyObjectPersonDAO()
        {

        }
        public override IMyObject[] SelectByNonPrimaykey(IMyObject obj)
        {
            IMyObject[] temp = null;

            int realPeopleByNameCount = 0;
            for (int i = 0; i < db.MyObjects.Length; i++)
            {
                //判断当前位置i上是否有人对象
                if (db.MyObjects[i] != null) //有人的对象
                {
                    if (db.MyObjects[i] is Person)
                    {
                        if (obj is Person)
                        {
                            //if ((db.MyObjects[i] as Person).Name == (obj as Person).Name)//精确查询
                            if ((db.MyObjects[i] as Person).Name.IndexOf((obj as Person).Name) >- 1)//模糊查询
                            {
                                realPeopleByNameCount++;
                            }
                        }
                    }
                    
                }
            }

            if (realPeopleByNameCount > 0)
            {
                temp = new IMyObject[realPeopleByNameCount];
                int j = 0;
                for (int i = 0; i < db.MyObjects.Length; i++)
                {
                    //判断当前位置i上是否有人对象
                    if (db.MyObjects[i] != null) //有人的对象
                    {
                        if (db.MyObjects[i] is Person)
                        {
                            if (obj is Person)
                            {
                                //if ((db.MyObjects[i] as Person).Name == (obj as Person).Name)
                                if ((db.MyObjects[i] as Person).Name.IndexOf((obj as Person).Name) > -1)//模糊查询
                                {
                                    //查出人信息
                                    temp[j] = db.MyObjects[i];
                                    j++;
                                }
                            }
                        }
                    }
                }
            }

            return temp;
        }
    }
}

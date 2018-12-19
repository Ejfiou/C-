using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary1;

namespace WareHouseSystem
{
    public class WareHouseDAO:IDAO
    {
        public WareHouseDAO()
        {
            
        }

        private DataBase db = new DataBase();
        private Files files = new Files();


        /// <summary>
        /// 入库
        /// </summary>
        /// <param name="ware">货物对象 </param>
        /// <returns>是否成功</returns>
        public int Put(IMyObject ware)
        {
            //读取文件
            db.Read(files);
           
            for (int i = 0; i < db.Foods.Count; i++)
            {
                //判断是否已经存在此货物
                if (ware.PrimaryKey == (db.Foods[i] as WareHouse).PrimaryKey)
                {

                    //存在就增加数量
                    (db.Foods[i] as WareHouse).FoodsNum = (db.Foods[i] as WareHouse).FoodsNum + (ware as WareHouse).FoodsNum;
                    if ((db.Foods[i] as WareHouse).Unit!=null)
                    {
                        (ware as WareHouse).Unit = (db.Foods[i] as WareHouse).Unit;
                    }
                    PandName();
                    db.Save(files);
                    return 1;
                }
            }


            
            //不存在就添加
            db.Foods.Add(ware);
            PandName();
            //写入文件
            db.Save(files);
            
            return 2;
        }

        /// <summary>
        /// 增加单位
        /// </summary>
        /// <param name="goods">物品对象</param>
        /// <param name="nuit">单位</param>
        /// <returns>是否成功</returns>
        public bool AddNnit(IMyObject goods, string nuit)
        {
            db.Read(files);
            bool flag = false;
            for (int i = 0; i < db.Foods.Count; i++)
            {
                if ((db.Foods[i] as WareHouse).PrimaryKey == (goods as WareHouse).FoodsName)
                {
                    WareHouse good = new WareHouse((goods as WareHouse).FoodsName, (goods as WareHouse).FoodsNum, nuit);
                    db.Foods.RemoveAt(i);
                    db.Foods.Add(good);
                    flag = true;
                    db.Save(files);
                    break;
                }
            }
            return flag;
        }


        /// <summary>
        /// 出库
        /// </summary>
        /// <param name="ware">货物对象</param>
        /// <returns>是否成功</returns>
        public int Out(IMyObject ware)
        {
            db.Read(files);
            //bool flag = false;

           

            for (int i = 0; i < db.Foods.Count; i++)
            {
                if ((db.Foods[i] as WareHouse).FoodsName == (ware as WareHouse).FoodsName)
                {
                    //有要出库的数量就出库 
                    if ((db.Foods[i] as WareHouse).FoodsNum >= (ware as WareHouse).FoodsNum)
                    {
                        if ((db.Foods[i] as WareHouse).FoodsNum > (ware as WareHouse).FoodsNum)
                        {
                            (db.Foods[i] as WareHouse).FoodsNum = (db.Foods[i] as WareHouse).FoodsNum - (ware as WareHouse).FoodsNum;
                            db.Save(files);
                            //flag = true;
                            return 1; //成功
                        }
                        if ((db.Foods[i] as WareHouse).FoodsNum == (ware as WareHouse).FoodsNum)
                        {
                            db.Foods.RemoveAt(i);
                            db.Save(files);
                            return 4; //全部出库
                        } 
                    }
                    else
                    {
                        return 2; //库存不足
                    }
                }
               
            }

            return 3;  //没有货物

            
        }


        /// <summary>
        /// 选择全部
        /// </summary>
        /// <returns>货物对象数组</returns>
        public IMyObject[] SelectAll()
        {
            db.Read(files);
            IMyObject[] temp = null;
            
            int realFoodsCount = db.Foods.Count;
            if (realFoodsCount > 0)
            {
                temp = new IMyObject[realFoodsCount];
                for (int i = 0; i < db.Foods.Count; i++)
                {
                    temp[i] = (db.Foods[i] as IMyObject);
                }
            }

            return temp;
        }

        /// <summary>
        /// 按货物名查找
        /// </summary>
        /// <param name="name">货物名</param>
        /// <returns>货物对象</returns>
        public IMyObject SelectByFoodsName(string name)
        {
            db.Read(files);
            IMyObject temp = null;

            for (int i = 0; i < db.Foods.Count; i++)
            {
                if (db.Foods[i].PrimaryKey == name)
                {
                    temp = db.Foods[i];
                    break;
                }
            }

            return temp;
        }



        /// <summary>
        /// 清除所有货物
        /// </summary>
        public void Clear()
        {
            db.Foods.Clear();
            db.Save(files);
        }

        /// <summary>
        /// 判断名字长度
        /// </summary>
        /// <param name="ware"></param>
        /// <returns></returns>
        public int NameLength(IMyObject ware)
        {
            int lengthOne = 0;
            foreach (char a in (ware as WareHouse).FoodsName)
            {
                if (a < 0 || a > 127)
                {
                    lengthOne = lengthOne + 2;
                }
                else
                {
                    lengthOne++;
                }

            }
            return lengthOne;
        }
        /// <summary>
        /// 最大商品名称长度
        /// </summary>
        public int NameLengthMAX()
        {
            int max = 0;
            for (int i = 0; i < db.Foods.Count; i++)
            {
  
                if (NameLength(db.Foods[i]) > max)
                {
                    max = NameLength(db.Foods[i]);
                }
                
            }
            return max;
        }
        /// <summary>
        /// 名称对齐
        /// </summary>
        public void PandName()
        {
            for (int i = 0; i < db.Foods.Count; i++)
            {
                
                string temp = null;
                for (int j = 0; j < NameLengthMAX() - NameLength(db.Foods[i]); j++)
                {
                    temp += " ";
                }
                (db.Foods[i] as WareHouse).FoodsName += temp;

            }
        }

    }
}

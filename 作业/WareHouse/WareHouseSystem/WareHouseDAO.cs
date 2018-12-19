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
            int flag = 0;
            db.Read(files);
            if (ware is WareHouse)
            {
                if ((ware as WareHouse).FoodsNum != 0)
                {
                    for (int i = 0; i < db.Foods.Count; i++)
                    {
                        if (db.Foods[i] is WareHouse)
                        {
                            //判断是否存在物品
                            if ((db.Foods[i] as WareHouse).PrimaryKey == ware.PrimaryKey)
                            {
                                //存在就增加数量
                                double s = db.Foods[i].FoodsNum;
                                ware.FoodsNum += db.Foods[i].FoodsNum; 

                                if ((db.Foods[i] as WareHouse).Unit != null)
                                {
                                    (ware as WareHouse).Unit = (db.Foods[i] as WareHouse).Unit;
                                }

                                db.Foods[i] = ware;
                                //db.Foods.RemoveAt(i);
                                //db.Foods.Add(ware);
                                flag = 2;
                                
                                db.Save(files);
                                return flag;
                            }
                        }
                    }
                   
                    flag = 1;
                    db.Save(files);
                }
            }

            return flag;
        }

        /// <summary>
        /// 增加单位
        /// </summary>
        /// <param name="goods">物品对象</param>
        /// <param name="nuit">单位</param>
        /// <returns>是否成功</returns>
        public bool AddNnit(IMyObject good, string nuit)
        {
            
            bool flag = false;
            
            IMyObject goods = new WareHouse(good.PrimaryKey, (good as WareHouse).FoodsNum, nuit);
            db.Foods.Add(goods);
            flag = true;
            db.Save(files);
            return flag;
        }


        /// <summary>
        /// 出库
        /// </summary>
        /// <param name="ware">货物对象</param>
        /// <returns>是否成功</returns>
        public int Out(IMyObject ware,out double a)
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
                            a = -1;
                            return 1; //成功
                        }
                        if ((db.Foods[i] as WareHouse).FoodsNum == (ware as WareHouse).FoodsNum)
                        {
                            db.Foods.RemoveAt(i);
                            db.Save(files);
                            a = -1;
                            return 4; //全部出库
                        } 
                    }
                    else
                    {
                        a = db.Foods[i].FoodsNum;
                        return 2; //库存不足
                    }
                }
               
            }
            a = -1;
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
        public IMyObject[] SelectByFoodsName(string name)
        {
            db.Read(files);
            IMyObject[] temp = null;

            List<IMyObject> templ = new List<IMyObject>();

            for (int i = 0; i < db.Foods.Count; i++)
            {
                if (db.Foods[i] is WareHouse)
                {
                    if ((db.Foods[i] as WareHouse).FoodsName.IndexOf(name) > -1)
                    {
                        templ.Add(db.Foods[i]);
                    }
                }

            }

            int real = templ.Count;
            if (real > 0)
            {
                temp = new IMyObject[real];
                templ.CopyTo(temp, 0);
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
        /// 删除物品
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        public bool Delete(IMyObject obj)
        {
            bool flag = false;

            db.Read(files);

            for (int i = 0; i < db.Foods.Count; i++)
            {
                if (db.Foods[i].PrimaryKey == obj.PrimaryKey)
                {
                    db.Foods.RemoveAt(i);
                    flag = true;
                    break;
                }
            }

            db.Save (files);

            return flag;
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

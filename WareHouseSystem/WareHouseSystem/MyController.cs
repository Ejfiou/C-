using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary1;
namespace WareHouseSystem
{
    public class MyController
    {
        public MyController()
        {

        }
        private IDAO dao = new WareHouseDAO();
        private View view = new View();

        /// <summary>
        /// 入口
        /// </summary>
        public void Start()
        {
            do
            {
                view.PrintMenu();
                int menuIndex = view.ChoiceMenu();
                if (menuIndex == 0)
                {
                    break;
                }
                switch (menuIndex)
                {
                    case 1:     //入库
                        Put();
                        break;
                    case 2:     //出库
                        Out();
                        break;
                    case 3:     //打印全部
                        PrintAll();
                        break;
                    case 4:     //打印一个
                        PrintOne();
                        break;
                    case 5:
                        Clear(); //清除所有
                        break;
                    default:
                        view.PrintMessage("没有此选项");
                        break;
                }
                view.Clear();
            } while (true);
        }

        /// <summary>
        /// 入库
        /// </summary>
        public void Put()
        {
            
            IMyObject ware = view.Put();
            int f = dao.Put(ware);
            if (f==2)
            {
                bool f1 = dao.AddNnit(ware,view.AddUnit());
                if (f1)
                {
                    view.PrintMessage("入库成功！");

                }
                else
                {
                    view.PrintMessage("入库失败！");
                }
            }
            else if (f==1)
            {
                view.PrintMessage("入库成功！");
            }
            else
            {
                view.PrintMessage("入库失败！");
            }
        }

        /// <summary>
        /// 出库
        /// </summary>
        public void Out()
        {
            IMyObject ware = view.Out();
            //bool f = dao.Out(ware);
            //if (f)
            //{/
            //    view.PrintMessage("出库成功！");
            //}
            //else
            //{
            //    view.PrintMessage("出库失败！");
            //}
            int f = dao.Out(ware);
            switch (f)
            {
                case 1:
                    view.PrintMessage("出库成功！");
                    break;
                case 2:
                    view.PrintMessage("库存不足，出库失败！");
                    break;
                case 3:
                    view.PrintMessage("无此货物，出库失败！");
                    break;
                case 4:
                    view.PrintMessage("货物全部出库，出库成功！");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 打印全部
        /// </summary>
        public void PrintAll()
        {
            IMyObject[] ware = dao.SelectAll();
            view.PrintAll(ware);
        }

        /// <summary>
        /// 打印一个
        /// </summary>
        public void PrintOne()
        {
            string name = view.SearchByName();
            IMyObject ware = dao.SelectByFoodsName(name);
            view.PrintOne(ware);
        }

        public void Clear()
        {
            dao.Clear();
            view.PrintMessage("清除成功！");
        }
    }
}

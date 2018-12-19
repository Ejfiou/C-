using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Class_11_30
{
    public class MyObjectBusView : MyObjectView
    {

        public override IMyObject Create()
        {
            IMyObject temp = null;

            Console.Write("请输入公交车车牌(以Bus开头加四位数字)：");
            string busNum = Console.ReadLine().Trim();
            while (Regex.IsMatch(busNum, @"^Bus\d{4}$") == false)
            {
                Console.Write("输入有误！请重新输入车牌(以Bus开头加四位数字)：");
                busNum = Console.ReadLine().Trim();
            }

            Console.Write("请输入公交车线路(L开头四位数字)：");
            string busLine = Console.ReadLine().Trim();
            while (Regex.IsMatch(busLine, @"^L\d{4}$") == false)
            {
                Console.Write("输入有误！请重新输入线路(L开头四位数字)：");
                busLine = Console.ReadLine().Trim();
            }

            Console.Write("请输入公交车起点：");
            string startPoint = Console.ReadLine().Trim();
            while (Regex.IsMatch(startPoint, @"^\w+$") == false)
            {
                Console.WriteLine("输入有误！请重新输入起点：");
                startPoint = Console.ReadLine().Trim();
            }

            Console.Write("请输入公交车终点：");
            string endPoint = Console.ReadLine().Trim();
            while (Regex.IsMatch(endPoint, @"^\w+$") == false)
            {
                Console.WriteLine("输入有误！请重新输入终点：");
                endPoint = Console.ReadLine().Trim();
            }

            temp = new Bus(busNum, busLine, startPoint, endPoint);

            return temp;
        }

        public override IMyObject Modify()
        {
            IMyObject temp = null;

            Console.Write("请输入要修改的公交车车牌(以Bus开头加四位数字)：");
            string busNum = Console.ReadLine().Trim();
            while (Regex.IsMatch(busNum, @"^Bus\d{4}$") == false)
            {
                Console.Write("输入有误！请重新输入车牌(以Bus开头加四位数字)：");
                busNum = Console.ReadLine().Trim();
            }

            Console.Write("请输入修改后的公交车线路(L开头四位数字)：");
            string busLine = Console.ReadLine().Trim();
            while (Regex.IsMatch(busLine, @"^L\d{4}$") == false)
            {
                Console.Write("输入有误！请重新输入线路(L开头四位数字)：");
                busLine = Console.ReadLine().Trim();
            }

            Console.Write("请输入修改后的公交车起点：");
            string startPoint = Console.ReadLine().Trim();
            while (Regex.IsMatch(startPoint, @"^\w+$") == false)
            {
                Console.WriteLine("输入有误！请重新输入起点：");
                startPoint = Console.ReadLine().Trim();
            }

            Console.Write("请输入修改后的公交车终点：");
            string endPoint = Console.ReadLine().Trim();
            while (Regex.IsMatch(endPoint, @"^\w+$") == false)
            {
                Console.WriteLine("输入有误！请重新输入终点：");
                endPoint = Console.ReadLine().Trim();
            }

            temp = new Bus(busNum, busLine, startPoint, endPoint);
            return temp;
        }

        public override void PrintMany(IMyObject[] objs)
        {
            Console.WriteLine("***************公交车信息如下****************");
            if (objs != null)
            {
                for (int i = 0; i < objs.Length; i++)
                {
                    Console.WriteLine(objs[i].ShowMe());
                }
            }
            else
            {
                Console.WriteLine("对不起，当前没有公交车信息！");
            }
        }

        public override void PrintMenu()
        {
            Console.WriteLine("**********公交车信息管理系统 v1.0***********");
            Console.WriteLine("0.退出");
            Console.WriteLine("1.增加公交车信息");
            Console.WriteLine("2.查询所有公交车信息");
            Console.WriteLine("3.修改公交车信息");
            Console.WriteLine("4.删除公交车信息");
            Console.WriteLine("5.按车牌查询公交车信息");
            Console.WriteLine("6.按线路查询公交车信息");
        }

        public override void PrintOne(IMyObject obj)
        {
            Console.WriteLine("\n************公交车信息如下*******************");

            if (obj != null)
            {
                Console.WriteLine(obj.ShowMe());
            }
            else
            {
                Console.WriteLine("对不起！没有对应的公交车信息！");
            }
        }

        public override IMyObject QueryByNonPrimaryKey()
        {
            IMyObject temp = null;

            Console.Write("请输入要查询的的公交车线路(L开头四位数字)：");
            string busLine = Console.ReadLine().Trim();
            while (Regex.IsMatch(busLine, @"^L\d{4}$") == false)
            {
                Console.Write("输入有误！请重新输入线路(L开头四位数字)：");
                busLine = Console.ReadLine().Trim();
            }

            temp = new Bus(null, busLine, null, null);

            return temp;
        }

        public override string QueryByPrimaryKey()
        {
            Console.Write("请输入要查询的公交车车牌(以Bus开头加四位数字)：");
            string busNum = Console.ReadLine().Trim();
            while (Regex.IsMatch(busNum, @"^Bus\d{4}$") == false)
            {
                Console.Write("输入有误！请重新输入车牌(以Bus开头加四位数字)：");
                busNum = Console.ReadLine().Trim();
            }

            return busNum;
        }

        public override IMyObject Remove()
        {
            IMyObject temp = null;

            Console.Write("请输入要删除的公交车车牌(以Bus开头加四位数字)：");
            string busNum = Console.ReadLine().Trim();
            while (Regex.IsMatch(busNum, @"^Bus\d{4}$") == false)
            {
                Console.Write("输入有误！请重新输入车牌(以Bus开头加四位数字)：");
                busNum = Console.ReadLine().Trim();
            }

            temp = new Student(busNum);

            return temp;
        }
    }
}

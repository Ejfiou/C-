using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary1;

namespace WareHouseSystem
{
    public class WareHouse:IMyObject
    {
        public WareHouse()
        { }

        public WareHouse(string foodsName, double foodsNum, string unit)
        {
            this.foodsName = foodsName;
            this.foodsNum = foodsNum;
            this.unit = unit;
        }

        public WareHouse(string foodsName, double foodsNum)
        {
            this.foodsName = foodsName;
            this.foodsNum = foodsNum;
        }

        private string unit;

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }


        public string PrimaryKey
        {
            get { return foodsName; }
            set { foodsName = value; }
        }
        
        private string foodsName;

        /// <summary>
        /// 货物名称
        /// </summary>          
        public string FoodsName
        {
            get { return foodsName; }
            set { foodsName = value; }
        }

        private double foodsNum;

        /// <summary>
        /// 库存数量
        /// </summary>
        public double FoodsNum
        {
            get { return foodsNum; }
            set { foodsNum = value; }
        }

        /// <summary>
        /// 显示信息
        /// </summary>
        /// <returns>信息</returns>
        public string ShowMe()
        {
            return $"货物名：{foodsName}\t货物库存：{foodsNum,7} ({unit})";
        }
    }
}

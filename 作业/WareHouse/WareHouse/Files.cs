using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MyClassLibrary1;
namespace WareHouse
{
    public class Files:IMyObjectTools
    {
        public Files()
        {

        }

        /// <summary>
        /// 存储的文件
        /// </summary>
        private string saveFile = "Data.vac";
        public string SaveFile
        {
            get
            {
                return saveFile;
            }

            set
            {
                saveFile = value;
            }
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="foods">货物对象</param>
        /// <returns>序列化后的字符串</returns>
        public string MySerialize(IMyObject foods)
        {
            string str = string.Empty;

            if (foods is WareHouse)
            {
                WareHouse temp = foods as WareHouse;
                str = string.Join(",", temp.FoodsName, temp.FoodsNum, temp.Unit);
            }
               
            return str;
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="str">序列化后的字符串</param>
        /// <returns>货物对象</returns>
        public IMyObject MyDeserialize(string str)
        {
            IMyObject temp = null;

            string[] s = str.Split(',');
            temp = new WareHouse(s[0], double.Parse(s[1]),s[2]);

            return temp;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MyClassLibrary1
{
    public class DataBase
    {
        public DataBase()
        {

        }

    
        private List<IMyObject> foods = new List<IMyObject>();

        /// <summary>
        /// 存储货物信息
        /// </summary>
        public List<IMyObject> Foods
        {
            get { return foods; }
            set { foods = value; }
        }

        /// <summary>
        /// 判断数据是否存储成功
        /// </summary>
        /// <param name="files">数据对象</param>
        /// <returns>是否成功</returns>
        public bool Save(IMyObjectTools files)
        {
            bool flag = false;

            try
            {
                using (StreamWriter sw = new StreamWriter(files.SaveFile, false, Encoding.UTF8))
                {
                    for (int i = 0; i < foods.Count; i++)
                    {
                        sw.WriteLine(files.MySerialize(foods[i] ));
                    }
                }
                flag = true;
            }
            catch (Exception e)
            {

                throw e;
            }

            return flag;
        }

        ///// <summary>
        ///// 判断数据是否读取成功
        ///// </summary>
        ///// <param name="files">数据对象</param>
        ///// <returns>是否成功</returns>
        public bool Read(IMyObjectTools files)
        {
            bool flag = false;

            try
            {
                if (!File.Exists(files.SaveFile))
                {
                    using (StreamWriter sw = new StreamWriter(files.SaveFile, false, Encoding.UTF8))
                    {
                        sw.Close();
                    }
                }
                using (StreamReader sr = new StreamReader(files.SaveFile, Encoding.UTF8))
                {
                    foods.Clear();
                    while (sr.Peek() > -1)
                    {
                        IMyObject temp = files.MyDeserialize(sr.ReadLine());
                        foods.Add(temp);
                    }
                }
                flag = true;
            }
            catch (Exception e)
            {
                throw e;
            }

            return flag;
        }
    }
}

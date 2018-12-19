using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_T2_11_22
{
    class Game
    {
        /// <summary>
        /// 判断输赢
        /// </summary>
        /// <param name="a">甲方输入的数据</param>
        /// <param name="b">乙方输入的数据</param>
        /// <returns>返回结果(0,1,2)</returns>
        public int Judge(int a, int b)
        {
            if (a == b)
            {
                return 0; //平局
            }
            else if ((a + b == 4 && a < b) || (a + b == 3 && a > b) || (a + b == 5 && a > b))
            {
                return 1; //乙赢了
            }
            else
            {
                return 2; //甲赢了
            }
        }
    }
}

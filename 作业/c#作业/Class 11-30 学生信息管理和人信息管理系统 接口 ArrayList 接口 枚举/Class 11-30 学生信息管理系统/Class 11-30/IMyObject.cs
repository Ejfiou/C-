using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    /// <summary>
    /// 万事万物中的某种信息
    /// </summary>
    public interface IMyObject
    {
        string PrimaryKey
        {
            get;
            set;
        }

        /// <summary>
        /// 显示该对象的信息
        /// </summary>
        /// <returns>该对象的信息</returns>
        string ShowMe();
    }
}

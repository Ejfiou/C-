using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public interface IMyObjectTools
    {
        /// <summary>
        /// 指定文件的保存路径
        /// </summary>
        string SaveFile { get; set; }

        /// <summary>
        /// 序列化(Serialization)将对象的状态信息转换为可以存储或传输的形式的过程
        /// 将对象转化为字符串
        /// </summary>
        /// <param name="obj">要转化的对象</param>
        /// <returns>转化为的字符串</returns>
        string MySerialize(IMyObject obj);

        /// <summary>
        /// 反序列化（Deserialization）将可以存储或传输的形式内容转化为对象的状态信息的过程
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        IMyObject MyDeserialize(string str);

    }
}

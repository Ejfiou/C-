using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    interface IMyObjectDAO
    {
        /// <summary>
        /// 增加某种信息
        /// </summary>
        /// <param name="per">新增的某种信息</param>
        /// <returns>返回true表示增加成功；否则返回false表示增加失败</returns>
        bool Insert(IMyObject obj);

        /// <summary>
        /// 修改某种信息
        /// </summary>
        /// <param name="per">修改后的新的某种信息数据</param>
        /// <returns>返回true表示修改成功；否则返回false表示修改失败</returns>
        bool Update(IMyObject obj);

        /// <summary>
        /// 删除某种信息
        /// </summary>
        /// <param name="obj">要删除的某种对象</param>
        /// <returns>返回true表示删除成功；否则返回false表示删除失败</returns>
        bool Delete(IMyObject obj);

        /// <summary>
        /// 查询所有某种信息
        /// </summary>
        /// <returns>所有某种信息数组</returns>
        IMyObject[] SelectAll();

        /// <summary>
        /// 按照主键查询对应的某种信息
        /// </summary>
        /// <param name="primaryKey">查询的主键</param>
        /// <returns>对应的某种信息</returns>
        IMyObject SelectByPrimaryKey(string primaryKeyy);

        /// <summary>
        /// 按照名字查询对应的某种信息
        /// </summary>
        /// <param name="name">查询的名字</param>
        /// <returns>所有信息的数组</returns>
        IMyObject[] SelectByNonPrimaykey(IMyObject obj);




    }
}

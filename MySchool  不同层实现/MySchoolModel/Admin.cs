using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Model
{
    /// <summary>
    /// 数据传输对象（DTO）（Data Transfer Object）
    /// </summary>


    public class Admin
    {
        public string AdminGuid { get; set; }

        public string LoginId { get; set; }

        public string LoginPwd { get; set; }

    }
}

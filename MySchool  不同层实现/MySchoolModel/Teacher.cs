using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Model
{
    public class Teacher
    {

        public string TeacherGuid { get; set; }
        public string LoginId { get; set; }

        public string LoginPwd { get; set; }

        public int UserStateId { get; set; }

        public string TeacherName { get; set; }

        public string Sex { get; set; }
        public Nullable<DateTime> Birthday { get; set; }
        public string SubjectGUID { get; set; }

        //外键类
        public Subject Subject { get; set;}
    }
}

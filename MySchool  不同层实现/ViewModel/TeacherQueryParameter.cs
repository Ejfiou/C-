using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.ViewModel
{
    public class TeacherQueryParameter
    {
        public string TeacherName { get; set; }
        public string Sex { get; set; }
        public string SubjectGUID { get; set; }
        public int PageMaxRowNumber { get; set; }//每页呈现的最大行数
        public int PageNumber { get; set; }//页数

        public int PageTotalNumber { get; set; }//总页数
    }
}

﻿using Ruanmou.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ruanmou.Framework.AttributeExtend;

namespace Ruanmou.Libraries.DAL
{
    public class TSqlHelper<T> where T : BaseModel
    {
        static TSqlHelper()
        {
            Type type = typeof(T);
            string columnString = string.Join(",", type.GetProperties().Select(p => $"[{p.GetColumnName()}]"));
            FindSql = $"SELECT {columnString} FROM [{type.Name}] WHERE Id=";
            FindAllSql = $"SELECT {columnString} FROM [{type.Name}];";
        }

        public static string FindSql = null;
        public static string FindAllSql = null;
        //delete  update  insert 
    }
}

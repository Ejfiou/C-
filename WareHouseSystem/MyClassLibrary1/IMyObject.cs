using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary1
{
    public interface IMyObject
    {

        string PrimaryKey
        {
            get;
            set;
        }

        string Unit
        {
            get;
            set;
        }

        string FoodsName
        {
            get;
            set;
        }

        double FoodsNum
        {
            get;
            set;
        }

    }
}

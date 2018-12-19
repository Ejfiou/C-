using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyClassLibrary1
{
    public interface IDAO
    {
        int Put(IMyObject ware);

        bool AddNnit(IMyObject goods, string nuit);

        int Out(IMyObject ware,out double p);

        IMyObject[] SelectAll();

        IMyObject[] SelectByFoodsName(string name);


    }
}

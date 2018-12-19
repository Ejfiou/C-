using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary1
{
    public interface IView
    {
        void PrintMenu();

        void Clear();

        int ChoiceMenu();

        IMyObject Put();

        string AddUnit();

        IMyObject Out();

        string SearchByName();

        void PrintAll(IMyObject[] ware);

        void PrintOne(IMyObject ware);

        void PrintMessage(string msg);

        

    }
}

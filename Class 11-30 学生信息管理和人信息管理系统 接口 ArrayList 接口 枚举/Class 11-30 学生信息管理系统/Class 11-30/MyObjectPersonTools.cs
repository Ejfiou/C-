using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public class MyObjectPersonTools : IMyObjectTools
    {

        private string saveFile = "Person.cvs";
        public string SaveFile
        {
            get
            {
                return saveFile;
            }

            set
            {
                saveFile = value;
            }
        }

        public IMyObject MyDeserialize(string str)
        {
            IMyObject temp = null;

            string[] ss = str.Split(',');
            temp = new Person(ss[0], ss[1], Convert.ToInt32(ss[2]), (Genders)Enum.Parse(typeof(Genders), ss[3]));

            return temp;
        }

        public string MySerialize(IMyObject obj)
        {
            string str = string.Empty;//"";

            if (obj is Person)
            {
                Person temp = obj as Person;
                str = string.Join(",",temp.CardID,temp.Name,temp.Age,temp.Sex);
            }
            return str;
        }
    }
}

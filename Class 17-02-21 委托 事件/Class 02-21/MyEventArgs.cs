using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_02_21
{
   public class MyEventArgs:EventArgs
    {

        public MyEventArgs()
        {

        }
        public MyEventArgs(string message)
        {
            this.message = message;
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

    }
}

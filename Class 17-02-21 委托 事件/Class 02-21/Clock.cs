using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_02_21
{
    public delegate void MyWinFormDelegate(object source, MyEventArgs e);
    class Clock
    {
        //事件
        public event TestDelegate TestEvent;
        public event MyWinFormDelegate TestWinFormEvent;

        public void Sound()
        {
            Console.WriteLine("现在六点钟了");
            //通知订阅者事件
            if (TestEvent != null)
            {
                TestEvent("测试");
            }

            if (TestWinFormEvent != null)
            {
                TestWinFormEvent(this, new MyEventArgs("我的参数"));
            }
        }
    }
}

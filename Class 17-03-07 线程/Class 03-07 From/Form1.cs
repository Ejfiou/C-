using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Class_03_07_From
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Thread th;
        private bool isSuspend = false;
        ManualResetEvent manual = new ManualResetEvent(false);

        private void btnStart_Click(object sender, EventArgs e)
        {
            th = new Thread(() =>
            {
                while(true)
                {
                    if (isSuspend == true)
                    {
                        //manual.WaitOne();
                    }
                    if (progressBar1.Value < progressBar1.Maximum)
                    {
                        this.progressBar1.Value++;
                        Thread.Sleep(100);
                    }
                    else
                    {
                        break;
                    }
                }
               
            });
            th.IsBackground = true;

            th.Start();
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            // th.Suspend();
            manual.Reset();
            isSuspend = true;

        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            //th.Resume();
            isSuspend = false;
            manual.Set();
        }
    }
}

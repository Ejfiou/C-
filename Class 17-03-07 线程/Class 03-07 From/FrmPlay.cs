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
    public partial class FrmPlay : Form
    {
        public FrmPlay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread threadBall = new Thread(() =>
            {
                while (true)
                {
                    Point newPoint = new Point();
                    bool toDown = true;
                    bool toRight = true;

                    if (this.label2.Location.X == this.Location.X)
                    {
                        toRight = false;
                    }
                    if (this.label2.Location.Y == this.Location.X)
                    {
                        toRight = false;
                    }

                    if (toRight)
                    {
                        newPoint.X = this.label2.Location.X - 1;
                    }
                    else
                    {
                        newPoint.X = this.label2.Location.X + 1;
                    }

                    if (toDown)
                    {
                        newPoint.Y = this.label2.Location.Y - 1;
                    }
                    else
                    {
                        newPoint.Y = this.label2.Location.Y + 1;
                    }

                    label2.Location = newPoint;


                    //if (label2.Location.X + this.label2.Width < this.ClientSize.Width)
                    //{
                    //    this.label2.Location = new Point(this.label2.Location.X + 1, this.label2.Location.Y+1);
                        
                    //}
                    
                    Thread.Sleep(10);
                }
            });
            threadBall.IsBackground = true;
            threadBall.Start();
        }
    }
}

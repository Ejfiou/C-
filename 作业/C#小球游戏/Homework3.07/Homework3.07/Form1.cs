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

namespace Homework3._07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool f;

        private int LblX=170;
        private int LblY=380;
        private int PicX=203;
        private int PicY=342;

        private void 开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeginChoice.Enabled = false;
            Resume();
            f = true;
            Thread th = new Thread(()=> 
            {
                if (f == true)
                {
                    RightUp();
                }
            });
            th.IsBackground = true;
            th.Start();
        }

         

        public void RightUp()
        {
            while (this.pictureBox1.Width + this.pictureBox1.Location.X < this.ClientSize.Width)
            {
                this.pictureBox1.Location = new System.Drawing.Point(this.pictureBox1.Location.X + 1, this.pictureBox1.Location.Y - 1);
                Thread.Sleep(5);
                if (this.pictureBox1.Location.Y == this.menuStrip1.Height)
                {
                    break;
                }
            }
            if (this.pictureBox1.Width + this.pictureBox1.Location.X == this.ClientSize.Width)
            {
                LeftUp();
            }
            else if (this.pictureBox1.Location.Y == this.menuStrip1.Height)
            {
                RightDown();
            }

        }

        //this.ClientSize.Height-(this.ClientSize.Height - this.label1.Location.Y)  接板
        public void RightDown()
        {
            while (this.pictureBox1.Height + this.pictureBox1.Location.Y < this.ClientSize.Height)
            {
                this.pictureBox1.Location = new System.Drawing.Point(this.pictureBox1.Location.X + 1, this.pictureBox1.Location.Y + 1);
                Thread.Sleep(5);
                if (this.pictureBox1.Width + this.pictureBox1.Location.X == this.ClientSize.Width)
                {
                    break;
                }
                if (this.pictureBox1.Location.Y + (this.pictureBox1.Height) == this.ClientSize.Height - (this.ClientSize.Height - this.label1.Location.Y))
                {
                    if ((this.pictureBox1.Location.X + (this.pictureBox1.Width) / 2 < this.label1.Location.X + this.label1.Width) && (this.pictureBox1.Location.X + (this.pictureBox1.Width) / 2 > this.label1.Location.X))
                    {
                        break;
                    }
                }
            }
            if (this.pictureBox1.Height + this.pictureBox1.Location.Y == this.ClientSize.Height)
            {
                f = false;
                if (f == false)
                {
                    MessageBox.Show("游戏结束");
                    BeginChoice.Enabled = true;
                }
            }
            else if (this.pictureBox1.Width + this.pictureBox1.Location.X == this.ClientSize.Width)
            {
                LeftDown();
            }
            else if (this.pictureBox1.Location.Y + (this.pictureBox1.Height) == this.ClientSize.Height - (this.ClientSize.Height - this.label1.Location.Y))
            {
                if ((this.pictureBox1.Location.X + (this.pictureBox1.Width) / 2 < this.label1.Location.X + this.label1.Width) && (this.pictureBox1.Location.X + (this.pictureBox1.Width) / 2 > this.label1.Location.X))
                {
                    RightUp();
                }
            }
        }

        public void LeftUp()
        {
            while (this.pictureBox1.Location.Y>this.menuStrip1.Height)
            {
                this.pictureBox1.Location = new System.Drawing.Point(this.pictureBox1.Location.X - 1, this.pictureBox1.Location.Y - 1);
                Thread.Sleep(5);
                if ((this.pictureBox1.Location.X == (this.Width - this.ClientSize.Width) / 4))
                {
                    break;
                }
            }
            if (this.pictureBox1.Location.Y == this.menuStrip1.Height)
            {
                LeftDown();
            }
            else if ((this.pictureBox1.Location.X == (this.Width - this.ClientSize.Width) / 4))
            {
                RightUp();
            }
        }
        public void LeftDown()
        {
            while (this.pictureBox1.Location.X > (this.Width - this.ClientSize.Width) / 4)
            {
                this.pictureBox1.Location = new System.Drawing.Point(this.pictureBox1.Location.X - 1, this.pictureBox1.Location.Y + 1);
                Thread.Sleep(5);
                if (this.pictureBox1.Height + this.pictureBox1.Location.Y == this.ClientSize.Height)
                {
                    f = false;
                    if (f == false)
                    {
                        MessageBox.Show("游戏结束");
                        BeginChoice.Enabled = true;
                    }
                    break;
                }
                if (this.pictureBox1.Location.Y + (this.pictureBox1.Height) == this.ClientSize.Height - (this.ClientSize.Height - this.label1.Location.Y))
                {
                    if ((this.pictureBox1.Location.X + (this.pictureBox1.Width) / 2 < this.label1.Location.X + this.label1.Width) && (this.pictureBox1.Location.X + (this.pictureBox1.Width) / 2 > this.label1.Location.X))
                    {
                        break;
                    }
                }
            }
            if (this.pictureBox1.Location.X == (this.Width - this.ClientSize.Width) / 4)
            {
                RightDown();
            }
            else if (this.pictureBox1.Location.Y + (this.pictureBox1.Height) == this.ClientSize.Height - (this.ClientSize.Height - this.label1.Location.Y))
            {
                if ((this.pictureBox1.Location.X + (this.pictureBox1.Width) / 2 < this.label1.Location.X + this.label1.Width) && (this.pictureBox1.Location.X + (this.pictureBox1.Width) / 2 > this.label1.Location.X))
                {
                    LeftUp();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(this.label1.Location.X>(this.Width-this.ClientSize.Width)/4)
                {
                    this.label1.Location = new System.Drawing.Point(this.label1.Location.X - 8, this.label1.Location.Y);
                }
            }
            else if(e.KeyCode == Keys.Right)
            {
                if (this.label1.Location.X+this.label1.Width <  this.ClientSize.Width)
                {
                    this.label1.Location = new System.Drawing.Point(this.label1.Location.X + 8, this.label1.Location.Y); 
                }
            }
        }

        public void Resume()
        {
            this.label1.Location = new System.Drawing.Point(LblX,LblY);
            this.pictureBox1.Location = new System.Drawing.Point(PicX,PicY);
        }
    }
}

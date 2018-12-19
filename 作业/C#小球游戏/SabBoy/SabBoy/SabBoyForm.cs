using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SabBoy
{
    public partial class SabBoy : Form
    {
        private Timer timer;
        private Timer timer_time;
        private Controler controler;
        private bool isKeyDown = false;
        //游戏时间
        int h=0, m=0, s=0;

        public SabBoy()
        {
            InitializeComponent();
            timer = new Timer();
            timer_time = new Timer();
            controler = new Controler(this.Width, this.Height);

            timer.Interval = 10;
            timer.Tick += new EventHandler(timer_Tick);
            timer_time.Interval = 1000;
            timer_time.Tick += new EventHandler(timer_time_Tick);
        }
        
        //初始化游戏界面
        private void SabBoy_Paint(object sender, PaintEventArgs e)
        {
            controler.InitGame(e.Graphics);
        }

        //游戏驱动
        public void timer_Tick(object sender, EventArgs e)
        {
            if (!controler.IsGameOver())
            {
                timer_time.Start();
                if (isKeyDown)
                {
                    controler.MoveBoard();
                }
                controler.RunBall();
                controler.Hit();               

                controler.InitGame(this.CreateGraphics());
                txtSorce.Text = controler.sorce.ToString();

                if (controler.IsSuccess())
                {
                    this.CreateGraphics().DrawString("You Win", new Font("Comic Sans MS", 25), new SolidBrush(Color.Red), 
                                                      this.Width / 2 - 100, this.Height / 2 - 50);
                    timer.Stop();
                    timer_time.Stop();
                }
            }
            else
            {
                this.CreateGraphics().DrawString("Game Over", new Font("Comic Sans MS", 25), new SolidBrush(Color.Snow), 
                                                  this.Width / 2 - 100, this.Height / 2 - 50);
                timer_time.Stop();
            }
        }

        private void SabBoy_KeyDown(object sender, KeyEventArgs e)
        {
            isKeyDown = true;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    {
                        controler.Direction = BoardDirection.Left;
                        timer.Start();
                    }
                    break;
                case Keys.Right:
                    {
                        controler.Direction = BoardDirection.Right;
                        timer.Start();
                    }
                    break;
                default:
                    break;
            }

        }

        private void SabBoy_KeyUp(object sender, KeyEventArgs e)
        {
            isKeyDown = false;
        }

        //因为我设置窗体边框样式为None(个人认为缺省的边框不好看)，自定义了关闭按钮
        //有时间的话再美化一下窗体，目前版本算是第一板吧，以后会更新
        private void lbClose_MouseMove(object sender, MouseEventArgs e)
        {
            lbClose.ForeColor = Color.Red;
        }

        private void lbClose_MouseLeave(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.White;
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //游戏时间
        public void timer_time_Tick(object sender, EventArgs e)
        {
            s++;
            if (s >= 59)
            {
                m += 1;
                s = 0;
            }
            if (m >= 59)
            {
                h += 1;
                m = 0;
            }
            txtTime.Text =h.ToString("00")+":"+m.ToString("00") + ":" + s.ToString("00");
        }
     
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 仓库管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader error = new StreamReader("wrong.txt");//读取错误次数信息
            int num = int.Parse(error.ReadLine());//转换读取信息
            error.Close();//关闭文本
            if (num > 0)//判断是否还有权利进入系统
            {
                StreamReader passw = new StreamReader("pass.txt");//读取密码文件
                string[] np = passw.ReadLine().Split('\t');//对比信息
                passw.Close();//关闭文本
                if (name.Text == np[0] && password.Text == np[1])//判断密码或用户名是否一致
                {
                    StreamWriter newnum = new StreamWriter("wrong.txt");//覆盖错误次数信息
                    newnum.Write("3");//写入新次数
                    newnum.Close();
                    this.Hide();//首先隐藏
                    manform newform = new manform();//打开主控面板
                    newform.ShowDialog();
                    this.Show();
                    Form1.ActiveForm.Close();//关闭主窗口

                }
                else
                {
                    num -= 1;//错误次数减1
                    StreamWriter newnum = new StreamWriter("wrong.txt");//覆盖错误次数信息
                    newnum.Write(num + "");//写入新次数
                    newnum.Close();
                    MessageBox.Show("对不起，你的密码或用户名错误" + "你还有" + num + "次机会");
                    name.Text = "";//清空输入框
                    password.Text = "";
                }
            }
            else
            {
                Random r = new Random();//创建随机密码
                char[] s1 = new char[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
                char[] s2 = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '|', '?', '<', '>' };
                int a1 = s1.Length;
                int a2 = s2.Length;
                string[] w1 = new string[4];
                string[] w2 = new string[4];
                for (int i = 0; i < 4; i++)
                {
                    w1[i] = s1[r.Next(0, a1 - 1)] + "";
                    w2[i] = s2[r.Next(0, a2 - 1)] + "";
                }
                int d = r.Next(000000, 999999);
                string All = w1[0] + w1[1] + w1[2] + w1[3] + d + w2[0] + w2[1] + w2[2] + w2[3];// 新密码
                StreamReader passw = new StreamReader("pass.txt");//读取密码文件
                string[] np = passw.ReadLine().Split('\t');//对比信息
                passw.Close();
                StreamWriter ne = new StreamWriter("pass.txt");
                ne.Write(np[0] + '\t' + All);
                ne.Close();
                MessageBox.Show("对不起，你错误次数已用完，电脑自动上锁！！");
                DialogResult D = MessageBox.Show("是否进入管理员破译界面?");
                if (D.ToString() == "OK")
                {
                    mine f = new mine();
                    f.ShowDialog();
                }
                else
                {

                }
                name.Text = "";//清空
                password.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
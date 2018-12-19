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
    public partial class manform : Form
    {
        public manform()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  清理控件
        /// </summary>
        public void clear()
        {
            inname.Text = "";
            inunit.Text = "";
            innum.Text = "";
            inpri.Text = "";
            inman.Text = "";
            incap.Text = "";
            outname.Text = "";
            outunit.Text = "";
            outnum.Text = "";
            outpri.Text = "";
            outws.Text = "";
            outman.Text = "";
            outcap.Text = "";
        }
        /// <summary>
        /// 表格显示
        /// </summary>
        /// 
        public void Shows()
        {
            listView1.Items.Clear();
            StreamReader X = new StreamReader("news\\inname.txt");//读取
            string E = X.ReadLine();
            X.Close();
            if (E != "" & E != null)//判断是否有信息
            {
                string[] lines = File.ReadAllLines("news\\inname.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] line = lines[i].ToString().Split('\t');
                    listView1.Items.Add((i + 1).ToString(), 0);
                    listView1.Items[i].SubItems.Add(line[0]);
                    listView1.Items[i].SubItems.Add(line[1]);
                    listView1.Items[i].SubItems.Add(line[2]);
                }
            }
        }
        /// <summary>
        /// 显示选择名字
        /// </summary>
        /// 
        public void showname()
        {
            inname.Items.Clear();
            outname.Items.Clear();
            StreamReader R = new StreamReader("news\\inname.txt");
            string T = R.ReadLine();
            R.Close();
            if (T != "" && T != null)//判断是否有信息
            {
                string[] lines = File.ReadAllLines("news\\inname.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] x = lines[i].ToString().Split('\t');
                    inname.Items.Add(x[0]);
                    outname.Items.Add(x[0]);
                }
            }
        }
        /// <summary>
        /// 写入详细信息
        /// </summary>
        /// 
        public void Wri()
        {
            StreamReader M = new StreamReader("news\\no.txt");//读取ID
            string a = M.ReadLine();
            M.Close();
            if (tim.Text.Length<4)
            {

                StreamWriter newfile = File.AppendText("news\\" + inname.Text + ".txt");//新建一个文本
                newfile.WriteLine(a+'\t'+inname.Text + '\t' + inunit.Text + '\t' + innum.Text + '\t' + inpri.Text + '\t' + "存" + '\t' + (long.Parse(innum.Text) * double.Parse(inpri.Text) + "") + '\t' + r + '\t' + inman.Text + '\t' + incap.Text);
                newfile.Close();
                long S = long.Parse(a);
                S += 1;
                StreamWriter T = new StreamWriter("news\\no.txt");
                T.Write(S + "");
                T.Close();
            }
            else
            {
                StreamWriter newfile = File.AppendText("news\\" + inname.Text + ".txt");//新建一个文本
                newfile.WriteLine(a+'\t'+inname.Text + '\t' + inunit.Text + '\t' + innum.Text + '\t' + inpri.Text + '\t' + "存" + '\t' + (long.Parse(innum.Text) * double.Parse(inpri.Text) + "") + '\t' +tim.Text + '\t' + inman.Text + '\t' + incap.Text);
                newfile.Close();
                long S = long.Parse(a);
                S += 1;
                StreamWriter T = new StreamWriter("news\\no.txt");
                T.Write(S + "");
                T.Close();
            }
        }
        string r;
        public void Time()//获取日期并以****-**-**形式显示
        {
             r = DateTime.Now.Year + "" + '-' + DateTime.Now.Month + "" + '-' + DateTime.Now.Day + "";
        }
        /// <summary>
        /// 进库信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (innum.Text != "" && inpri.Text != "")
            {
                if (inname.Text != "")
                {
                    Time();//调用时间
                    int XK = 0;//变量
                    StreamReader nothing = new StreamReader("news\\inname.txt");// 读取所有名字信息
                    string R = nothing.ReadLine();
                    nothing.Close();
                    if (R != "" && R != null)//判断文本是否有信息
                    {
                        string[] S = File.ReadAllLines("news\\inname.txt");//读取文本里的所有信息
                        for (int i = 0; i < S.Length; i++)
                        {
                            string[] One = S[i].ToString().Split('\t');
                            if (One[0] == inname.Text)//判断是否有相同的名字
                            {
                                StreamWriter U = new StreamWriter("news\\inname.txt");//删除文本的所有信息
                                U.Write("");
                                U.Close();
                                int a = int.Parse(One[1]);//转换库存信息
                                int b = int.Parse(innum.Text);//转换输入信息
                                string c = a + b + "";
                                for (int T = 0; T < i; T++)//写入前面的所有信息
                                {
                                    StreamWriter s1 = File.AppendText("news\\inname.txt");
                                    s1.WriteLine(S[T]);
                                    s1.Close();
                                }
                                for (int j = i + 1; j < S.Length; j++)//写入后面的信息
                                {
                                    StreamWriter s2 = File.AppendText("news\\inname.txt");
                                    s2.WriteLine(S[j]);
                                    s2.Close();
                                }
                                StreamWriter s3 = File.AppendText("news\\inname.txt");//写入更改的信息
                                s3.WriteLine(One[0] + '\t' + c + '\t' + r);
                                s3.Close();
                                XK = 1;
                                Wri();
                                MessageBox.Show("添加成功");
                                clear();
                            }
                        }
                        if (XK == 0)//判断有没有添加
                        {
                            StreamWriter s4 = File.AppendText("news\\inname.txt");
                            s4.WriteLine(inname.Text + '\t' + innum.Text + '\t' + r);
                            s4.Close();
                            Wri();
                            MessageBox.Show("添加成功");
                            clear();
                        }
                    }
                    else
                    {
                        StreamWriter open = File.AppendText("news\\inname.txt");
                        open.WriteLine(inname.Text + '\t' + innum.Text + '\t' + r);
                        open.Close();
                        Wri();
                        MessageBox.Show("添加成功");
                        clear();
                    }
                }
                else
                {
                    MessageBox.Show("请输入名字");
                }
            }
            else
            {
                MessageBox.Show("数量或单价信息输入不全！");
            }
        }
        /// <summary>
        /// 判断有没有输入单价信息
        /// </summary>
        /// <returns></returns>
        public bool danjia()
        {
            if (outpri.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 出库信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)//----------取出
        {
            StreamReader M = new StreamReader("news\\no.txt");//读取ID
            string a = M.ReadLine();
            M.Close();
            Time();
            if (outname.Text != "")
            {
                if (outnum.Text != "")
                {
                    string[] lines = File.ReadAllLines("news\\inname.txt");//读取总信息
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] line = lines[i].ToString().Split('\t');//读取信息
                        if (line[0] == outname.Text)//找到那一项时
                        {
                            int q1 = int.Parse(line[1]);
                            int q2 = int.Parse(outnum.Text);
                            if ( q1>= q2)//判断库存是否足够取出
                            {
                                StreamWriter dd = new StreamWriter("news\\inname.txt");
                                dd.Write("");
                                dd.Close();
                                string D = int.Parse(line[1]) - int.Parse(outnum.Text) + "";
                                for (int j = 0; j < i; j++)//输入前面的值
                                {
                                    StreamWriter a1 = File.AppendText("news\\inname.txt");
                                    a1.WriteLine(lines[j]);
                                    a1.Close();
                                }
                                for (int x = i + 1; x < lines.Length; x++)//写入后面的值
                                {
                                    StreamWriter a2 = File.AppendText("news\\inname.txt");
                                    a2.WriteLine(lines[x]);
                                    a2.Close();
                                }
                                StreamWriter a3 = File.AppendText("news\\inname.txt");//写入更改的值
                                a3.WriteLine(line[0] + '\t' + D + '\t' + r);
                                a3.Close();
                                StreamWriter a4 = File.AppendText("news\\" + outname.Text + ".txt");//写入详细信息列表
                                a4.WriteLine(a+'\t'+outname.Text + '\t' + outunit.Text +'\t'+outnum.Text+ '\t' + outpri.Text + '\t' + "取" + '\t' + (int.Parse(outnum.Text) * int.Parse(outpri.Text)) +'\t'+r+ '\t' + outws.Text + '\t' + outman.Text + '\t' + outcap.Text);
                                a4.Close();
                                long S = long.Parse(a);
                                S += 1;
                                StreamWriter T = new StreamWriter("news\\no.txt");
                                T.Write(S + "");
                                T.Close();
                                MessageBox.Show("取出成功!");
                                clear();
                            }
                            else
                            {
                                MessageBox.Show("对不起，库存只有" + line[1] + "不足" + outnum.Text);
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("请输入出库的数量");
                }
            }
            else
            {
                MessageBox.Show("请选择出库名称");
            }
        }

        private void manform_Activated(object sender, EventArgs e)
        {
            Shows();
            showname();
        }

        private void button5_Click(object sender, EventArgs e)//基本信息查询
        {
            listView1.Items.Clear();
            StreamReader R = new StreamReader("news\\inname.txt");
            string F = R.ReadLine();
            R.Close();
            if (F != "" && F != null)
            {
                int a = 0;
                string[] H = File.ReadAllLines("news\\inname.txt");
                for (int i = 0; i < H.Length; i++)
                {
                    string[] d = H[i].ToString().Split('\t');
                    if (d[0] == search.Text || d[1] == search.Text)
                    {
                        listView1.Items.Add((a + 1).ToString(), 0);
                        listView1.Items[a].SubItems.Add(d[0]);
                        listView1.Items[a].SubItems.Add(d[1]);
                        listView1.Items[a].SubItems.Add(d[2]);
                        a++;
                    }
                }
            }
            else
            {
                MessageBox.Show("对不起，信息库暂时还没有任何信息");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            detail newform = new detail();
            newform.ShowDialog();
        }
        /// <summary>
        /// -------------------------------------------------计算器---------------------------------
        /// </summary>
        char oper = 'W';//1(加法）2（减法）3（乘法）4（除法）
        double num1 = 0;
        double num2 = 0;
        bool isSencond = false;
        bool isDone = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetBtnFun(Char.Parse(((Button)sender).Text));
        }

        private void manform_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetBtnFun(e.KeyChar);
        }
        private void SetBtnFun(char p)
        {
            if (char.IsDigit(p))
            {
                if (isSencond || isDone)
                {
                    lblResult.Text = "";
                    isDone = false;
                    isSencond = false;
                }
                string s = lblResult.Text + p.ToString();
                s = double.Parse(s).ToString();
                lblResult.Text = s;
            }
            else if (p == '+' || p == '-' || p == '*' || p == '/')
            {
                num1 = double.Parse(lblResult.Text);
                oper = p;
                isSencond = true;
            }
            else if (p == '=')
            {
                num2 = double.Parse(lblResult.Text);

                double result = 0;
                switch (oper)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                }
                lblResult.Text = result.ToString();
                num1 = result;
                isSencond = false;
                isDone = true;
            }
            else if (p == '.')
            {
                if (lblResult.Text.IndexOf(".") == -1)
                {
                    lblResult.Text += ".";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sn R = new sn();
            R.ShowDialog();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "ssk\\" + comboBox1.Text + ".ssk";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IM G = new IM();
            G.ShowDialog();
        }
    }
}
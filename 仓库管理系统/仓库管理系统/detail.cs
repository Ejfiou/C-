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
    public partial class detail : Form
    {
        public detail()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 显示所有信息
        /// </summary>
        public void shows()
        {
            listView1.Items.Clear();
            int R = 0;//变量
            StreamReader r = new StreamReader("news\\inname.txt");
            string A = r.ReadLine();
            r.Close();
            if (A != "" && A != null)//判断是否有信息
            {
                string[] lines = File.ReadAllLines("news\\inname.txt");//读取所有名字
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] line = lines[i].ToString().Split('\t');//读取名字
                    StreamReader all = new StreamReader("news\\" + line[0] + ".txt");//打开相关文本
                    string D = all.ReadLine();
                    all.Close();
                    if (D != "" && D != null)
                    {
                        string[] one = File.ReadAllLines("news\\" + line[0] + ".txt");
                        for (int j = 0; j < one.Length; j++)
                        {
                            string[] cs = one[j].ToString().Split('\t');//读取详细信息
                            listView1.Items.Add((R + 1).ToString(), 0);//编号
                            if (cs[5] == "存")//判断属于哪一类信息
                            {
                                listView1.Items[R].SubItems.Add(cs[1]);//名称
                                listView1.Items[R].SubItems.Add(cs[3]+cs[2]);//数量单位
                                listView1.Items[R].SubItems.Add(cs[4]);//单价
                                listView1.Items[R].SubItems.Add(cs[5]);//存取
                                listView1.Items[R].SubItems.Add(cs[6]);//总额
                                listView1.Items[R].SubItems.Add("");//车间
                                listView1.Items[R].SubItems.Add(cs[7]);//存取时间
                                listView1.Items[R].SubItems.Add(cs[8]);//验收人
                                listView1.Items[R].SubItems.Add("");//领料人
                                listView1.Items[R].SubItems.Add(cs[9]);//说明
                                listView1.Items[R].SubItems.Add(cs[0]);
                                R++;
                            }
                            else
                            {
                                listView1.Items[R].SubItems.Add(cs[1]);//名称
                                listView1.Items[R].SubItems.Add(cs[3]+cs[2]);//数量单位
                                listView1.Items[R].SubItems.Add(cs[4]);//单价
                                listView1.Items[R].SubItems.Add(cs[5]);//存取
                                listView1.Items[R].SubItems.Add(cs[6]);//总额
                                listView1.Items[R].SubItems.Add(cs[8]);//车间
                                listView1.Items[R].SubItems.Add(cs[7]);//存取时间
                                listView1.Items[R].SubItems.Add("");//验收人
                                listView1.Items[R].SubItems.Add(cs[9]);//领料人
                                listView1.Items[R].SubItems.Add(cs[10]);//说明
                                listView1.Items[R].SubItems.Add(cs[0]);
                                R++;
                            }
                        }
                    }
                }
            }
        }
        public bool allname()//判断总目录是否有信息
        {
            StreamReader R = new StreamReader("news\\inname.txt");
            string H = R.ReadLine();
            R.Close();
            if (H != "" && H != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void detail_Activated(object sender, EventArgs e)
        {
            shows();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int G = 0;
            if (allname())
            {
                string[] alllines = File.ReadAllLines("news\\inname.txt");
                for (int i = 0; i < alllines.Length; i++)
                {
                    string[] nam = alllines[i].ToString().Split('\t');
                    StreamReader t = new StreamReader("news\\" + nam[0] + ".txt");
                    string D = t.ReadLine();
                    t.Close();
                    if (D != "" && D != null)//判断文本是否含有信息
                    {
                        string[] pk = File.ReadAllLines("news\\" + nam[0] + ".txt");//打开相关文本
                        for (int x = 0; x < pk.Length; x++)
                        {
                            string[] a = pk[x].ToString().Split('\t');
                            if (a[1] == importan.Text || a[2] == importan.Text || a[8] == importan.Text || a[9] == importan.Text||a[5]==importan.Text||a[6]==importan.Text)//有信息匹配时
                            {
                                listView1.Items.Add((G + 1).ToString(), 0);//编号
                                if (a[5] == "存")//判断属于哪一类信息
                                {
                                    listView1.Items[G].SubItems.Add(a[1]);//名称
                                    listView1.Items[G].SubItems.Add(a[3] + a[2]);//数量单位
                                    listView1.Items[G].SubItems.Add(a[4]);//单价
                                    listView1.Items[G].SubItems.Add(a[5]);//存取
                                    listView1.Items[G].SubItems.Add(a[6]);//总额
                                    listView1.Items[G].SubItems.Add("");//车间
                                    listView1.Items[G].SubItems.Add(a[7]);//存取时间
                                    listView1.Items[G].SubItems.Add(a[8]);//验收人
                                    listView1.Items[G].SubItems.Add("");//领料人
                                    listView1.Items[G].SubItems.Add(a[9]);//说明
                                    listView1.Items[G].SubItems.Add(a[0]);
                                    G++;
                                }
                                else
                                {
                                    listView1.Items[G].SubItems.Add(a[1]);//名称
                                    listView1.Items[G].SubItems.Add(a[3] + a[2]);//数量单位
                                    listView1.Items[G].SubItems.Add(a[4]);//单价
                                    listView1.Items[G].SubItems.Add(a[5]);//存取
                                    listView1.Items[G].SubItems.Add(a[6]);//总额
                                    listView1.Items[G].SubItems.Add(a[8]);//车间
                                    listView1.Items[G].SubItems.Add(a[7]);//存取时间
                                    listView1.Items[G].SubItems.Add("");//验收人
                                    listView1.Items[G].SubItems.Add(a[9]);//领料人
                                    listView1.Items[G].SubItems.Add(a[10]);//说明
                                    listView1.Items[G].SubItems.Add(a[0]);
                                    G++;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("对不起，数据库暂时无信息");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int U = 0;
            if (allname())
            {
                string[] lines = File.ReadAllLines("news\\inname.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] r = lines[i].ToString().Split('\t');
                    StreamReader G = new StreamReader("news\\" + r[0] + ".txt");
                    string Yn = G.ReadLine();
                    G.Close();
                    if (Yn != "")
                    {
                        string[] s = File.ReadAllLines("news\\" + r[0] + ".txt");
                        for (int j = 0; j < s.Length; j++)
                        {
                            string[] k = s[j].ToString().Split('\t');
                            double a = double.Parse(minm.Text);
                            double b = double.Parse(maxm.Text);
                            double c = double.Parse(k[4]);
                            if (c >= a && c <= b)
                            {
                                listView1.Items.Add((U + 1).ToString(), 0);//编号
                                if (k[5] == "存")//判断属于哪一类信息
                                {
                                    listView1.Items[U].SubItems.Add(k[1]);//名称
                                    listView1.Items[U].SubItems.Add(k[3] + k[2]);//数量单位
                                    listView1.Items[U].SubItems.Add(k[4]);//单价
                                    listView1.Items[U].SubItems.Add(k[5]);//存取
                                    listView1.Items[U].SubItems.Add(k[6]);//总额
                                    listView1.Items[U].SubItems.Add("");//车间
                                    listView1.Items[U].SubItems.Add(k[7]);//存取时间
                                    listView1.Items[U].SubItems.Add(k[8]);//验收人
                                    listView1.Items[U].SubItems.Add("");//领料人
                                    listView1.Items[U].SubItems.Add(k[9]);//说明
                                    listView1.Items[U].SubItems.Add(k[0]);
                                    U++;
                                }
                                else
                                {
                                    listView1.Items[U].SubItems.Add(k[1]);//名称
                                    listView1.Items[U].SubItems.Add(k[3] + k[2]);//数量单位
                                    listView1.Items[U].SubItems.Add(k[4]);//单价
                                    listView1.Items[U].SubItems.Add(k[5]);//存取
                                    listView1.Items[U].SubItems.Add(k[6]);//总额
                                    listView1.Items[U].SubItems.Add(k[8]);//车间
                                    listView1.Items[U].SubItems.Add(k[7]);//存取时间
                                    listView1.Items[U].SubItems.Add("");//验收人
                                    listView1.Items[U].SubItems.Add(k[9]);//领料人
                                    listView1.Items[U].SubItems.Add(k[10]);//说明
                                    listView1.Items[U].SubItems.Add(k[0]);
                                    U++;
                                }
                            }
                        }
                    }
                }
            }
            else
            {

                MessageBox.Show("对不起，数据库暂时无信息");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int U = 0;
            if (allname())
            {
                string[] lines = File.ReadAllLines("news\\inname.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] r = lines[i].ToString().Split('\t');
                    StreamReader G = new StreamReader("news\\" + r[0] + ".txt");
                    string Yn = G.ReadLine();
                    G.Close();
                    if (Yn != "")
                    {
                        string[] s = File.ReadAllLines("news\\" + r[0] + ".txt");
                        for (int j = 0; j < s.Length; j++)
                        {
                            string[] k = s[j].ToString().Split('\t');
                            int a = int.Parse(k[4]);
                            int b = int.Parse(minnum.Text);
                            int c = int.Parse(maxnum.Text);
                            if (a>=b&&a<=c)
                            {
                                listView1.Items.Add((U + 1).ToString(), 0);//编号
                                if (k[5] == "存")//判断属于哪一类信息
                                {
                                    listView1.Items[U].SubItems.Add(k[1]);//名称
                                    listView1.Items[U].SubItems.Add(k[3] + k[2]);//数量单位
                                    listView1.Items[U].SubItems.Add(k[4]);//单价
                                    listView1.Items[U].SubItems.Add(k[5]);//存取
                                    listView1.Items[U].SubItems.Add(k[6]);//总额
                                    listView1.Items[U].SubItems.Add("");//车间
                                    listView1.Items[U].SubItems.Add(k[7]);//存取时间
                                    listView1.Items[U].SubItems.Add(k[8]);//验收人
                                    listView1.Items[U].SubItems.Add("");//领料人
                                    listView1.Items[U].SubItems.Add(k[9]);//说明
                                    listView1.Items[U].SubItems.Add(k[0]);
                                    U++;
                                }
                                else
                                {
                                    listView1.Items[U].SubItems.Add(k[1]);//名称
                                    listView1.Items[U].SubItems.Add(k[3] + k[2]);//数量单位
                                    listView1.Items[U].SubItems.Add(k[4]);//单价
                                    listView1.Items[U].SubItems.Add(k[5]);//存取
                                    listView1.Items[U].SubItems.Add(k[6]);//总额
                                    listView1.Items[U].SubItems.Add(k[8]);//车间
                                    listView1.Items[U].SubItems.Add(k[7]);//存取时间
                                    listView1.Items[U].SubItems.Add("");//验收人
                                    listView1.Items[U].SubItems.Add(k[9]);//领料人
                                    listView1.Items[U].SubItems.Add(k[10]);//说明
                                    listView1.Items[U].SubItems.Add(k[0]);
                                    U++;
                                }
                            }
                        }
                    }
                }
            }
            else
            {

                MessageBox.Show("对不起，数据库暂时无信息");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int U = 0;
            if (allname())
            {
                string[] lines = File.ReadAllLines("news\\inname.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] r = lines[i].ToString().Split('\t');
                    StreamReader G = new StreamReader("news\\" + r[0] + ".txt");
                    string Yn = G.ReadLine();
                    G.Close();
                    if (Yn != "")
                    {
                        string[] s = File.ReadAllLines("news\\" + r[0] + ".txt");
                        for (int j = 0; j < s.Length; j++)
                        {
                            string[] k = s[j].ToString().Split('\t');
                            string[] tim = k[7].ToString().Split('-');
                            int t1 = int.Parse(tim[0]);//年
                            int t2 = int.Parse(tim[1]);//月
                            int t3 = int.Parse(tim[2]);//日
                            string[] st1 = st.Text.Split('-');
                            int s1 = int.Parse(st1[0]);
                            int s2 = int.Parse(st1[1]);
                            int s3 = int.Parse(st1[2]);
                            string[] st2 = et.Text.Split('-');
                            int e1 = int.Parse(st2[0]);
                            int e2 = int.Parse(st2[1]);
                            int e3 = int.Parse(st2[2]);
                            if (t1>s1&&t1<e1)
                            {
                                listView1.Items.Add((U + 1).ToString(), 0);//编号
                                if (k[5] == "存")//判断属于哪一类信息
                                {
                                    listView1.Items[U].SubItems.Add(k[1]);//名称
                                    listView1.Items[U].SubItems.Add(k[3] + k[2]);//数量单位
                                    listView1.Items[U].SubItems.Add(k[4]);//单价
                                    listView1.Items[U].SubItems.Add(k[5]);//存取
                                    listView1.Items[U].SubItems.Add(k[6]);//总额
                                    listView1.Items[U].SubItems.Add("");//车间
                                    listView1.Items[U].SubItems.Add(k[7]);//存取时间
                                    listView1.Items[U].SubItems.Add(k[8]);//验收人
                                    listView1.Items[U].SubItems.Add("");//领料人
                                    listView1.Items[U].SubItems.Add(k[9]);//说明
                                    listView1.Items[U].SubItems.Add(k[0]);
                                    U++;
                                }
                                else
                                {
                                    listView1.Items[U].SubItems.Add(k[1]);//名称
                                    listView1.Items[U].SubItems.Add(k[3] + k[2]);//数量单位
                                    listView1.Items[U].SubItems.Add(k[4]);//单价
                                    listView1.Items[U].SubItems.Add(k[5]);//存取
                                    listView1.Items[U].SubItems.Add(k[6]);//总额
                                    listView1.Items[U].SubItems.Add(k[8]);//车间
                                    listView1.Items[U].SubItems.Add(k[7]);//存取时间
                                    listView1.Items[U].SubItems.Add("");//验收人
                                    listView1.Items[U].SubItems.Add(k[9]);//领料人
                                    listView1.Items[U].SubItems.Add(k[10]);//说明
                                    listView1.Items[U].SubItems.Add(k[0]);
                                    U++;
                                }
                            }
                            else if ((t1 == s1 && t2 > s2 && t2 < e2) || (t1 == e1 && t2 > s2 && t2 < e2))
                            {
                                listView1.Items.Add((U + 1).ToString(), 0);//编号
                                if (k[5] == "存")//判断属于哪一类信息
                                {
                                    listView1.Items[U].SubItems.Add(k[1]);//名称
                                    listView1.Items[U].SubItems.Add(k[3] + k[2]);//数量单位
                                    listView1.Items[U].SubItems.Add(k[4]);//单价
                                    listView1.Items[U].SubItems.Add(k[5]);//存取
                                    listView1.Items[U].SubItems.Add(k[6]);//总额
                                    listView1.Items[U].SubItems.Add("");//车间
                                    listView1.Items[U].SubItems.Add(k[7]);//存取时间
                                    listView1.Items[U].SubItems.Add(k[8]);//验收人
                                    listView1.Items[U].SubItems.Add("");//领料人
                                    listView1.Items[U].SubItems.Add(k[9]);//说明
                                    listView1.Items[U].SubItems.Add(k[0]);
                                    U++;
                                }
                                else
                                {
                                    listView1.Items[U].SubItems.Add(k[1]);//名称
                                    listView1.Items[U].SubItems.Add(k[3] + k[2]);//数量单位
                                    listView1.Items[U].SubItems.Add(k[4]);//单价
                                    listView1.Items[U].SubItems.Add(k[5]);//存取
                                    listView1.Items[U].SubItems.Add(k[6]);//总额
                                    listView1.Items[U].SubItems.Add(k[8]);//车间
                                    listView1.Items[U].SubItems.Add(k[7]);//存取时间
                                    listView1.Items[U].SubItems.Add("");//验收人
                                    listView1.Items[U].SubItems.Add(k[9]);//领料人
                                    listView1.Items[U].SubItems.Add(k[10]);//说明
                                    listView1.Items[U].SubItems.Add(k[0]);
                                    U++;
                                }
                            }
                            else if ((t1 == s1 && t2 == s2 && t3 >= s3 && t3 <= e3) || (t1 == s1 && t2 == e2 && t3 >= s3 && t3 <= e3) || (t1 == e1 && t2 == e2 && t3 >= s3 && t3 <= e3) || (t1 == e1 && t2 == s2 && t3 >= s3 && t3 <= e3))
                            {
                                listView1.Items.Add((U + 1).ToString(), 0);//编号
                                if (k[5] == "存")//判断属于哪一类信息
                                {
                                    listView1.Items[U].SubItems.Add(k[1]);//名称
                                    listView1.Items[U].SubItems.Add(k[3] + k[2]);//数量单位
                                    listView1.Items[U].SubItems.Add(k[4]);//单价
                                    listView1.Items[U].SubItems.Add(k[5]);//存取
                                    listView1.Items[U].SubItems.Add(k[6]);//总额
                                    listView1.Items[U].SubItems.Add("");//车间
                                    listView1.Items[U].SubItems.Add(k[7]);//存取时间
                                    listView1.Items[U].SubItems.Add(k[8]);//验收人
                                    listView1.Items[U].SubItems.Add("");//领料人
                                    listView1.Items[U].SubItems.Add(k[9]);//说明
                                    listView1.Items[U].SubItems.Add(k[0]);
                                    U++;
                                }
                                else
                                {
                                    listView1.Items[U].SubItems.Add(k[1]);//名称
                                    listView1.Items[U].SubItems.Add(k[3] + k[2]);//数量单位
                                    listView1.Items[U].SubItems.Add(k[4]);//单价
                                    listView1.Items[U].SubItems.Add(k[5]);//存取
                                    listView1.Items[U].SubItems.Add(k[6]);//总额
                                    listView1.Items[U].SubItems.Add(k[8]);//车间
                                    listView1.Items[U].SubItems.Add(k[7]);//存取时间
                                    listView1.Items[U].SubItems.Add("");//验收人
                                    listView1.Items[U].SubItems.Add(k[9]);//领料人
                                    listView1.Items[U].SubItems.Add(k[10]);//说明
                                    listView1.Items[U].SubItems.Add(k[0]);
                                    U++;
                                }
                            }
                        }
                    }
                }
            }
            else
            {

                MessageBox.Show("对不起，数据库暂时无信息");
            }
        }
        public void All()
        {
            man.Enabled = true;
            num.Enabled = true;
            one.Enabled = true;
            YN.Enabled = true;
            all.Enabled = true;
            car.Enabled = true;
            timer.Enabled = true;
            inman.Enabled = true;
            outman.Enabled = true;
            why.Enabled = true;
        }
        public void allclear()
        {
            man.Text = "";
            num.Text = "";
            one.Text = "";
            YN.Text = "";
            all.Text = "";
            car.Text = "";
            timer.Text = "";
            inman.Text = "";
            outman.Text = "";
            why.Text = "";
            ID.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            allclear();
            All();
            int X = listView1.Items.Count;
            if (int.Parse(no.Text) > 0 && int.Parse(no.Text) <= X)
            {
                int V=int.Parse(no.Text);
                string H = listView1.Items[V - 1].SubItems[4].Text;//获取判断此项是属于存项还是取向
                if (H == "存")
                {
                    man.Text = listView1.Items[V - 1].SubItems[1].Text;
                    num.Text = listView1.Items[V - 1].SubItems[2].Text;
                    one.Text = listView1.Items[V - 1].SubItems[3].Text;
                    YN.Text  = listView1.Items[V - 1].SubItems[4].Text;
                    all.Text = listView1.Items[V - 1].SubItems[5].Text;
                    timer.Text = listView1.Items[V - 1].SubItems[7].Text;
                    inman.Text = listView1.Items[V - 1].SubItems[8].Text;
                    why.Text = listView1.Items[V - 1].SubItems[10].Text;
                    car.Enabled = false;
                    outman.Enabled = false;
                    ID.Text = listView1.Items[V - 1].SubItems[11].Text;
                }
                else
                {
                    man.Text = listView1.Items[V - 1].SubItems[1].Text;
                    num.Text = listView1.Items[V - 1].SubItems[2].Text;
                    one.Text = listView1.Items[V - 1].SubItems[3].Text;
                    YN.Text = listView1.Items[V - 1].SubItems[4].Text;
                    all.Text = listView1.Items[V - 1].SubItems[5].Text;
                    car.Text = listView1.Items[V - 1].SubItems[6].Text;
                    timer.Text = listView1.Items[V - 1].SubItems[7].Text;
                    outman.Text = listView1.Items[V - 1].SubItems[9].Text;
                    why.Text = listView1.Items[V - 1].SubItems[10].Text;
                    inman.Enabled = false;
                    ID.Text = listView1.Items[V - 1].SubItems[11].Text;
                }
            }
            else
            {
                MessageBox.Show("对不起！你要查找的编号超出了范围");
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                string str1 = listView1.SelectedItems[0].Text;//获取编号
                DialogResult G = MessageBox.Show("是否删除此条信息？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (G.ToString() == "OK")
                {
                 
                    int a = int.Parse(str1);
                    string Sname = listView1.Items[a-1].SubItems[1].Text;//获取名字
                    string dID = listView1.Items[a-1].SubItems[11].Text;//获取要删除的ID号
                    string[] lines = File.ReadAllLines("news\\" + Sname + ".txt");
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] R = lines[i].ToString().Split('\t');//读取ID
                        if (dID == R[0])//找到此路径
                        {
                            StreamWriter nes = new StreamWriter("news\\" + Sname + ".txt");
                            nes.Write("");
                            nes.Close();
                            for (int j = 0; j < i; j++)//写前面
                            {
                                StreamWriter S1 = File.AppendText("news\\" + Sname + ".txt");
                                S1.WriteLine(lines[j]);
                                S1.Close();
                            }
                            for (int x = i + 1;x<lines.Length ; x++)//写后面
                            {
                                StreamWriter S2 = File.AppendText("news\\" + Sname + ".txt");
                                S2.WriteLine(lines[x]);
                                S2.Close();
                            }
                            MessageBox.Show("删除成功！");
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("news\\" + man.Text + ".txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] s1 = lines[i].ToString().Split('\t');
                if (ID.Text == s1[0])//找到要修改的项时
                {
                    StreamWriter cle=new StreamWriter("news\\" + man.Text + ".txt");
                    cle.Write("");
                    cle.Close();
                    for (int a1 = 0; a1 < i; a1++)// 重写前面的值
                    {
                        StreamWriter F1 = File.AppendText("news\\" + man.Text + ".txt");
                        F1.WriteLine(lines[a1]);
                        F1.Close();
                    }
                    for(int a2=i+1;a2<lines.Length;a2++)//重写后面的值
                    {
                        StreamWriter F2 = File.AppendText("news\\" + man.Text + ".txt");
                        F2.WriteLine(lines[a2]);
                        F2.Close();
                    }
                    if (s1[5] == "存")
                    {
                        StreamWriter news = File.AppendText("news\\" + man.Text + ".txt");
                        news.WriteLine(ID.Text + '\t' + man.Text + '\t' + s1[2] + '\t' + num.Text + '\t' + one.Text + '\t' + YN.Text + '\t' + all.Text + '\t' + timer.Text + '\t' + inman.Text + '\t' + why.Text);
                        news.Close();
                        MessageBox.Show("修改成功！");
                    }
                    else
                    {
                        StreamWriter news = File.AppendText("news\\" + man.Text + ".txt");
                        news.WriteLine(ID.Text + '\t' + man.Text + '\t' + s1[2] + '\t' + num.Text + '\t' + one.Text + '\t' + YN.Text + '\t' + all.Text + '\t' + timer.Text + '\t' + car.Text + '\t' + outman.Text + '\t' + why.Text);
                        news.Close();
                        MessageBox.Show("修改成功！");
                    }
                }
            }
        }
        /// <summary>
        /// 合并方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public void an()
        {
             int G = 0;
            int X = listView1.Items.Count;//读取数目
            string[] ID = new string[X];
            for (int K = 0; K < X; K++)
            {
                ID[K] = listView1.Items[K].SubItems[11].Text;//获取ID
            }
            string[] R = File.ReadAllLines("news\\inname.txt");
            listView1.Items.Clear();
            for (int i = 0; i < R.Length; i++)
            {
                string[] S = R[i].ToString().Split('\t');
                string[] Glines = File.ReadAllLines("news\\" + S[0] + ".txt");//打开所有文本
                for (int j = 0; j < Glines.Length; j++)
                {
                    string[] a = Glines[j].ToString().Split('\t');//读取ID
                    for (int V = 0; V < ID.Length; V++)//对比ID
                    {
                        if (a[0] == ID[V])//ID相同
                        {
                             if (a[1] == importan.Text || a[2] == importan.Text || a[8] == importan.Text || a[9] == importan.Text||a[5]==importan.Text||a[6]==importan.Text)//有信息匹配时
                            {
                                listView1.Items.Add((G + 1).ToString(), 0);//编号
                                if (a[5] == "存")//判断属于哪一类信息
                                {
                                    listView1.Items[G].SubItems.Add(a[1]);//名称
                                    listView1.Items[G].SubItems.Add(a[3] + a[2]);//数量单位
                                    listView1.Items[G].SubItems.Add(a[4]);//单价
                                    listView1.Items[G].SubItems.Add(a[5]);//存取
                                    listView1.Items[G].SubItems.Add(a[6]);//总额
                                    listView1.Items[G].SubItems.Add("");//车间
                                    listView1.Items[G].SubItems.Add(a[7]);//存取时间
                                    listView1.Items[G].SubItems.Add(a[8]);//验收人
                                    listView1.Items[G].SubItems.Add("");//领料人
                                    listView1.Items[G].SubItems.Add(a[9]);//说明
                                    listView1.Items[G].SubItems.Add(a[0]);
                                    G++;
                                }
                                else
                                {
                                    listView1.Items[G].SubItems.Add(a[1]);//名称
                                    listView1.Items[G].SubItems.Add(a[3] + a[2]);//数量单位
                                    listView1.Items[G].SubItems.Add(a[4]);//单价
                                    listView1.Items[G].SubItems.Add(a[5]);//存取
                                    listView1.Items[G].SubItems.Add(a[6]);//总额
                                    listView1.Items[G].SubItems.Add(a[8]);//车间
                                    listView1.Items[G].SubItems.Add(a[7]);//存取时间
                                    listView1.Items[G].SubItems.Add("");//验收人
                                    listView1.Items[G].SubItems.Add(a[9]);//领料人
                                    listView1.Items[G].SubItems.Add(a[10]);//说明
                                    listView1.Items[G].SubItems.Add(a[0]);
                                    G++;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            an();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            an();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            an();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            shows();
        }
    }
}
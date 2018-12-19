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
    public partial class sn : Form
    {
        public sn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (s2.Text == s3.Text)
            {
                StreamWriter F = new StreamWriter("pass.txt");
                F.Write(s1.Text + '\t' + s2.Text);
                F.Close();
                StreamWriter T = new StreamWriter("wrong.txt");
                T.WriteLine(s4);
                T.Close();
                MessageBox.Show("密码修改成功!");
                sn.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("两次密码不一致");
                s2.Text = "";
                s3.Text = "";
            }
        }
    }
}
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
    public partial class IM : Form
    {
        public IM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter T = new StreamWriter("key.txt");
            T.WriteLine(s1.Text + '\t' + s2.Text + '\t' + s3.Text + '\t' + s4.Text);
            T.Close();
            MessageBox.Show("修改成功！");
            IM.ActiveForm.Close();
        }
    }
}
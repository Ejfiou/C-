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
    public partial class mine : Form
    {
        public mine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] y = File.ReadAllLines("key.txt");
            string[] F = y[0].ToString().Split('\t');
            if (s1.Text == F[0] && s2.Text == F[1] && s3.Text == F[2] && s4.Text == F[3])
            {
                string[] S=File.ReadAllLines("pass.txt");
                string[] a=S[0].ToString().Split('\t');
                textBox1.Text = a[1];
                StreamWriter J = new StreamWriter("wrong.txt");
                J.Write("3");
                J.Close();
            }
            else
            {
                Form.ActiveForm.Close();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_02_24
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string value)
        {
            InitializeComponent();
            this.value = value;
        }

        public Form2(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private string value;

        private Form1 parentForm;
        private void Form2_Load(object sender, EventArgs e)
        {
            this.txtTest.Text = value;
        }

        private void btnSendFather_Click(object sender, EventArgs e)
        {
            parentForm.txtTest.Text = this.txtTest.Text;
            this.Close();
        }
    }
}

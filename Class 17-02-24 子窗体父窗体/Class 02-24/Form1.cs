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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 frm = null;
        
        private void btnForm_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (frm == null)
                {
                    frm = new Form2();
                }
                frm.Show();

            }
            catch (Exception)
            {
                frm = null;
                frm = new Form2();
                frm.Show();
            }
            
            
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (frm != null)
            {
                frm.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (frm != null)
            {
                frm.Close();
            }
            frm = null;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2(this.txtTest.Text);
            fr.Show();
        }

        private void btnCroller_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.Show();
        }
    }
}

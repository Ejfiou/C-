using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork04_02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsert f = new FrmInsert();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void 出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOut f = new FrmOut();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void 查询商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSelect f = new FrmSelect();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}

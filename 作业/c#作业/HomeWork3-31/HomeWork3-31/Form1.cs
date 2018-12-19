using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork3_31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 增加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FemInsert f = new HomeWork3_31.FemInsert();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void 修改学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdate f = new FrmUpdate();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void 删除学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDelete f = new FrmDelete();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void 查询所有学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSelect f = new FrmSelect();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}

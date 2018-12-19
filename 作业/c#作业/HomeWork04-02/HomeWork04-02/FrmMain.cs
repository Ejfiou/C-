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

        public FrmMain(FrmAdmin f1)
        {
            InitializeComponent();
            this.f1 = f1;

        }

        private FrmAdmin f1;

        private bool ShowChildrenForm(string childFormName)
        {
            //检测当前窗体的子窗体
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                //判断当前子窗体的Name属性值是否与传入的子窗体的Name属性相同
                if (this.MdiChildren[i].Name == childFormName)
                {
                    //如果值相同则表示此子窗体为想要调用的子窗体，激活此子窗体并返回true值
                    this.MdiChildren[i].Activate();
                    return true;
                }
            }
            //如果没有相同的值则表示要调用的子窗体还没有被打开，返回false值
            return false;
        }

        private void tsmiInsert_Click(object sender, EventArgs e)
        {
            if (!ShowChildrenForm("FrmInsert"))
            {
                FrmInsert frm = new FrmInsert();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tsmiOut_Click(object sender, EventArgs e)
        {
            if (!ShowChildrenForm("FrmOut"))
            {
                FrmOut frm = new FrmOut();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            if (!ShowChildrenForm("FrmSelect"))
            {
                FrmSelect frm = new FrmSelect();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tsmiLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

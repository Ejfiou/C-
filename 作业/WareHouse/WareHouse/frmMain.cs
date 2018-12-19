using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary1;

namespace WareHouse
{
    public partial class frmMain : FrmObject
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(frmLogin fl)
        {
            this.fl1 = fl;
            InitializeComponent();
        }

        
        private frmLogin fl1;

        private IDAO dao = new WareHouseDAO();
        private DataBase db = new DataBase();

        /// <summary>
        /// 点击注销按钮时,显示登录窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            this.Hide();
            fl1.Show();

        }

        /// <summary>
        /// 防止打开多个子窗口
        /// </summary>
        /// <param name="childForm">子窗体的Name</param>
        /// <returns></returns>
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

        /// <summary>
        /// 点击入库时，将listview中选中项物品名传入增加窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //选中项中的名称
            //string s =null;
            ////选中项中的单位
            //string unit = null;
            //foreach (ListViewItem item in this.listView1.Items)
            //{
            //    if (item.Selected)
            //    {
            //        s = item.SubItems[1].Text;
            //        unit = item.SubItems[3].Text;
            //    }
            //}

            

            if (!ShowChildrenForm("frmInput"))
            {
                frmInput frm = new frmInput();
                frm.MdiParent = this;
                frm.Show();
            }            
        }

        /// <summary>
        /// 将商品信息添加到Listview
        /// </summary>
        private void IShow()
        {

            //listView1.Items.Clear();
            //this.listView1.BeginUpdate();
            //IMyObject[] obj = dao.SelectAll();
            
            //if (obj != null)
            //{
            //    for (int i = 0; i < obj.Length; i++)
            //    {
            //        ListViewItem lvi = new ListViewItem();

            //        lvi.Text = (i + 1).ToString();

            //        lvi.SubItems.Add(obj[i].PrimaryKey);

            //        lvi.SubItems.Add(obj[i].FoodsNum.ToString());

            //        lvi.SubItems.Add(obj[i].Unit);

            //        listView1.Items.Add(lvi);
            //    }
            //}
            //else
            //{
                
            //}
            //this.listView1.EndUpdate();
        }

        /// <summary>
        /// 窗体激活时刷新listview的显示
        /// </summary>
        /// <param name="senFder"></param>
        /// <param name="e"></param>
        private void frmMain_Activated(object senFder, EventArgs e)
        {
            IShow();
        }

        /// <summary>
        /// 显示出库的窗口,并将listview选中的名称传入出库的窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //选中项的名称
            //string s = null;
          
            //foreach (ListViewItem item in this.listView1.Items)
            //{
            //    //有选中的就传名称
            //    if (item.Selected)
            //    {
            //        s = item.SubItems[1].Text;
                    
            //    }
            //}

            

            if (!ShowChildrenForm("frmOut"))
            {
                frmOut o = new frmOut();
                o.MdiParent = this;
                o.Show();
            }
        }

        /// <summary>
        /// 显示查询物品的窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void 所有信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
  
            if (!ShowChildrenForm("frmSearch"))
            {
                //frmSearch f = new frmSearch();
                frmSearchTreeView f = new frmSearchTreeView();
                f.MdiParent = this;
                f.Show();
            }
        }

        /// <summary>
        /// 显示显示物品的窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 显示所有物品信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //listView1.Visible = true;
        }

        /// <summary>
        /// 点击窗口的 X 时程序全部退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void tsmiView_Click(object sender, EventArgs e)
        {
            if (!ShowChildrenForm("frmShowAll"))
            {
                frmShowAll fr = new frmShowAll();

                
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void tsmiTree_Click(object sender, EventArgs e)
        {
            if (!ShowChildrenForm("frmShowAllTreeView"))
            {
                frmShowAllTreeView fr = new frmShowAllTreeView();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void tsmiList_Click(object sender, EventArgs e)
        {
            if (!ShowChildrenForm("frmShowAllListBox"))
            {
                frmShowAllListBox fr = new frmShowAllListBox();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}

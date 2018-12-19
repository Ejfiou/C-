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
    public partial class frmShowAll : FrmObject
    {
        public frmShowAll()
        {
            InitializeComponent();
        }
        private IDAO  dao= new WareHouseDAO();

        /// <summary>
        /// 将商品信息添加到Listview
        /// </summary>
        private void IShow()
        {

            listView1.Items.Clear();
            this.listView1.BeginUpdate();
            IMyObject[] obj = dao.SelectAll();

            //存在物品
            if (obj != null)
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    ListViewItem lvi = new ListViewItem();

                    lvi.Text = (i + 1).ToString();

                    lvi.SubItems.Add(obj[i].PrimaryKey);

                    lvi.SubItems.Add(obj[i].FoodsNum.ToString());

                    lvi.SubItems.Add(obj[i].Unit);

                    listView1.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("对不起！当前没有任何货物信息！", "提示", MessageBoxButtons.OK);
                this.Close();
            }
            this.listView1.EndUpdate();
        }

       
        /// <summary>
        /// 窗体加载时显示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmShowAll_Load(object sender, EventArgs e)
        {
            IShow();
        }

        private void frmShowAll_MouseEnter(object sender, EventArgs e)
        {
            IShow();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IShow();
        }
    }
}

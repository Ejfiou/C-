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
    public partial class frmShowAllListBox : FrmObject
    {
        public frmShowAllListBox()
        {
            InitializeComponent();
        }

        private IDAO dao = new WareHouseDAO();

        private void frmShowAllListBox_Load(object sender, EventArgs e)
        {
            IShow();
        }

        private void IShow()
        {
            lstShow.Items.Clear();
            IMyObject[] obj = dao.SelectAll();

            //存在物品
            if (obj != null)
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    lstShow.Items.Add($"名称：{obj[i].PrimaryKey,-10} 数量：{obj[i].FoodsNum.ToString(),-8}单位：{obj[i].Unit} ");
                }
            }
            else
            {
                MessageBox.Show("对不起！当前没有任何货物信息！", "提示", MessageBoxButtons.OK);
                this.Close();
            }

        }

        private void frmShowAllListBox_MouseEnter(object sender, EventArgs e)
        {
            IShow();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IShow();
        }
    }
}

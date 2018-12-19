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
    public partial class frmShowAllTreeView : FrmObject
    {
        public frmShowAllTreeView()
        {
            InitializeComponent();
        }

        private IDAO dao = new WareHouseDAO();

        private void frmShowAllTreeView_Load(object sender, EventArgs e)
        {
            IShow();
        }

        private void IShow()
        {
            tvwShow.Nodes.Clear();

            IMyObject[] obj = dao.SelectAll();

            //存在物品
            if (obj != null)
            {
                for (int i = 0; i < obj.Length; i++)
                {

                    TreeNode node = new TreeNode(obj[i].PrimaryKey);

                    TreeNode nodeNum = new TreeNode("数量："+obj[i].FoodsNum.ToString());

                    TreeNode nodeUnit = new TreeNode("单位："+obj[i].Unit);


                    node.Nodes.Add(nodeNum);
                    node.Nodes.Add(nodeUnit);
                    tvwShow.Nodes.Add(node);
                }
            }
            else
            {
                MessageBox.Show("对不起！当前没有任何货物信息！", "提示", MessageBoxButtons.OK);
                this.Close();
            }
           
        }

        private void frmShowAllTreeView_MouseEnter(object sender, EventArgs e)
        {
            IShow();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IShow();
        }
    }
}

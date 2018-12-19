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
    public partial class frmSearchTreeView : FrmObject
    {
        public frmSearchTreeView()
        {
            InitializeComponent();
        }

        private IDAO dao = new WareHouseDAO();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchName.Text;
            if (!string.IsNullOrWhiteSpace(name))
            {
                IMyObject[] temp = dao.SelectByFoodsName(name);

                tvwSearch.Nodes.Clear();
                

                if (temp != null)
                {
                    for (int i = 0; i < temp.Length; i++)
                    {
                        TreeNode node = new TreeNode(temp[i].PrimaryKey);
                        TreeNode nodeNum = new TreeNode("数量：" + temp[i].FoodsNum.ToString());
                        TreeNode nodeUnit = new TreeNode("单位：" + temp[i].Unit);

                        node.Nodes.Add(nodeNum);
                        node.Nodes.Add(nodeUnit);
                        tvwSearch.Nodes.Add(node);
                    }
                }
                else
                {
                    MessageBox.Show("当前仓库无此货物");
                }
                
            }
        }
    }
}

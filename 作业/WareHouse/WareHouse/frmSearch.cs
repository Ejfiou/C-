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
    public partial class frmSearch : FrmObject
    {
        public frmSearch()
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

                listView1.Items.Clear();
                this.listView1.BeginUpdate();

                if (temp != null)
                {
                    for (int i = 0; i < temp.Length; i++)
                    {
                        ListViewItem lvi = new ListViewItem();

                        lvi.Text = (i + 1).ToString();

                        lvi.SubItems.Add(temp[i].PrimaryKey);

                        lvi.SubItems.Add(temp[i].FoodsNum.ToString());

                        lvi.SubItems.Add(temp[i].Unit);

                        listView1.Items.Add(lvi);
                    }
                }
                else
                {
                    MessageBox.Show("当前仓库无此货物");
                }
                this.listView1.EndUpdate();
            }
        }
    }
}

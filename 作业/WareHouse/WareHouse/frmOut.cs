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
using System.Text.RegularExpressions;
namespace WareHouse
{
    public partial class frmOut : FrmObject
    {
        public frmOut()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 构造函数传入listview选中的名称
        /// </summary>
        /// <param name="value"></param>
        public frmOut(string value)
        {
            InitializeComponent();
            this.value = value;
        }

        //主窗口listview选中的名称
        private string value = null;

        private IDAO dao = new WareHouseDAO();

        /// <summary>
        /// 点击出库时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOut_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            int s = -1;
            double p=-1;
            if (string.IsNullOrWhiteSpace(cmbFoodsName.Text))
            {
                this.errorProvider1.SetError(cmbFoodsName, "不能为空");
                MessageBox.Show("请输入物品名", "提示", MessageBoxButtons.OK);
                cmbFoodsName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtFoodsNum.Text))
            {
                this.errorProvider1.SetError(txtFoodsNum, "不能为空");
                MessageBox.Show("请输入出库数量", "提示", MessageBoxButtons.OK);
                txtFoodsNum.Focus();
            }
            else
            {
                string name = this.cmbFoodsName.Text;
                string num = this.txtFoodsNum.Text;

                if (!Regex.IsMatch(num, @"^(([1-9]|[1-9][0-9]+)(.([0]+))?)$"))
                {
                    this.errorProvider1.SetError(txtFoodsNum, "不能为零,小数,或者字符");
                    MessageBox.Show("数量不能为零,小数,或者字符", "提示", MessageBoxButtons.OK);
                    txtFoodsNum.Focus();
                }
                else
                {
                    WareHouse w = new WareHouse(name,double.Parse( num), null);

                    s = dao.Out(w, out p);
                }

                //判断是否能正常出库
                if (s == 1) 
                {
                    MessageBox.Show("出库成功", "提示", MessageBoxButtons.OK);
                    this.Close();
                }
                else if (s == 2)
                {
                    MessageBox.Show($"库存不足,当前库存为{p}", "提示", MessageBoxButtons.OK);
                }
                else if (s == 3)
                {
                    MessageBox.Show("无此货物，出库失败", "提示", MessageBoxButtons.OK);
                }
                else if(s != -1)
                {
                    MessageBox.Show("货物全部出库，出库成功！", "提示", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        /// <summary>
        /// 窗口加载时，将物品增加到comboBox下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOut_Load(object sender, EventArgs e)
        {
            IMyObject[] obj = dao.SelectAll();
            if (obj != null)
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    this.cmbFoodsName.Items.Add(obj[i].PrimaryKey);
                }
            }

            //自动选择名字
            if (value!=null)
            {
                cmbFoodsName.SelectedItem = value;
            }

    }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

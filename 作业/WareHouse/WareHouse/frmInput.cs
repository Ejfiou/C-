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
    public partial class frmInput : FrmObject
    {
        public frmInput()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// 构造函数传入单位名称
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unit"></param>
        public frmInput(string value,string unit)
        {
            InitializeComponent();
            this.value = value;
            this.unit = unit;

        }
        
        //主窗口listview选中的名称
        private string value=null;

        //主窗口listview选中的单位
        private string unit = null;
         
        private IDAO dao = new WareHouseDAO();
        private DataBase db = new DataBase();

         /// <summary>
         /// 点击添加时
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void btnAddFoods_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtFoodsNum.Text))
            {
                this.errorProvider1.SetError(cboFoodsName, "不能为空");
                MessageBox.Show("请输入物品名","提示",MessageBoxButtons.OK);
                cboFoodsName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtFoodsNum.Text))
            {
                this.errorProvider1.SetError(txtFoodsNum, "不能为空");
                MessageBox.Show("请输入物品数量", "提示", MessageBoxButtons.OK);
                txtFoodsNum.Focus();
            }
            else if (txtFoodsUnit.Enabled == true&& string.IsNullOrWhiteSpace(txtFoodsUnit.Text))
            {
                this.errorProvider1.SetError(txtFoodsUnit, "不能为空");
                MessageBox.Show("请输入物品单位", "提示", MessageBoxButtons.OK);
                txtFoodsUnit.Focus();
            }
            else
            {
                this.cboFoodsName.Focus();
                string name = this.cboFoodsName.Text;
                string  num = this.txtFoodsNum.Text;
                string unit = this.txtFoodsUnit.Text;

                if (!Regex.IsMatch(num, @"^(([1-9]|[1-9][0-9]+)(.([0]+))?)$"))
                {
                    this.errorProvider1.SetError(txtFoodsNum, "数量不能为零,小数,或者字符");
                    MessageBox.Show("数量不能为零,小数,或者字符", "提示", MessageBoxButtons.OK);
                    txtFoodsNum.Focus();
                }
                else
                {
                    WareHouse temp = new WareHouse(name, double.Parse(num), unit);
                    dao.Put(temp);
                    MessageBox.Show("入库成功！");
                    this.Close();

                }
            }
        }

        /// <summary>
        /// 窗体加载时，将名称添加到cboFoodsName
        /// 如果主窗口listview有选中项，将选中的名称添加到cboFoodsName
        /// 单位也添加到txtFoodsUnit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInput_Load(object sender, EventArgs e)
        {

            IMyObject[] obj = dao.SelectAll();

            if (obj !=null)
            {
                //cboFoodsName下拉框添加物品名
                for (int i = 0; i < obj.Length; i++)
                {
                    this.cboFoodsName.Items.Add(obj[i].PrimaryKey);
                }
            }

            //将listview选中的名称添加到cboFoodsName
            if (value != null)
            {
                cboFoodsName.SelectedItem = value;
                txtFoodsUnit.Text = unit;
                txtFoodsNum.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 焦点离开时
        /// 如果有此物品
        /// 自动显示单位，将txtFoodsUnit变false
        /// 否则变true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboFoodsName_Leave(object sender, EventArgs e)
        {
            IMyObject[] temp = dao.SelectAll();
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    if (cboFoodsName.Text == (temp[i] as WareHouse).PrimaryKey)
                    {
                        txtFoodsUnit.Enabled = false;
                        txtFoodsUnit.Text = (temp[i] as WareHouse).Unit;
                        break;
                    }
                    else
                    {
                        txtFoodsUnit.Enabled = true;
                    }
                }
            }
        }
    }
}

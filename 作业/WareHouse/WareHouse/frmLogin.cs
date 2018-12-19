using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouse
{
    public partial class frmLogin : FrmObject
    {
        public frmLogin()
        {
            InitializeComponent();
            txtLoginName.Focus();
        }

        public frmLogin(int o)
        {
            InitializeComponent();
            txtLoginName.Focus();
            this.o = o;
        }

        //判断是否按注销
        private int o;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (TestInput())
            {
                MessageBox.Show("恭喜您！登录成功！","提示",MessageBoxButtons.OK);
                frmMain main = new frmMain(this);
                this.Hide();

                //main.ShowDialog();
                //this.Show();
                main.Show();
                
            }
        }

        private bool TestInput()
        {
            this.errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtLoginName.Text.Trim()))
            {
                this.errorProvider1.SetError(txtLoginName, "不能为空");
                MessageBox.Show("请输入用户名","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);

                txtLoginName.Focus();
                return false;
            }
            else if(string.IsNullOrEmpty(txtLoginPwd.Text.Trim()))
            {
                this.errorProvider1.SetError(txtLoginPwd, "不能为空");
                MessageBox.Show("请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginPwd.Focus();
                return false;
            }
            

            bool flag=false;
            string name = txtLoginName.Text;
            string pwd = txtLoginPwd.Text;

            if (name == "123" && pwd == "123")
            {
                flag = true;
            }
            else if (name == "admin"&& pwd == "admin")
            {
                flag = true;
            }
            else if (name == "tom"&& pwd =="tom")
            {
                flag = true;
            }
            else
            {
                this.errorProvider1.SetError(txtLoginPwd, "用户名或密码错误");
                MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginName.Focus();
            }

            return flag;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLoginName.Focus();
        }
    }
}

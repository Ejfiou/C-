using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySchool.BLL;
using MySchool.Model;
namespace MySchool.WinForms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private BLLLogin bllLogin = new BLLLogin();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //验证输入数据是否合法
            
            //组装对象
            Admin adminQuery = new Admin()
            {
                LoginId = this.txtUsername.Text.Trim(),
                LoginPwd = this.txtPassword.Text.Trim()
            };

            bool flag = bllLogin.Login(adminQuery);
            if (flag)
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

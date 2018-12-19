using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Teach
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strCon = @"server=.\SQL2014;database=MySchool;uid=sa;password=123";
            string strSQL = $"select LoginPwd from Teacher where LoginId='{this.txtUser.Text}'";
            object obj = null;
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand sqlProcedure = new SqlCommand(strSQL, con);
                con.Open();
                //返回了密码
                obj = sqlProcedure.ExecuteScalar();
                con.Close();
            }
            if(obj!=null)
            {
                if(obj.ToString()==this.txtPwd.Text)
                {
                    //登录成功
                    FrmTeach f = new FrmTeach();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("您输入的用户名或密码错误");
            }
        }
    }
}

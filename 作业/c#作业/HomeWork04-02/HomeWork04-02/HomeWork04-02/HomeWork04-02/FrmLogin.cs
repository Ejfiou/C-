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

namespace HomeWork04_02
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        private string strCon = @"server=.\SQL2014;database=WareHouse;uid=sa;password=123;";
        private void btnLogin_Click(object sender, EventArgs e)
        {


            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName,"账号不能为空");
                return;

            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "密码不能为空");
                return;

            }
            bool isValid = false;

            string strSQL = $"select COUNT(*) from Users where UserName=@userName and UserPassword=@userPassword";
            object obj = null;
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@userName", txtUserName.Text.Trim());
                cmd.Parameters.AddWithValue("@userPassword", txtPassword.Text.Trim());
                con.Open();
                obj = cmd.ExecuteScalar();
                con.Close();
            }
            int count = Convert.ToInt32(obj);
            if (count == 1)
            {
                isValid = true;
            }

            if (isValid)
            {
                FrmMain f = new FrmMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
        }
    }
}

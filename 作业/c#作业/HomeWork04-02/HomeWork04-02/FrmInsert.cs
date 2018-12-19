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
using System.Text.RegularExpressions;

namespace HomeWork04_02
{
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }

        private DBHelper helper = new DBHelper();
        //private string strCon = @"server=.\SQL2014;database=WareHouse;uid=sa;password=123;";
        private void btnInsert_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNum.Text))
            {
                errorProvider1.SetError(txtNum, "不能为空");
                return;
            }
            if (!Regex.IsMatch(txtNum.Text,@"^\d+$"))
            {
                errorProvider1.SetError(txtNum, "输入数字");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                errorProvider1.SetError(txtUnit, "不能为空");
                return;
            }

            //string strSQL = "select count(*) from Goods where GoodName=@GoodName";
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@GoodName", txtName.Text);

            //    object obj = cmd.ExecuteScalar();
            //    int row = Convert.ToInt32(obj);
            //    if (row > 0)
            //    {
            //        strSQL = "update Goods set GoodNum+=@GoodNum  where GoodName=@GoodName ";
            //        SqlCommand cmd2 = new SqlCommand(strSQL, con);
            //        cmd2.Parameters.AddWithValue("@GoodNum", Convert.ToInt32(txtNum.Text));

            //        row = cmd2.ExecuteNonQuery();
            //        if (row > 0)
            //        {
            //            MessageBox.Show("增加成功！");
            //        }
            //        else
            //        {
            //            MessageBox.Show("增加失败！");
            //        }
            //    }
            //    else
            //    {
            //        strSQL = "insert into Goods(GoodName,GoodUnit,GoodNum) values (@GoodName,@GoodUnit,@GoodNum)";
            //        SqlCommand cmd1 = new SqlCommand(strSQL, con);
            //        cmd1.Parameters.AddWithValue("@GoodName", txtName.Text);
            //        cmd1.Parameters.AddWithValue("@GoodNum", txtNum.Text);
            //        cmd1.Parameters.AddWithValue("@GoodUnit", txtUnit.Text);
            //        row = cmd1.ExecuteNonQuery();
            //        if (row > 0)
            //        {
            //            MessageBox.Show("增加成功！");
            //        }
            //        else
            //        {
            //            MessageBox.Show("增加失败！");
            //        }

            //    }

            //    con.Close();
            //}
            string strSQL = "sp_selectGoodNameConut";

            int row = Convert.ToInt32(helper.ExecuteScalar(strSQL, CommandType.StoredProcedure, new SqlParameter("@GoodName", txtName.Text)));
            if (row >0)
            {
                strSQL = "sp_updateGoodNum";
                row = helper.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, new SqlParameter("@GoodNum", Convert.ToInt32(txtNum.Text)), new SqlParameter("@GoodName", txtName.Text));
                if (row > 0)
                {
                    MessageBox.Show("增加成功！");
                }
                else
                {
                    MessageBox.Show("增加失败！");
                }
            }
            else
            {
                strSQL = "sp_insertGoods";
                row = helper.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, new SqlParameter("@GoodName", txtName.Text),
                        new SqlParameter("@GoodNum", txtNum.Text), new SqlParameter("@GoodUnit", txtUnit.Text));
                if (row > 0)
                {
                    MessageBox.Show("增加成功！");
                }
                else
                {
                    MessageBox.Show("增加失败！");
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string strSQL = "select count(*) from Goods where GoodName=@GoodName";
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@GoodName", txtName.Text);

            //    object obj = cmd.ExecuteScalar();
            //    int row = Convert.ToInt32(obj);
            //    if (row > 0)
            //    {
            //        strSQL = "select GoodUnit from Goods where GoodName=@GoodName";
            //        SqlCommand cmd1 = new SqlCommand(strSQL, con);
            //        cmd1.Parameters.AddWithValue("@GoodName", txtName.Text);
            //        SqlDataReader reader = cmd1.ExecuteReader();
            //        if (reader.Read())
            //        {
            //            txtUnit.Text = reader.GetString(reader.GetOrdinal("GoodUnit"));
            //        }
            //        reader.Close();
            //    }
            //    con.Close();
            //}

            string strSQL = "sp_selectGoodNameConut";

            int row = Convert.ToInt32(helper.ExecuteScalar(strSQL, CommandType.StoredProcedure, new SqlParameter("@GoodName", txtName.Text)));
            if (row > 0 )
            {
                strSQL = "sp_selectUnit";

                using (IDataReader reader = helper.ExecuteReader(strSQL, CommandType.StoredProcedure, new SqlParameter("@GoodName", txtName.Text)))
                {
                    if (reader.Read())
                    {
                        txtUnit.Text = reader.GetString(reader.GetOrdinal("GoodUnit"));
                    }
                    reader.Close(); 
                }
                txtUnit.Enabled = false;
            }
            else
            {
                txtUnit.Enabled = true;
                txtUnit.Clear();
            }
        }
    }
}

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
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }
        private string strCon = @"server=.\SQL2014;database=WareHouse;uid=sa;password=123;";
        private void btnInsert_Click(object sender, EventArgs e)
        {

            string strSQL = "select count(*) from Goods where GoodName=@GoodName";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GoodName", textBox1.Text);

                object obj = cmd.ExecuteScalar();
                int row = Convert.ToInt32(obj);
                if (row > 0)
                {
                    strSQL = "update Goods set GoodNum+=@GoodNum  where GoodName=@GoodName ";
                    SqlCommand cmd2 = new SqlCommand(strSQL, con);
                    cmd2.Parameters.AddWithValue("@GoodNum", Convert.ToInt32(textBox2.Text));

                    row = cmd2.ExecuteNonQuery();
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
                    strSQL = "insert into Goods(GoodName,GoodUnit,GoodNum) values (@GoodName,@GoodUnit,@GoodNum)";
                    SqlCommand cmd1 = new SqlCommand(strSQL, con);
                    cmd1.Parameters.AddWithValue("@GoodName", textBox1.Text);
                    cmd1.Parameters.AddWithValue("@GoodNum", textBox2.Text);
                    cmd1.Parameters.AddWithValue("@GoodUnit", textBox4.Text);
                    row = cmd1.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("增加成功！");
                    }
                    else
                    {
                        MessageBox.Show("增加失败！");
                    }

                }

                con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string strSQL = "select count(*) from Goods where GoodName=@GoodName";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GoodName", textBox1.Text);

                object obj = cmd.ExecuteScalar();
                int row = Convert.ToInt32(obj);
                if (row > 0)
                {
                    strSQL = "select GoodUnit,GoodPrice from Goods where GoodName=@GoodName";
                    SqlCommand cmd1 = new SqlCommand(strSQL, con);
                    cmd1.Parameters.AddWithValue("@GoodName", textBox1.Text);
                    SqlDataReader reader = cmd1.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox4.Text = reader.GetString(reader.GetOrdinal("GoodUnit"));
                    }
                    reader.Close();
                }
                con.Close();
            }
        }
    }
}

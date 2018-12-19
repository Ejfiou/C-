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
    public partial class FrmOut : Form
    {
        public FrmOut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = Convert.ToInt32(this.textBox2.Text);
            string strSQL = "select GoodNum from Goods ";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    a = reader.GetInt32(reader.GetOrdinal("GoodNum"));                   
                }
                reader.Close();
                con.Close();
            }
            if (a > b)
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    strSQL = "update Goods set GoodNum-=@GoodNum where GoodName=@GoodName";
                    SqlCommand cmd2 = new SqlCommand(strSQL, con);
                    cmd2.Parameters.AddWithValue("@GoodNum", Convert.ToInt32(textBox2.Text));
                    cmd2.Parameters.AddWithValue("@GoodName", comboBox1.Text);

                    int  row = cmd2.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("出库成功！");
                    }
                    else
                    {
                        MessageBox.Show("出库失败！");
                    }
                    con.Close();
                }
            }
            else if (a == b)
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    strSQL = "delete from Goods  where GoodName=@GoodName";
                    SqlCommand cmd2 = new SqlCommand(strSQL, con);
                    cmd2.Parameters.AddWithValue("@GoodName", comboBox1.Text);

                    int row = cmd2.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("出库成功！");
                    }
                    else
                    {
                        MessageBox.Show("出库失败！");
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("出库失败！");
            }
        }
        private string strCon = @"server=.\SQL2014;database=WareHouse;uid=sa;password=123;";
        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            string strSQL = "select GoodName from Goods ";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string GoodName = reader.GetString(reader.GetOrdinal("GoodName"));
                    this.comboBox1.Items.Add(GoodName);
                }

                reader.Close();

                con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strSQL = "select count(*) from Goods where GoodName=@GoodName";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GoodName", comboBox1.Text);

                object obj = cmd.ExecuteScalar();
                int row = Convert.ToInt32(obj);
                if (row > 0)
                {
                    strSQL = "select GoodUnit,GoodPrice from Goods where GoodName=@GoodName";
                    SqlCommand cmd1 = new SqlCommand(strSQL, con);
                    cmd1.Parameters.AddWithValue("@GoodName", comboBox1.Text);
                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox4.Text = reader.GetString(reader.GetOrdinal("GoodUnit"));
                    }
                    reader.Close();
                }
                con.Close();
            }
            textBox4.Enabled = false;
        }
    }
}

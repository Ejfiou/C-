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
    public partial class FrmSelect : Form
    {
        public FrmSelect()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string strCon = @"server=.\SQL2014;database=WareHouse;uid=sa;password=123;";
        private void FrmSelect_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string s = this.comboBox1.Text;
            if (s == "查询所有商品")
            {
                s = "";
            }
            listView1.Items.Clear();
            string  strSQL= "select GoodName, GoodNum,GoodUnit from Goods where (CHARINDEX(@GoodName,GoodName)>0 or LEN(@GoodName)=0)";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GoodName",s);
                cmd.Parameters.AddWithValue("@Sex", comboBox1.Text);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string goodName = reader.GetString(reader.GetOrdinal("GoodName"));
                    string goodUnit = reader.GetString(reader.GetOrdinal("GoodUnit"));
                    string goodNum = reader.GetInt32(reader.GetOrdinal("GoodNum")).ToString();

                    ListViewItem list = new ListViewItem(goodName);
                    list.SubItems.Add(goodNum);
                    list.SubItems.Add(goodUnit);
                    listView1.Items.Add(list);
                }
                reader.Close();
                con.Close();
            }
        }
    }
}

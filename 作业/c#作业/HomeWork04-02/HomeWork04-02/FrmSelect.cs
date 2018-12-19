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

        //private string strCon = @"server=.\SQL2014;database=WareHouse;uid=sa;password=123;";
        private DBHelper helper = new DBHelper();
        private void FrmSelect_Load(object sender, EventArgs e)
        {
            string strSQL = "sp_selectGoodName";
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    con.Open();

            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        string GoodName = reader.GetString(reader.GetOrdinal("GoodName"));
            //        this.cboName.Items.Add(GoodName);
            //    }

            //    reader.Close();

            //    con.Close();
            //}
            using (IDataReader reader = helper.ExecuteReader(strSQL,CommandType.StoredProcedure))
            {
                while (reader.Read())
                {
                    string GoodName = reader.GetString(reader.GetOrdinal("GoodName"));
                    this.cboName.Items.Add(GoodName);
                }

                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = this.cboName.Text;
            if (s == "查询所有商品")
            {
                s = "";
            }
            lvwShow.Items.Clear();
            string  strSQL= "sp_selectGoods";
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@GoodName",s);
            //    con.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        string goodName = reader.GetString(reader.GetOrdinal("GoodName"));
            //        string goodUnit = reader.GetString(reader.GetOrdinal("GoodUnit"));
            //        string goodNum = reader.GetInt32(reader.GetOrdinal("GoodNum")).ToString();

            //        ListViewItem list = new ListViewItem(goodName);
            //        list.SubItems.Add(goodNum);
            //        list.SubItems.Add(goodUnit);
            //        lvwShow.Items.Add(list);
            //    }
            //    reader.Close();
            //    con.Close();
            //}

            using (IDataReader reader = helper.ExecuteReader(strSQL,CommandType.StoredProcedure,new SqlParameter("@GoodName", s)))
            {
                while (reader.Read())
                {
                    string goodName = reader.GetString(reader.GetOrdinal("GoodName"));
                    string goodUnit = reader.GetString(reader.GetOrdinal("GoodUnit"));
                    string goodNum = reader.GetInt32(reader.GetOrdinal("GoodNum")).ToString();

                    ListViewItem list = new ListViewItem(goodName);
                    list.SubItems.Add(goodNum);
                    list.SubItems.Add(goodUnit);
                    lvwShow.Items.Add(list);
                }
                reader.Close();
            }
        }
    }
}

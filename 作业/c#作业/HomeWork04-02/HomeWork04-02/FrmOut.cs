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
    public partial class FrmOut : Form
    {
        public FrmOut()
        {
            InitializeComponent();
        }

        //private string strCon = @"server=.\SQL2014;database=WareHouse;uid=sa;password=123;";

        private DBHelper helper = new DBHelper();


        private int SearchNum()
        {
            int a = -2;
            string strSQL = "sp_selectNum";
            using (IDataReader reader = helper.ExecuteReader(strSQL, CommandType.StoredProcedure, new SqlParameter("@GoodName", cboName.Text)))
            {
                if (reader.Read())
                {
                    a = reader.GetInt32(reader.GetOrdinal("GoodNum"));
                }
                reader.Close();
            }
            return a;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNum.Text))
            {
                errorProvider1.SetError(txtNum, "不能为空");
                return;
            }
            if (!Regex.IsMatch(txtNum.Text, @"^\d+$"))
            {
                errorProvider1.SetError(txtNum, "输入数字");
                return;
            }
            if (string.IsNullOrWhiteSpace(cboName.Text))
            {
                errorProvider1.SetError(cboName, "不能为空");
                return;
            }


            
            int b = Convert.ToInt32(this.txtNum.Text);
            // string strSQL = "select GoodNum from Goods ";
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    con.Open();

            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        a = reader.GetInt32(reader.GetOrdinal("GoodNum"));                   
            //    }
            //    reader.Close();
            //    con.Close();
            //}
            int a = SearchNum();
            
            if (a > b)
            {
                //using (SqlConnection con = new SqlConnection(strCon))
                //{
                //    con.Open();
                //    strSQL = "update Goods set GoodNum-=@GoodNum where GoodName=@GoodName";
                //    SqlCommand cmd2 = new SqlCommand(strSQL, con);
                //    cmd2.Parameters.AddWithValue("@GoodNum", Convert.ToInt32(txtNum.Text));
                //    cmd2.Parameters.AddWithValue("@GoodName", cboName.Text);

                //    int  row = cmd2.ExecuteNonQuery();
                //    if (row > 0)
                //    {
                //        MessageBox.Show("出库成功！");
                //    }
                //    else
                //    {
                //        MessageBox.Show("出库失败！");
                //    }
                //    con.Close();
                //}
                string strSQL = "sp_subGoodNum";

                int row = helper.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, new SqlParameter("@GoodNum", Convert.ToInt32(txtNum.Text)),
                            new SqlParameter("@GoodName", cboName.Text));
                if (row > 0)
                {
                    MessageBox.Show("出库成功！");
                }
                else
                {
                    MessageBox.Show("出库失败！");
                }
            }
            else if (a == b)
            {
                //using (SqlConnection con = new SqlConnection(strCon))
                //{
                //    con.Open();
                //    strSQL = "delete from Goods  where GoodName=@GoodName";
                //    SqlCommand cmd2 = new SqlCommand(strSQL, con);
                //    cmd2.Parameters.AddWithValue("@GoodName", cboName.Text);

                //    int row = cmd2.ExecuteNonQuery();
                //    if (row > 0)
                //    {
                //        MessageBox.Show("商品全部出库！");
                //    }
                //    else
                //    {
                //        MessageBox.Show("出库失败！");
                //    }
                //    con.Close();
                //}
                string strSQL = "sp_deleteGood";
                int row = helper.ExecuteNonQuery(strSQL, CommandType.StoredProcedure,
                                new SqlParameter("@GoodName", cboName.Text));
                if (row > 0)
                {
                    MessageBox.Show("商品全部出库！");
                }
                else
                {
                    MessageBox.Show("出库失败！");
                }
            }
            else
            {
                MessageBox.Show($"库存不足,出库失败！当前库存{a}");
            }
        }
        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            //string strSQL = "select GoodName from Goods ";
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

            string strSQL = "sp_selectGoodName ";

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string strSQL = "select count(*) from Goods where GoodName=@GoodName";
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@GoodName", cboName.Text);

            //    object obj = cmd.ExecuteScalar();
            //    int row = Convert.ToInt32(obj);
            //    if (row > 0)
            //    {
            //        strSQL = "select GoodUnit from Goods where GoodName=@GoodName";
            //        SqlCommand cmd1 = new SqlCommand(strSQL, con);
            //        cmd1.Parameters.AddWithValue("@GoodName", cboName.Text);
            //        SqlDataReader reader = cmd1.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            txtUnit.Text = reader.GetString(reader.GetOrdinal("GoodUnit"));
            //        }
            //        reader.Close();
            //    }
            //    con.Close();
            //}

            string strSQL = "sp_selectGoodNameConut";
            int row = Convert.ToInt32(helper.ExecuteScalar(strSQL, CommandType.StoredProcedure, new SqlParameter("@GoodName", cboName.Text)));
            if (row >0)
            {
                strSQL = "sp_selectUnit";
                using (IDataReader reader = helper.ExecuteReader(strSQL,CommandType.StoredProcedure,new SqlParameter("@GoodName", cboName.Text)))
                {
                    while (reader.Read())
                    {
                        lblUnit.Text = reader.GetString(reader.GetOrdinal("GoodUnit"));
                    }
                    reader.Close();
                }
                lblUnitl.Visible = true;
            }
            lblNums.Text = SearchNum().ToString();
            lblNuml.Visible = true;
        }
    }
}

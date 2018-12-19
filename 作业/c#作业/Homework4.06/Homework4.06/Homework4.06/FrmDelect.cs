using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4._06
{
    public partial class FrmDelect : Form
    {
        public FrmDelect()
        {
            InitializeComponent();
        }

        public FrmDelect(string guid)
        {
            this.guid = guid;
            InitializeComponent();
        }

        //private string strCon = @"server=.\SQL2014;database=MySchool;uid=sa;password=123";
        private DBHelper helper = new DBHelper();
        private string guid = null;

        private void FrmDelect_Load(object sender, EventArgs e)
        {
            string str = "sp_selectByStuGuid";

            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand(str, con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@StudentGuid", guid);

            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        lblStuNo.Text = reader.GetString(reader.GetOrdinal("StudentNO"));
            //        lblId.Text = reader.GetString(reader.GetOrdinal("LoginId"));
            //        int userStateId = reader.GetInt32(reader.GetOrdinal("UserStateId"));
            //        lblState.Text = userStateId == 1 ? "在线" : "离线";
            //        lblClass.Text = reader.GetString(reader.GetOrdinal("ClassName"));
            //        lblName.Text = reader.GetString(reader.GetOrdinal("StudentName"));
            //        lblAddress.Text = reader.GetString(reader.GetOrdinal("Address"));
            //        lblSex.Text = reader.GetString(reader.GetOrdinal("Sex"));
            //    }
            //    reader.Close();

            //    con.Close();
            //}

            using (IDataReader reader = helper.ExecuteReader(str,CommandType.StoredProcedure,new SqlParameter("@StudentGuid", guid)))
            {
                while (reader.Read())
                {
                    lblStuNo.Text = reader.GetString(reader.GetOrdinal("StudentNO"));
                    lblId.Text = reader.GetString(reader.GetOrdinal("LoginId"));
                    int userStateId = reader.GetInt32(reader.GetOrdinal("UserStateId"));
                    lblState.Text = userStateId == 1 ? "在线" : "离线";
                    lblClass.Text = reader.GetString(reader.GetOrdinal("ClassName"));
                    lblName.Text = reader.GetString(reader.GetOrdinal("StudentName"));
                    lblAddress.Text = reader.GetString(reader.GetOrdinal("Address"));
                    lblSex.Text = reader.GetString(reader.GetOrdinal("Sex"));
                }
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();
            //    string strSql = "sp_delete";
            //    SqlCommand cmd = new SqlCommand(strSql, con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@StudentGuid", guid);
            //    int a = cmd.ExecuteNonQuery();
            //    if (a >= 1)
            //    {
            //        MessageBox.Show("删除成功");
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("删除失败");
            //    }
            //    con.Close();
            //}
            string strSql = "sp_delete";
            int a = helper.ExecuteNonQuery(strSql, CommandType.StoredProcedure, new SqlParameter("@StudentGuid", guid));
            if (a >= 1)
            {
                MessageBox.Show("删除成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
    }
}

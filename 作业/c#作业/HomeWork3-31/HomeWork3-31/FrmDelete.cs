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

namespace HomeWork3_31
{
    public partial class FrmDelete : Form
    {
        public FrmDelete()
        {
            InitializeComponent();
        }
        private string strCon = @"server=.\SQL2014;database=MySchool;uid=sa;password=123;";
        private void button1_Click(object sender, EventArgs e)
        {
            string  strSQL = "Delete Student  where StudentNO=@StudentNO";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@StudentNO", this.comboBox1.Text);
                con.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
                con.Close();
            }
        }

        private void FrmDelete_Load(object sender, EventArgs e)
        {
           string   strSQL = "select StudentNO from Student";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //string GradeName = reader[0].ToString();
                    //string GradeName = Convert.ToString(reader["GradeName"]);
                    string studentNO = reader.GetString(reader.GetOrdinal("StudentNO"));
                    this.comboBox1.Items.Add(studentNO);
                }

                reader.Close();

                con.Close();
            }
        }
    }
}

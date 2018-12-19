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
namespace Class_03_31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DBHelper helper = new DBHelper();

        private void Form1_Load(object sender, EventArgs e)
        {
            //string strCon = @"server=DEEP-20161031OJ;database=MySchool;uid=sa;password=123";
            string strSQL = "Select GradeName from Grade order by GradeSeq";

            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    con.Open();

            //    SqlDataReader reader = cmd.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        //四种ExecuteReader方法读取数据
            //        //string gradeName = Convert.ToString(reader[0]);
            //        //string gradeName = Convert.ToString(reader["GradeName"]);
            //        //string gradeName = reader.GetString(0);
            //        string gradeName = reader.GetString(reader.GetOrdinal("GradeName"));

            //        this.cboGrade.Items.Add(gradeName);
            //    }

            //    reader.Close();

            //    con.Close();
            //}

            using (IDataReader reader = helper.ExecuteReader(strSQL))
            {
                while (reader.Read())
                {
                    string gradeName = reader.GetString(reader.GetOrdinal("GradeName"));
                    this.cboGrade.Items.Add(gradeName);
                }
            }
        }
    }
}

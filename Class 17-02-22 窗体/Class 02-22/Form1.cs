using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Class_02_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "测试";

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "点我吧！";
        }

        //int count = 0;

        private void btnTest_Click(object sender, EventArgs e)
        {

            //count++;
            //lblTest.Text = $"按钮被点击了{count}次";

            //this.txtTest.Text= $"按钮被点击了{count}次";

            //this.lblTest.Text = this.txtTest.Text;

            // MessageBox.Show("你在");
            // MessageBox.Show("错误", "警告", MessageBoxButtons.YesNoCancel);
            // MessageBox.Show("错误","警告",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Asterisk);
            //  MessageBox.Show("错误", "警告", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button3);
            //DialogResult dr =  MessageBox.Show("错误", "警告", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button3);
            // if (dr == DialogResult.Yes)
            // {
            //     lblTest.Text = "选择了是";
            // }
            // else if (dr == DialogResult.No)
            // {
            //     lblTest.Text = "选择了否";
            // }
            // else
            // {
            //     lblTest.Text = "取消";
            // }

            //if (rbtnMale.Checked)
            //{
            //    MessageBox.Show(rbtnMale.Text);
            //}
            //if (rbtn.Checked)
            //{
            //    MessageBox.Show(rbtn.Text);
            //}

            // MessageBox.Show(!rbtn.Checked ? rbtnMale.Text : rbtn.Text, "性别");


            //遍历groupBox中的控件
            //foreach (var item in gbSex.Controls)
            //{
            //    if (item is RadioButton)
            //    {
            //        RadioButton rd = item as RadioButton;
            //        if (rd.Checked)
            //        {
            //            MessageBox.Show(rd.Text, "性别");
            //        }
            //    }
            //}

            //foreach (var item in gbEducation.Controls)
            //{
            //    if (item is RadioButton)
            //    {
            //        RadioButton rd = item as RadioButton;
            //        if (rd.Checked)
            //        {
            //            MessageBox.Show(rd.Text, "学历");
            //        }
            //    }
            //}

            //bool flag = false;
            //string s = null;
            //foreach (var item in gbHobby.Controls)
            //{
            //    if (item is CheckBox)
            //    {
            //        CheckBox ck = item as CheckBox;
            //        if (ck.Checked)
            //        {
            //            s += ck.Text + " ";
            //            flag = true;
            //        }
            //    }
            //}
            //if (flag)
            //{
            //    MessageBox.Show(s, "兴趣");
            //}
            //else
            //{
            //    MessageBox.Show("没有选择兴趣", "兴趣");

            //}

            //if (string.IsNullOrEmpty(lstTest.Text))
            //{
            //    MessageBox.Show("没有选择名字", "名字");
            //}
            //else
            //{
            //    MessageBox.Show(lstTest.Text.ToString(), "名字");
            //}

            //  MessageBox.Show(lstTest.SelectedItem.ToString());
            //foreach (var item in lstTest.SelectedItems)
            //{
            //    MessageBox.Show(item.ToString());
            //}
            
        }

        private void txtTest_TextChanged(object sender, EventArgs e)
        {
            this.lblTest.Text = this.txtTest.Text;
        }

        private void cboTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTest.Text = cboTest.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text==string.Empty)
            {
                txtAdd.Focus();
            }
            else
            {
                lstTest.Items.Add(txtAdd.Text);
                this.txtAdd.Clear();
                txtAdd.Focus();
            }
           
        }

        //private void lstTest_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (lstTest.SelectedItem !=null)
        //    {
        //        txtAdd.Text = lstTest.SelectedItem.ToString();
        //    }
        //}

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lstTest.SelectedIndex > -1)
            {
                lstTest.Items[lstTest.SelectedIndex] = txtAdd.Text;

            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            while (lstTest.SelectedIndex>-1)
            {
                lstTest.Items.RemoveAt(lstTest.SelectedIndex);
            }
           
        }

        private void btnToRignt_Click(object sender, EventArgs e)
        {
            //while (lstTest.SelectedIndex>-1)
            //{
            //    lstTraget.Items.Add(lstTest.Items[lstTest.SelectedIndex]);
            //    lstTest.Items.RemoveAt(lstTest.SelectedIndex);
            //}

            foreach (int item in lstTest.SelectedIndices)
            {
                lstTraget.Items.Add(lstTest.Items[item]);
            }



            for (int i = lstTest.SelectedIndices.Count-1; i>=0; i--)
            {
                lstTest.Items.RemoveAt(lstTest.SelectedIndices[i]);
            }
            

        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            while (lstTraget.SelectedIndex > -1)
            {
                lstTest.Items.Add(lstTraget.Items[lstTraget.SelectedIndex]);
                lstTraget.Items.RemoveAt(lstTraget.SelectedIndex);
            }
        }

        private void btnToRightAll_Click(object sender, EventArgs e)
        {
            lstTraget.Items.AddRange(lstTest.Items);
            lstTest.Items.Clear();
        }

        private void btnToLeftAll_Click(object sender, EventArgs e)
        {
            lstTest.Items.AddRange(lstTraget.Items);
            lstTraget.Items.Clear();
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

      

        /// <summary>
        /// 拖拽
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                textBox1.Text = e.Data.GetData(DataFormats.Text).ToString();
            }
        }

        private void txtTest_MouseLeave(object sender, EventArgs e)
        {
            this.txtTest.DoDragDrop(this.txtTest.Text, DragDropEffects.Copy);
        }

        /// <summary>
        /// 鼠标离开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
        }

        private void txtTest_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                txtTest.Text = e.Data.GetData(DataFormats.Text).ToString();
            }
        }

        //private void txtTest_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.Text))
        //    {
        //        e.Effect = DragDropEffects.Copy;
        //    }
        //    else
        //    {
        //        e.Effect = DragDropEffects.None;
        //    }
        //}
    }
}

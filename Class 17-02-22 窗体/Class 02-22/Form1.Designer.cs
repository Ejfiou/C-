namespace Class_02_22
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTest = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.cboTest = new System.Windows.Forms.ComboBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtn = new System.Windows.Forms.RadioButton();
            this.rbtnHighSchool = new System.Windows.Forms.RadioButton();
            this.rbtnSpecialist = new System.Windows.Forms.RadioButton();
            this.rbtnUndergraduate = new System.Windows.Forms.RadioButton();
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.gbEducation = new System.Windows.Forms.GroupBox();
            this.chkRead = new System.Windows.Forms.CheckBox();
            this.chkPlay = new System.Windows.Forms.CheckBox();
            this.chkSwim = new System.Windows.Forms.CheckBox();
            this.gbHobby = new System.Windows.Forms.GroupBox();
            this.lstTest = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstTraget = new System.Windows.Forms.ListBox();
            this.btnToRignt = new System.Windows.Forms.Button();
            this.btnToRightAll = new System.Windows.Forms.Button();
            this.btnToLeft = new System.Windows.Forms.Button();
            this.btnToLeftAll = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.测试1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gbSex.SuspendLayout();
            this.gbEducation.SuspendLayout();
            this.gbHobby.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(94, 11);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(29, 12);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "测试";
            // 
            // btnTest
            // 
            this.btnTest.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Image")));
            this.btnTest.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTest.Location = new System.Drawing.Point(59, 76);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(97, 107);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "测试";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtTest
            // 
            this.txtTest.AllowDrop = true;
            this.txtTest.Location = new System.Drawing.Point(209, 65);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(146, 21);
            this.txtTest.TabIndex = 2;
            this.txtTest.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtTest_DragDrop);
            this.txtTest.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            this.txtTest.MouseLeave += new System.EventHandler(this.txtTest_MouseLeave);
            // 
            // cboTest
            // 
            this.cboTest.FormattingEnabled = true;
            this.cboTest.Items.AddRange(new object[] {
            "tom",
            "jack",
            "rose",
            "jerry"});
            this.cboTest.Location = new System.Drawing.Point(46, 210);
            this.cboTest.Name = "cboTest";
            this.cboTest.Size = new System.Drawing.Size(121, 20);
            this.cboTest.TabIndex = 3;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Location = new System.Drawing.Point(35, 19);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(35, 16);
            this.rbtnMale.TabIndex = 4;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "男\r\n";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtn
            // 
            this.rbtn.AutoSize = true;
            this.rbtn.Location = new System.Drawing.Point(121, 20);
            this.rbtn.Name = "rbtn";
            this.rbtn.Size = new System.Drawing.Size(35, 16);
            this.rbtn.TabIndex = 5;
            this.rbtn.Text = "女";
            this.rbtn.UseVisualStyleBackColor = true;
            // 
            // rbtnHighSchool
            // 
            this.rbtnHighSchool.AutoSize = true;
            this.rbtnHighSchool.Location = new System.Drawing.Point(10, 26);
            this.rbtnHighSchool.Name = "rbtnHighSchool";
            this.rbtnHighSchool.Size = new System.Drawing.Size(47, 16);
            this.rbtnHighSchool.TabIndex = 6;
            this.rbtnHighSchool.TabStop = true;
            this.rbtnHighSchool.Text = "高中";
            this.rbtnHighSchool.UseVisualStyleBackColor = true;
            // 
            // rbtnSpecialist
            // 
            this.rbtnSpecialist.AutoSize = true;
            this.rbtnSpecialist.Location = new System.Drawing.Point(70, 26);
            this.rbtnSpecialist.Name = "rbtnSpecialist";
            this.rbtnSpecialist.Size = new System.Drawing.Size(47, 16);
            this.rbtnSpecialist.TabIndex = 7;
            this.rbtnSpecialist.TabStop = true;
            this.rbtnSpecialist.Text = "专科";
            this.rbtnSpecialist.UseVisualStyleBackColor = true;
            // 
            // rbtnUndergraduate
            // 
            this.rbtnUndergraduate.AutoSize = true;
            this.rbtnUndergraduate.Checked = true;
            this.rbtnUndergraduate.Location = new System.Drawing.Point(136, 26);
            this.rbtnUndergraduate.Name = "rbtnUndergraduate";
            this.rbtnUndergraduate.Size = new System.Drawing.Size(47, 16);
            this.rbtnUndergraduate.TabIndex = 8;
            this.rbtnUndergraduate.TabStop = true;
            this.rbtnUndergraduate.Text = "本科";
            this.rbtnUndergraduate.UseVisualStyleBackColor = true;
            // 
            // gbSex
            // 
            this.gbSex.Controls.Add(this.rbtnMale);
            this.gbSex.Controls.Add(this.rbtn);
            this.gbSex.Location = new System.Drawing.Point(3, 15);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(200, 41);
            this.gbSex.TabIndex = 9;
            this.gbSex.TabStop = false;
            this.gbSex.Text = "性别";
            // 
            // gbEducation
            // 
            this.gbEducation.Controls.Add(this.rbtnUndergraduate);
            this.gbEducation.Controls.Add(this.rbtnHighSchool);
            this.gbEducation.Controls.Add(this.rbtnSpecialist);
            this.gbEducation.Location = new System.Drawing.Point(3, 74);
            this.gbEducation.Name = "gbEducation";
            this.gbEducation.Size = new System.Drawing.Size(200, 51);
            this.gbEducation.TabIndex = 10;
            this.gbEducation.TabStop = false;
            this.gbEducation.Text = "最高学历";
            // 
            // chkRead
            // 
            this.chkRead.AutoSize = true;
            this.chkRead.Location = new System.Drawing.Point(25, 25);
            this.chkRead.Name = "chkRead";
            this.chkRead.Size = new System.Drawing.Size(48, 16);
            this.chkRead.TabIndex = 11;
            this.chkRead.Text = "看书";
            this.chkRead.UseVisualStyleBackColor = true;
            // 
            // chkPlay
            // 
            this.chkPlay.AutoSize = true;
            this.chkPlay.Location = new System.Drawing.Point(90, 25);
            this.chkPlay.Name = "chkPlay";
            this.chkPlay.Size = new System.Drawing.Size(36, 16);
            this.chkPlay.TabIndex = 12;
            this.chkPlay.Text = "玩";
            this.chkPlay.UseVisualStyleBackColor = true;
            // 
            // chkSwim
            // 
            this.chkSwim.AutoSize = true;
            this.chkSwim.Location = new System.Drawing.Point(146, 25);
            this.chkSwim.Name = "chkSwim";
            this.chkSwim.Size = new System.Drawing.Size(48, 16);
            this.chkSwim.TabIndex = 13;
            this.chkSwim.Text = "游泳";
            this.chkSwim.UseVisualStyleBackColor = true;
            // 
            // gbHobby
            // 
            this.gbHobby.Controls.Add(this.chkSwim);
            this.gbHobby.Controls.Add(this.chkRead);
            this.gbHobby.Controls.Add(this.chkPlay);
            this.gbHobby.Location = new System.Drawing.Point(3, 144);
            this.gbHobby.Name = "gbHobby";
            this.gbHobby.Size = new System.Drawing.Size(200, 51);
            this.gbHobby.TabIndex = 14;
            this.gbHobby.TabStop = false;
            this.gbHobby.Text = "兴趣";
            // 
            // lstTest
            // 
            this.lstTest.FormattingEnabled = true;
            this.lstTest.ItemHeight = 12;
            this.lstTest.Items.AddRange(new object[] {
            "tom",
            "jack",
            "rose",
            "jerry"});
            this.lstTest.Location = new System.Drawing.Point(6, 34);
            this.lstTest.Name = "lstTest";
            this.lstTest.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstTest.Size = new System.Drawing.Size(75, 100);
            this.lstTest.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(64, 156);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 21);
            this.txtAdd.TabIndex = 17;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(233, 158);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(52, 23);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(170, 156);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(56, 23);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "删除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstTraget
            // 
            this.lstTraget.FormattingEnabled = true;
            this.lstTraget.ItemHeight = 12;
            this.lstTraget.Location = new System.Drawing.Point(161, 34);
            this.lstTraget.Name = "lstTraget";
            this.lstTraget.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstTraget.Size = new System.Drawing.Size(108, 100);
            this.lstTraget.TabIndex = 20;
            // 
            // btnToRignt
            // 
            this.btnToRignt.Location = new System.Drawing.Point(87, 34);
            this.btnToRignt.Name = "btnToRignt";
            this.btnToRignt.Size = new System.Drawing.Size(64, 23);
            this.btnToRignt.TabIndex = 21;
            this.btnToRignt.Text = ">";
            this.btnToRignt.UseVisualStyleBackColor = true;
            this.btnToRignt.Click += new System.EventHandler(this.btnToRignt_Click);
            // 
            // btnToRightAll
            // 
            this.btnToRightAll.Location = new System.Drawing.Point(87, 63);
            this.btnToRightAll.Name = "btnToRightAll";
            this.btnToRightAll.Size = new System.Drawing.Size(64, 23);
            this.btnToRightAll.TabIndex = 22;
            this.btnToRightAll.Text = ">>";
            this.btnToRightAll.UseVisualStyleBackColor = true;
            this.btnToRightAll.Click += new System.EventHandler(this.btnToRightAll_Click);
            // 
            // btnToLeft
            // 
            this.btnToLeft.Location = new System.Drawing.Point(87, 87);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(64, 23);
            this.btnToLeft.TabIndex = 23;
            this.btnToLeft.Text = "<";
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // btnToLeftAll
            // 
            this.btnToLeftAll.Location = new System.Drawing.Point(87, 111);
            this.btnToLeftAll.Name = "btnToLeftAll";
            this.btnToLeftAll.Size = new System.Drawing.Size(64, 23);
            this.btnToLeftAll.TabIndex = 24;
            this.btnToLeftAll.Text = "<<";
            this.btnToLeftAll.UseVisualStyleBackColor = true;
            this.btnToLeftAll.Click += new System.EventHandler(this.btnToLeftAll_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(35, 257);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(301, 242);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbSex);
            this.tabPage1.Controls.Add(this.gbEducation);
            this.tabPage1.Controls.Add(this.gbHobby);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(293, 216);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "选择";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstTraget);
            this.tabPage2.Controls.Add(this.btnToLeftAll);
            this.tabPage2.Controls.Add(this.lstTest);
            this.tabPage2.Controls.Add(this.btnToLeft);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.btnToRightAll);
            this.tabPage2.Controls.Add(this.txtAdd);
            this.tabPage2.Controls.Add(this.btnToRignt);
            this.tabPage2.Controls.Add(this.btnModify);
            this.tabPage2.Controls.Add(this.btnRemove);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(293, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "列表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 25);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关闭ToolStripMenuItem.Text = "保存";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测试1ToolStripMenuItem,
            this.测试2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // 测试1ToolStripMenuItem
            // 
            this.测试1ToolStripMenuItem.Name = "测试1ToolStripMenuItem";
            this.测试1ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.测试1ToolStripMenuItem.Text = "测试1";
            // 
            // 测试2ToolStripMenuItem
            // 
            this.测试2ToolStripMenuItem.Name = "测试2ToolStripMenuItem";
            this.测试2ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.测试2ToolStripMenuItem.Text = "测试2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(546, 25);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(209, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 106);
            this.textBox1.TabIndex = 30;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(384, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(125, 106);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 520);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cboTest);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.gbSex.ResumeLayout(false);
            this.gbSex.PerformLayout();
            this.gbEducation.ResumeLayout(false);
            this.gbEducation.PerformLayout();
            this.gbHobby.ResumeLayout(false);
            this.gbHobby.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.ComboBox cboTest;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtn;
        private System.Windows.Forms.RadioButton rbtnHighSchool;
        private System.Windows.Forms.RadioButton rbtnSpecialist;
        private System.Windows.Forms.RadioButton rbtnUndergraduate;
        private System.Windows.Forms.GroupBox gbSex;
        private System.Windows.Forms.GroupBox gbEducation;
        private System.Windows.Forms.CheckBox chkRead;
        private System.Windows.Forms.CheckBox chkPlay;
        private System.Windows.Forms.CheckBox chkSwim;
        private System.Windows.Forms.GroupBox gbHobby;
        private System.Windows.Forms.ListBox lstTest;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstTraget;
        private System.Windows.Forms.Button btnToRignt;
        private System.Windows.Forms.Button btnToRightAll;
        private System.Windows.Forms.Button btnToLeft;
        private System.Windows.Forms.Button btnToLeftAll;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 测试1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测试2ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


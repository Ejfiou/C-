namespace HomeWork04_02
{
    partial class FrmOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblUnitl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblNums = new System.Windows.Forms.Label();
            this.lblNuml = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(99, 64);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(92, 21);
            this.txtNum.TabIndex = 13;
            // 
            // lblUnitl
            // 
            this.lblUnitl.AutoSize = true;
            this.lblUnitl.Location = new System.Drawing.Point(57, 97);
            this.lblUnitl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitl.Name = "lblUnitl";
            this.lblUnitl.Size = new System.Drawing.Size(41, 12);
            this.lblUnitl.TabIndex = 11;
            this.lblUnitl.Text = "单位：";
            this.lblUnitl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "商品数量：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "商品名字：";
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(62, 155);
            this.btnOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(66, 26);
            this.btnOut.TabIndex = 16;
            this.btnOut.Text = "确定";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(99, 30);
            this.cboName.Margin = new System.Windows.Forms.Padding(2);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(92, 20);
            this.cboName.TabIndex = 17;
            this.cboName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(102, 97);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(0, 12);
            this.lblUnit.TabIndex = 18;
            // 
            // lblNums
            // 
            this.lblNums.AutoSize = true;
            this.lblNums.Location = new System.Drawing.Point(105, 124);
            this.lblNums.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNums.Name = "lblNums";
            this.lblNums.Size = new System.Drawing.Size(0, 12);
            this.lblNums.TabIndex = 20;
            // 
            // lblNuml
            // 
            this.lblNuml.AutoSize = true;
            this.lblNuml.Location = new System.Drawing.Point(60, 124);
            this.lblNuml.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuml.Name = "lblNuml";
            this.lblNuml.Size = new System.Drawing.Size(41, 12);
            this.lblNuml.TabIndex = 19;
            this.lblNuml.Text = "库存：";
            this.lblNuml.Visible = false;
            // 
            // FrmOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 192);
            this.Controls.Add(this.lblNums);
            this.Controls.Add(this.lblNuml);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblUnitl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmOut";
            this.Text = "出库";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblUnitl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblNums;
        private System.Windows.Forms.Label lblNuml;
    }
}
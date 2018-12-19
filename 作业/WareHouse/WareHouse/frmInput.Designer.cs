namespace WareHouse
{
    partial class frmInput
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
            this.btnAddFoods = new System.Windows.Forms.Button();
            this.cboFoodsName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFoodsNum = new System.Windows.Forms.TextBox();
            this.txtFoodsUnit = new System.Windows.Forms.TextBox();
            this.lblFoodsUnit = new System.Windows.Forms.Label();
            this.lblFoodsNum = new System.Windows.Forms.Label();
            this.lblFoodsName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFoods
            // 
            this.btnAddFoods.Location = new System.Drawing.Point(46, 219);
            this.btnAddFoods.Name = "btnAddFoods";
            this.btnAddFoods.Size = new System.Drawing.Size(75, 23);
            this.btnAddFoods.TabIndex = 4;
            this.btnAddFoods.Text = "添加";
            this.btnAddFoods.UseVisualStyleBackColor = true;
            this.btnAddFoods.Click += new System.EventHandler(this.btnAddFoods_Click);
            // 
            // cboFoodsName
            // 
            this.cboFoodsName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboFoodsName.FormattingEnabled = true;
            this.cboFoodsName.Location = new System.Drawing.Point(116, 42);
            this.cboFoodsName.Name = "cboFoodsName";
            this.cboFoodsName.Size = new System.Drawing.Size(138, 20);
            this.cboFoodsName.TabIndex = 1;
            this.cboFoodsName.Leave += new System.EventHandler(this.cboFoodsName_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(179, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFoodsNum
            // 
            this.txtFoodsNum.Location = new System.Drawing.Point(116, 92);
            this.txtFoodsNum.Name = "txtFoodsNum";
            this.txtFoodsNum.Size = new System.Drawing.Size(138, 21);
            this.txtFoodsNum.TabIndex = 2;
            // 
            // txtFoodsUnit
            // 
            this.txtFoodsUnit.Location = new System.Drawing.Point(116, 145);
            this.txtFoodsUnit.Name = "txtFoodsUnit";
            this.txtFoodsUnit.Size = new System.Drawing.Size(138, 21);
            this.txtFoodsUnit.TabIndex = 3;
            // 
            // lblFoodsUnit
            // 
            this.lblFoodsUnit.AutoSize = true;
            this.lblFoodsUnit.Location = new System.Drawing.Point(44, 148);
            this.lblFoodsUnit.Name = "lblFoodsUnit";
            this.lblFoodsUnit.Size = new System.Drawing.Size(41, 12);
            this.lblFoodsUnit.TabIndex = 2;
            this.lblFoodsUnit.Text = "单位：";
            // 
            // lblFoodsNum
            // 
            this.lblFoodsNum.AutoSize = true;
            this.lblFoodsNum.Location = new System.Drawing.Point(44, 101);
            this.lblFoodsNum.Name = "lblFoodsNum";
            this.lblFoodsNum.Size = new System.Drawing.Size(41, 12);
            this.lblFoodsNum.TabIndex = 1;
            this.lblFoodsNum.Text = "数量：";
            // 
            // lblFoodsName
            // 
            this.lblFoodsName.AutoSize = true;
            this.lblFoodsName.Location = new System.Drawing.Point(44, 42);
            this.lblFoodsName.Name = "lblFoodsName";
            this.lblFoodsName.Size = new System.Drawing.Size(41, 12);
            this.lblFoodsName.TabIndex = 0;
            this.lblFoodsName.Text = "名称：";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmInput
            // 
            this.AcceptButton = this.btnAddFoods;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 283);
            this.Controls.Add(this.cboFoodsName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddFoods);
            this.Controls.Add(this.txtFoodsNum);
            this.Controls.Add(this.txtFoodsUnit);
            this.Controls.Add(this.lblFoodsUnit);
            this.Controls.Add(this.lblFoodsNum);
            this.Controls.Add(this.lblFoodsName);
            this.Name = "frmInput";
            this.Text = "增加物品";
            this.Load += new System.EventHandler(this.frmInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFoodsName;
        private System.Windows.Forms.Label lblFoodsNum;
        private System.Windows.Forms.Label lblFoodsUnit;
        private System.Windows.Forms.TextBox txtFoodsUnit;
        private System.Windows.Forms.TextBox txtFoodsNum;
        private System.Windows.Forms.Button btnAddFoods;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboFoodsName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
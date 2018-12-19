namespace HomeWork04_02
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.入库ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.出库ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查询商品ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入库ToolStripMenuItem1,
            this.出库ToolStripMenuItem1,
            this.查询商品ToolStripMenuItem1,
            this.注销ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(456, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 入库ToolStripMenuItem1
            // 
            this.入库ToolStripMenuItem1.Name = "入库ToolStripMenuItem1";
            this.入库ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.入库ToolStripMenuItem1.Text = "入库";
            this.入库ToolStripMenuItem1.Click += new System.EventHandler(this.入库ToolStripMenuItem_Click);
            // 
            // 出库ToolStripMenuItem1
            // 
            this.出库ToolStripMenuItem1.Name = "出库ToolStripMenuItem1";
            this.出库ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.出库ToolStripMenuItem1.Text = "出库";
            this.出库ToolStripMenuItem1.Click += new System.EventHandler(this.出库ToolStripMenuItem_Click);
            // 
            // 查询商品ToolStripMenuItem1
            // 
            this.查询商品ToolStripMenuItem1.Name = "查询商品ToolStripMenuItem1";
            this.查询商品ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.查询商品ToolStripMenuItem1.Text = "查询商品";
            this.查询商品ToolStripMenuItem1.Click += new System.EventHandler(this.查询商品ToolStripMenuItem_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.注销ToolStripMenuItem.Text = "注销";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 259);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMain";
            this.Text = "仓库管理界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 入库ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 出库ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查询商品ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
    }
}
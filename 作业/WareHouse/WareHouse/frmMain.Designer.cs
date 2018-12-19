namespace WareHouse
{
    partial class frmMain
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
            this.出库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.显示所有物品信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTree = new System.Windows.Forms.ToolStripMenuItem();
            this.所有信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.出库ToolStripMenuItem,
            this.出库ToolStripMenuItem2,
            this.显示所有物品信息ToolStripMenuItem,
            this.所有信息查询ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 出库ToolStripMenuItem
            // 
            this.出库ToolStripMenuItem.Name = "出库ToolStripMenuItem";
            this.出库ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.出库ToolStripMenuItem.Text = "入库";
            this.出库ToolStripMenuItem.Click += new System.EventHandler(this.入库ToolStripMenuItem_Click);
            // 
            // 出库ToolStripMenuItem2
            // 
            this.出库ToolStripMenuItem2.Name = "出库ToolStripMenuItem2";
            this.出库ToolStripMenuItem2.Size = new System.Drawing.Size(44, 21);
            this.出库ToolStripMenuItem2.Text = "出库";
            this.出库ToolStripMenuItem2.Click += new System.EventHandler(this.出库ToolStripMenuItem_Click);
            // 
            // 显示所有物品信息ToolStripMenuItem
            // 
            this.显示所有物品信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiList,
            this.tsmiView,
            this.tsmiTree});
            this.显示所有物品信息ToolStripMenuItem.Name = "显示所有物品信息ToolStripMenuItem";
            this.显示所有物品信息ToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.显示所有物品信息ToolStripMenuItem.Text = "显示所有货物信息";
            this.显示所有物品信息ToolStripMenuItem.Click += new System.EventHandler(this.显示所有物品信息ToolStripMenuItem_Click);
            // 
            // tsmiList
            // 
            this.tsmiList.Name = "tsmiList";
            this.tsmiList.Size = new System.Drawing.Size(153, 22);
            this.tsmiList.Text = "ListBox显示";
            this.tsmiList.Click += new System.EventHandler(this.tsmiList_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(153, 22);
            this.tsmiView.Text = "ListView显示";
            this.tsmiView.Click += new System.EventHandler(this.tsmiView_Click);
            // 
            // tsmiTree
            // 
            this.tsmiTree.Name = "tsmiTree";
            this.tsmiTree.Size = new System.Drawing.Size(153, 22);
            this.tsmiTree.Text = "TreeView显示";
            this.tsmiTree.Click += new System.EventHandler(this.tsmiTree_Click);
            // 
            // 所有信息查询ToolStripMenuItem
            // 
            this.所有信息查询ToolStripMenuItem.Name = "所有信息查询ToolStripMenuItem";
            this.所有信息查询ToolStripMenuItem.Size = new System.Drawing.Size(140, 21);
            this.所有信息查询ToolStripMenuItem.Text = "按货物名查询货物信息";
            this.所有信息查询ToolStripMenuItem.Click += new System.EventHandler(this.所有信息查询ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "注销";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 437);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "frmMain";
            this.Text = "仓库管理系统";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 出库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 所有信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示所有物品信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiList;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiTree;
    }
}
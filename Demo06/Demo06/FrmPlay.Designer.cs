namespace Demo06
{
    partial class FrmPlay
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
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBall = new System.Windows.Forms.Label();
            this.lblBoard = new System.Windows.Forms.Label();
            this.lblBoardTarget = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConnect,
            this.tsmiStart});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // tsmiConnect
            // 
            this.tsmiConnect.Name = "tsmiConnect";
            this.tsmiConnect.Size = new System.Drawing.Size(152, 22);
            this.tsmiConnect.Text = "连接";
            this.tsmiConnect.Click += new System.EventHandler(this.tsmiConnect_Click);
            // 
            // tsmiStart
            // 
            this.tsmiStart.Name = "tsmiStart";
            this.tsmiStart.Size = new System.Drawing.Size(152, 22);
            this.tsmiStart.Text = "开始";
            this.tsmiStart.Click += new System.EventHandler(this.tsmiStart_Click);
            // 
            // lblBall
            // 
            this.lblBall.AutoSize = true;
            this.lblBall.Location = new System.Drawing.Point(35, 261);
            this.lblBall.Name = "lblBall";
            this.lblBall.Size = new System.Drawing.Size(17, 12);
            this.lblBall.TabIndex = 1;
            this.lblBall.Text = "●";
            // 
            // lblBoard
            // 
            this.lblBoard.BackColor = System.Drawing.Color.Black;
            this.lblBoard.Location = new System.Drawing.Point(35, 498);
            this.lblBoard.Name = "lblBoard";
            this.lblBoard.Size = new System.Drawing.Size(122, 15);
            this.lblBoard.TabIndex = 2;
            this.lblBoard.Text = "label1";
            // 
            // lblBoardTarget
            // 
            this.lblBoardTarget.BackColor = System.Drawing.Color.Black;
            this.lblBoardTarget.Location = new System.Drawing.Point(35, 47);
            this.lblBoardTarget.Name = "lblBoardTarget";
            this.lblBoardTarget.Size = new System.Drawing.Size(122, 15);
            this.lblBoardTarget.TabIndex = 3;
            this.lblBoardTarget.Text = "label1";
            // 
            // FrmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 576);
            this.Controls.Add(this.lblBoardTarget);
            this.Controls.Add(this.lblBoard);
            this.Controls.Add(this.lblBall);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPlay";
            this.Text = "FrmPlay";
            this.Load += new System.EventHandler(this.FrmPlay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPlay_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiConnect;
        private System.Windows.Forms.ToolStripMenuItem tsmiStart;
        private System.Windows.Forms.Label lblBall;
        private System.Windows.Forms.Label lblBoard;
        private System.Windows.Forms.Label lblBoardTarget;
    }
}
﻿namespace Demo06
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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnClientTCP = new System.Windows.Forms.Button();
            this.btnServerTCP = new System.Windows.Forms.Button();
            this.btnP2P = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(25, 25);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(88, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "创建套接字";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(25, 65);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(75, 23);
            this.btnServer.TabIndex = 1;
            this.btnServer.Text = "服务端";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(126, 65);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(75, 23);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "客户端";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnClientTCP
            // 
            this.btnClientTCP.Location = new System.Drawing.Point(126, 114);
            this.btnClientTCP.Name = "btnClientTCP";
            this.btnClientTCP.Size = new System.Drawing.Size(75, 23);
            this.btnClientTCP.TabIndex = 4;
            this.btnClientTCP.Text = "客户端TCP";
            this.btnClientTCP.UseVisualStyleBackColor = true;
            this.btnClientTCP.Click += new System.EventHandler(this.btnClientTCP_Click);
            // 
            // btnServerTCP
            // 
            this.btnServerTCP.Location = new System.Drawing.Point(25, 114);
            this.btnServerTCP.Name = "btnServerTCP";
            this.btnServerTCP.Size = new System.Drawing.Size(75, 23);
            this.btnServerTCP.TabIndex = 3;
            this.btnServerTCP.Text = "服务端TCP";
            this.btnServerTCP.UseVisualStyleBackColor = true;
            this.btnServerTCP.Click += new System.EventHandler(this.btnServerTCP_Click);
            // 
            // btnP2P
            // 
            this.btnP2P.Location = new System.Drawing.Point(25, 167);
            this.btnP2P.Name = "btnP2P";
            this.btnP2P.Size = new System.Drawing.Size(75, 23);
            this.btnP2P.TabIndex = 5;
            this.btnP2P.Text = "P2P";
            this.btnP2P.UseVisualStyleBackColor = true;
            this.btnP2P.Click += new System.EventHandler(this.btnP2P_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(126, 167);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "P2PPlay";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnP2P);
            this.Controls.Add(this.btnClientTCP);
            this.Controls.Add(this.btnServerTCP);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnClientTCP;
        private System.Windows.Forms.Button btnServerTCP;
        private System.Windows.Forms.Button btnP2P;
        private System.Windows.Forms.Button btnPlay;
    }
}

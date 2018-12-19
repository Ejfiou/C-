using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Demo06
{
    public partial class FrmP2P : Form
    {
        public FrmP2P()
        {
            InitializeComponent();
        }

        private TcpListener server = null;
        private TcpClient client = null;
        private StreamWriter sayStreamWriter = null;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                return;
            }

            IPAddress address = IPAddress.Any;
            int port = Convert.ToInt32(this.txtLocalPort.Text.Trim());
            IPEndPoint point = new IPEndPoint(address, port);
            server = new TcpListener(point);
            server.Start();

            MessageBox.Show("服务端已经开启");
            this.btnStart.Enabled = false;

            Task.Run(() =>
            {
                while (true)
                {
                    Socket clientSocket = server.AcceptSocket();

                    NetworkStream stream = new NetworkStream(clientSocket);
                    StreamReader reader = new StreamReader(stream);
                    StreamWriter writer = new StreamWriter(stream);

                    //告知客户端连接结果
                    string msg = "恭喜您！连接成功！";
                    writer.WriteLine(msg);
                    writer.Flush();

                    //接收消息
                    Task.Run(() =>
                    {
                        while (true)
                        {
                            string msgReceive = reader.ReadLine();
                            //MessageBox.Show(msgReceive);
                            this.txtContent.AppendText("对方说：" + msgReceive + "\n");
                        }
                    });
                }
            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                {
                    return;
                }

                IPAddress address = IPAddress.Parse(this.txtRemoteIPAddress.Text.Trim());
                int port = int.Parse(this.txtRemotePort.Text.Trim());
                IPEndPoint point = new IPEndPoint(address, port);
                client = new TcpClient();
                client.Connect(point);

                Task.Run(() =>
                {
                    NetworkStream stream = client.GetStream();
                    StreamReader reader = new StreamReader(stream);
                    //StreamWriter writer = new StreamWriter(stream);
                    sayStreamWriter = new StreamWriter(stream);

                    string msgReceive = reader.ReadLine();
                    if (msgReceive == "恭喜您！连接成功！")
                    {
                        this.btnConnect.Enabled = false;
                    }
                    MessageBox.Show(msgReceive);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtSay.Text.Trim()))
            {
                MessageBox.Show("不能为空！");
                return;
            }

            if ((client != null) && (client.Connected == true))
            {
                if (sayStreamWriter != null)
                {
                    sayStreamWriter.WriteLine(this.txtSay.Text.Trim());
                    sayStreamWriter.Flush();

                    this.txtContent.AppendText("自己说：" + this.txtSay.Text.Trim() + "\n");
                    this.txtSay.Clear();
                }
            }
        }
    }
}

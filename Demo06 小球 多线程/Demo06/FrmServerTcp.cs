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
    public partial class FrmServerTcp : Form
    {
        public FrmServerTcp()
        {
            InitializeComponent();
        }

        private TcpListener server = null;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                return;
            }

            IPAddress address = IPAddress.Any;
            int port = Convert.ToInt32(this.txtPort.Text.Trim());
            IPEndPoint point = new IPEndPoint(address, port);
            server = new TcpListener(point);
            server.Start();

            MessageBox.Show("服务端已经开启");
            this.btnStart.Enabled = false;

            Task.Run(()=> {
                while (true)
                {
                    Socket clientSocket = server.AcceptSocket();
                    this.lstClient.Items.Add(clientSocket.RemoteEndPoint);

                    NetworkStream stream = new NetworkStream(clientSocket);
                    StreamReader reader = new StreamReader(stream);
                    StreamWriter writer = new StreamWriter(stream);

                    //告知客户端连接结果
                    string msg = "恭喜您！连接成功！";
                    writer.WriteLine(msg);
                    writer.Flush();
                    
                    //接收消息
                    Task.Run(()=> {
                        while (true)
                        {
                            string msgReceive = reader.ReadLine();
                            string who = msgReceive.Split(';')[0];
                            string msgContent = msgReceive.Split(';')[1];
                            this.txtClientContent.AppendText(clientSocket.RemoteEndPoint + "说：" + msgContent + "\n");
                        }
                    });
                }
            });
        }
    }
}

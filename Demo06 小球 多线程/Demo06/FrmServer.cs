using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Demo06
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
        }

        private Socket s = null;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (s != null)
            {
                return;
            }
            
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPAddress address = new IPAddress(new byte[] { 192, 168, 20, 51 });
            IPAddress address = IPAddress.Any;
            //int port = 8888;
            int port = Convert.ToInt32(this.txtPort.Text.Trim());
            IPEndPoint point = new IPEndPoint(address, port);
            s.Bind(point);
            s.Listen(100); 

            MessageBox.Show("服务端已经开启");
            this.btnStart.Enabled = false;

            Dictionary<string,Socket> dic = new Dictionary<string,Socket>();
            Task.Run(()=> {
                while (true)
                {
                    Socket clientSocket = s.Accept();
                    //MessageBox.Show($"连接成功！客户端的Ip地址{clientSocket.RemoteEndPoint.ToString()}");
                    this.lstClient.Items.Add(clientSocket.RemoteEndPoint);
                    //让ListBox自动滚动到底部 
                    lstClient.TopIndex = lstClient.Items.Count - (int)(lstClient.Height / lstClient.ItemHeight);
                    dic.Add(clientSocket.RemoteEndPoint.ToString(), clientSocket);

                    //告知客户端连接结果
                    string msg = "恭喜您！连接成功！";
                    byte[] msgBytes = Encoding.UTF8.GetBytes(msg);
                    clientSocket.Send(msgBytes);

                    //接收消息
                    Task.Run(() => {
                        while (true)
                        {
                            byte[] msgBytesReceive = new byte[clientSocket.ReceiveBufferSize];
                            int realBytesNumReceive = clientSocket.Receive(msgBytesReceive);
                            string msgReceive = Encoding.UTF8.GetString(msgBytesReceive, 0, realBytesNumReceive);
                            string who = msgReceive.Split(';')[0];
                            string msgContent = msgReceive.Split(';')[1];
                            if (who == "close")
                            {
                                break;
                            }
                            //MessageBox.Show(msgReceive);
                            this.txtClientContent.AppendText(clientSocket.RemoteEndPoint + "说：" + msgContent + "\n");

                            //得到发送对方客户端的Socket
                            Socket targetSocket = dic[who];
                            if (targetSocket != null && targetSocket.Connected == true)
                            {
                                targetSocket.Send(Encoding.UTF8.GetBytes(clientSocket.RemoteEndPoint + "说：" + msgContent));
                            }
                        }

                        this.lstClient.Items.Remove(clientSocket.RemoteEndPoint);
                        dic.Remove(clientSocket.RemoteEndPoint.ToString());
                        clientSocket.Close();
                    });
                }
            });
        }

        private void FrmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (s != null)
            {
                s.Close();
            }
        }
    }
}
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

namespace Demo06
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private Socket s = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (s != null)
                {
                    return;
                }

                s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //IPAddress address = new IPAddress(new byte[] { 192, 168, 20, 51 });
                IPAddress address = IPAddress.Parse(this.txtIPAddress.Text.Trim());
                //int port = 8888;
                int port = int.Parse(this.txtPort.Text.Trim());
                EndPoint point = new IPEndPoint(address, port);
                s.Connect(point);

                Task.Run(()=> {
                    byte[] msgBytesReceive = new byte[s.ReceiveBufferSize];
                    int realBytesNumReceive = s.Receive(msgBytesReceive);
                    string msgReceive = Encoding.UTF8.GetString(msgBytesReceive, 0, realBytesNumReceive);
                    if (msgReceive == "恭喜您！连接成功！")
                    {
                        this.btnConnect.Enabled = false;
                    }
                    MessageBox.Show(msgReceive);

                    //接收消息
                    Task.Run(() => {
                        while (true)
                        {
                            byte[] msgBytesReceive1 = new byte[s.ReceiveBufferSize];
                            int realBytesNumReceive1 = s.Receive(msgBytesReceive1);
                            string msgReceive1 = Encoding.UTF8.GetString(msgBytesReceive1, 0, realBytesNumReceive1);
                            //MessageBox.Show(msgReceive1);
                            this.txtClientContent.AppendText(msgReceive1 + "\n"); 
                        }
                    });
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if ((s != null) && (s.Connected == true))
            {
                string who = this.txtTargetClient.Text.Trim();
                string msg = this.txtContent.Text.Trim();
                byte[] msgBytes = Encoding.UTF8.GetBytes(who + ";" + msg);
                s.Send(msgBytes);
            }
        }

        private void FrmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((s != null) && (s.Connected == true))
            {
                string who = "close";
                string msg = this.txtContent.Text.Trim();
                byte[] msgBytes = Encoding.UTF8.GetBytes(who + ";" + msg);
                s.Send(msgBytes);

                s.Close();
            }

            if (s != null)
            {
                s.Close();
            }
        }
    }
}

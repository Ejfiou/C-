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
namespace Class_03_09
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //IPAddress address = new IPAddress(new byte[] { 192, 168, 20, 237 });
                IPAddress address = IPAddress.Any;

                int port = Convert.ToInt32(txtPort.Text.Trim());

                EndPoint point = new IPEndPoint(address, port);
                s.Bind(point);
                s.Listen(1000);

                MessageBox.Show("服务端已开启");

                Task.Run(() => {
                    while (true)
                    {
                        Socket clientSocket = s.Accept();
                        //MessageBox.Show($"连接成功！客户端的Ip地址{clientSocket.RemoteEndPoint.ToString()}");
                        //lstClient.Items.Add(clientSocket.RemoteEndPoint.ToString());
                        string msg = "恭喜您！连接成功！";
                        byte[] msgBytes = Encoding.UTF8.GetBytes(msg);
                        clientSocket.Send(msgBytes);
                    }
                });
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}

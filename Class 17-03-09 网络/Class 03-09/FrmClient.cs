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
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //IPAddress address = new IPAddress(new byte[] { 192, 168, 20, 237 });
                IPAddress address = IPAddress.Parse(txtIp.Text.Trim());

                //int port = 8888;

                int port = int.Parse(txtPort.Text.Trim());

                EndPoint point = new IPEndPoint(address, port);
                s.Connect(point);

                byte[] msgBytes = new byte[10000];
                int realBytesNum = s.Receive(msgBytes);
                string msg = Encoding.UTF8.GetString(msgBytes, 0,realBytesNum);
                MessageBox.Show(msg);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}

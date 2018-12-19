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
    public partial class FrmClientTcp : Form
    {
        public FrmClientTcp()
        {
            InitializeComponent();
        }

        private TcpClient client = null;
        private StreamWriter writer = null;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                {
                    return;
                }

                IPAddress address = IPAddress.Parse(this.txtIPAddress.Text.Trim());
                int port = int.Parse(this.txtPort.Text.Trim());
                IPEndPoint point = new IPEndPoint(address, port);
                client = new TcpClient();
                client.Connect(point);

                Task.Run(() =>
                {
                    NetworkStream stream = client.GetStream();
                    StreamReader reader = new StreamReader(stream);
                    writer = new StreamWriter(stream);

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

        private void btnSend_Click(object sender, EventArgs e)
        {
            if ((client != null) && (client.Connected == true))
            {
                string who = this.txtTargetClient.Text.Trim();
                string msg = this.txtContent.Text.Trim();
                if (writer != null)
                {
                    writer.WriteLine(who + ";" + msg);
                    writer.Flush();
                }
            }
        }
    }
}

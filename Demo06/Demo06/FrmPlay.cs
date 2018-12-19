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
using System.Threading;

namespace Demo06
{
    public partial class FrmPlay : Form
    {
        public FrmPlay()
        {
            InitializeComponent();
        }

        private TcpListener server = null;
        private TcpClient client = null;
        private StreamWriter xStreamWriter = null;

        private void FrmPlay_Load(object sender, EventArgs e)
        {
            if (server != null)
            {
                return;
            }

            IPAddress address = IPAddress.Any;
            //int port = 8888;
            //IPEndPoint point = new IPEndPoint(address, port);
            FrmDialog dia = new FrmDialog();
            dia.ShowDialog();
            IPEndPoint point = new IPEndPoint(address, dia.point.Port);
            server = new TcpListener(point);
            server.Start();

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
                            int x;
                            bool flag = int.TryParse(msgReceive, out x);
                            if (flag)
                            {
                                this.lblBoardTarget.Location = new Point(x, this.lblBoardTarget.Location.Y);
                            }
                            else
                            {
                                if (msgReceive == "start")
                                {
                                    MyPlay();
                                }
                            }
                        }
                    });
                }
            });
        }

        private void tsmiConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                {
                    return;
                }

                //IPAddress address = IPAddress.Parse(this.txtRemoteIPAddress.Text.Trim());
                //int port = int.Parse(this.txtRemotePort.Text.Trim());
                //IPEndPoint point = new IPEndPoint(address, port);
                FrmDialog dia = new FrmDialog();
                dia.ShowDialog();
                IPEndPoint point = dia.point;
                client = new TcpClient();
                client.Connect(point);

                Task.Run(() =>
                {
                    NetworkStream stream = client.GetStream();
                    StreamReader reader = new StreamReader(stream);
                    //StreamWriter writer = new StreamWriter(stream);
                    xStreamWriter = new StreamWriter(stream);

                    string msgReceive = reader.ReadLine();
                    //if (msgReceive == "恭喜您！连接成功！")
                    //{
                    //    this.tsmiStart.Enabled = false;
                    //}
                    MessageBox.Show(msgReceive);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsmiStart_Click(object sender, EventArgs e)
        {
            if ((client != null) && (client.Connected == true))
            {
                if (xStreamWriter != null)
                {
                    xStreamWriter.WriteLine("start");
                    xStreamWriter.Flush();
                    MyPlay();
                }
            }
        }

        void MyPlay()
        {
            Task.Run(()=> {
                while (true)
                {
                    Point newPoint = this.lblBall.Location;
                    newPoint.X = newPoint.X + 1;
                    newPoint.Y = newPoint.Y + 1;
                    this.lblBall.Location = newPoint;

                    Thread.Sleep(100);
                }
            });
        }

        private void FrmPlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (this.lblBoard.Location.X > 0)
                {
                    this.lblBoard.Location = new Point(this.lblBoard.Location.X - 10, this.lblBoard.Location.Y);
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (this.lblBoard.Location.X + this.lblBoard.Width < this.ClientSize.Width)
                {
                    this.lblBoard.Location = new Point(this.lblBoard.Location.X + 10, this.lblBoard.Location.Y);
                }
            }

            if ((client != null) && (client.Connected == true))
            {
                if (xStreamWriter != null)
                {
                    xStreamWriter.WriteLine(this.lblBoard.Location.X);
                    xStreamWriter.Flush();
                }
            }
        }
    }
}

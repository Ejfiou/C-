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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            FrmServer f = new FrmServer();
            f.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FrmClient f = new FrmClient();
            f.Show();
        }

        private void btnServerTCP_Click(object sender, EventArgs e)
        {
            FrmServerTcp f = new FrmServerTcp();
            f.Show();
        }

        private void btnClientTCP_Click(object sender, EventArgs e)
        {
            FrmClientTcp f = new FrmClientTcp();
            f.Show();
        }

        private void btnP2P_Click(object sender, EventArgs e)
        {
            FrmP2P f = new FrmP2P();
            f.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            FrmPlay f = new FrmPlay();
            f.Show();
        }
    }
}

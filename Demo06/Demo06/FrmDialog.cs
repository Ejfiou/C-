using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo06
{
    public partial class FrmDialog : Form
    {
        public FrmDialog()
        {
            InitializeComponent();
        }

        public IPEndPoint point = null;

        private void btnOK_Click(object sender, EventArgs e)
        {
            IPAddress address = IPAddress.Parse(this.txtRemoteIPAddress.Text.Trim());
            int port = int.Parse(this.txtRemotePort.Text.Trim());
            point = new IPEndPoint(address, port);

            this.Close();
        }
    }
}

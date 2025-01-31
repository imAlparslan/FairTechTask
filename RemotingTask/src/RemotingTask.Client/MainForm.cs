using RemotingTask.RemoteObjects;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using System.Windows.Forms;

namespace RemotingTask.Client
{
    public partial class MainForm : Form
    {
        private IProductService _productService;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // conf dosyasından okunacak
            TcpClientChannel tcpClient = new TcpClientChannel();
            ChannelServices.RegisterChannel(tcpClient, false);
            _productService = (IProductService)Activator.GetObject(typeof(IProductService), "tcp://localhost:1234/ProductService"
            );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            var msg = msg_textbox.Text;
            var result = _productService.Test(msg);
            responseLabel.Text = result;
            responseLabel.Visible = true;
        }

        private void responseLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

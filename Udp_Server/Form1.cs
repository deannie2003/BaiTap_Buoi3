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
using System.Text;

namespace Udp_Server
{

    public partial class Server : Form
    {
        private UdpClient server_socket;
        private BackgroundWorker worker;

        public Server()
        {
            InitializeComponent();
            // tạo UDP client cho Server và bind nó tới cổng port 12345
            server_socket = new UdpClient(12345);
            // tạo background worker để liên tục nhận tin nhắn từ client
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerAsync();
        }

        private async void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var _worker = sender as BackgroundWorker;
            while (!_worker.CancellationPending)
            {
                try
                {
                    var result = await server_socket.ReceiveAsync();
                    // nhận endpoint từ client ( gồm địa chỉ IP và cổng port ) 
                    var remoteEndPoint = result.RemoteEndPoint;
                    // nhận tin nhắn từ client
                    var buffer = result.Buffer;
                    // chuyển tin nhắn về dạng string 
                    var message = Encoding.UTF8.GetString(buffer);
                    // hiển thị tin nhắn
                    Invoke((MethodInvoker) delegate {
                        Output_Server.Items.Add(remoteEndPoint.ToString() + ": " + message);
                    });
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void gui_Click(object sender, EventArgs e)
        {
        }
    }
}

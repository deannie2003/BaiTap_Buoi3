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

namespace Udp_Client
{
    public partial class Client : Form
    {
        private Socket client_socket;
        private IPEndPoint server_endpoint;
        public Client()
        {
            InitializeComponent();

            // tạo Endpoint chứa địa chỉ IP address sever và cổng port
            server_endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            // tạo UDP socket cho Client
            client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            client_socket.EnableBroadcast = true;
        }

        private void gui_Click(object sender, EventArgs e)
        {
            try
            {
                // nhận tin nhắn 
                string tn_gui = Input_Client.Text;

                // chuyển tin nhắn từ dạng string sang dạng byte 
                byte[] byte_input_client = Encoding.UTF8.GetBytes(tn_gui);

                // gửi tin nhắn cho sever 
                client_socket.SendTo(byte_input_client, server_endpoint);

                // hiển thị tin nhẵn vừa gửi 
                Output_Client.Items.Add("Client : " + tn_gui);

                Output_Client.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dong_Click(object sender, EventArgs e)
        {
            client_socket.Close();
            Application.Exit();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void Output_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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

namespace TCP_ServerClient_App
{
    public partial class ClientForm : Form
    {
        TcpClient client; //initialising client obeject to represent the connection to the server which allow us to read and writedata and manage connection state.
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(PortTextBox.Text, out int port)) 
                {
                    MessageBox.Show("Please enter a valid port number."); //pop up dialogue not text box show
                    return;
                }
                if (port < 1024)
                {
                    MessageBox.Show("Please enter a port number greater than 1024 to avoid conflict with Privileged Ports!");  //reference from Beej's Network Programming
                    return;
                }
                client = new TcpClient(); //create a connection to the server using the TcpClient class
                client.Connect(IPAddress.Parse(ServerIPTextBox.Text), port); //connect to the server using the IP address and port number specified by the user. This method blocks until the connection is established or fails.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {

        }
    }
}

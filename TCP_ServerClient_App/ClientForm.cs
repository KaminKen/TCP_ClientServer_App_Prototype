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
        NetworkStream stream; //initialising channel for sending and receiving data.
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (client != null && client.Connected)
                {
                    MessageBox.Show("Already connected to a server. Please disconnect first before connecting to another server.");
                    return;
                }
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

                stream = client.GetStream(); //get the network stream associated with the client connection, which allows us to send and receive data to and from the server. This stream is used for communication between the client and server.

                LogTextBox.AppendText("Connected to server at " + ServerIPTextBox.Text + ":" + port + Environment.NewLine); //update the log text box with the connection status
                ConnectButton.Enabled = false;
                DisconnectButton.Enabled = true;
                SendButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            try 
            {
                if (client != null) 
                {
                    if (stream != null) 
                    {
                        stream.Close(); //close the network channel to free resources
                    }
                    stream = null;
                    client.Close(); //close the client connection
                    client = null;

                    ConnectButton.Enabled = true;
                    DisconnectButton.Enabled = false;
                    SendButton.Enabled = false;
                    LogTextBox.AppendText("Disconnected from server." + Environment.NewLine); //update the log to tell user that it is disconnected

                }
            } 
            catch 
            {
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try 
            {
                if (client == null || !client.Connected) 
                {
                    MessageBox.Show("Not connected to server.");
                    return;
                }
                if (stream == null) 
                {
                    MessageBox.Show("Network stream is not available.");
                    return;
                }

                string msg = MessageTextBox.Text; //get the message from the text box

                if (string.IsNullOrWhiteSpace(msg))
                {
                    MessageBox.Show("Please enter a message to send.");
                    return;
                }

                byte[] data = Encoding.UTF8.GetBytes(msg); //convert the message to bytes using UTF-8 encoding
                stream.Write(data, 0, data.Length); //send bytes to the server
                LogTextBox.AppendText("Sent: " + msg + Environment.NewLine); //update the log with the sent message
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {

        }
    }
}

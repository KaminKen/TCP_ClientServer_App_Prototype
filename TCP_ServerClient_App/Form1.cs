using System;
using System.Linq.Expressions;

//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_ServerClient_App
{
    public partial class Form1 : Form
    {

        TcpListener server; //represent bind and listen socket in one class, which is more convenient to use but less flexible than using Socket class directly, but for this simple server, it's enough
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                //int port = int.Parse(txtPort.Text); // this will fail if port is empty or not a number
                if (!int.TryParse(txtPort.Text, out int port)) 
                { 
                    MessageBox.Show("Please enter a valid port number.");
                    return;
                }
                if (port < 1024) 
                { 
                    MessageBox.Show("Please enter a port number greater than 1024 to avoid conflict with Privileged Ports!");  //reference from Beej's Network Programming
                    return;
                }
                server = new TcpListener(IPAddress.Any, port); //listen on all available network interfaces from the machine, and use the port specified by user
                server.Start(); //start listening for incoming connection requests
                txtLog.AppendText("Server started on port " + port + Environment.NewLine);

                btnStartServer.Enabled = false;
                btnStopServer.Enabled = true;

                Task.Run(() => ListenForClient());  //start a new thread to listen for client connections, so that the UI thread is not blocked and can still respond to user interactions. Or meaning it works in the background, allowing the main thread to remain responsive.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting server: " + ex.Message);
            }
            
        }

        private void ListenForClient()
        //This method runs in a separate thread and continuously listens for incoming client connections.
        //When a client connects, it accepts the connection, reads the message sent by the client, and updates the UI with the client's information and the received message.
        //The use of Invoke is necessary to update the UI from a non-UI thread.
        {
            try
            {
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient(); //This method blocks until there is connection and returns a TcpClient object that represents the connection to the client. It allows us to read from and write to the client.
                    this.Invoke((MethodInvoker)delegate
                    {
                        txtLog.AppendText("Client connected from: " + client.Client.RemoteEndPoint + Environment.NewLine);
                    });

                    NetworkStream stream = client.GetStream(); 
                    byte[] buffer = new byte[1024]; // Using [] to tell C# that this is an array, not a single byte
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    this.Invoke((MethodInvoker)delegate
                    {
                        txtLog.AppendText("Received Message: " + receivedMessage + Environment.NewLine);
                    });

                    client.Close();
                }
            }
            catch
            { 
                //if stop, finished automatically
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (server != null)
                {
                    server.Stop();
                    server = null;
                    txtLog.AppendText("Server stopped." + Environment.NewLine);
                    btnStartServer.Enabled = true;
                    btnStopServer.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                txtLog.AppendText("Error during stop: " + ex.Message + Environment.NewLine);
            }
            
        }

    
    }
}

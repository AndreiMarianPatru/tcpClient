using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Runtime.CompilerServices;

namespace tcpClient
{
    public partial class chat : Form
    {
        public chat()
        {
            InitializeComponent();
        }

        private static readonly Socket ClientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private const int PORT = 100;

        //static void Main()
        //{
        //    updateUI.Title = "Client";
        //    ConnectToServer();
        //    RequestLoop();
        //    Exit();
        //}

        private static void ConnectToServer()
        {
            int attempts = 0;

            while (!ClientSocket.Connected)
            {
                try
                {
                    attempts++;
                    updateUI("Connection attempt " + attempts);
                    // Change IPAddress.Loopback to a remote IP to connect to a remote host.
                    ClientSocket.Connect(IPAddress.Loopback, PORT);
                }
                catch (SocketException)
                {
                    updateUI("Could not connect. Retrying");
                    if (attempts == 3)
                    {
                        updateUI("Connection failed!");
                        return;
                    }
                }
            }

            updateUI("");

            updateUI("Connected");
        }

        private static void RequestLoop()
        {
           // updateUI(@"<Type ""exit"" to properly disconnect client>");

            if (ClientSocket.Connected)
            {
                SendRequest();
                ReceiveResponse();
            }
            else
            {
                updateUI("Not connected to the server");
            }
               
            
        }

        /// <summary>
        /// Close socket and exit program.
        /// </summary>
        private static void Exit()
        {
            SendString("exit"); // Tell the server we are exiting
            ClientSocket.Shutdown(SocketShutdown.Both);
            ClientSocket.Close();
            Environment.Exit(0);
        }
      
        private static void SendRequest()
        {
            updateUI("Request sent!");
            string request = Program.mchat.tChat.Text;
            SendString(request);

            if (request.ToLower() == "exit")
            {
                Exit();
            }
        }

        /// <summary>
        /// Sends a string to the server with ASCII encoding.
        /// </summary>
        private static void SendString(string text)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            ClientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private static void ReceiveResponse()
        {
            var buffer = new byte[2048];
            int received = ClientSocket.Receive(buffer, SocketFlags.None);
            if (received == 0) return;
            var data = new byte[received];
            Array.Copy(buffer, data, received);
            string text = Encoding.ASCII.GetString(data);
            updateUI(text);
        }
        private void bSend_Click(object sender, EventArgs e)
        {
            RequestLoop();
            updateUI(Program.mchat.tChat.Text);
            Program.mchat.tChat.Text = "";
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            ConnectToServer();
            
            //Exit();
        }

        private void tChat_TextChanged(object sender, EventArgs e)
        {

        }
        private static void updateUI(string text)
        {
            Program.mchat.tConsole.AppendText(text);
            Program.mchat.tConsole.AppendText(Environment.NewLine);
        }

        private void tConsole_TextChanged(object sender, EventArgs e)
        {

        }
    }

   
}

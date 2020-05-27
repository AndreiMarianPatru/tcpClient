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

namespace tcpClient
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
           // RequestLoop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private  void RequestLoop()
        {
            Console.WriteLine(@"<Type ""exit"" to properly disconnect client>");

            while (true)
            {
                SendRequest();
                ReceiveResponse();
            }
        }
        private  void Exit()
        {
            
            
            SendString("exit"); // Tell the server we are exiting
            tcpClient.FrontPage.ClientSocket.Shutdown(SocketShutdown.Both);
            tcpClient.FrontPage.ClientSocket.Close();
            Environment.Exit(0);
        }

        private  void SendRequest()
        {
            //Console.Write("Send a request: ");
            string request = textBox1.Text;
            SendString(request);

            if (request.ToLower() == "exit")
            {
                Exit();
            }
        }

        /// <summary>
        /// Sends a string to the server with ASCII encoding.
        /// </summary>
        private  void SendString(string text)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            tcpClient.FrontPage.ClientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private  void ReceiveResponse()
        {
            var buffer = new byte[2048];
            int received = tcpClient.FrontPage.ClientSocket.Receive(buffer, SocketFlags.None);
            if (received == 0) return;
            var data = new byte[received];
            Array.Copy(buffer, data, received);
            string text = Encoding.ASCII.GetString(data);
            Console.WriteLine(text);
        }

        private void bSend_Click(object sender, EventArgs e)
        {

        }
    }
}

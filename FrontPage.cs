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
    
    public partial class FrontPage : Form
    {
     
        public static  readonly Socket ClientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private const int PORT = 100;
        public FrontPage()
        {
            InitializeComponent();
           

        }
        private  void ConnectToServer()
        {
            int attempts = 0;

            while (!ClientSocket.Connected)
            {
                try
                {
                    attempts++;
                    Console.WriteLine("Connection attempt " + attempts);
                    // Change IPAddress.Loopback to a remote IP to connect to a remote host.
                    ClientSocket.Connect(IPAddress.Loopback, PORT);
                }
                catch (SocketException)
                {
                    
                }
                updateUI(attempts.ToString());
            }


            updateUI("Connected");
        }


        private void bRegister_Click(object sender, EventArgs e)
        {

        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            ConnectToServer();
            Chat f1 = new Chat();
            this.Hide();
            f1.ShowDialog();
            this.Close();
             
        }

        private void FPUsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FPPassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FPConsole_TextChanged(object sender, EventArgs e)
        {

        }
        private void updateUI(string text)
        {
            FPConsole.AppendText(text);
            FPConsole.AppendText(Environment.NewLine);
        }
    }
}

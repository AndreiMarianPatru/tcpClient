using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcpClient
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }

      

        private void bRegister_Click(object sender, EventArgs e)
        {

        }

        private void bLogin_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
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
    }
}

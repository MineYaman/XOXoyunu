using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Net.Sockets;

namespace XOXoyunu
{
    public partial class OyunSecenekleri : Form
    {
        public static void Main(string[] args)
        {
            IPAddress ip = Dns.GetHostEntry("LOCALHOST").AddressList[0];
            TcpListener server = new TcpListener(ip, 8080);
            TcpClient client = default(TcpClient);
            try
            {
                server.Start();
                Console.WriteLine("server started ....");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Read();
                //throw;
            }

            while (true)
            {
                client = server.AcceptTcpClient();

                NetworkStream stream = client.GetStream();
            }
        }

        public OyunSecenekleri()
        {
            InitializeComponent();
        }

        private void rdbtnOnePlayer_CheckedChanged(object sender, EventArgs e)
        {
            lblPlayerOne.Visible = true;
            txtPlayerOne.Visible = true;
            lblPlayerTwo.Visible = false;
            txtPlayerTwo.Visible = false;
            txtPlayerTwo.Text = "";
            btnPlay.Visible = true;
        }

        private void rdbtnTwoPlayer_CheckedChanged(object sender, EventArgs e)
        {
            lblPlayerOne.Visible = true;
            txtPlayerOne.Visible = true;
            lblPlayerTwo.Visible = true;
            txtPlayerTwo.Visible = true;
            btnPlay.Visible = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmXOX xox1 = new frmXOX();
            frmXOX.PlayerNames(txtPlayerOne.Text, txtPlayerTwo.Text);
            xox1.ShowDialog();
            this.Close();
        }

        private void txtPlayerTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                btnPlay.PerformClick();
        }
    }
}

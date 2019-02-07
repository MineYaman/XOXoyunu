using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOXoyunu
{
    public partial class OyunSecenekleri : Form
    {
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

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            OyunSecenekleri os1 = new OyunSecenekleri();
            os1.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sdfgfggfgf","XOX OYUNU HAKKINDA");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class frmXOX : Form
    {
        bool sira = true , zaman = true , avantaj = true ;   
        bool BilgisayaraKarsi = false;
        int siraSayisi = 0;
        static string player1, player2;
        int Xdakika = 0 , Xsaniye = 0 , Odakika = 0, Osaniye = 0;

        public frmXOX()
        {
            InitializeComponent();
        }
        
        public static void PlayerNames(string p1,string p2)
        {
            player1 = p1;
            player2 = p2;
        }

       public void ZamanHesapla()
        {
            if (siraSayisi % 2 == 0)
                timer1.Enabled = true;
            else
                timer2.Enabled = true;
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (sira)
                b.Text = "X";
            else
                b.Text = "O";
            sira = !sira;
            b.Enabled = false;
            btnNewGame.Enabled = true;
            siraSayisi++;

            lblOwin.Focus();
            KazananKontrol();

            if ((!sira) && BilgisayaraKarsi)
                BilgisayarOyna();
            if (siraSayisi % 2 == 0)
            {
                timer2.Stop();
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void BilgisayarOyna()
        {
            Button move = null;
            move = KazanEngelle("O");
            if(move==null)
            {
                move = KazanEngelle("X");
                if(move==null)
                {
                    move = KoseBak();
                    if(move==null)
                        move = BosAlanBak();
                }
            }
            move.PerformClick();
        }

        private Button KazanEngelle(string sayac)
        {
            if ((A1.Text == sayac) && (A2.Text == sayac) && (A3.Text == ""))
                return A3;
            if ((A2.Text == sayac) && (A3.Text == sayac) && (A1.Text == ""))
                return A1;
            if ((A3.Text == sayac) && (A1.Text == sayac) && (A2.Text == ""))
                return A2;
            if ((B1.Text == sayac) && (B2.Text == sayac) && (B3.Text == ""))
                return B3;
            if ((B2.Text == sayac) && (B3.Text == sayac) && (B1.Text == ""))
                return B1;
            if ((B3.Text == sayac) && (B1.Text == sayac) && (B2.Text == ""))
                return B2;
            if ((C1.Text == sayac) && (C2.Text == sayac) && (C3.Text == ""))
                return C3;
            if ((C2.Text == sayac) && (C3.Text == sayac) && (C1.Text == ""))
                return C1;
            if ((C3.Text == sayac) && (C1.Text == sayac) && (C2.Text == ""))
                return C2;
            if ((A1.Text == sayac) && (B1.Text == sayac) && (C1.Text == ""))
                return C1;
            if ((A1.Text == sayac) && (C1.Text == sayac) && (B1.Text == ""))
                return B1;
            if ((C1.Text == sayac) && (B1.Text == sayac) && (A1.Text == ""))
                return A1;
            if ((A2.Text == sayac) && (B2.Text == sayac) && (C2.Text == ""))
                return C2;
            if ((A2.Text == sayac) && (C2.Text == sayac) && (B2.Text == ""))
                return B2;
            if ((C2.Text == sayac) && (B2.Text == sayac) && (A2.Text == ""))
                return A2;
            if ((A3.Text == sayac) && (B3.Text == sayac) && (C3.Text == ""))
                return C3;
            if ((A3.Text == sayac) && (C3.Text == sayac) && (B3.Text == ""))
                return B3;
            if ((C3.Text == sayac) && (B3.Text == sayac) && (A3.Text == ""))
                return A3;
            if ((A1.Text == sayac) && (B2.Text == sayac) && (C3.Text == ""))
                return C3;
            if ((A1.Text == sayac) && (C3.Text == sayac) && (B2.Text == ""))
                return B2;
            if ((C3.Text == sayac) && (B2.Text == sayac) && (A1.Text == ""))
                return A1;
            if ((A3.Text == sayac) && (B2.Text == sayac) && (C1.Text == ""))
                return C1;
            if ((A3.Text == sayac) && (C1.Text == sayac) && (B2.Text == ""))
                return B2;
            if ((C1.Text == sayac) && (B3.Text == sayac) && (A3.Text == ""))
                return A3;
            return null;
        }

        private Button KoseBak()
        {
            if(A1.Text=="O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }
            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }
            if (C3.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (A1.Text == "")
                    return A1;
                if (C1.Text == "")
                    return C1;
            }
            if (C1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (A1.Text == "")
                    return A1;
            }
            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;
            return null;
        }

        private Button BosAlanBak()
        {
            if (A2.Text == "")
                return A2;
            if (B1.Text == "")
                return B1;
            if (B2.Text == "")
                return B2;
            if (B3.Text == "")
                return B3;
            if (C2.Text == "")
                return C2;
            return null;
        }

        private void KazananKontrol()
        {
            bool kazananVar = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                kazananVar = true;
                A1.BackColor = Color.LightSkyBlue;
                A2.BackColor = Color.LightSkyBlue;
                A3.BackColor = Color.LightSkyBlue;

            }
               
                
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                kazananVar = true;
                B1.BackColor = Color.LightSkyBlue;
                B2.BackColor = Color.LightSkyBlue;
                B3.BackColor = Color.LightSkyBlue;

            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                kazananVar = true;
                C1.BackColor = Color.LightSkyBlue;
                C2.BackColor = Color.LightSkyBlue;
                C3.BackColor = Color.LightSkyBlue;

            }
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                kazananVar = true;
                A1.BackColor = Color.LightSkyBlue;
                B1.BackColor = Color.LightSkyBlue;
                C1.BackColor = Color.LightSkyBlue;

            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                kazananVar = true;
                A2.BackColor = Color.LightSkyBlue;
                B2.BackColor = Color.LightSkyBlue;
                C2.BackColor = Color.LightSkyBlue;

            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                kazananVar = true;
                A3.BackColor = Color.LightSkyBlue;
                B3.BackColor = Color.LightSkyBlue;
                C3.BackColor = Color.LightSkyBlue;

            }
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                kazananVar = true;
                A1.BackColor = Color.LightSkyBlue;
                B2.BackColor = Color.LightSkyBlue;
                C3.BackColor = Color.LightSkyBlue;

            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                kazananVar = true;
                A3.BackColor = Color.LightSkyBlue;
                B2.BackColor = Color.LightSkyBlue;
                C1.BackColor = Color.LightSkyBlue;

            }
          
 
            if (kazananVar)
            {
                buttonIptal();
                String kazanan = "";
                if (sira)
                {
                    if(BilgisayaraKarsi)
                        kazanan = "COMPUTER";
                    else
                        kazanan = player2;
                    avantaj = true;
                    timer2.Dispose();
                    lblOwinCount.Text = (int.Parse(lblOwinCount.Text) + 1).ToString();
                }
                else
                {
                    kazanan = player1;
                    avantaj = false;
                    timer1.Dispose();
                    lblXwinCount.Text = (int.Parse(lblXwinCount.Text) + 1).ToString();
                }
                MessageBox.Show(kazanan + " WİNS!", "CONGRATULATIONS");
                A1.BackColor = Color.White;
                A2.BackColor = Color.White;
                A3.BackColor = Color.White;
                B1.BackColor = Color.White;
                B2.BackColor = Color.White;
                B3.BackColor = Color.White;
                C1.BackColor = Color.White;
                C2.BackColor = Color.White;
                C3.BackColor = Color.White;
                btnNewGame.PerformClick();
            }
            else
            {
                if(siraSayisi==9)
                {
                    if ((Xdakika >= Odakika) && (Xsaniye >= Osaniye))
                    {
                        if (BilgisayaraKarsi)
                            player2 = "COMPUTER";
                        MessageBox.Show(player2 + " WİNS!", "CONGRATULATIONS");
                        lblOwinCount.Text = (int.Parse(lblOwinCount.Text) + 1).ToString();
                    }
                    else if ((Odakika >= Xdakika) && (Osaniye >= Xsaniye))
                    {
                        MessageBox.Show(player1 + " WİNS!", "CONGRATULATIONS");
                        lblXwinCount.Text = (int.Parse(lblXwinCount.Text) + 1).ToString();
                    }
                    btnNewGame.PerformClick();
                }
            }
        }

        private void buttonIptal()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    btnNewGame.Enabled = true;
                    btnResetGame.Enabled = true;
                    btnStart.Enabled = true;
                }
                catch { }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            sira = true;
            zaman = true;
            siraSayisi = 0;
            if(avantaj)
            {
                Osaniye = 0;
                Xsaniye = 10;
            }
            else
            {
                Xsaniye = 0;
                Osaniye = 10;
            }
            Xdakika = 0;
            Odakika = 0;
            timer1.Enabled = false;
            timer2.Enabled = false;
            avantaj = true;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    lblXSaniye.Text = Xsaniye.ToString();
                    lblXDakika.Text = "0";
                    lblOSaniye.Text = Osaniye.ToString();
                    lblODakika.Text = "0";
                    btnNewGame.Text = "NEW GAME";
                    btnResetGame.Text = "RESET GAME";
                    btnStart.Text = "START";
                    timer1.Dispose();
                    btnStart.Enabled = true;
                    A1.Visible = false;
                    A2.Visible = false;
                    A3.Visible = false;
                    B1.Visible = false;
                    B2.Visible = false;
                    B3.Visible = false;
                    C1.Visible = false;
                    C2.Visible = false;
                    C3.Visible = false;
                }
                catch { }
            }
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Enabled)
            {
                if (sira)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void frmXOX_Load(object sender, EventArgs e)
        {
            if(player2=="")
            {
                lblXwin.Text = player1;
                lblOwin.Text = "COMPUTER";
                BilgisayaraKarsi = true;
            }
            else
            {
                lblXwin.Text = player1;
                lblOwin.Text = player2;
                BilgisayaraKarsi = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if((!zaman))
            {
                Xsaniye++;
                lblXSaniye.Text = Xsaniye.ToString();
                if (Xsaniye == 60)
                {
                    Xsaniye = 0;
                    lblXSaniye.Text = Xsaniye.ToString();
                    Xdakika++;
                    lblXDakika.Text = Xdakika.ToString();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            A1.Visible = true;
            A2.Visible = true;
            A3.Visible = true;
            B1.Visible = true;
            B2.Visible = true;
            B3.Visible = true;
            C1.Visible = true;
            C2.Visible = true;
            C3.Visible = true;
            btnStart.Enabled = false;
            timer1.Dispose();
            ZamanHesapla();
            zaman = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Osaniye++;
            lblOSaniye.Text = Osaniye.ToString();
            if (Osaniye == 60)
            {
                Osaniye = 0;
                lblOSaniye.Text = Osaniye.ToString();
                Odakika++;
                lblODakika.Text = Odakika.ToString();
            }
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            lblXwinCount.Text = "0";
            lblOwinCount.Text = "0";
            btnNewGame.PerformClick();
        }

    }
}

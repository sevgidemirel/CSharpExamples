using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class Form1 : Form
    {
        PacMan pacman = new PacMan();
        Ghost ghost = new Ghost();
        Random rnd = new Random();
        int puan = 0, can = 5;
        int xPosition = 234, yPosition = 182, xStart = 234, yStart = 182;


        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {

            engeleCarptimi();

            if (e.KeyCode == Keys.Right)
            {

                tmrSag.Start();
                tmrSol.Stop();
                tmrYukari.Stop();
                tmrAsagi.Stop();

                tmrCanavar.Start();
            }

            if (e.KeyCode == Keys.Left)
            {
                tmrSol.Start();
                tmrYukari.Stop();
                tmrAsagi.Stop();
                tmrSag.Stop();

                tmrCanavar.Start();
            }

            if (e.KeyCode == Keys.Up)
            {
                tmrYukari.Start();
                tmrSag.Stop();
                tmrSol.Stop();
                tmrAsagi.Stop();

                tmrCanavar.Start();

            }

            if (e.KeyCode == Keys.Down)
            {
                tmrAsagi.Start();
                tmrYukari.Stop();
                tmrSag.Stop();
                tmrSol.Stop();

                tmrCanavar.Start();

            }
        }



        private void tmrSag_Tick(object sender, EventArgs e)
        {



            foreach (Control c2 in this.Controls)
            {
                if (!c2.Equals(pbCanavar) && c2 is PictureBox
                && pbCanavar.Bounds.IntersectsWith(c2.Bounds))
                {
                    canavarıKonumlandır();
                    puan += 10;
                    statusPuan.Text = "Puan:" + puan.ToString();

                    tmrCanavar.Stop();
                }

            }
            pacman.SagaKay(pbPacMan);
            if (engeleCarptimi())
            {
                can--;
                caniKontrolEt();

                statusCan.Text = "Can:" + can.ToString();
                pacman.setPacMan(pbPacMan);


                tmrSag.Stop();

            }


        }



        private void tmrSol_Tick(object sender, EventArgs e)
        {


            foreach (Control c2 in this.Controls)
            {
                if (!c2.Equals(pbCanavar) && c2 is PictureBox
                && pbCanavar.Bounds.IntersectsWith(c2.Bounds))
                {

                    canavarıKonumlandır();
                    puan += 10;
                    statusPuan.Text = "Puan:" + puan.ToString();

                    tmrAsagi.Stop();
                    tmrSol.Stop();
                    tmrSag.Stop();
                    tmrYukari.Stop();

                }

            }
            pacman.SolaKay(pbPacMan);
            if (engeleCarptimi())
            {
                can--;
                caniKontrolEt();

                statusCan.Text = "Can:" + can.ToString();
                pacman.setPacMan(pbPacMan);


                tmrAsagi.Stop();
                tmrSol.Stop();
                tmrSag.Stop();
                tmrYukari.Stop();

            }

        }

        private void tmrYukari_Tick(object sender, EventArgs e)
        {



            foreach (Control c2 in this.Controls)
            {
                if (!c2.Equals(pbCanavar) && c2 is PictureBox
                && pbCanavar.Bounds.IntersectsWith(c2.Bounds))
                {

                    canavarıKonumlandır();
                    puan += 10;
                    statusPuan.Text = "Puan:" + puan.ToString();

                    tmrCanavar.Stop();

                }

            }
            pacman.YukariKay(pbPacMan);
            if (engeleCarptimi())
            {
                can--;
                caniKontrolEt();

                statusCan.Text = "Can:" + can.ToString();
                pacman.setPacMan(pbPacMan);

                tmrAsagi.Stop();
                tmrSol.Stop();
                tmrSag.Stop();
                tmrYukari.Stop();

            }

        }

        private void tmrAsagi_Tick(object sender, EventArgs e)
        {


            foreach (Control c2 in this.Controls)
            {
                if (!c2.Equals(pbCanavar) && c2 is PictureBox
                && pbCanavar.Bounds.IntersectsWith(c2.Bounds))
                {

                    canavarıKonumlandır();
                    puan += 10;
                    statusPuan.Text = "Puan:" + puan.ToString();

                    tmrCanavar.Stop();
                }

            }
            pacman.AsagiKay(pbPacMan);

            if (engeleCarptimi())
            {
                can--;
                caniKontrolEt();

                statusCan.Text = "Can:" + can.ToString();
                pacman.setPacMan(pbPacMan);

                tmrAsagi.Stop();
                tmrSol.Stop();
                tmrSag.Stop();
                tmrYukari.Stop();

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void tmrCanavar_Tick(object sender, EventArgs e)
        {
            ghost.HareketEttir(pbCanavar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pacmanOzellikleriAta();

            pacman.setPacMan(pbPacMan);

            canavarıKonumlandır();

            statusPuan.Text = "Puan:" + puan.ToString();
            statusCan.Text = "Can:" + can.ToString();


        }


        private void pacmanOzellikleriAta()
        {
            pacman.XStart = xStart;
            pacman.YStart = yStart;
            pacman.XPosition = xPosition;
            pacman.YPosition = yPosition;
            pacman.SagAcik = Properties.Resources.openPacman;
            pacman.SagKapali = Properties.Resources.closePacman;

            pacman.SolAcik = Properties.Resources.openPacman_sag;
            pacman.SolKapali = Properties.Resources.closePacman_sag;

            pacman.YukariAcik = Properties.Resources.openPacman_yukari;
            pacman.YukariKapali = Properties.Resources.closePacman_yukari;

            pacman.AsagiAcik = Properties.Resources.openPacman_asagi;
            pacman.AsagiKapali = Properties.Resources.closePacman_asagi;
        }

        private void canavarıKonumlandır()
        {
            pbCanavar.Visible = false;
            Thread.Sleep(1000);
            pbCanavar.Visible = true;
            ghost.XPosition = rnd.Next(0, 586);
            ghost.YPosition = rnd.Next(0, 355);
            ghost.setPosition(pbCanavar);
        }

        private bool engeleCarptimi()
        {
            foreach (Control c2 in this.Controls)
            {
                if (!c2.Equals(pbPacMan) && c2 is Button
                && pbPacMan.Bounds.IntersectsWith(c2.Bounds))
                {

                    return true;
                }

            }

            return false;
        }

        private void caniKontrolEt()
        {
            if (can==0)
            {
                DialogResult cikis = new DialogResult();
                cikis = MessageBox.Show(puan.ToString() + " puan ile oyunu bitirdiniz..","Yandınız!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                if (cikis == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

    }
}

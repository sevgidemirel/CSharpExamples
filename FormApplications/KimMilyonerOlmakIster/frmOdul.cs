using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimMilyonerOlmakIster
{

    
    public partial class frmOdul : Form
    {

        private string adSoyad;
        private string odul;

        public string AdSoyad
        {
            get
            {
                return adSoyad;
            }

            set
            {
                adSoyad = value;
            }
        }

        public string Odul
        {
            get
            {
                return odul;
            }

            set
            {
                odul = value;
            }
        }

        public frmOdul()
        {
            InitializeComponent();
        }

        private void frmOdul_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblYarismaci.Text = AdSoyad;
            lblToplamOdul.Text = Odul;
           

        }

     

        private void btnCik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Kutuphane.DTO;
using Kutuphane.BLL;

namespace Kutuphane.UI.Yazar
{
    public partial class frm_YazarEkle : Form
    {
        public frm_YazarEkle()
        {
            InitializeComponent();
        }

        YazarRepository yazarRepo = new YazarRepository();
        YazarDTO newY = new YazarDTO();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                newY.YazarAdi = txtYazarAd.Text;
                newY.YazarSoyad = txtYazarSoyad.Text;
                newY.Ozgecmis = txtOzgecmis.Text;

                yazarRepo.addYazar(newY);

                DialogResult dr = MessageBox.Show("Yeni yazar başarıyla eklenmiştir! Yeni yazar eklemek istermisiniz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Temizle();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Form1.cb.DataSource = YazarRepository.tumYazarlar();
        }

        private void Temizle()
        {
            txtOzgecmis.Text = "";
            txtYazarAd.Text = "";
            txtYazarSoyad.Text = "";
        }
    }
}

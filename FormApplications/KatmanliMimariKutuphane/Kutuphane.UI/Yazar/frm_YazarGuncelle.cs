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
    public partial class frm_YazarGuncelle : Form
    {
        public frm_YazarGuncelle()
        {
            InitializeComponent();
        }

        private void frm_YazarGuncelle_Load(object sender, EventArgs e)
        {
            txtYazarAd.Text = Form1.GuncellenecekYazar.YazarAdi;
            txtYazarSoyad.Text = Form1.GuncellenecekYazar.YazarSoyad;
            txtOzgecmis.Text = Form1.GuncellenecekYazar.Ozgecmis;

        }

        YazarRepository yazarRepo = new YazarRepository();
      

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.GuncellenecekYazar.YazarAdi = txtYazarAd.Text;
                Form1.GuncellenecekYazar.YazarSoyad = txtYazarSoyad.Text;
                Form1.GuncellenecekYazar.Ozgecmis = txtOzgecmis.Text;

                yazarRepo.updateYazar(Form1.GuncellenecekYazar);

                MessageBox.Show("Yazar Başarıyla guncellenmiştir.");


                this.Close();


            }
            catch (Exception)
            {

                throw;
            }

            Form1.cb.DataSource = YazarRepository.tumYazarlar();

        }
    }
}

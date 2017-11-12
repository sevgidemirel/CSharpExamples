using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphane.BLL;
using Kutuphane.DTO;

namespace Kutuphane.UI.Kitap
{
    public partial class frm_KitapEkle : Form
    {
        public frm_KitapEkle()
        {
            InitializeComponent();
        }

        private void frm_KitapEkle_Load(object sender, EventArgs e)
        {
            cbYazar.DataSource = YazarRepository.tumYazarlar();
        }

        KitapDTO newK = new KitapDTO();
        KitapRepository kitapRepo = new KitapRepository();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var secilenYazar = cbYazar.SelectedValue as YazarDTO;
            try
            {
                newK.KitapAdi = txtKitapAdi.Text;
                newK.KitapKonusu = txtKitapKonusu.Text;
                newK.YayinTarihi = txtYayinEvi.Text;
                newK.Yayinevi = txtYayinEvi.Text;
                newK.YazarId = secilenYazar.YazarId;
                kitapRepo.addKitap(newK);

                DialogResult dr = MessageBox.Show("Yeni Kitap başarıyla eklenmiştir! Yeni kitap eklemek istermisiniz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        }

        private void Temizle()
        {
            txtKitapAdi.Text = "";
            txtKitapKonusu.Text = "";
            txtYayinEvi.Text = "";
            txtYayinTarihi.Text = "";
        }
    }
}

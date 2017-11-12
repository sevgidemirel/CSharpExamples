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

namespace Kutuphane.UI.Kitap
{
    public partial class frm_KitapGuncelle : Form
    {
        public frm_KitapGuncelle()
        {
            InitializeComponent();
        }

        private void frm_KitapGuncelle_Load(object sender, EventArgs e)
        {
            cbYazar.DataSource = YazarRepository.tumYazarlar();
   

            txtKitapAdi.Text = Form1.GuncellenecekKitap.KitapAdi;
            txtKitapKonusu.Text = Form1.GuncellenecekKitap.KitapKonusu;
            txtYayinEvi.Text = Form1.GuncellenecekKitap.Yayinevi;
            txtYayinTarihi.Text = Form1.GuncellenecekKitap.YayinTarihi;

        }

        KitapRepository kitapRepo = new KitapRepository();

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var secilenYazar = cbYazar.SelectedValue as YazarDTO;

         
            Form1.GuncellenecekKitap.KitapAdi = txtKitapAdi.Text;
            Form1.GuncellenecekKitap.KitapKonusu = txtKitapKonusu.Text;
            Form1.GuncellenecekKitap.Yayinevi = txtYayinEvi.Text;
            Form1.GuncellenecekKitap.YayinTarihi = txtYayinTarihi.Text;
            Form1.GuncellenecekKitap.YazarId = secilenYazar.YazarId;

            kitapRepo.updateKitap(Form1.GuncellenecekKitap);


            this.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Kutuphane.DAL;
using Kutuphane.BLL;
using Kutuphane.DTO;

namespace Kutuphane.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static YazarDTO GuncellenecekYazar;
        public static KitapDTO GuncellenecekKitap;
        public static ComboBox cb;
        YazarDTO secilenYazar;

        public void Form1_Load(object sender, EventArgs e)
        {
            cbYazarlar.DataSource = YazarRepository.tumYazarlar();
            cb = cbYazarlar;
        }

        private void cbYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {

            secilenYazar = cbYazarlar.SelectedValue as YazarDTO;
            GuncellenecekYazar = cbYazarlar.SelectedValue as YazarDTO;

            lbKitaplar.DataSource = KitapRepository.getKitap(secilenYazar.YazarId);

            toolStripStatusLabel1.Text = lbKitaplar.Items.Count + " adet kitap listelenmiştir.";
            //MessageBox.Show(secilenYazar.YazarId.ToString());
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kitap.frm_KitapEkle ekle = new Kitap.frm_KitapEkle();
            ekle.Show();
        }

        private void guncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lbKitaplar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kitabı listeden seçiniz.");
            }
            else
            {
                Kitap.frm_KitapGuncelle guncelle = new Kitap.frm_KitapGuncelle();

                GuncellenecekKitap = lbKitaplar.SelectedValue as KitapDTO;

                guncelle.Show();
            }

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yazar.frm_YazarEkle ekle = new Yazar.frm_YazarEkle();
            ekle.Show();
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Yazar.frm_YazarGuncelle guncelle = new Yazar.frm_YazarGuncelle();

            guncelle.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var silincekYazar = cbYazarlar.SelectedValue as YazarDTO;
                YazarRepository.deleteYazar(silincekYazar);
                MessageBox.Show("veriniz başarıyla silindi.");
                cbYazarlar.DataSource = YazarRepository.tumYazarlar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var silincekKitap = lbKitaplar.SelectedValue as KitapDTO;
                KitapRepository.deleteKitap(silincekKitap);
                MessageBox.Show("veriniz başarıyla silindi.");
                lbKitaplar.DataSource = KitapRepository.getKitap(secilenYazar.YazarId);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections;
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
    public partial class Form1 : Form
    {

        Random random = new Random();
        Soru s = new Soru();
        ArrayList secilenSorular = new ArrayList();

        frmOdul frmOdul = new frmOdul();

        int rastgeleSoru, soruSayac = 1;
        int odul = 0;

        string yarismaciAdi;

        bool cokluCevap = false;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            gbSorular.Visible = false;
            gbOduller.Visible = false;
            gbCevaplar.Visible = false;
            gbJoker.Visible = false;
            gbAyril.Visible = false;
           


            s.KolaySorular = new string[] { "2003 Yılında Euro Vizyon Şarkı Yarışmasında Ülkemizi Temsil Eden Ve Yarışmada Birinci Gelen Sanatçımız Kimdir ?", "Sözüne 'benden duymuş olma’ lafıyla başlayan biri hangisini yapacaktır?", "Bir yemekte, çatal veya bıçakla cam bardağa vurarak ses çıkaran biri muhtemelen ne yapacaktır?", "Hangisi ev sahiplerinin ev vermek istemedikleri kişiler listesinde genellikle yer almaz?", "Halk arasında hangisi için çiğ tavuk yeneceği söylenir?", "Anneler, eve geç gelen çocuklarına neyi unuttuklarını söyleyerek sitemde bulunurlar?", "İnsanı şaşırtarak sevindiren veya üzen beklenmedik olaya ne denir?", "Beklenmedik bir anda “Ben en son ne anlattım?” diye soran biri genellikle kimdir?", "Filmlerde yüksek sesle konuşanların genellikle gözlüklü ve orta yaşı görevli tarafından 'Şşşt!' sesiyle uyarıldığı yer neresidir?" };


            // cevaplarlar dizisinde ilk kelimecik dogru cevap yazıldı.
            // split('-') yöntemiyle ayrılan cevap şıkları .sort özelligiyle butonlara atanacak.
            
            s.KolayCevaplar = new string[] { "Sertab Erener-Athena-Manga-Ajda Pekkan", "Dedikodu-Evlilik Teklifi-Basın açıklaması-Sunum", "Konuşma yapacaktır-Masayı toplayacaktır-Siparişleri alacaktır-Hesabı isteyecektir", "Bankacı-Bekar-Çocuklu aile-Öğrenci", "Hatır-Aşk-Dostluk-Aile", "Evin yolunu-Babalarının adını-Dizinin saatini-Yemeklerinin tadını", "Sürpriz-Nüans-Davet-Espri", "Öğretmen-Psikolog-Görgü tanığı-Suflör", "Kütüphane - Otopark - Stadyum - Konser alanı" };

            s.OrtaSorular = new string[] { "Bir işi 'çalakalem’ yaptığınız söyleniyorsa, o işi nasıl yaptığınızdan bahsediliyordur?", "Gömme şeklinde yapılan mutfak eşyası için kullanılan kelime hangisidir?", "Genellikle altın için kullanılan 'som’ ifadesinin anlamı nedir?", "'Karadenizin İncisi', 'Egenin İncisi' gibi ifadeler genellikle hangileri için kullanılır?", "“Sokrates’in Savunması” adlı eserin yazarı kimdir?", "'Soluk soluğa izleyeceksiniz, gözlerinizi ekrandan alamayacaksınız’ sözleriyle tanıtımı yapılan muhtemelen hangisidir?", "Hiç Oscar alamamış olmasıyla gündemde olan, “Diriliş” filmiyle bu yıl “en iyi erkek oyuncu” ödülünü alıp alamayacağı konuşulan aktör kimdir?", "'Kaynağında el değmeden şişelenmiştir' yazısı hangisinin üzerinde yazılıdır?", "İstanbul Arkeoloji Müzesi’nin kurucusu olan ve ilk Türk arkeoloğu olarak kabul edilen ressam kimdir?" };

            s.OrtaCevaplar = new string[] { "Gelişigüzel-Tekrarlayarak-Yavaş yavaş-Özenerek", "Ankastre-Aplike-No frost-Set Ustu", "Katışıksız olan-Metal içeren-Karışmış olan-Dışı kaplama olan", "Şehirler-Tarihi eserler-Şanatcılar-Deniz mahsulleri", "Platon-Cicero-Aristoteles-Sokrates", "Macera filmi-Bale gösterisi-Modern Sanat Sergisi-Klaisk Müzik Konseri", "Leonardo DiCaprio-Matt Damon-Colin Farrell-Matthew McConaughey", "Su-Sabun-ZeytinYagı-Meyve suyu", "Osman Hamdi Bey-Burhan Doğançay-Nuri İyem-Halil Ethem Bey" };

            s.ZorSorular = new string[] { "Geçtiğimiz aylarda Uluslararası Doğayı Koruma Birliği’nin raporunda hangisinin 'nesli tükenmekte olan türler’ listesinden çıkarıldığı belirtilmiştir?", "Bir astronot Ay yüzeyinde ellerindeki bir kuş tüyü ile bir çekici aynı anda bırakırsa hangisi gerçekleşir?", "'Pelennor Çayırları, Rohan ve Mordor’ hangi film serisinde geçen yer isimleridir?", "'En büyük hayalim Mauna Kea Gözlemevine gitmek’ diyen bir astronomi hayranı nereye uçak bileti almalıdır?", "Birbirine bağlanmak istenen ağaç veya demir parçaların üzerindeki deliklerden geçirilip ucuna somun takılarak sıkıştırılan iri başlı vidaya ne ad verilir?", "Peter Jackson, hangi müzik grubunun üyelerinin daha önce Yüzüklerin Efendisi filminde oynama taleplerinin yazar Tolkien tarafından reddedildiğini açıklamıştır?", "Hangi fare türünün beyaz renkli olanları laboratuvarlarda deney faresi olarak kullanılır?", "Peri tozuna sahipseniz ve uçabildiğiniz, hiç büyümeyip çocuk kaldığınız bir yerdeyseniz hangi hayali ülkedesinizdir?", "“İskete” hangi hayvanın bir türüdür?" };

            s.ZorCevaplar = new string[] { "Panda-Kutup Ayısı-Çizgili Sırtlan-Sumatra Kaplanı", "İkisi de aynı anda düşer-Kuş tüyü önce düşer-İkisi de havada asılı kalır-Çekiç önce düşer", "Yüzüklerin Efendisi-Harry Pother-Oz Büyücüsü-Narnia Günlükleri", "Hawai-Madagaskar-Tayland-Sri Lanka", "Cıvata-Conta-Tornavida-Dübel", "The Beatles-The Doors-Pearl Jam-The Rolling Stones", "Ev Faresi-Fındık Faresi-Tarla Faresi-Firavun Faresi", "Var Olmayan Ülke-Atlantis-Liliput-Kayıp Ada", "Kuş-Balık-Geyik-Örümcek" };


            gbSorular.Text = soruSayac.ToString();
            rastgeleSoru = random.Next(0, s.KolaySorular.Length);

            secilenSorular.Add(rastgeleSoru);
            s.SoruUret(btnSoru, gbCevaplar, gbSorular, rastgeleSoru);

        }

        private void btnA_Click(object sender, EventArgs e)
        {


            bool sorularDogruMu = s.KolaySoruDogruMu((Button)sender, s.KolayCevaplar, rastgeleSoru) || s.OrtaSoruDogruMu((Button)sender, s.OrtaCevaplar, rastgeleSoru) || s.ZorSoruDogruMu((Button)sender, s.ZorCevaplar, rastgeleSoru);


            if (sorularDogruMu)
            {
                if (gbSorular.Text == "13")
                {
                    frmOdul.AdSoyad = yarismaciAdi;
                    frmOdul.Odul = "1.000.000 TL";
                    frmOdul.Show();
                }
                ((Button)sender).BackColor = Color.Green;

                MessageBox.Show(soruSayac + ". ncı soruyu bildiniz :)", "Tebrikler " + yarismaciAdi);

                soruSayac++;
                gbSorular.Text = soruSayac.ToString();

                do
                {
                    if (Convert.ToInt32(gbSorular.Text) == 3)
                    {
                        secilenSorular.Clear();
                    }
                    if (Convert.ToInt32(gbSorular.Text) == 8)
                    {
                        secilenSorular.Clear();
                    }
                    rastgeleSoru = random.Next(0, s.KolaySorular.Length);


                } while (secilenSorular.Contains(rastgeleSoru));
                secilenSorular.Add(rastgeleSoru);

                s.SoruUret(btnSoru, gbCevaplar, gbSorular, rastgeleSoru);

                foreach (Control item in gbCevaplar.Controls)
                {
                    item.Enabled = true;
                    item.BackColor = Color.Lavender;

                }
                KazandigiParayiBoya();
            }
            else if (cokluCevap)
            {

                MessageBox.Show("Son Hakkınız Kaldı..");



                ((Button)sender).Enabled = false;
                ((Button)sender).BackColor = Color.Red;

                cokluCevap = false;

            }
            else
            {
                ((Button)sender).BackColor = Color.Red;
                odulHesapla();
            }

        }

        private void odulHesapla()
        {
            btnBasla.Enabled = true;

            if (Convert.ToInt32(gbSorular.Text) < 2)
            {
                odul = 0;

            }
            if (Convert.ToInt32(gbSorular.Text) > 2 && Convert.ToInt32(gbSorular.Text) < 8)
            {
                odul = 1000;
            }

            if (Convert.ToInt32(gbSorular.Text) > 8)
            {
                odul = 15000;
            }

            frmOdul.Odul = odul.ToString();
            frmOdul.AdSoyad = yarismaciAdi;
            frmOdul.Show();
          
        }

        private void pbAyril_Click(object sender, EventArgs e)
        {
            

            foreach (Control item in gbOduller.Controls)
            {
                if (Convert.ToInt32(item.Tag) == Convert.ToInt32(gbSorular.Text))
                {
                    frmOdul.Odul = item.Text.ToString();
                    frmOdul.AdSoyad = yarismaciAdi;
                    frmOdul.Show();
                    
                }

            }



        }

     
        private void btnBasla_Click(object sender, EventArgs e)
        {

            if (txtYarismaciAdi.Text == "")
            {
                MessageBox.Show("Lütfen bir isim giriniz:");
            }
            else
            {


                gbSorular.Visible = true;
                gbOduller.Visible = true;
                gbCevaplar.Visible = true;
                gbJoker.Visible = true;
                gbAyril.Visible = true;
               

                gbYarismaciBilgileri.Enabled = false;

                yarismaciAdi = txtYarismaciAdi.Text;

            }

        }

        private void pbYariYariya_Click(object sender, EventArgs e)
        {
            s.SoruYarila(soruSayac, rastgeleSoru, gbCevaplar);

            JokerKullanildi(pbYariYariya, lblYariyariya);
        }

        private void JokerKullanildi(PictureBox pb, Label lb)
        {
            pb.BackColor = Color.Red;
            pb.Enabled = false;

            lb.ForeColor = Color.Red;
            lb.Text = "Kullanıldı!";
        }


        private void pbCokluCevap_Click(object sender, EventArgs e)
        {
            cokluCevap = true;

            JokerKullanildi(pbCokluCevap, lblCokluCevap);
        }

        private void pbSeyirci_Click(object sender, EventArgs e)
        {


        }



        private void KazandigiParayiBoya()
        {
            foreach (Control item in gbOduller.Controls.OfType<Label>())
            {
                if (item.Tag.Equals(soruSayac.ToString()))
                {
                    item.BackColor = Color.DarkMagenta;
                }
                else
                {
                    item.BackColor = Color.LightPink;
                }
            }
        }

    }
}

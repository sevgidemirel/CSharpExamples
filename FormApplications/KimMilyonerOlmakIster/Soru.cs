using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimMilyonerOlmakIster
{
    public class Soru
    {

        string[] kolaySorular;
        string[] kolayCevaplar;
        string[] ortaSorular;
        string[] ortaCevaplar;
        string[] zorSorular;
        string[] zorCevaplar;

        public string[] KolaySorular
        {
            get
            {
                return kolaySorular;
            }

            set
            {
                kolaySorular = value;
            }
        }

        public string[] KolayCevaplar
        {
            get
            {
                return kolayCevaplar;
            }

            set
            {
                kolayCevaplar = value;
            }
        }

        public string[] OrtaSorular
        {
            get
            {
                return ortaSorular;
            }

            set
            {
                ortaSorular = value;
            }
        }

        public string[] OrtaCevaplar
        {
            get
            {
                return ortaCevaplar;
            }

            set
            {
                ortaCevaplar = value;
            }
        }

        public string[] ZorSorular
        {
            get
            {
                return zorSorular;
            }

            set
            {
                zorSorular = value;
            }
        }

        public string[] ZorCevaplar
        {
            get
            {
                return zorCevaplar;
            }

            set
            {
                zorCevaplar = value;
            }
        }



        /// <summary>
        /// uretilen rastgele sayıya gore , üretilen sorunun cevaplarını sıralı bir şekilde butonlara atar.
        /// </summary>
        /// 
        /// <param name="btn"> Soru butonuna üretilen soruyu atamak için tanımlandı</param>
        /// <param name="gb">Cevap butonların bulundugu groupbox</param>
        /// <param name="soru">groupbox'ın text ozelligi soru sırasını tutar. soru sırasına gore uretilecek sorunun duzeyi belirlenir (kolay-orta-zor gibi.)</param>
        /// <param name="rastgeleSayi"></param>
        public void SoruUret(Button btn, GroupBox gb, GroupBox soru, int rastgeleSayi)
        {
            if (Convert.ToInt32(soru.Text) < 3)
            {
                btn.Text = KolaySorular[rastgeleSayi];

                string[] ayrilmisKolayCevaplar = cevaplariAyir(KolayCevaplar[rastgeleSayi]);
                int sayac = 0;
                Array.Sort(ayrilmisKolayCevaplar);

                foreach (Control item in gb.Controls.OfType<Button>())
                {
                    item.Text = ayrilmisKolayCevaplar[sayac];
                    sayac++;
                }
            }
            else if (Convert.ToInt32(soru.Text) >= 3 && Convert.ToInt32(soru.Text) < 8)
            {
                btn.Text = OrtaSorular[rastgeleSayi];

                string[] ayrilmisOrtaCevaplar = cevaplariAyir(OrtaCevaplar[rastgeleSayi]);
                int sayac = 0;
                Array.Sort(ayrilmisOrtaCevaplar);
                foreach (Control item in gb.Controls.OfType<Button>())
                {
                    item.Text = ayrilmisOrtaCevaplar[sayac];
                    sayac++;
                }
            }
            else if (Convert.ToInt32(soru.Text) >= 8)
            {
                btn.Text = ZorSorular[rastgeleSayi];

                string[] ayrilmisZorCevaplar = cevaplariAyir(ZorCevaplar[rastgeleSayi]);
                int sayac = 0;
                Array.Sort(ayrilmisZorCevaplar);
                foreach (Control item in gb.Controls.OfType<Button>())
                {
                    item.Text = ayrilmisZorCevaplar[sayac];
                    sayac++;
                }
            }




        }


        public string[] cevaplariAyir(string cevaplar)
        {
            string[] words = cevaplar.Split('-');
            return words;
        }

        public bool KolaySoruDogruMu(Button btn, String[] cevap, int rastgeleSayi)
        {
            cevap = cevaplariAyir(kolayCevaplar[rastgeleSayi]);

            if (btn.Text == cevap[0])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool OrtaSoruDogruMu(Button btn, String[] cevap, int rastgeleSayi)
        {
            cevap = cevaplariAyir(ortaCevaplar[rastgeleSayi]);

            if (btn.Text == cevap[0])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ZorSoruDogruMu(Button btn, String[] cevap, int rastgeleSayi)
        {
            cevap = cevaplariAyir(zorCevaplar[rastgeleSayi]);

            if (btn.Text == cevap[0])
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void SoruYarila(int soruSayac, int rastgeleSayi, GroupBox gb)
        {


            if (soruSayac <= 2)
            {

                int sayac = 0;
                string[] ayrilmisKolayCevaplar = cevaplariAyir(KolayCevaplar[rastgeleSayi]);

                for (int i = 0; i < 4; i++)
                {
                    if (gb.Controls[i].Text == ayrilmisKolayCevaplar[0])
                        continue;

                    else
                    {
                        sayac++;
                        if (sayac <= 2)
                            gb.Controls[i].Text = "";
                    }
                }

            }

            if (soruSayac >= 3 && soruSayac <= 7)
            {
                int sayac = 0;
                string[] ayrilmisOrtaCevaplar = cevaplariAyir(OrtaCevaplar[rastgeleSayi]);

                for (int i = 0; i < 4; i++)
                {
                    if (gb.Controls[i].Text == ayrilmisOrtaCevaplar[0])
                        continue;

                    else
                    {
                        sayac++;
                        if (sayac <= 2)
                            gb.Controls[i].Text = "";
                    }
                }

            }

            if (soruSayac >= 8 && soruSayac <= 13)
            {
                int sayac = 0;
                string[] ayrilmisZorCevaplar = cevaplariAyir(ZorCevaplar[rastgeleSayi]);

                for (int i = 0; i < 4; i++)
                {
                    if (gb.Controls[i].Text == ayrilmisZorCevaplar[0])
                        continue;

                    else
                    {
                        sayac++;
                        if (sayac <= 2)
                            gb.Controls[i].Text = "";
                    }
                }

            }
        }

       

    }
}

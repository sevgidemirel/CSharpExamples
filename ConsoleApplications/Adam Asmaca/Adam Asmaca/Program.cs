using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adam_Asmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rastgeleSayi = random.Next(0, 5);

            int hak = 8, puan = 800;
            char girilenHarf;

            string[] kelimeler = { "buzdolabı", "bilgisayar", "istanbul", "fenerbahce", "kriptoloji" };
            object[] kelimeKarakterleri = HarflereAyir(kelimeler[rastgeleSayi]);//HarflereAyir fonksiyonu ile rasgele seçilen kelimenin harflerini char türündeki diziye atanacak.


            ArrayList girilenHarfler = new ArrayList(); //Kullanıcının dogru girdigi harfler bu listede tutulacak.

            do
            {
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;

                
                Console.Write("\n\nBir harf giriniz:");
            harfGir:
                girilenHarf = char.Parse(Console.ReadLine());

                bool oncedenYazilmisMi = girilenHarfler.Contains(girilenHarf);
                if (oncedenYazilmisMi)// Kullanıcının dogru girdigi harfleri tekrar girmesi önlenir.
                {
                    Console.Write("{0} harfini önceden girdiniz , tekrar bir harf deneyin:", girilenHarf);
                    goto harfGir;
                }  

                Console.Clear();

                if (kelimeKarakterleri.Contains(girilenHarf))
                {
                    girilenHarfler.Add(girilenHarf);
                    ekranaYaz(kelimeKarakterleri, girilenHarfler);

                }
                else
                {
                    ekranaYaz(kelimeKarakterleri, girilenHarfler);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    hak--;
                    puan -= 100;
                    Console.SetCursorPosition(10,5);
                    Console.WriteLine("{0} PUAN {1}  HAK kaldı...", puan, hak);

                    if(hak == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.WriteLine("\n");
                        Thread.Sleep(200);
                        Console.WriteLine("\nUzgunuz...' {0} ' kelimesini bilemediniz!!..", kelimeler[rastgeleSayi]);
                        Thread.Sleep(200);
                        Console.WriteLine("\nSkor : {0} ", puan);
                        Thread.Sleep(200);
                        Console.WriteLine("\nHamle : {0} ",hak);
                        break;
                    }
                }

                if (kelimeKarakterleri.Distinct().ToArray().Count() == girilenHarfler.Count)
                {
                    
                    Console.BackgroundColor = ConsoleColor.White;

                    Console.WriteLine("\n");
                    Thread.Sleep(200);
                    Console.WriteLine("\nTEBRİKLER...' {0} ' kelimesini bildiniz!!..",kelimeler[rastgeleSayi]);
                    Thread.Sleep(200);
                    Console.WriteLine("\nSkor : {0} ",puan);
                    Thread.Sleep(200);
                    Console.WriteLine("\nHamle : {0} ", 8-hak);
                    break;
                }


            } while (hak > 0);


            Console.ReadKey();

        }
        /// <summary>
        /// paratmetre olarak string turunde bir kelime alan bu fonksiyon, harfleri dizi olarak döndürür.
        /// </summary>
        /// <param name="kelime"></param>
        /// <returns></returns>
        static object[] HarflereAyir(string kelime)
        {
            object[] harfler = new object[kelime.Length];

            int sayac = 0;
            foreach (var item in kelime)
            {
                harfler[sayac] = item;
                if (sayac == kelime.Length)
                    break;
                sayac++;
            }
            return harfler;
        }


        /// <summary>
        /// parametre olarak obj. dizisi ve arraylist alan bu fonksiyon, kelimeKarakterlerinin içinde
        /// girilenHarfin olup olmadığını kontrol eder. 
        /// varsa ise ilgili karakteri ekrana yazar. yoksa "_" ekler.
        /// </summary>
        /// <param name="kelimeKarakterleri"></param>
        /// <param name="girilenHarfler"></param>
        static void ekranaYaz(object[] kelimeKarakterleri, ArrayList girilenHarfler)
        {
            for (int i = 0; i < kelimeKarakterleri.Length; i++)// bu döngü bir kelimenin her harfinde gezinmek için yaratıldı.
            {

                if (!girilenHarfler.Contains(kelimeKarakterleri[i]))//girilenHarfler listesinde kelimeKarakterleri'nde biri yoksa ekrana "_" yazdıracak.
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("_");
                }
                else//girilen harf , üretilen kelimenin harflerinde biri ise;
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    for (int j = 0; j < girilenHarfler.Count; j++) 
                    {
                        if (kelimeKarakterleri[i].Equals(girilenHarfler[j])) //kelimeKarakterlerinin hangi indisinde girilenHarf esit ise ilgili harf ekrana yazdırılacak.
                        {
                            Console.Write(girilenHarfler[j]);
                        }
                    }
                }
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icecek_Menusu
{
    class Program
    {
        static void Main(string[] args)
        {
            float toplamTutar = 0;
            ConsoleKeyInfo tus = new ConsoleKeyInfo();

            do
            {

                Console.Clear();
                Console.WriteLine("1- Su : 1.00 TL");
                Console.WriteLine("2- Kola : 4.00 TL");
                Console.WriteLine("3- Türk Kahvesi : 5.00 TL");
                Console.WriteLine("4- Soda : 0.50 TL");
                Console.WriteLine("5- Çay : 1.00 TL");
                Console.WriteLine("6- Meyve Suyu : 2.50 TL");

                Console.WriteLine("-----------------------");
                Console.Write("Bir Seçim Yapınız: ");
                try 
                {
                    byte sayi = byte.Parse(Console.ReadLine());
                    switch (sayi)
                    {
                        case 1: toplamTutar += (float)1.00; break;
                        case 2: toplamTutar += (float)4.00; break;
                        case 3: toplamTutar += (float)5.00; break;
                        case 4: toplamTutar += (float)0.50; break;
                        case 5: toplamTutar += (float)1.00; break;
                        case 6: toplamTutar += (float)2.50; break;
                        default:
                            Console.Write("Geçersiz seçim!!..");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nHatanız: {0} \n",e);
                }


                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\nBaşka Bir Şey İster Misiniz (e/h) ? : ");
                tus = Console.ReadKey();


                if (tus.Key == ConsoleKey.H)
                    Console.Write("\nToplam Tutarınız : {0} Tl, iyi günler!!", toplamTutar);
  

            } while (tus.Key == ConsoleKey.E);

            Console.ReadKey();

        }
    }
}

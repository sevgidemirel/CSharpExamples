using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Street_Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int kenCan = 50, zyraCan = 50;
            byte kenStep = 0, zyraStep = 0;

         

            do
            {
                int sira = random.Next(0, 2);
                Console.Clear();
                Console.Write("Z: {0} ", zyraCan);
                for (int i = 0; i < zyraCan; i++)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("K: {0} ", kenCan);
                for (int i = 0; i < kenCan; i++)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" ");
                }
                if (sira == 0)
                {
                    kenStep++;

                    Console.BackgroundColor = ConsoleColor.Black;
                    int kenVurus = random.Next(1, 10);
                    Console.Write("\n{0}. Ken ==> {1} vurdu!! \n",kenStep, kenVurus);
                    zyraCan -= kenVurus;
                    if (zyraCan <= 0)
                    {
                        Console.Write("{0} adımda {1} canla 'KEN' kazandı", kenStep, kenCan);
                        break;
                    }
                    Console.ReadKey();

                }
                else if (sira == 1)
                {
                    zyraStep++;

                    Console.BackgroundColor = ConsoleColor.Black;
                    int zyraVurus = random.Next(1, 10);
                    Console.Write("\n{0}. Zyra ==> {1} vurdu!! \n",zyraStep, zyraVurus);
                    kenCan -= zyraVurus;
                    if (kenCan <= 0)
                    {
                        Console.Write("{0} adımda {1} canla 'ZYRA' kazandı",zyraStep, zyraCan);
                        break;
                    }
                    Console.ReadKey();

                }
            } while (true);



            Console.ReadKey();
        }
    }
}

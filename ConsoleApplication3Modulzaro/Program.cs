using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            int hossz=18;
            char jel= '-';
            int tetel = 3;
            Console.WriteLine("Számla");
            kiir(hossz, jel);
            Console.WriteLine();
            tetelkiir(tetel);
            kiir(hossz, jel);
            Console.WriteLine();
            Console.WriteLine("Összesen: ");
            jel = '=';
            kiir(hossz, jel);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dátum: ");
            Console.WriteLine();
            jel = '_';
            kiir(hossz, jel);
            Console.WriteLine();
            Console.WriteLine();
            felsor(hossz, jel);
            Console.WriteLine();
            alair(hossz);

            Console.ReadLine();
        }

        private static void alair(int h)
        {
            for (int i = 0; i < h / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write(" aláírás");
            
        }

        private static void felsor(int h, char j)
        {
            for (int i = 0; i < h/2; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < h/2; i++)
            {
                Console.Write(j);
            }
        }

        private static void tetelkiir(int t)
        {
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Tétel " + (i + 1));
            }
        }

        private static void kiir(int h, char j)
        {
            for (int i = 0; i < h; i++)
            {
                Console.Write(j);
            }
        }
    }
}

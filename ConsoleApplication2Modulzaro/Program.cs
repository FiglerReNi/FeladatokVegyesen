using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            //jó adat ellenőrzése B
            int paros_e;
            do
            {
                Console.Write("páros szám megadása: ");
                paros_e = int.Parse(Console.ReadLine());
                if (paros_e % 2 != 0)
                {
                    Console.WriteLine("Nem helyes az érték, add meg újra");
                }
            } while (paros_e % 2 != 0);
            Console.WriteLine("jó érték");


            //jó adat ellenőrzése A
            Console.Write("páros szám megadása: ");
            int paros = int.Parse(Console.ReadLine());
            bool feltetel = paros % 2 == 0;
            Console.WriteLine((feltetel) ? "jó érték" : "nem jó érték");


            //else if
            Console.Write("Add meg a százalékot: ");
            int szazalek = int.Parse(Console.ReadLine());
            if (szazalek >= 0 && szazalek <= 100)
            {
                if (szazalek < 51)
                {
                    Console.WriteLine("elégtelen");
                }
                else if (szazalek < 61)
                {
                    Console.WriteLine("elégséges");
                }
                else if (szazalek < 81)
                {
                    Console.WriteLine("közepes");
                }
                else if (szazalek < 91)
                {
                    Console.WriteLine("jó");
                }
                else
                {
                    Console.WriteLine("jeles");
                }
            }
            else
            {
                Console.WriteLine("nem jó adat");
            }

            //switch 
            Console.Write("Add meg a jegyet: ");
            int jegy = int.Parse(Console.ReadLine());
            switch (jegy)
            {
                case 5:
                    Console.WriteLine("jeles");
                    break;
                case 4:
                    Console.WriteLine("jó");
                    break;
                case 3:
                    Console.WriteLine("közepes");
                    break;
                case 2:
                    Console.WriteLine("elégséges");
                    break;
                case 1:
                    Console.WriteLine("elégtelen");
                    break;
                default:
                    Console.WriteLine("téves adat");
                    break;
            }


            //kiiras
            int c = 2;
            int d = 6;
            Console.WriteLine($"{c}+{d}={c + d}");


            //min, max szám
            int a = int.MaxValue;
            int b = int.MinValue;
            Console.WriteLine("max: " + a + "; min: " + b);


            //előjel feladat
            int szam1 = 5;
            int szam2 = -2;
            //milyen előjelű
            if (szam1 < 0)
            {
                Console.WriteLine("-");
            }
            else if (szam1 == 0)
            {
                Console.WriteLine("nulla");
            }
            else
            {
                Console.WriteLine("+");
            }
            //összehasonlítás
            if ((szam1 < 0 && szam2 < 0) || (szam1 > 0 && szam2 > 0) || (szam1 == 0 && szam2 == 0))
            {
                Console.WriteLine("egyezik");
            }
            else
            {
                Console.WriteLine("nem egyezik");
            }


            //hány tizedesig kiírás
            double tizedes = (double)14 / 3;
            Console.WriteLine("Az eredmény: {0:N3}", tizedes);


            //faktoriális
            int t = 16;
            long fakt = 1;
            for (int i = 2; i <= t; i++)
            {
                fakt = fakt * i;
            }
            Console.WriteLine("Az első {0} szám faktoriálisa: {1}", t, fakt);


            //gyökvonás
            double gyok = Math.Sqrt(9);
            Console.WriteLine(gyok);


            Console.ReadLine();
        }
    }
}

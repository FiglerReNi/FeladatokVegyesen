using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {  
            //számjegyes feladat
            for (int i = 2; i < 5; i++)
            {
                for (int v = 2; v < 5; v++)
                {
                    for (int z = 2; z < 5; z++)
                    {
                        Console.WriteLine(100 * i + 10 * v + z);
                    }
                }
            }


            //tökéletes szém feladat (Random)
            int ossz1;
            int szamrandom;
            Random random = new Random();
            do
            {
                ossz1 = 0;
                szamrandom = random.Next(1, 500);
                for (int j = 1; j < szamrandom; j++)
                {
                    if (szamrandom % j == 0)
                    {
                        ossz1 = ossz1 + j;
                    }
                }
            } while (szamrandom == 1 || szamrandom != ossz1);
            Console.WriteLine("Tökéletes szám: " + szamrandom);


            //tökéletes szám feladat (1000ig)
            int ossz;
            int p;
            for (p = 2; p < 1000; p++)
            {
                ossz = 0;
                for (int j = 1; j < p; j++)
                {
                    if (p % j == 0)
                    {
                        ossz = ossz + j;
                    }
                }
                if (p == ossz)
                {
                    Console.WriteLine("Tökéletes számok: " + p);
                    //break; (az első talált)
                }
            }
           

            //állatos feladat
            double m, n, k;
            for (m = 1; m < 100; m++)
            {
                for (n = 1 ; n < 100; n++)
                {
                    for (k = 1; k < 100; k++)
                    {
                           // if ((m + n + k == 100) && ((7 * m) / 2 + (4 * n) / 3 + (1 * k) / 2) == 100)
                            if (m + n + k == 100 && ((double)7 / 2 * m + (double)4 / 3 * n + (double)1 / 2 * k) == 100)
                        {
                            Console.WriteLine("Sertés: {0}, Kecske: {1}, Juh: {2}.", m, n, k);
                        }
                    }
                }
            }


            //sárkányos feladat
            bool vanmegoldas = false;
            for (int i = 1; i < 145/7; i++)
            {
                for (int j = 1; j < 145/7; j++)
                {
                    if (7*i + 11*j == 145)
                    {
                        Console.WriteLine("Hét fejű: " + i + ", Tizenegy fejű: " + j);
                        vanmegoldas = true;
                    }                  
                }
            }
            if (vanmegoldas == false)
            {
                Console.WriteLine("Nincs megoldás");
            }


            //kétdimenziós különböző hosszúságú tömb
            int[][] kettodim = new int[4][];
            kettodim[0] = new int[2];
            kettodim[1] = new int[5];
            kettodim[2] = new int[3];
            kettodim[3] = new int[4];
            //szerkezet kiiratás
            for (int i = 0; i < kettodim.GetLength(0); i++)
            {
                for (int j = 0; j < kettodim[i].GetLength(0); j++)
                {
                    Console.Write(kettodim[i][j]);
                }
                Console.WriteLine();
            }


            //többdimenziós tömb
            int[,,] haromdim = new int[3, 5, 10];
            
        
            //Két dimenziós tömb: kockastatisztika két kockával
            Console.Write("Dobások száma: ");
            int dobasszam = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[,] dobasokstat = new int[6, 6];
            for (int i = 0; i < dobasszam; i++)
            {
                int dobas1 = rnd.Next(1, 7);
                int dobas2 = rnd.Next(1, 7);
                dobasokstat[(dobas1 - 1), (dobas2 - 1)]++;
            }
            Console.Write("\t\t");
            for (int i = 0; i < 6; i++)
            {
                Console.Write((i + 1) + "\t");
            }
            Console.WriteLine();
            Console.Write("\t ----------------------------------------------------------------");
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                Console.Write((i + 1) + ": \t" );
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("\t " + dobasokstat[i, j]);
                }
                Console.WriteLine();
            }


            //tömb kezelése: kocka statisztika egy kockával
            Console.Write("Dobások száma: ");
            int dobasszam1 = int.Parse(Console.ReadLine());
            rnd = new Random();
            int[] statisztika = new int[6];
            for (int i = 0; i < dobasszam1; i++)
            {
                int dobas = rnd.Next(1, 7);
                statisztika[dobas - 1]++;
            }
            //for (int i = 0; i < dobasszam; i++)
            //{
            //    int dobas = rnd.Next(1, 7);
            //    switch (dobas)
            //    {
            //        case 1:
            //            statisztika[0]++;
            //            break;
            //        case 2:
            //            statisztika[1]++;
            //            break;
            //        case 3:
            //            statisztika[2]++;
            //            break;
            //        case 4:
            //            statisztika[3]++;
            //            break;
            //        case 5:
            //            statisztika[4]++;
            //            break;
            //        case 6:
            //            statisztika[5]++;
            //            break;
            //    }
            //}
            for (int i = 0; i < statisztika.Length; i++)
            {
                Console.WriteLine((i+1) + ": " + statisztika[i]);
            }
            Console.ReadLine();
        }
    }
}


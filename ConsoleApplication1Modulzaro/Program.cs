using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
          


            //prímszám
            int[] prim_e = { 1, 2, 5, 26, 73, 8, 67, 44, 21 };
            for (int i = 0; i < prim_e.Length; i++)
            {
                int osztok = 0;
                for (int q = 1; q <= prim_e[i]; q++)
                {
                    if (prim_e[i] % q == 0)
                    {
                        osztok++;
                    }
                }
                if (osztok==2)
                {
                    Console.Write(prim_e[i] + "; ");
                }
            }
            Console.WriteLine();


            //Beolvasás string tömb to int tömb
            string[] beolvas = File.ReadAllLines("modulzaro.txt");
            int[] beszamok = new int[beolvas.Length];
            for (int i = 0; i < beolvas.Length; i++)
            {
                beszamok[i] = int.Parse(beolvas[i]);
                Console.WriteLine(beszamok[i]);
            }


            //Kiirás int tömb to string tömb
            int[] szamok = { 1, 25, 98, 112, 5, 69, 897, 74 };
            string[] kiiras = new string[szamok.Length];
            for (int i = 0; i < szamok.Length; i++)
            {
                kiiras[i] = Convert.ToString(szamok[i]);
            }
            //File.AppendAllLines("modulzaro.txt", kiiras);
            File.WriteAllLines("modulzaro.txt", kiiras);
            

            //Sorbarendezés
            int[] sor = { 1, 9, 5, 2, 16, 33, 25, 11 };
            int y;
            for (int v = 0; v < sor.Length-1; v++)
                {
                    for (int z = v+1; z<sor.Length; z++)
                    {
                    if (sor[v] > sor[z])
                    {
                        y = sor[v];
                        sor[v] = sor[z];
                        sor[z] = y;
                    }
                    }
                }
            for (int i = 0; i < sor.Length; i++)
            {
                Console.Write(sor[i] + "; ");
            }
            Console.WriteLine();


            //Unio
            int[] alap3 = { 1, 5, 9, 7 };
            int[] alap4 = { 5, 8, 11, 1 };
            int[] unio = new int[alap3.Length + alap4.Length];
            for (int i = 0; i < alap3.Length; i++)
            {
                unio[i] = alap3[i];

            }
            int un = alap3.Length;
            for (int p = 0; p < alap4.Length; p++)
            {
                int x = 0;
                while (x < alap3.Length && alap3[x] != alap4[p])
                {
                    x++;
                }
                if (x >= alap3.Length)
                {
                    unio[un] = alap4[p];
                    un++;
                }
            }
            for (int i = 0; i < un; i++)
            {
                Console.Write(unio[i] + "; ");
            }
            Console.WriteLine();


            //Metszet
            int[] alap1 = { 1, 3, 25, 16, 9, 8, 45, 2, };
            int[] alap2 = { 4, 9, 7, 3, 2, 99 };
            int[] metszet = new int[alap2.Length];
            int me = 0;
            for (int i = 0; i < alap1.Length; i++)
            {
                int g = 0;
                while (g < alap2.Length && alap1[i] != alap2[g])
                {
                    g++;
                }
                if (g < alap2.Length)
                {
                    metszet[me] = alap1[i];
                    me++;
                }
            }
            for (int i = 0; i < me; i++)
            {
                Console.Write(metszet[i] + "; ");
            }
            Console.WriteLine();


            //Szétválogatás tétele
            int[] alap = { 1, 7, 15, 9, 8, 32, 9, 45 };
            int[] szet1 = new int[alap.Length];
            int[] szet2 = new int[alap.Length];
            int s = 0;
            int ss = 0;
            for (int i = 0; i < alap.Length; i++)
            {
                if (alap[i] < 10)
                {
                    szet1[s] = alap[i];
                    s++;
                }
                else
                {
                    szet2[ss] = alap[i];
                    ss++;
                }
            }
            for (int i = 0; i < s; i++)
            {
                Console.Write(szet1[i] + "; ");
            }
            Console.WriteLine();
            for (int i = 0; i < ss; i++)
            {
                Console.Write(szet2[i] + "; ");
            }
            Console.WriteLine();


            //Kiválogatás tétele
            int[] kezdo = { 1, 2, 17, 3, 26, 8 };
            //List<int> valogatott = new List<int>();
            //for (int i = 0; i < kezdo.Length; i++)
            //{
            //    if (kezdo[i] < 10)
            //    {
            //        valogatott.Add(kezdo[i]);
            //    }
            //}
            //foreach (int f in valogatott)
            //{
            //    Console.Write(f + "; ");
            //}
            int[] valogatott = new int[kezdo.Length];
            int n = 0;
            for (int i = 0; i < kezdo.Length; i++)
            {
                if (kezdo[i] < 10)
                {
                    valogatott[n] = kezdo[i];
                    n++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(valogatott[i] + "; ");
            }
            Console.WriteLine();


            //Minimum kiválasztás
            int[] min = { 12, 27, 29, 3, 5 };
            int minimum = min[0];
            for (int i = 1; i < min.Length; i++)
            {
                if (min[i] < minimum)
                {
                    minimum = min[i];
                }
            }
            Console.WriteLine(minimum);


            //Maximum kiválasztás
            int[] max = { 1, 27, 29, 3, 5 };
            int maximum = max[0];
            for (int i = 1; i < max.Length; i++)
            {
                if (max[i] > maximum)
                {
                    maximum = max[i];
                }
            }
            Console.WriteLine(maximum);


            //Megszámolás tétele 
            int[] megszámol = { 1, 4, 6, 7, 3, 3, 10, 2, 1 };
            int szamolo = 0;
            for (int i = 0; i < megszámol.Length; i++)
            {
                if (megszámol[i] < 6)
                {
                    szamolo++;
                }
            }
            Console.WriteLine("Hatnál kisebb számok darabszáma: {0}", szamolo);


            //Lineáris keresés tétele
            int[] keres = { 1, 5, 7, 8, 13, 11 };
            int ker = 5;
            int m = 0;
            while (m < keres.Length && keres[m] != ker)
            {
                m++;
            }
            if (m < keres.Length)
            {
                Console.WriteLine("Az elem indexe: {0}.", m);
            }
            else
            {
                Console.WriteLine("Nincs benne");
            }


            //Kiválasztás tétele
            int[] ki = { 1, 9, 3, 6, 7};
            int l = 0;
            while (ki[l] % 2 != 0)
            {
                l++;
            }
            Console.WriteLine("Az elem indexe: {0}, Az elem értéke: {1}", l, ki[l]);


            //Összegzés tétele
            int[] e = { 1, 2, 2, 3 };
            int osszeg = 0;
            int atlag;
            for (int i = 0; i < e.Length; i++)
            {
                osszeg = osszeg + e[i];
            }
            atlag = osszeg / e.Length;
            Console.WriteLine("Osszeg: " + osszeg + ", Átlag: " + atlag);


            //Eldöntés tétele B minden elemre igaz-e, hogy páros
            int[] eldontesek = { 2, 2, 6, 4, 2 };
            int k = 0;
            while (k < eldontesek.Length && eldontesek[k] % 2 == 0)
            {
                k++;
            }
            if (k < eldontesek.Length)
            {
                Console.WriteLine("Nem minden elem páros");
            }
            else
            {
                Console.WriteLine("Minden elem páros");
            }


            //Eldöntés tétele A egy elemre igaz-e
            int[] eldontes = { 2, 3, 4, 5, 6 };
            int keresett = 4;
            int j = 0;
            while (j<eldontes.Length && eldontes[j]!= keresett)
            {
                j++;
            }
            if (j<eldontes.Length)
            {
                Console.WriteLine("Benne van");
            }
            else
            {
                Console.WriteLine("Nincs benne");
            }


            //hány osztója van
            int b = 5;
            int oszto = 0;
            for (int i = 1; i <= b; i++)
            {
                if (b % i == 0)
                {
                    oszto++;
                }
            }
            Console.WriteLine(oszto);


            //hányados probléma int - double
            double hanyados = (double)14 / 3;
            Console.WriteLine(hanyados);


            //páros, páratlan
            int a = 2;
            if (a % 2 == 0)
            {
                Console.WriteLine("páros");
            }
            else
            {
                Console.WriteLine("páratlan");
            }


            //random 
            Random rnd = new Random();
            int szam = rnd.Next(4, 15);
            //tömb feltöltés
            int[] c = new int[5];
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = rnd.Next(1, 11);
                Console.Write(c[i] + "; ");
            }
            Console.WriteLine();
            //lista feltöltése
            List<int> d = new List<int>();
            int hany = rnd.Next(1, 6);
            for (int i = 0; i < hany ; i++)
            {
                d.Add(rnd.Next(1, 11));
                //Console.Write(d[i] + "; ");
            }
            foreach (int i in d)
            {
                Console.Write(i + "; ");
            }
            Console.WriteLine();
            

            //kiir - bekér
            Console.Write("Kérem a számot: ");
            int bekert = int.Parse(Console.ReadLine());
            //string bekert = Console.ReadLine();
            //int alakitott = Convert.ToInt32(bekert);
            //int alaitott = int.Parse(bekert);



        }
}
}
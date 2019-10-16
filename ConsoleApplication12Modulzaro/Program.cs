using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication12Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            Haromszogek h = new Haromszogek();
            Console.WriteLine(h.ToString());
            Console.WriteLine();
            //Beolvasás, elemekre válogatás
            string[] beolvas = File.ReadAllLines("adatok.txt", Encoding.Default);
            List<Haromszogek> haromszogek = new List<Haromszogek>();
            for (int i = 1; i < beolvas.Length; i++)
            {
                string[] alap = beolvas[i].Split(';');
                int a = int.Parse(beolvas[i].Split(';')[0]);
                int b = int.Parse(beolvas[i].Split(';')[1]);
                int c = int.Parse(beolvas[i].Split(';')[2]);
                string szin = beolvas[i].Split(';')[3];
                haromszogek.Add(new Haromszogek(a, b, c, szin));
            }
            //Háromszögek darabszáma
            int db = haromszogek.Count;
            Console.WriteLine("Háromszögek darabszáma: " + db);
            //Területek, Kerületek, Összegük, Legnagyobb terület
            double maxterulet = haromszogek[0].terulet();
            double terulet = 0;
            double kerulet = 0;
            for (int i = 0; i < haromszogek.Count; i++)
            {
                if (haromszogek[i].terulet() > maxterulet)
                {
                    maxterulet = haromszogek[i].terulet();
                }
                haromszogek[i].teruletkeruletKiir();
                terulet += haromszogek[i].terulet();
                kerulet += haromszogek[i].kerulet();
            }
            Console.WriteLine("Összes kerület: {0}, Összes terület: {1}, Legnagyobb terület: {2}", kerulet, terulet, maxterulet);
            //piros háromszögek, és kiiratás txt-fájlba, pirosak özött derékszögű
            List<Haromszogek> pirosak = new List<Haromszogek>();
            string kiir = "";
            for (int i = 0; i < haromszogek.Count; i++)
            {               
                if (haromszogek[i].getszin() == "piros")
                {
                    pirosak.Add(haromszogek[i]);
                    Console.WriteLine(haromszogek[i].ToString());
                    kiir += haromszogek[i].ToString() + Environment.NewLine;
                }
            }
            File.WriteAllText("pirosak.txt", kiir);
            int j = 0;
            while (j < pirosak.Count && !pirosak[j].derekszogu_e())
            {
                j++;
            }
            if (j < pirosak.Count)
            {
                Console.WriteLine("Van piros derékszögű.");
            }
            else
            {
                Console.WriteLine("Nincs piros derékszögű.");
            }
            Console.ReadLine();

        }
    }

}

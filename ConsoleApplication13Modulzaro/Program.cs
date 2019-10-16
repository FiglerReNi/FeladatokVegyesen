using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication13Modulzaro
{
    class Program
    {
        static List<Jarmu> autok = new List<Jarmu>();
        static void Main(string[] args)
        {
            //Jarmu auto = new Jarmu("BMV", 5, 2, 4);
            //Console.WriteLine(auto.nev);
            //Console.WriteLine(auto.ToString());
            //auto.kiir();
            
            feltolt();
            Console.WriteLine();
            //beker();
            kiir(beker());




            Console.ReadLine();
        }

        private static void kiir(int jarmuszam)
        {
            Console.WriteLine(jarmuszam + " járművet adott meg.");
        }

        private static int beker()
        {
            Console.WriteLine("Adja meg a járművek számát: ");
            return int.Parse(Console.ReadLine());
        }

        private static void feltolt()
        {
            //beolvasás, feltöltés           
            string[] beolvas = File.ReadAllLines("jarmuvek.txt", Encoding.Default);
            for (int i = 1; i < beolvas.Length; i++)
            {   
                string[] alap = beolvas[i].Split(';');
                string nev = beolvas[i].Split(';')[2];
                int szelesseg = int.Parse(beolvas[i].Split(';')[0]);
                int magassag = int.Parse(beolvas[i].Split(';')[1]);
                int db = int.Parse(beolvas[i].Split(';')[3]);
                autok.Add(new Jarmu(nev, szelesseg, magassag, db));
            }
        }
    }
}

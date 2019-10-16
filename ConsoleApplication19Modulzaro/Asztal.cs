using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19Modulzaro
{
    class Asztal
    {
        public string Nev { get; set; }
        public List<Etel> etelek;

        public Asztal(string nev)
        {
            this.Nev = nev;
            etelek = new List<Etel>();
        }

        public int osszegzes()
        {
            int ossz = 0;
            foreach (Etel item in etelek)
            {
                ossz += item.Ar;
            }
            return ossz;
        }

        public void megjelenit()
        {
            Console.WriteLine(Nev + " asztal");
            Console.WriteLine("==============================");
            foreach (Etel item in etelek)
            {
                Console.WriteLine("{0,-17}{1,13:C0}",item.Nev, item.Ar);    //sorba igazítás -17 és 13 értékekkel, hogy egymás alatt legyenek
            }
            Console.WriteLine("______________________________");
            Console.WriteLine("{0,-17} {1,12:C0}","Fizetendő:", osszegzes());
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            Alkalmazott a1 = new Alkalmazott("Peti", 21, 2);
            Alkalmazott a2 = new Alkalmazott("Pál", 25, 1);
            Console.WriteLine(a1);
            Console.WriteLine(a2.ToString());
  
            Ember e1 = new Ember("Kata", 18);
            Ember e2 = new Ember("Erzsi", 19);
            Console.WriteLine(e1);
            Console.WriteLine(e2.ToString());

            Object o = new object();
            Console.WriteLine(o);
            Console.WriteLine();
            Console.WriteLine();

            //Emberek lista, hozzáadás, kiiratás
            Ember e3 = new Ember("Ancsa", 28);
            List<Ember> emberek = new List<Ember>();
            emberek.Add(e1);
            emberek.Add(e2);
            emberek.Add(e3);
            emberek.Add(new Ember("Reni", 25));
            Console.WriteLine(e1);
            Console.WriteLine(emberek[1]);
            foreach (Ember elem in emberek)
            {
                Console.WriteLine(elem);
            }
            //Alkalmazottak lista, hozzáadás, kiiratás
            Alkalmazott a3 = new Alkalmazott("Sára", 23, 3);
            List<Alkalmazott> alkalmazottak = new List<Alkalmazott>();
            alkalmazottak.Add(a1);
            alkalmazottak.Add(a2);
            alkalmazottak.Add(a3);
            alkalmazottak.Add(new Alkalmazott("Zsuzsi", 35, 8));
            Console.WriteLine(a3);
            Console.WriteLine(alkalmazottak[3]);
            foreach (Alkalmazott elem in alkalmazottak)
            {
                Console.WriteLine(elem);
            }
            //Közös lista : Ember típusú, mert az az ős.
            List<Ember> kozos = new List<Ember>();
            kozos.Add(e1);
            kozos.Add(a1);
            kozos.Add(e2);
            kozos.Add(a2);
            kozos.Add(e3);
            kozos.Add(a3);
            kozos.Add(new Ember("Korinna", 26));
            kozos.Add(new Alkalmazott("Brogi", 34, 10));
            Console.WriteLine(a2);
            Console.WriteLine(kozos[2]);
            foreach (Ember elem in kozos)
            {
                Console.WriteLine(elem);
            }
            Console.ReadLine();
        }
    }
}

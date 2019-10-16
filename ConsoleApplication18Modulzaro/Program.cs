using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {   
            //elérések
            Ember e = new Ember("Peti", 20);
            Console.WriteLine(e.kor2);
            Console.WriteLine(e.Getkor1());

            //Dictionary típusok: Sorted; <Key, Value> pár
            IDictionary<string, int> szamok = new SortedDictionary<string, int>(); //sorba rendez
            szamok.Add("egy", 1);          
            szamok.Add("ketto", 2);
            szamok.Add("harom", 3);
            //Elem elérése a Key elemmel
            Console.WriteLine(szamok["harom"]); //Value - t írja ki
            //Kiiratás
            foreach (KeyValuePair<string, int> elem in szamok)
            {
                Console.WriteLine(elem); // teljes elemet írja ki
                Console.WriteLine(elem.Key); //elsőt írja ki
                Console.WriteLine(elem.Value); //másodikat írja ki
            }
            Console.WriteLine();

            //Dictionary típusok: Alap
            IDictionary<int, char> betuk = new Dictionary<int, char>();
            betuk.Add(1, 'a');
            betuk.Add(2, 'b');
            betuk.Add(3, 'c');
            //Elem elérése a Key elemmel
            Console.WriteLine(betuk[2]); //Value - t írja ki
            //Kiiratás
            foreach (KeyValuePair<int, char> elem in betuk)
            {
                Console.WriteLine(elem); // teljes elemet írja ki
                Console.WriteLine(elem.Key); //elsőt írja ki
                Console.WriteLine(elem.Value); //másodikat írja ki
            }

            //Dictionary Ember típussal
            IDictionary<string, Ember> barat = new Dictionary<string, Ember>();
            Ember e1 = new Ember("Péter", 23);
            //barat.Add("Pál barátja: ", e1); A kulcs értéke nem lehet azonos
            barat.Add("Zsófi barátja: ", e1);
            barat.Add("Pál barátja: ", new Ember("Zsóka", 25));
            barat.Add("Erzsi barátja: ", new Ember("Ildi", 22));
            //Elem elérése a Key elemmel
            Console.WriteLine(barat["Pál barátja: "]);  //ToStringet ad vissza, mert írtunk ilyet az Embernél
            //Kiiratás
            foreach (KeyValuePair<string, Ember> elem in barat)
            {
                Console.WriteLine(elem); // teljes elemet írja ki
                Console.WriteLine(elem.Key); //elsőt írja ki
                Console.WriteLine(elem.Value); //másodikat írja ki
            }

            //Dictionary Listával
            IDictionary<string, List<Ember>> baratok = new Dictionary<string, List<Ember>>();
            List<Ember> baratlista1 = new List<Ember>();
            List<Ember> baratlista2 = new List<Ember>();
            baratok.Add("Pál barátai: ", baratlista1);
            baratok.Add("Réka barátai: ", baratlista2);
            baratlista1.Add(e1);
            baratlista1.Add(new Ember("Zsóka", 25));
            baratlista2.Add(e);
            baratlista2.Add(new Ember("Ildi", 22));
            foreach (KeyValuePair<string, List<Ember>> elem in baratok)
            {              
                Console.WriteLine(elem.Key); //elsőt írja ki
                foreach (Ember item in elem.Value)
                {
                    Console.WriteLine("\t" + item); //listát elemenként írja ki
                }
            }

            //Egy elem csak egyszer kerül bele
            HashSet<string> csakEgyedi = new HashSet<string>();
            csakEgyedi.Add("Péter");
            csakEgyedi.Add("Pál");
            csakEgyedi.Add("Petra");
            csakEgyedi.Add("Péter");
            csakEgyedi.Add("Pisti");
            csakEgyedi.Add("Péter");
            Console.WriteLine($"csakEgyedi darabszáma: {csakEgyedi.Count}");
            foreach (string nev in csakEgyedi)
            {
                Console.WriteLine(nev);
            }
            Console.ReadLine();

     

        }
    }
}

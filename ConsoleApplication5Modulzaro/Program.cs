using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApplication5Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Barátok - kine van a legtöbb barátja, kik azok, és hány db (lista a listában)
            string[] baratok = File.ReadAllLines("baratok.txt", Encoding.Default);
            IDictionary<string, List<string>> baratsag = new SortedDictionary<string, List<string>>();
            //Dictionary<string, List<string>> baratsag = new Dictionary<string, List<string>>();
            List<string> baratokneve = new List<string>();
            bool elsosor = true;
            foreach (string sor in baratok)
            {
                //Console.WriteLine(sor);
                if (!String.IsNullOrEmpty(sor))
                {
                    if (elsosor)
                    {
                        baratsag.Add(sor, baratokneve);
                        elsosor = false;
                    }
                    else
                    {
                        baratokneve.Add(sor);
                    }
                }
                else
                {
                    baratokneve = new List<string>();
                    elsosor = true;
                }
            }
            //kiiratás sorban
            foreach (KeyValuePair<string, List<string>> par in baratsag)
            {
                Console.WriteLine(par.Key);
                par.Value.Sort();
                foreach (string item in par.Value)
                {
                    Console.WriteLine("\tBarátja:" + item);
                }
            }
            int db = 0;
            string kinek = "";
            foreach (KeyValuePair<string, List<string>> par in baratsag)
            {
                if (par.Value.Count > db)
                {
                    db = par.Value.Count;
                    kinek = par.Key;
                }
            }
            Console.WriteLine("A legtöbb barátja van: " + kinek + " " + db + "db.");
            foreach (string par in baratsag[kinek])
            {
                Console.Write(par + "; ");
            }
            Console.WriteLine();
            //Hashset - egy elem csak egyszer kerül bele
            HashSet<string> csakbaratok = new HashSet<string>();
            foreach (KeyValuePair<string, List<string>> par in baratsag)
            {
                foreach (string item in par.Value)
                {
                    csakbaratok.Add(item);
                }
            }
            foreach (string item in csakbaratok)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(csakbaratok.Count);
            Console.WriteLine();
            Console.WriteLine();


            //Nevek, korok másként Dictionary
            string[] nevkor = File.ReadAllLines("korok.txt", Encoding.Default);
            Dictionary<string, int> ujnevkor = new Dictionary<string, int>(); 
            foreach (string sor in nevkor)
            {
                Console.WriteLine(sor);
                ujnevkor.Add(sor.Split(';')[0], int.Parse(sor.Split(';')[1]));
            }
            Console.WriteLine("Add meg a nevet: ");
            string megadottnev = Console.ReadLine();
            foreach (KeyValuePair<string, int> sor in ujnevkor)
            {
                //Console.WriteLine(sor.Key + sor.Value);
                if (megadottnev == sor.Key)
                {
                    Console.WriteLine("Kora: " + sor.Value);
                }
            }
            Console.WriteLine();
           
            
            //Nevek feladat
            string[] nevek = File.ReadAllLines("nevek.txt", Encoding.Default);
            List<string> ter = new List<string>();
            Console.WriteLine("Teljes lista: ");
            foreach (string sor in nevek)
            {
                Console.WriteLine(sor);
            }
            Console.WriteLine();
            foreach (string sor in nevek)
            {
                if (sor.EndsWith("ter"))
                 //(sor.Contains("ter"))
                {
                    Console.WriteLine(sor + "; ");
                    ter.Add(sor);
                }
            }
            Console.WriteLine();
            foreach (string sor in ter)
            {
                Console.WriteLine(sor+"; " );
            }
            Console.WriteLine();


            //Korok feladat
            string[] tartalom = File.ReadAllLines("korok.txt", Encoding.Default);
            List<string> idosnevek = new List<string>();
            foreach (string sor in tartalom)
            {   
                Console.WriteLine(sor);
                if (int.Parse(sor.Split(';')[1]) > 18)
                {
                    idosnevek.Add(sor);
                }
            }
            foreach (string sor in idosnevek)
            { 
                Console.WriteLine(sor.Split(';')[0]);
            }
            int maxkor = int.Parse(idosnevek[0].Split(';')[1]);
            string maxnev = "";
            for (int f = 1; f < idosnevek.Count; f++)
            {
                if (int.Parse(idosnevek[f].Split(';')[1]) > maxkor )
                {
                    maxkor = int.Parse(idosnevek[f].Split(';')[1]);
                    maxnev = idosnevek[f].Split(';')[0];
                }
            }
            Console.WriteLine("Legidősebb: " + maxnev + " Kora: " + maxkor);


            //tökéletes szám fv
            int[] a = { 1, 5, 14, 6, 18, 23, 22, 18, 28 };
            int j;
            int oszto;
            for (int l = 0; l < a.Length; l++)
            {
                oszto = 0;
                for (j = 1; j < a[l]; j++)
                {
                    if (osztas(a[l], j))
                    {
                        oszto = oszto + j;
                    }
                }
                if (a[l] == oszto)
                {
                    Console.Write(a[l] + "; ");
                }
            }
            Console.WriteLine();


            //páros szám fv (van-e benne páros szám)
            int[] tomb = { 1, 5, 14, 6, 18, 23, 22, 18 };
            int i = 0;
            while (i<tomb.Length && !paros(tomb[i]))
            {
                i++;
            }
            if (i<tomb.Length)
            {
                Console.WriteLine("Van benne páros szám");
                Console.WriteLine("Indexe: " + i + "; Értéke: " + tomb[i]);
            }
            else
            {
                Console.WriteLine("Nincs benne.");
            }


            //Listák 
            //ArrayList - mindenféle elem pakolható bele:
            ArrayList listamidenfele = new ArrayList();
            listamidenfele.Add('5');
            listamidenfele.Add('s');
            listamidenfele.Add("szilva");
            listamidenfele.Add(3);
            listamidenfele.Add(22 * 5);
            kiirarray(listamidenfele);
            //List - egyféle típust tud egyszerre
            List<int> lista = new List<int>();
            lista.Add(23);
            lista.Add(5 + 2);
            lista.Add(15);
            lista.Add(23);
            kiirlist(lista);
        
            Console.ReadLine();
        }

        private static bool osztas(int szam, int oszto)
        {
            return szam % oszto == 0;
        }

        private static bool paros(int szam)
        {
            return szam % 2 == 0;
            
        }

        private static void kiirlist(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(i + "; ");
            }
        }

        private static void kiirarray(ArrayList lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i] + "; ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication19Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas1 = File.ReadAllLines("etelek.txt", Encoding.Default);
            List<Etel> alaplistaetelek = new List<Etel>();
            foreach (string sor in beolvas1)
            {
                string nev = sor.Split('|')[0];
                int ar = int.Parse(sor.Split('|')[1]);              
                alaplistaetelek.Add(new Etel(nev, ar));
            }
            string[] beolvas2 = File.ReadAllLines("asztalok.txt", Encoding.Default);
            List<Asztal> asztalok = new List<Asztal>();
            bool elsosor = true;
            Asztal egyasztal = null;
            foreach (string sor in beolvas2)
            {
                if (elsosor)
                {
                    egyasztal = new Asztal(sor);
                    asztalok.Add(egyasztal);
                    egyasztal.etelek = new List<Etel>();
                    elsosor = false;
                }
                else
                {   //(!String.IsNullOrEmpty(sor))
                    if (sor != "") 
                    {
                        foreach (Etel item in alaplistaetelek)
                        {
                            if (sor == item.Nev)
                            {
                                egyasztal.etelek.Add(new Etel(item.Nev, item.Ar));                                   
                            }
                        }
                    }
                    else
                    {
                        elsosor = true;
                    }
                }
            }
            foreach (Asztal item in asztalok)
            {
                item.megjelenit();
            }
            Console.ReadLine();

        }
    }
}

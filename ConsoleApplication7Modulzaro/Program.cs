using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            Asztal jatek = new Asztal(2);
            jatek.mutat();
            jatek.megraz();
            Console.WriteLine();


           Kockaprogram kockaprogram = new Kockaprogram();
            //Console.WriteLine(kockaprogram.mutat());
            Console.WriteLine(kockaprogram.ToString());
            kockaprogram.dobas();
            Console.WriteLine(kockaprogram.mutat());
            Console.WriteLine();
           Kockaprogram kockaprogram2 = new Kockaprogram(100);
            kockaprogram2.dobas();
            Console.WriteLine(kockaprogram2.mutat());
            Console.WriteLine(kockaprogram2.ToString());

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabla sakk = new Tabla('#');
            Console.WriteLine("4.feladat: az üres tábla: ");
            Console.WriteLine(sakk.Megjelenit());
            sakk.Elhelyez(5);

            Console.WriteLine("6.feladat: a feltöltött tábla: ");
            Console.WriteLine(sakk.Megjelenit());

            Console.WriteLine("9.feladat: üres oszlopok és sorok száma: ");
            Console.WriteLine("Oszlopok: " + sakk.UresOszlopokSzama + Environment.NewLine + "Sorok: " + sakk.UresSorokSzama);

            //10.feladat: tablak64.txt;
            sakk.fajlbaIr();
            Console.ReadLine();
        }
    }
}

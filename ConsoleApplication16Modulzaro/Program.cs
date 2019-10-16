using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {

            Négyzet n = new Négyzet(6);
            Console.WriteLine(n);
            Teglalap t = new Teglalap(5, 2);
            Console.WriteLine(t);
            List<Alakzat> a = new List<Alakzat>();
            a.Add(n);
            a.Add(t);
            foreach (Alakzat elem in a)
            {
                Console.WriteLine(elem);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            Négyzet n1 = new Négyzet(3);
            Teglalap t1 = new Teglalap(2, 3);
            Haromszog h1 = new Haromszog(3, 4, 5);
            //Alakzat a1 = new Alakzat(); //abstract class nem példányosítható

            List<Alakzat> alakzatok = new List<Alakzat>();
            alakzatok.Add(n1);
            alakzatok.Add(t1);
            alakzatok.Add(h1);
            alakzatok.Add(new Teglalap(5,2));
            foreach (Alakzat elem in alakzatok)
            {
                Console.WriteLine(elem);  //ToString() - et írja ki
                Console.WriteLine("\t csak terület: " + elem.terulet());  
            }
            Console.ReadLine();

        }
    }
}

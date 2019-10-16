using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            Emberek e = new Emberek(1982,"");
            e.munkatvallal();
            e.felmond();
            e.Setnev("Peti");


            Console.WriteLine(e.getnev());
            Console.WriteLine(e.getev());
            Console.WriteLine(e.getkor());
            Console.WriteLine(e.dolgozike());
            Console.WriteLine(e.ToString());
            Console.ReadLine();


        }
    }
}

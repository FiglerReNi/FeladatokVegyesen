using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            Console.WriteLine(auto.ToString());
            auto.halad();
            //auto.motor = true;
            auto.motoratallitas(true);
            auto.halad();
            auto.halad();
            auto.tankol(20);
            auto.motoratallitas(false);
            auto.tankol(20);
            Console.WriteLine(auto.ToString());
            Console.ReadLine();
        }
    }
}

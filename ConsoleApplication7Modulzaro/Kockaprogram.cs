using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7Modulzaro
{
    class Kockaprogram
    {
        private int eredmeny, oldalakszama;
        Random r = new Random();
        public Kockaprogram(int oldalakszama = 6)
        {
            this.oldalakszama = oldalakszama;
            eredmeny = r.Next(1, oldalakszama + 1);

        }
        public void dobas()
        {
            Console.WriteLine("Dobás folyamatban: ");
            eredmeny = r.Next(1, this.oldalakszama + 1);
        }
        public int mutat()
        {
            return eredmeny;
        }
        public override string ToString()
        {
            return String.Format("Oldalak száma: " + oldalakszama + ", Dobások értéke: " + eredmeny);
        }
    }
}
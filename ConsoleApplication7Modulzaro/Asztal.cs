using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7Modulzaro
{
    class Asztal
    {
        private int db;
        List<Kockaprogram> kocka;
        Random r = new Random();

        public Asztal(int kockaszama)
        {

            db = kockaszama;
            kocka = new List<Kockaprogram>();
            for (int i = 0; i < kockaszama; i++)
            {
                int o = r.Next(1, 100);             
                kocka.Add(new Kockaprogram(o));                
            }
        }

        public void mutat()
        {
            Console.WriteLine("Kockák száma: " + db);
            foreach (Kockaprogram kockak in kocka)
            {
                Console.WriteLine(kockak.ToString());
            }
        }
        public void megraz()
        {
            Console.WriteLine("Az asztalt megrázták");
            foreach (Kockaprogram kockak in kocka)
            {
                kockak.dobas();
            }
            mutat();
        }
    }
}

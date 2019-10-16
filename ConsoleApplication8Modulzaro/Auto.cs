using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8Modulzaro
{
    class Auto
    {
        private bool benzin;
        public bool motor;
        private int penztarca;

        public Auto()
        {
            benzin = true;
            penztarca = 100;
            motor = false;
        }

        public void halad()
        {
            if (benzin && motor)
            {
                Console.WriteLine("A kocsi halad, de kifogy a benzin.");
                benzin = false;
            }
            else
            {
                Console.WriteLine("A kocsi áll.");
            }
        }
        public bool tankol(int penz)
        {
            bool siker = false;
            if (penz <= penztarca)
            {
                if (!motor)
                {
                    siker = true;
                    benzin = true;
                    penztarca = penztarca - penz;
                    Console.WriteLine("Sikeres tankolás!");
                }
                else
                {
                    Console.WriteLine("Állítsd le a motort!");
                }                
            }
            else
            {
                Console.WriteLine("Nincs elég pénzed!");
            }
            return siker;
        }
        public bool motoratallitas(bool allapot)
        {
            return motor = allapot;
        }
        public override string ToString()
        {
            return String.Format("motor: {0}, benzin:{1}, pénztárca: {2}", motor, benzin, penztarca);
        }
    }
}

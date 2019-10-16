using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14Modulzaro
{
    class Alkalmazott : Ember
    {
        private int ev;

        public Alkalmazott(string nev, int kor, int ev) : base(nev, kor)
        {
            this.ev = ev; 
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" Ledolgozott évek száma: " + ev);
        }

        public void HanyEvesen()
        {
            Console.WriteLine("Hány évesen kezdett  dolgozni: " + (kor - ev));
        }

    }
}

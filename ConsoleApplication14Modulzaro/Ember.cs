using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14Modulzaro
{
    class Ember
    {
        protected string nev; //protected a tartalmazó és származtatott osztályokban érhetó csak el
        protected int kor;

        public Ember(string nev, int kor)
        {
            this.nev = nev;
            this.kor = kor;
        }

        public override string ToString()
        {
            return String.Format("Név: {0}, Kor: {1}", nev, kor);
        }
    }
}

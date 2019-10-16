using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15Modulzaro
{
    class Négyzet: Alakzat
    {
        private int a;

        public Négyzet(int a)
        {
            this.a = a;
        }

        public int kerulet() { return (4 * a); }

        public int terulet() { return (a * a); }

        public override string ToString()
        {
            return String.Format("Négyzet: \nkerület: {0}, terület: {1}", kerulet(), terulet());
        }
    }
}

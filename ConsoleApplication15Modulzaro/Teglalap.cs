using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15Modulzaro
{
    class Teglalap : Alakzat
    {
        private int a, b;

        public Teglalap(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int kerulet() { return (2* (b + a)); }

        public int terulet() { return (b * a); }

        public override string ToString()
        {
            return String.Format("Téglalap: \nkerület: {0}, terület: {1}", kerulet(), terulet());
        }
    }
}

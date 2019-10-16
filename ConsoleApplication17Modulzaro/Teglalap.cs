using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17Modulzaro
{
    class Teglalap : Alakzat
    {
        private int a, b;

        public Teglalap(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override int kerulet() { return (2* (b + a)); }  //az abstract osztály függvényeit tudjuk felülírni

        public override double terulet() { return (b * a); }

        public override string ToString()
        {
            return String.Format("Téglalap: \nkerület: {0}, terület: {1}", kerulet(), terulet());
        }
    }
}

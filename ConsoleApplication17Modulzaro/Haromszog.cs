using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17Modulzaro
{
    class Haromszog : Alakzat
    {
        private int a, b, c;

        public Haromszog(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        public override int kerulet()
        {
            return (a + b + c);
        }

        public override double terulet()
        {
            double s = kerulet() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public override string ToString()
        {
            return String.Format("Háromszög: \nkerület: {0}, terület: {1}", kerulet(), terulet());
        }
    }
}

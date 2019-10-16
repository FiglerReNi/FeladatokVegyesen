using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12Modulzaro
{
    class Haromszogek
    {
        double a, b, c;
        string szin;

        public Haromszogek(int a, int b, int c, string szin="kék")
        {
            if (a<1)
            {
                a = 1;
            }
            this.a = a;
            if (b < 1)
            {
                b = 1;
            }
            this.b = b;
            if (c<1)
            {
                c = 1;
            }
            this.c = c;
            this.szin = szin;
         }
        public Haromszogek(int a, int b, int c) : this(a, b, c, "kék")
        {
        }
        public Haromszogek() : this(1, 1, 1)
        {
        }

        public double geta() { return a; }
        public double getb() { return b; }
        public double getc() { return c; }
        public string getszin() { return szin; }

        public bool derekszogu_e()
        {
            return a * a + b * b == c * c;
        }
        public double kerulet()
        {
            return a + b + c;
        }
        public double terulet()
        {
            double s = kerulet() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public void teruletkeruletKiir()
        {
            Console.WriteLine("Kerület: {0:N3}; Terület: {1:N3}", kerulet(), terulet());
        }
        public override string ToString()
        {
            return String.Format("a: {0}, b: {1}, c: {2}, kerület: {3:N3}, terület: {4:N3}, szín: {5}", a, b, c, kerulet(), terulet(), szin);
        }

    }
}

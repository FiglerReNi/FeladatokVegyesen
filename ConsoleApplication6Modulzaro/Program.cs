using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            Haromszog haromszog = new Haromszog();
            Teglalap teglalap = new Teglalap();
            teglalap.keruletir();
            teglalap.SetA(3);
            teglalap.SetB(5);
            teglalap.teruletir();
            teglalap.keruletir();
            Console.WriteLine(teglalap.ToString());
            Teglalap teglalap2 = new Teglalap(10, 3);
            teglalap2.keruletir();
            Console.ReadLine();
        }
    }

    class Haromszog
    {
        //ADATTAGOK
        private double a, b, c;
        //TAGFÜGGVÉNYEK
        //konstruktor
        public Haromszog()
        {
            SetA(a);
            SetB(b);
            SetB(c);
        }
        public Haromszog(double a, double b, double c)
        {
            SetA(a);
            SetB(b);
            SetB(c);
        }
        //setter - beállítók
        public void SetA(double a) { this.a = a; }
        public void SetB(double b) { this.b = b; }
        public void SetC(double c) { this.c = c; }
        //getter lekérdezők
        public double GetA() { return a; }
        public double GetB() { return b; }
        public double GetC() { return c; }

        public bool Egyenloszaru() { return a == b; }
    }

    class Teglalap
    {
        //ADATTAGOK
        private int a, b;
        //TAGFÜGGVÉNYEK
        //konstruktor
        public Teglalap()
        {
            SetA(a);
            SetB(b);
        }
        public Teglalap(int a, int b)
        {
            SetA(a);
            SetB(b);
        }
        //setter - beállítók
        public void SetA(int Uja)
        {
            if (Uja > 0 && Uja != b)
            {
                a = Uja;
            }
            else
            {
                a = 1;
            }
        }
        public void SetB(int Ujb)
        {
            if (Ujb > 0 && Ujb != a)
            {
                b = Ujb;
            }
            else
            {
                b = 1;
            }
        }
        //getter - leérdezők
        public int GetA() { return a; }
        public int GetB() { return b; }
        //ToString felülírása
        public override string ToString()
        {
            return String.Format("a: {0}, b: {1}, kerület: {2}, terület: {3},", a, b, kerulet(), terulet());
        }
        //Függyvények, eljárások
        public int kerulet()
        {
            return 2 * (a + b);
        }
        public int terulet()
        {
            return a * b;
        }
        public void keruletir()
        {
            Console.WriteLine("Kerület: " + kerulet());
        }
        public void teruletir()
        {
            Console.WriteLine("Terület: " + terulet());
        }
    }
}

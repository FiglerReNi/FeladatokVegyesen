using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16Modulzaro
{
    class Négyzet: Alakzat
    {
        private int a;
        private Teglalap t; // tartalmazás (egyik class tartalmazhatja a másikat. Itt a négyzetnek van egy téglalapja, így elérhetjük a téglalap területét, kerületét, stb.
        public Négyzet(int a)
        {
            this.a = a;
            t = new Teglalap(a, a); //mivel négyzet az oldalak egyenlőek lesznek
        }

        public int kerulet() { return t.kerulet(); } // téglalap függyvényeit hívjuk meg

        public int terulet() { return t.kerulet(); }

        public override string ToString()
        {
            return String.Format("Négyzet: \nkerület: {0}, terület: {1}", kerulet(), terulet());
        }
    }
}

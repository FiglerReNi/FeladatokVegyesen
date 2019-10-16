using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18Modulzaro
{
    class Ember
    {
        //adattagok megadása:
        // 1.
        private string nev1; //külön állíthatóak be getterek és setterek ha szükség van rá;
        private int kor1; //külön állíthatóak be getterek és setterek ha szükség van rá;
                          // main-ben, másik classban nem érhetőek ezek el;
                          // main-ben lekérdezés csak ha van getter;
        public string Getnev1(){ return nev1; }
        public int Getkor1() { return kor1; }

        // 2.
        public string nev2; // elérhetőek mainben, másik classban
        public int kor2;    // elérhetőek mainben, másik classban

        //3
        public int Kor { get; } //nem lehet kort változtatni, ha lehagyjuk a set-et, de mainben elérhető;
        //4.
        public string Nev { get; set; } //mindent lehet vele
        //5.
        protected int nev3; //classban elérhető  (tartalmazó és származtatott osztályokban), de mainben nem.
        protected int kor3; //classban elérhető(tartalmazó és származtatott osztályokban), de mainben nem.

        public Ember(string nev, int kor)
        {   
            this.Nev = nev;
            this.Kor = kor;
        }

        public override string ToString()
        {
            return String.Format("Kor: {0}, Név:{1}", Kor, Nev);
        }

    }
}


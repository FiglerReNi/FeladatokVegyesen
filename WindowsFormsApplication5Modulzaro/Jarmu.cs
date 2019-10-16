using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5Modulzaro
{
    class Jarmu
    {
        public string nev { get; set; }
        public int szelesseg { get; set; }
        public int magassag { get; set; }
        public int db { get; set; }

        public Jarmu(string nev, int szelesseg, int magassag, int db)
        {
            this.nev = nev;
            this.szelesseg = szelesseg;
            this.magassag = magassag;
            this.db = db;
        }

        public override string ToString()
        {
            return String.Format("Név: {0}, Szélesség: {1}, Magasság: {2}, Kerék száma: {3}", nev, szelesseg, magassag, db);
        }
        public void kiir()
        {
            Console.WriteLine("Név: {0}, Szélesség: {1}, Magassás: {2}, Kerék száma: {3}", nev, szelesseg, magassag, db);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication8Modulzaro
{
    class Emberek
    {
        public string nev { get; set; }
        public int kor { get; set; }
        public string nem { get; set; }
        public int evek { get; set; }
        public Emberek(string nev, int kor, string nem, int evek)
        {
            this.nev = nev;
            this.kor = kor;
            this.nem = nem;
            this.evek = evek;
        }
    }
}

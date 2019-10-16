using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6Modulzaro
{
    class Asztal
    {
    
        public List<Tetel> tetel { get; set; }
        public string neve { get; set; }


        public Asztal (string neve)
        {
            this.neve = neve;
            this.tetel = new List<Tetel>();
        }

        public void hozzaad(Tetel tetelhozza)
        {
            tetel.Add(tetelhozza);
        }

        public int osszesen()
        {
            int ossz = 0;
            for (int i = 0; i < tetel.Count; i++)
            {
                ossz += tetel[i].ar;
            }
            return ossz;
        }
        public override string ToString()
        {
            string kiir = neve + Environment.NewLine;
            foreach (Tetel elem in tetel)
            {
                kiir += "\t" + elem.nev +"  :  " + elem.ar + Environment.NewLine;
            }
            kiir += "...................................." + Environment.NewLine + "Összesen: " + osszesen() + "Ft";
            return kiir;
        }
    }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9Modulzaro
{
    class Emberek
    {   //adattagok
        private int ev;
        private string nev;
        private bool dolgozik;
        //konstruktorok
        public Emberek()
        {
            this.ev = 0;
            this.nev = "John Doe";
            this.dolgozik = false;
        }
        public Emberek(int Ev)
        {
            if (Ev < 0)
            {
                this.ev = 0;
            }
            else
            {
                this.ev = Ev;
            }
            this.nev = "John Doe";
            this.dolgozik = false;
        }
        public Emberek(string Nev)
        {
            if (Nev == "")
            {
                this.nev = "John Doe";
            }
            else
            {
                this.nev = Nev;
            }
            this.ev = 0;
            this.dolgozik = false;
        }
        public Emberek(int Ev, string Nev)
        {
            if (Nev == "")
            {
                this.nev = "John Doe";
            }
            else
            {
                this.nev = Nev;
            }
            if (Ev < 0)
            {
                this.ev = 0;
            }
            else
            {
                this.ev = Ev;
            }
            this.dolgozik = false;
        }
        //setter
        public void munkatvallal()
        {
            dolgozik = true;
        }
        public void felmond()
        {
            dolgozik = false;
        }
        public void Setnev(string nevuj)
        {
            if (nevuj != "")
            {
                nev = nevuj;
            }
            
        }
        //getter
        public string getnev() { return nev; }
        public int getev() { return ev; }
        public int getkor()
        {
            if (ev==0)
            {
                return 0;
            }
            else
            {
                return 2018 - ev;
            }         
        }
        public bool dolgozike() { return dolgozik; }
        //felülírás
        public override string ToString()
        {
            string kor;          
            if (ev != 0)
            {
                    kor = getkor() + "";
                
            }
            else
            {
                kor = "Nem ismert.";
            }         
            return String.Format("Név: {0}, Év: {1}, Kor: {2}, Dolgozik: {3}", nev, ev, kor, dolgozik);
        }
        //saját
        public void setal()
        {
            Console.WriteLine("Sétál.");
        }


    }
}

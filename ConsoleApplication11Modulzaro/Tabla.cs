using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication11Modulzaro
{
    class Tabla
    {
        private char[,] T;
        private char UresCella;

        public Tabla(char cellaertek)
        {
            T = new char[8, 8];
            this.UresCella = cellaertek;
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    T[i, j] = UresCella;
                }
            }
        }
        public int UresOszlopokSzama
        {
            get{
                int uresoszlop = 0;
                for (int i = 0; i < T.GetLength(1); i++)
                {
                    if (UresOszlop(i))
                    {
                        uresoszlop++;
                    }
                }
                return uresoszlop;
                }
        }
       public int UresSorokSzama
        {
            get
            {
                int uressor = 0;
                for (int i = 0; i < T.GetLength(0); i++)
                {
                    if (UresSor(i))
                    {
                        uressor++;
                    }
                }
                return uressor;
            }
        }

        public string Megjelenit()
        {
                string kiir = "";
              for (int i = 0; i < T.GetLength(0); i++)
            {
                
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    //Console.Write(T[i, j]);
                    kiir += (T[i, j]);
                }
                //Console.WriteLine();
                kiir += Environment.NewLine;
            }
            //Console.WriteLine();
            kiir += Environment.NewLine;
            return kiir;
        }
        public void Elhelyez(int N)
        {
            Random r = new Random();
            int hely1;
            int hely2;
            int elhelyezett = 0;
            while (elhelyezett < N)         
            {
                hely1 = r.Next(0, 7);
                hely2 = r.Next(0, 7);
                if (T[hely1,hely2] != 'k')
                {
                    T[hely1, hely2] = 'K';
                    elhelyezett++;
                }

            }
        }
        public bool UresOszlop(int oszlop)
        {
            bool ures = true;
            int i = 0;
            while (i<T.GetLength(0) && T[i,oszlop] != 'K')
            {
                i++;
            }
            if (i < T.GetLength(0))
            {
                ures = false;
            }
            return ures;
        }
        public bool UresSor(int sor)
        {
            bool ures = true;
            int i = 0;
            while (i < T.GetLength(1) && T[sor, i] != 'K')
            {
                i++;
            }
            if (i < T.GetLength(1))
            {
                ures = false;
            }
            return ures;
        }
        public void fajlbaIr()
        {
            if (File.Exists("tablak64.txt"))
            {
                File.Delete("tablak64.txt");
            }            
            Tabla[] tabla64tomb = new Tabla[65];
            string kiir = "";
            for (int i = 1; i < 65; i++)
            {
                Tabla tabla64 = new Tabla('*');
                tabla64.Elhelyez(i);
                tabla64tomb[i] = tabla64;
                kiir += tabla64.Megjelenit();  
            }
            File.WriteAllText("tablak64.txt", kiir);
            
        }

    }
}

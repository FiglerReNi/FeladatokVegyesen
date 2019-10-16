using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication10Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> ipcimek = new List<List<int>>();

            string[] beolvas = File.ReadAllLines("adatok.txt");
            foreach (string sor in beolvas)
            {
                List<int> belso = new List<int>();
                Console.WriteLine(sor);
                string[] split = sor.Split('.');
                for (int i = 0; i < split.Length; i++)
                {
                    belso.Add(int.Parse(split[i]));
                }
                ipcimek.Add(belso);                
            }
            int minindex = 0;  // külső lista i
            int maxindex = 0; // külső lista i
            int utolsominindex = ipcimek[0].Count - 1; //belső lista i
            int utolsomaxindex = ipcimek[0].Count - 1; //belső lista i
            for (int i = 0; i < ipcimek.Count; i++)
            {
                if (ipcimek[i][ipcimek[i].Count - 1] > ipcimek[maxindex][utolsomaxindex] )
                {
                    maxindex = i;
                    utolsomaxindex = ipcimek[i].Count - 1;
                }
                if (ipcimek[i][ipcimek[i].Count - 1] < ipcimek[minindex][utolsominindex])
                {
                    minindex = i;
                    utolsominindex = ipcimek[i].Count - 1;
                }
                
            }
            Console.WriteLine("MAX: " + ipcimek[maxindex][utolsomaxindex] + Environment.NewLine + "MIN: " + ipcimek[minindex][utolsominindex]);
            Console.Write("MAX: " + ipcimek[maxindex][0]);
            for (int i = 1; i < ipcimek[maxindex].Count-1; i++)
            {
                Console.Write("." + ipcimek[maxindex][i] );
            }
            Console.WriteLine();
            Console.Write("MIN: " + ipcimek[minindex][0]);
            for (int i = 1; i < ipcimek[minindex].Count - 1; i++)
            {
                Console.Write("." + ipcimek[minindex][i]);
            }
            Console.ReadLine();
        }
    }
}

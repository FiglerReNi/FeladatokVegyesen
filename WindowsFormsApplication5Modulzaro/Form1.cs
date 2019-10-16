using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication5Modulzaro
{
    public partial class Form1 : Form
    {
        static List<Jarmu> autok = new List<Jarmu>();
        public Form1()
        {
            InitializeComponent();
            string[] beolvas = File.ReadAllLines("jarmuvek.txt", Encoding.Default);
            for (int i = 1; i < beolvas.Length; i++)
            {
                string[] alap = beolvas[i].Split(';');
                string nev = beolvas[i].Split(';')[2];
                int m = int.Parse(beolvas[i].Split(';')[1]);
                int sz = int.Parse(beolvas[i].Split(';')[0]);
                int db = int.Parse(beolvas[i].Split(';')[3]);
                autok.Add(new Jarmu(nev, sz, m, db));
                jarmulista.Items.Add(beolvas[i].Split(';')[2]);
            }
            //foreach (string sor in beolvas)
            //{
            //    if (sor.Contains(';'))
            //    {
            //        string[] alap = sor.Split(';');
            //        string nev = sor.Split(';')[2];
            //        int m = int.Parse(sor.Split(';')[1]);
            //        int sz = int.Parse(sor.Split(';')[0]);
            //        int db = int.Parse(sor.Split(';')[3]);
            //        autok.Add(new Jarmu(nev, sz, m, db));
            //        jarmulista.Items.Add(sor.Split(';')[2]);
            //    }
            //}

        }

        private void jarmulista_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < autok.Count; i++)
            {
                if (autok[i].nev == jarmulista.SelectedItem.ToString())
                {
                    magassag.Text = autok[i].magassag.ToString();
                    szelesseg.Text = autok[i].szelesseg.ToString();
                    db.Text = autok[i].db.ToString();
                }
            }
           
           
        }
    }
}

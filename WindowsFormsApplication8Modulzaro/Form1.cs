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

namespace WindowsFormsApplication8Modulzaro
{
    public partial class Fodolgozok : Form
    {
        string[] beolvas = File.ReadAllLines("emberek.txt", Encoding.Default);
        List<Emberek> emberek = new List<Emberek>();
        List<int> lanymiota = new List<int>();
        List<int> fiumiota = new List<int>();

        public Fodolgozok()
        {
            InitializeComponent();

            for (int i = 1; i < beolvas.Length; i++)
            {
                string[] alap = beolvas[i].Split(';');
                string nev = beolvas[i].Split(';')[0];
                int kor = int.Parse(beolvas[i].Split(';')[1]);
                string nem = beolvas[i].Split(';')[2];
                int evek;
                if (alap.Length > 3)
                {
                    evek = int.Parse(beolvas[i].Split(';')[3]);
                }
                else
                {
                    evek = 0;
                }
                emberek.Add(new Emberek(nev, kor, nem, evek));
                if (emberek[i - 1].nem == "L")
                {
                    Folanyok.Items.Add(emberek[i - 1].nev);
                    lanymiota.Add(emberek[i - 1].evek);
                }
                else
                {
                    Fofiuk.Items.Add(emberek[i - 1].nev);
                    fiumiota.Add(emberek[i - 1].evek);
                }
            }
        }

        private void Folanyok_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Emberek elem in emberek)
            {
                if (elem.nev == Folanyok.SelectedItem.ToString())
                {
                    Adatokkor.Text = elem.kor.ToString();
                    Adatokmiota.Text = elem.evek.ToString();
                }
            }
        }
        private void Fofiuk_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Emberek elem in emberek)
            {
                if (elem.nev == Fofiuk.SelectedItem.ToString())
                {
                    Adatokkor.Text = elem.kor.ToString();
                    Adatokmiota.Text = elem.evek.ToString();
                }
            }
        }
        private void Osszesitolany_CheckedChanged(object sender, EventArgs e)
        {

            Osszesitolegidosebb.Text = max(emberek, "L").ToString();
            Osszesitokor.Text = osszkor(emberek, "L").ToString();
            Osszesito6ev.Text = hateveki(lanymiota, "L") + "";
        }
        private void Osszesitofiu_CheckedChanged(object sender, EventArgs e)
        {
            Osszesitolegidosebb.Text = max(emberek, "F").ToString();
            Osszesitokor.Text = osszkor(emberek, "F").ToString();
            Osszesito6ev.Text = hateveki(fiumiota, "F") + "";
        }
        private void Fomind2_CheckedChanged(object sender, EventArgs e)
        {
            if (max(emberek, "L") > max(emberek, "F"))
            {
                Osszesitolegidosebb.Text = max(emberek, "L") + "";
            }
            else
            {
                Osszesitolegidosebb.Text = max(emberek, "F") + "";
            }         
            Osszesitokor.Text = osszkor(emberek, "L") + osszkor(emberek, "F") + ""; 
            if (hateveki(fiumiota, "F") == "nincs" && hateveki(lanymiota, "L") == "nincs")
            {
                Osszesito6ev.Text = "nincs";
            }
            else if (hateveki(fiumiota, "F") == "nincs")
            {
                Osszesito6ev.Text = hateveki(lanymiota, "L") + "";
            }
            else if (hateveki(lanymiota, "L") == "nincs")
            {
                Osszesito6ev.Text = hateveki(fiumiota, "F") + "";
            }
            else
            {
                Osszesito6ev.Text = hateveki(fiumiota, "F") + ", " + hateveki(lanymiota, "L;");
            }

        }
        private void Fomentes_Click(object sender, EventArgs e)
        {
            string kiir = "";
            if (Osszesitolany.Checked)
            {
                kiir = kiir + "Lányok: " + Environment.NewLine + "Legidősebb: " + Osszesitolegidosebb.Text + Environment.NewLine + "Összes kor: " + Osszesitokor.Text + Environment.NewLine + "6 éve dolgozó: " + Osszesito6ev.Text + Environment.NewLine;
                File.AppendAllText("dolgozok.txt", kiir);
            }
            else if (Osszesitofiu.Checked)
            {
                kiir = kiir + "Fiúk: " + Environment.NewLine + "Legidősebb: " + Osszesitolegidosebb.Text + Environment.NewLine + "Összes kor: " + Osszesitokor.Text + Environment.NewLine + "6 éve dolgozó: " + Osszesito6ev.Text + Environment.NewLine;
                File.AppendAllText("dolgozok.txt", kiir);
            }
        }
        private int max(List<Emberek> lista, string nem)
        {
            int maximum = lista[0].kor;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].nem == nem && lista[i].kor > maximum)
                {
                    maximum = lista[i].kor;
                }
            }
            return maximum;
        }
        private int osszkor(List<Emberek> lista, string nem)
        {
            int ossz = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].nem == nem)
                {
                    ossz += lista[i].kor;
                }
            }
            return ossz;
        }
        private int hateve(List<int> lista)
        {

            int i = 0;
            while (i < lista.Count && !(lista[i] > 6))
            {
                i++;
            }
            if (i < lista.Count)
            {
                return lista[i];
            }
            else
            {
                return 0;
            }
        }
        private string hateveki(List<int> lista, string nem)
        {
            string a = "";
            if (hateve(lista) > 6)
            {
                for (int i = 0; i < emberek.Count; i++)
                {
                    if (emberek[i].nem == nem)
                    {
                        if (emberek[i].evek == hateve(lista))

                        {
                            a = emberek[i].nev;
                        }
                    }
                }
            }
            else
            {
                a = "nincs";
            }
            return a;


        }

       
    }
}

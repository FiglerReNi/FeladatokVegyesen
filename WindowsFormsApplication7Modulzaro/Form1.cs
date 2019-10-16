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

namespace WindowsFormsApplication7Modulzaro
{
    public partial class Dolgozok : Form
    {
        string[] beolvas = File.ReadAllLines("emberek.txt", Encoding.Default);
        List<int> dolgozikevl = new List<int>();
        List<int> dolgozikevf = new List<int>();
        List<int> koral = new List<int>();
        List<int> koraf = new List<int>();
        List<int> dolgozikev = new List<int>();
        public Dolgozok()
        {
            InitializeComponent();
            for (int i = 1; i < beolvas.Length; i++)
            {
                if (beolvas[i].Split(';')[2] == "L")
                {
                    Dolgozoklany2.Items.Add(beolvas[i].Split(';')[0]);
                    koral.Add(int.Parse(beolvas[i].Split(';')[1]));
                    if ((beolvas[i].Contains("L;")))
                    {
                        dolgozikevl.Add(int.Parse(beolvas[i].Split(';')[3]));
                        dolgozikev.Add(int.Parse(beolvas[i].Split(';')[3]));
                    }

                }
                else
                {
                    Dolgozokfiu2.Items.Add(beolvas[i].Split(';')[0]);
                    koraf.Add(int.Parse(beolvas[i].Split(';')[1]));
                    if (beolvas[i].Contains("F;"))
                    {
                        dolgozikevf.Add(int.Parse(beolvas[i].Split(';')[3]));
                        dolgozikev.Add(int.Parse(beolvas[i].Split(';')[3]));
                    }
                }

            }
        }

        private void Dolgozoklany2_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < beolvas.Length; i++)
            {
                if (beolvas[i].Contains(Dolgozoklany2.SelectedItem.ToString()))
                {
                    Adatokkor2.Text = beolvas[i].Split(';')[1];
                    Adatokmiota2.Text = "";
                    if ((beolvas[i].Contains("L;")))
                    {
                        Adatokmiota2.Text = beolvas[i].Split(';')[3];
                    }
                }
            }
        }

        private void Dolgozokfiu2_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < beolvas.Length; i++)
            {
                if (beolvas[i].Contains(Dolgozokfiu2.SelectedItem.ToString()))
                {
                    Adatokkor2.Text = beolvas[i].Split(';')[1];
                    Adatokmiota2.Text = "";
                    if ((beolvas[i].Contains("F;")))
                    {
                        Adatokmiota2.Text = beolvas[i].Split(';')[3];
                    }
                }

            }
        }

        private void Osszesitolany_CheckedChanged(object sender, EventArgs e)
        {
            Osszesitolegidosebb2.Text = max(koral) + "";
            Osszesitokor2.Text = osszkor(koral) + "";
            Osszesito6ev2.Text = hateveki(dolgozikevl, "L;") + "";
        }

        private void Osszesitofiu_CheckedChanged(object sender, EventArgs e)
        {
            Osszesitolegidosebb2.Text = max(koraf) + "";
            Osszesitokor2.Text = osszkor(koraf) + "";
            Osszesito6ev2.Text = hateveki(dolgozikevf, "F;") + "";
        }
        private void Dolgozikmind2_CheckedChanged(object sender, EventArgs e)
        {
            if (max(koral) > max(koraf))
            {
                Osszesitolegidosebb2.Text = max(koral) + "";
            }
            else
            {
                Osszesitolegidosebb2.Text = max(koraf) + "";
            }    
            Osszesitokor2.Text = osszkor(koral) + osszkor(koraf) + "";
            if (hateveki(dolgozikevf, "F;") == "nincs" && hateveki(dolgozikevl, "L;") == "nincs")
            {
                Osszesito6ev2.Text = "nincs";
            }
            else if (hateveki(dolgozikevf, "F;") == "nincs")
            {
                Osszesito6ev2.Text = hateveki(dolgozikevl, "L;") + "";
            }
            else if (hateveki(dolgozikevl, "L;") == "nincs")
            {
                Osszesito6ev2.Text = hateveki(dolgozikevf, "F;") + "";
            }
            else
            {
                Osszesito6ev2.Text = hateveki(dolgozikevf, "F;") + ", " + hateveki(dolgozikevl, "L;");
            }
          
        }

        private void Dolgozikment_Click(object sender, EventArgs e)
        {
            string kiir = "";
            if (Osszesitolany.Checked)
            {
                kiir = kiir + "Lányok: " + Environment.NewLine + "Legidősebb: " + Osszesitolegidosebb2.Text + Environment.NewLine + "Összes kor: " + Osszesitokor2.Text + Environment.NewLine + "6 éve dolgozó: " + Osszesito6ev2.Text + Environment.NewLine;
                File.AppendAllText("dolgozok.txt", kiir);
            }
            else if (Osszesitofiu.Checked)
            {
                kiir = kiir + "Fiúk: " + Environment.NewLine + "Legidősebb: " + Osszesitolegidosebb2.Text + Environment.NewLine + "Összes kor: " + Osszesitokor2.Text + Environment.NewLine + "6 éve dolgozó: " + Osszesito6ev2.Text + Environment.NewLine;
                File.AppendAllText("dolgozok.txt", kiir);
            }
        }
        public int max(List<int> koraf)
        {
            int maxi = koraf[0];
            for (int i = 0; i < koraf.Count; i++)
            {
                if (koraf[i] > koraf[0])
                {
                    maxi = koraf[i];
                }
            }
            return maxi;
        }
        public int osszkor(List<int> koraf)
        {
            int ossz = 0;
            for (int i = 0; i < koraf.Count; i++)
            {
                ossz = ossz + koraf[i];
            }
            return ossz;
        }
        public int hateve(List<int> ev)
        {
            int i = 0;
            while (i < ev.Count && !(ev[i] > 6))
            {
                i++;
            }
            if (i < ev.Count)
            {
                return ev[i];
            }
            else
            {
                return 0;
            }
        }
        public string hateveki(List<int> ev, string nem)
        {
            string a = "";
            if (hateve(ev) > 6)
            {
                for (int i = 0; i < beolvas.Length; i++)
                {
                    if ((beolvas[i].Contains(nem)))
                    {
                        if (int.Parse(beolvas[i].Split(';')[3]) == hateve(ev))

                        {
                            a = beolvas[i].Split(';')[0];
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

        private void Dolgozoklany2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
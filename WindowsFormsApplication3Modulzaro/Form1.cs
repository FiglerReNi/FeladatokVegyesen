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


namespace WindowsFormsApplication3Modulzaro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("adatok.txt"))
            {
                string[] beolvas = File.ReadAllLines("adatok.txt");
                FoSzoveg.Clear();
                FoSorba1.Items.Clear();
                foreach (string sor in beolvas)
                {
                    FoSzoveg.Text = FoSzoveg.Text + sor + Environment.NewLine;
                    FoSorba1.Items.Add(sor.Split(';')[2]);
                }
            }
            else
            {
                FoBeolvas_Click(sender, e);
            }
        }

        private void FoBeolvas_Click(object sender, EventArgs e)
        {
            if (FoMegnyit.ShowDialog() == DialogResult.OK)
            {
                string[] beolvas = File.ReadAllLines(FoMegnyit.FileName, Encoding.Default);
                FoSzoveg.Clear();
                FoSorba1.Items.Clear();
                foreach (string sor in beolvas)
                {
                    FoSzoveg.Text = FoSzoveg.Text + sor + Environment.NewLine;
                    FoSorba1.Items.Add(sor.Split(';')[2]);
                }
            }
        }

        private void FoSorba_CheckedChanged(object sender, EventArgs e)
        {
            FoSorba1.Sorted = !FoSorba1.Sorted;
        }

        private void Fomentmind_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox[] mind = new CheckBox[] { Fomentfajl, Fomentdb, Fomentemail };
            if (Fomentmind.Checked)
            {
                foreach (CheckBox elem in mind)
                {
                    elem.Checked = true;
                }
            }
            else
            {
                foreach (CheckBox elem in mind)
                {
                    elem.Checked = false;
                }
            }


        }

        private void FoKiir_Click(object sender, EventArgs e)
        {
            string kiiras = "";
            foreach (string elem in FoSorba1.Items)
            {
                kiiras = kiiras + elem + Environment.NewLine;
            }
            if (FoMentTXT.Checked)
            {
                File.WriteAllText("kiir.txt", kiiras);
            }
            else if (FoMentDAT.Checked)
            {
                File.WriteAllText("kiir.dat", kiiras);
            }
            else
            {
                File.WriteAllText("kiir.csp", kiiras);
            }
           
        }
    }
}

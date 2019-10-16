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

namespace WindowsFormsApplication6Modulzaro
{
    public partial class Form1 : Form
    {
        List<Asztal> minden;
        string[] beolvas = File.ReadAllLines("adatok.txt", Encoding.Default);
        public Form1()
        {
            minden = new List<Asztal>();
            InitializeComponent();
            
            bool elsosor = true;
            Asztal a = null;
            for (int i = 0; i < beolvas.Length; i++)
            {
                if (beolvas[i] != "")
                {
                    if (elsosor)
                    {
                        asztalok.Items.Add(beolvas[i]);
                        a = new Asztal(beolvas[i]);
                        minden.Add(a);
                        elsosor = false;                       
                    }
                    else
                    { 
                        a.hozzaad(new Tetel((beolvas[i].Split(' ')[0]), int.Parse(beolvas[i].Split(' ')[1])));
                    }
                }
                else
                {
                    elsosor = true;
                }
            }
        }

        private void mutat_Click(object sender, EventArgs e)
        {
            mindenelem.Items.AddRange(beolvas);
        }

        private void asztalok_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < minden.Count; i++)
            {
                if (minden[i].neve == asztalok.SelectedItem.ToString())
                {
                    asztalokreszletek.Text = minden[i].ToString();

                }
            }
        }

        private void kilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void osszasztal_CheckedChanged(object sender, EventArgs e)
        {
            if (osszasztal.Checked)
            {
                int osszes = 0;
                for (int i = 0; i < minden.Count; i++)
                {
                    osszes += minden[i].osszesen();
                }
                ossz.Text = osszes + "Ft";
            }
        }
    }
    }


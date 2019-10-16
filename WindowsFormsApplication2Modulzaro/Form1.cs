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

namespace WindowsFormsApplication2Modulzáró
{
    public partial class Fooldal : Form
    {
        public Fooldal()
        {
            InitializeComponent();
        }

        private void Fofajlmegnyit_Click(object sender, EventArgs e)
        {
            Foszoveg.Text = "";
            if(Fomegnyitablak.ShowDialog() == DialogResult.OK)
            {
                string szoveg = File.ReadAllText(Fomegnyitablak.FileName);
                Foszoveg.Text = szoveg;
            }
        }
        private string mentettfajlneve = "";
        private void Fofajlmentmaskent_Click(object sender, EventArgs e)
        {
            
            if(Fomentablak.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(Fomentablak.FileName, Foszoveg.Text);
                mentettfajlneve = Fomentablak.FileName;
            }
        }

        private void Fofajlment_Click(object sender, EventArgs e)
        {
            if (mentettfajlneve == "")
            {
                Fofajlmentmaskent_Click(sender, e);
            }
            else
            {
                File.WriteAllText(mentettfajlneve, Foszoveg.Text);
            }
        }
    }
}

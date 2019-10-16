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

namespace WindowsFormsApplication1Modulzaro
{
    public partial class Fo : Form
    {
        public Fo()
        {
            InitializeComponent();
        }

        string mentettfajlneve = "";
        private void Fomenufajlmentesmaskent_Click(object sender, EventArgs e)
        {
            if (Fomentablak.ShowDialog() == DialogResult.OK)
            {
                string kiterjesztes = Fomentablak.FileName.Split('.')[1];
                switch (kiterjesztes)
                {
                    case "rtf":
                        Szoveg.SaveFile(Fomentablak.FileName, RichTextBoxStreamType.RichText);
                        break;
                    default:
                        File.WriteAllText(Fomentablak.FileName, Szoveg.Text, Encoding.Default);
                        break;
                }
                mentettfajlneve = Fomentablak.FileName;
            }
        }

        private void Fomenufajlmegnyitas_Click(object sender, EventArgs e)
        {
            Szoveg.Text = "";
            if(Fomegnyitablak.ShowDialog()== DialogResult.OK)
            {
                string kit = Fomegnyitablak.FileName.Split('.')[1];
                switch (kit)
                {
                    case "rtf":
                        Szoveg.LoadFile(Fomegnyitablak.FileName, RichTextBoxStreamType.RichText);
                        break;
                    default:
                        Szoveg.Text = File.ReadAllText(Fomegnyitablak.FileName);
                        break;
                }
            }
        }

        private void Fomenufajlkilepes_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this, "Nem mentettél","FIGYELMEZTETÉS",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Fomenufajluj_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Nem mentettél", "FIGYELMEZTETÉS", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Szoveg.Clear();
            }
        }

        private void Almenuuj2_Click(object sender, EventArgs e)
        {
            Fomenufajluj_Click(sender, e);
        }

        private void Fomenuformátumbetutipus_Click(object sender, EventArgs e)
        {
            if (Betuablak.ShowDialog() == DialogResult.OK)
            {
                Szoveg.Font = Betuablak.Font;
            }
        }

        private void almenubetutipus_Click(object sender, EventArgs e)
        {
            Fomenuformátumbetutipus_Click(sender, e);
        }

        private void Fomenuformátumirasvedett_Click(object sender, EventArgs e)
        {
            Fomenuformátumirasvedett.Checked = !Fomenuformátumirasvedett.Checked;
        }

        
        bool talalat = false;
        private void Fomenuszerkeszteskeres_Click(object sender, EventArgs e)
        {
            Keres keres = new Keres();
            if (keres.ShowDialog() == DialogResult.OK)
            {
                int talalathely = 0;
                if (keres.kereselejetol.Checked)
                {
                    talalathely = Szoveg.Find(keres.Keresszoveg2.Text);
                }
                else
                {
                    if (talalat)
                    {
                        Szoveg.SelectionStart = Szoveg.SelectionStart + keres.Keresszoveg2.Text.Length;
                    }
                    talalathely = Szoveg.Find(keres.Keresszoveg2.Text, Szoveg.SelectionStart, RichTextBoxFinds.None);
                }
                if (talalathely >= 0)
                {
                    Szoveg.SelectionStart = talalathely;
                    Szoveg.SelectionLength = keres.Keresszoveg2.Text.Length;
                    talalat = true;                   
                }
                else
                {
                    MessageBox.Show("Nincs találat");
                }
            }
            

        }

        private void Fomenuszerkesztescsere_Click(object sender, EventArgs e)
        {
            Csere csere = new Csere();
            RichTextBox regi = new RichTextBox();
            regi.Text = Szoveg.Text;
            if(csere.ShowDialog() == DialogResult.OK)
            {
                if (csere.cserebeir1.Text.Length > 0)
                {
                    Szoveg.Text = Szoveg.Text.Replace(csere.cserebeir1.Text, csere.cserebeir2.Text);
                    if (regi.Text == Szoveg.Text)
                    {
                        MessageBox.Show("Nem történt csere.");
                    }
                }
                else
                {
                    MessageBox.Show("Nem írtál be szöveget.");
                }
            }
        }

        private void Fo_Load(object sender, EventArgs e)
        {

        }

        private void Fomenuszerkesztesvisszavonas_Click(object sender, EventArgs e)
        {
            if (Szoveg.CanUndo)
            {
                Szoveg.Undo();
                Szoveg.ClearUndo();
            }
        }

        private void Fomenuszerkesztesbeilleszt_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                {
                Szoveg.Paste();
                }
        }

        private void Fomenuszerkesztesmasol_Click(object sender, EventArgs e)
        {
            if(Szoveg.SelectedText != "")
            {
                Szoveg.Copy();
            }
        }

        private void Fomenuszerkeszteskivag_Click(object sender, EventArgs e)
        {
            if (Szoveg.SelectionLength > 0)
            {
                Szoveg.Cut();
            }
        }

        private void Fomenufajlmentes_Click(object sender, EventArgs e)
        {
            if(mentettfajlneve == "")
            {
                Fomenufajlmentesmaskent_Click(sender, e);
            }
            else
            {
                string kiterjesztes1 = Fomentablak.FileName.Split('.')[1];
                switch (kiterjesztes1)
                {
                    case "rtf":
                        Szoveg.SaveFile(Fomentablak.FileName, RichTextBoxStreamType.RichText);
                        break;
                    default:
                        File.WriteAllText(Fomentablak.FileName, Szoveg.Text, Encoding.Default);
                        break;
                }
                mentettfajlneve = Fomentablak.FileName;
            }
        }
    }
}

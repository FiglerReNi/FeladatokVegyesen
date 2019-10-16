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

namespace WindowsFormsApplication4Modulzaro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ip = File.ReadAllLines("ip.txt", Encoding.Default);
            foreach (string sor in ip)
            {
                Szovegmezo.Items.Add(sor);
                Sorba2.Items.Add(sor.Split('.')[3]);
            }
        }

        private void Sorba1_CheckedChanged(object sender, EventArgs e)
        {
            //Sorba2.Sorted = !Sorba2.Sorted;
            if (Sorba1.Checked)
            {
                Sorba2.Sorted = true;
            }
            else
            {
                Sorba2.Sorted = false;
            }
        }

        private void Ment_Click(object sender, EventArgs e)
        {
            string mentes = "";
            foreach (string sor in Sorba2.Items)
            {
                mentes = mentes + sor + Environment.NewLine;
            }
            if (TXT.Checked)
            {
                File.WriteAllText("mentes.txt", mentes);
            }
            else if (DAT.Checked)
            {
                File.WriteAllText("mentes.dat", mentes);
            }
            else
            {
                File.WriteAllText("mentes.csv", mentes);
            }
        }
    }
}

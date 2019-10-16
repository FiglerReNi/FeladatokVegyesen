namespace WindowsFormsApplication8Modulzaro
{
    partial class Fodolgozok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Folanyok = new System.Windows.Forms.ComboBox();
            this.Fofiuk = new System.Windows.Forms.ComboBox();
            this.Foosszesito = new System.Windows.Forms.GroupBox();
            this.Osszesito6ev = new System.Windows.Forms.TextBox();
            this.Osszesitokor = new System.Windows.Forms.TextBox();
            this.Osszesitolegidosebb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Osszesitofiu = new System.Windows.Forms.RadioButton();
            this.Osszesitolany = new System.Windows.Forms.RadioButton();
            this.Foadatok = new System.Windows.Forms.GroupBox();
            this.Adatokkor = new System.Windows.Forms.TextBox();
            this.Adatokmiota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Fomind2 = new System.Windows.Forms.CheckBox();
            this.Fomentes = new System.Windows.Forms.Button();
            this.Foosszesito.SuspendLayout();
            this.Foadatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lányok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiúk";
            // 
            // Folanyok
            // 
            this.Folanyok.FormattingEnabled = true;
            this.Folanyok.Location = new System.Drawing.Point(98, 37);
            this.Folanyok.Name = "Folanyok";
            this.Folanyok.Size = new System.Drawing.Size(121, 21);
            this.Folanyok.TabIndex = 2;
            this.Folanyok.SelectedValueChanged += new System.EventHandler(this.Folanyok_SelectedValueChanged);
            // 
            // Fofiuk
            // 
            this.Fofiuk.FormattingEnabled = true;
            this.Fofiuk.Location = new System.Drawing.Point(319, 37);
            this.Fofiuk.Name = "Fofiuk";
            this.Fofiuk.Size = new System.Drawing.Size(121, 21);
            this.Fofiuk.TabIndex = 3;
            this.Fofiuk.SelectedValueChanged += new System.EventHandler(this.Fofiuk_SelectedValueChanged);
            // 
            // Foosszesito
            // 
            this.Foosszesito.Controls.Add(this.Osszesito6ev);
            this.Foosszesito.Controls.Add(this.Osszesitokor);
            this.Foosszesito.Controls.Add(this.Osszesitolegidosebb);
            this.Foosszesito.Controls.Add(this.label5);
            this.Foosszesito.Controls.Add(this.label4);
            this.Foosszesito.Controls.Add(this.label3);
            this.Foosszesito.Controls.Add(this.Osszesitofiu);
            this.Foosszesito.Controls.Add(this.Osszesitolany);
            this.Foosszesito.Location = new System.Drawing.Point(53, 120);
            this.Foosszesito.Name = "Foosszesito";
            this.Foosszesito.Size = new System.Drawing.Size(203, 209);
            this.Foosszesito.TabIndex = 4;
            this.Foosszesito.TabStop = false;
            this.Foosszesito.Text = "Összesítő";
            // 
            // Osszesito6ev
            // 
            this.Osszesito6ev.Location = new System.Drawing.Point(97, 158);
            this.Osszesito6ev.Name = "Osszesito6ev";
            this.Osszesito6ev.Size = new System.Drawing.Size(100, 20);
            this.Osszesito6ev.TabIndex = 7;
            // 
            // Osszesitokor
            // 
            this.Osszesitokor.Location = new System.Drawing.Point(97, 120);
            this.Osszesitokor.Name = "Osszesitokor";
            this.Osszesitokor.Size = new System.Drawing.Size(100, 20);
            this.Osszesitokor.TabIndex = 6;
            // 
            // Osszesitolegidosebb
            // 
            this.Osszesitolegidosebb.Location = new System.Drawing.Point(97, 86);
            this.Osszesitolegidosebb.Name = "Osszesitolegidosebb";
            this.Osszesitolegidosebb.Size = new System.Drawing.Size(100, 20);
            this.Osszesitolegidosebb.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "6 éve dolgozó";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Összes kor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Legidősebb";
            // 
            // Osszesitofiu
            // 
            this.Osszesitofiu.AutoSize = true;
            this.Osszesitofiu.Location = new System.Drawing.Point(99, 29);
            this.Osszesitofiu.Name = "Osszesitofiu";
            this.Osszesitofiu.Size = new System.Drawing.Size(36, 17);
            this.Osszesitofiu.TabIndex = 1;
            this.Osszesitofiu.TabStop = true;
            this.Osszesitofiu.Text = "fiú";
            this.Osszesitofiu.UseVisualStyleBackColor = true;
            this.Osszesitofiu.CheckedChanged += new System.EventHandler(this.Osszesitofiu_CheckedChanged);
            // 
            // Osszesitolany
            // 
            this.Osszesitolany.AutoSize = true;
            this.Osszesitolany.Location = new System.Drawing.Point(7, 29);
            this.Osszesitolany.Name = "Osszesitolany";
            this.Osszesitolany.Size = new System.Drawing.Size(44, 17);
            this.Osszesitolany.TabIndex = 0;
            this.Osszesitolany.TabStop = true;
            this.Osszesitolany.Text = "lány";
            this.Osszesitolany.UseVisualStyleBackColor = true;
            this.Osszesitolany.CheckedChanged += new System.EventHandler(this.Osszesitolany_CheckedChanged);
            // 
            // Foadatok
            // 
            this.Foadatok.Controls.Add(this.Adatokkor);
            this.Foadatok.Controls.Add(this.Adatokmiota);
            this.Foadatok.Controls.Add(this.label7);
            this.Foadatok.Controls.Add(this.label6);
            this.Foadatok.Location = new System.Drawing.Point(289, 120);
            this.Foadatok.Name = "Foadatok";
            this.Foadatok.Size = new System.Drawing.Size(200, 100);
            this.Foadatok.TabIndex = 5;
            this.Foadatok.TabStop = false;
            this.Foadatok.Text = "Adatok";
            // 
            // Adatokkor
            // 
            this.Adatokkor.Location = new System.Drawing.Point(99, 31);
            this.Adatokkor.Name = "Adatokkor";
            this.Adatokkor.Size = new System.Drawing.Size(80, 20);
            this.Adatokkor.TabIndex = 3;
            // 
            // Adatokmiota
            // 
            this.Adatokmiota.Location = new System.Drawing.Point(99, 61);
            this.Adatokmiota.Name = "Adatokmiota";
            this.Adatokmiota.Size = new System.Drawing.Size(80, 20);
            this.Adatokmiota.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mióta dolgozik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kor";
            // 
            // Fomind2
            // 
            this.Fomind2.AutoSize = true;
            this.Fomind2.Location = new System.Drawing.Point(289, 253);
            this.Fomind2.Name = "Fomind2";
            this.Fomind2.Size = new System.Drawing.Size(98, 17);
            this.Fomind2.TabIndex = 6;
            this.Fomind2.Text = "Mindkettő elem";
            this.Fomind2.UseVisualStyleBackColor = true;
            this.Fomind2.CheckedChanged += new System.EventHandler(this.Fomind2_CheckedChanged);
            // 
            // Fomentes
            // 
            this.Fomentes.Location = new System.Drawing.Point(289, 306);
            this.Fomentes.Name = "Fomentes";
            this.Fomentes.Size = new System.Drawing.Size(75, 23);
            this.Fomentes.TabIndex = 7;
            this.Fomentes.Text = "Mentés";
            this.Fomentes.UseVisualStyleBackColor = true;
            this.Fomentes.Click += new System.EventHandler(this.Fomentes_Click);
            // 
            // Fodolgozok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 363);
            this.Controls.Add(this.Fomentes);
            this.Controls.Add(this.Fomind2);
            this.Controls.Add(this.Foadatok);
            this.Controls.Add(this.Foosszesito);
            this.Controls.Add(this.Fofiuk);
            this.Controls.Add(this.Folanyok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fodolgozok";
            this.Text = "Dolgozók";
            this.Foosszesito.ResumeLayout(false);
            this.Foosszesito.PerformLayout();
            this.Foadatok.ResumeLayout(false);
            this.Foadatok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Folanyok;
        private System.Windows.Forms.ComboBox Fofiuk;
        private System.Windows.Forms.GroupBox Foosszesito;
        private System.Windows.Forms.GroupBox Foadatok;
        private System.Windows.Forms.RadioButton Osszesitofiu;
        private System.Windows.Forms.RadioButton Osszesitolany;
        private System.Windows.Forms.TextBox Osszesito6ev;
        private System.Windows.Forms.TextBox Osszesitokor;
        private System.Windows.Forms.TextBox Osszesitolegidosebb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Adatokkor;
        private System.Windows.Forms.TextBox Adatokmiota;
        private System.Windows.Forms.CheckBox Fomind2;
        private System.Windows.Forms.Button Fomentes;
    }
}


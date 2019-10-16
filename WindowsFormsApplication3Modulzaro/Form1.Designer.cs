namespace WindowsFormsApplication3Modulzaro
{
    partial class Form1
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
            this.FoSzoveg = new System.Windows.Forms.TextBox();
            this.FoMentHely = new System.Windows.Forms.GroupBox();
            this.Fomentmind = new System.Windows.Forms.CheckBox();
            this.Fomentfajl = new System.Windows.Forms.CheckBox();
            this.Fomentdb = new System.Windows.Forms.CheckBox();
            this.Fomentemail = new System.Windows.Forms.CheckBox();
            this.FoSorba = new System.Windows.Forms.CheckBox();
            this.FoSorba1 = new System.Windows.Forms.ComboBox();
            this.FoMentForma = new System.Windows.Forms.GroupBox();
            this.FoMentTXT = new System.Windows.Forms.RadioButton();
            this.FoMentDAT = new System.Windows.Forms.RadioButton();
            this.FoMentCSP = new System.Windows.Forms.RadioButton();
            this.FoNeme = new System.Windows.Forms.GroupBox();
            this.FoNo = new System.Windows.Forms.RadioButton();
            this.FoFerfi = new System.Windows.Forms.RadioButton();
            this.FoBeolvas = new System.Windows.Forms.Button();
            this.FoKiir = new System.Windows.Forms.Button();
            this.FoMegnyit = new System.Windows.Forms.OpenFileDialog();
            this.FoMentHely.SuspendLayout();
            this.FoMentForma.SuspendLayout();
            this.FoNeme.SuspendLayout();
            this.SuspendLayout();
            // 
            // FoSzoveg
            // 
            this.FoSzoveg.Location = new System.Drawing.Point(34, 31);
            this.FoSzoveg.Multiline = true;
            this.FoSzoveg.Name = "FoSzoveg";
            this.FoSzoveg.Size = new System.Drawing.Size(134, 133);
            this.FoSzoveg.TabIndex = 0;
            // 
            // FoMentHely
            // 
            this.FoMentHely.Controls.Add(this.Fomentemail);
            this.FoMentHely.Controls.Add(this.Fomentdb);
            this.FoMentHely.Controls.Add(this.Fomentfajl);
            this.FoMentHely.Controls.Add(this.Fomentmind);
            this.FoMentHely.Location = new System.Drawing.Point(192, 31);
            this.FoMentHely.Name = "FoMentHely";
            this.FoMentHely.Size = new System.Drawing.Size(123, 170);
            this.FoMentHely.TabIndex = 1;
            this.FoMentHely.TabStop = false;
            this.FoMentHely.Text = "Mentések helye";
            // 
            // Fomentmind
            // 
            this.Fomentmind.AutoSize = true;
            this.Fomentmind.Location = new System.Drawing.Point(20, 35);
            this.Fomentmind.Name = "Fomentmind";
            this.Fomentmind.Size = new System.Drawing.Size(48, 17);
            this.Fomentmind.TabIndex = 0;
            this.Fomentmind.Text = "mind";
            this.Fomentmind.UseVisualStyleBackColor = true;
            this.Fomentmind.CheckedChanged += new System.EventHandler(this.Fomentmind_CheckedChanged);
            // 
            // Fomentfajl
            // 
            this.Fomentfajl.AutoSize = true;
            this.Fomentfajl.Location = new System.Drawing.Point(20, 69);
            this.Fomentfajl.Name = "Fomentfajl";
            this.Fomentfajl.Size = new System.Drawing.Size(39, 17);
            this.Fomentfajl.TabIndex = 1;
            this.Fomentfajl.Text = "fájl";
            this.Fomentfajl.UseVisualStyleBackColor = true;
            // 
            // Fomentdb
            // 
            this.Fomentdb.AutoSize = true;
            this.Fomentdb.Location = new System.Drawing.Point(20, 103);
            this.Fomentdb.Name = "Fomentdb";
            this.Fomentdb.Size = new System.Drawing.Size(38, 17);
            this.Fomentdb.TabIndex = 2;
            this.Fomentdb.Text = "db";
            this.Fomentdb.UseVisualStyleBackColor = true;
            // 
            // Fomentemail
            // 
            this.Fomentemail.AutoSize = true;
            this.Fomentemail.Location = new System.Drawing.Point(20, 136);
            this.Fomentemail.Name = "Fomentemail";
            this.Fomentemail.Size = new System.Drawing.Size(53, 17);
            this.Fomentemail.TabIndex = 3;
            this.Fomentemail.Text = "e-mail";
            this.Fomentemail.UseVisualStyleBackColor = true;
            // 
            // FoSorba
            // 
            this.FoSorba.AutoSize = true;
            this.FoSorba.Location = new System.Drawing.Point(354, 44);
            this.FoSorba.Name = "FoSorba";
            this.FoSorba.Size = new System.Drawing.Size(101, 17);
            this.FoSorba.TabIndex = 2;
            this.FoSorba.Text = "Sorba rendezve";
            this.FoSorba.UseVisualStyleBackColor = true;
            this.FoSorba.CheckedChanged += new System.EventHandler(this.FoSorba_CheckedChanged);
            // 
            // FoSorba1
            // 
            this.FoSorba1.FormattingEnabled = true;
            this.FoSorba1.Location = new System.Drawing.Point(344, 76);
            this.FoSorba1.Name = "FoSorba1";
            this.FoSorba1.Size = new System.Drawing.Size(121, 21);
            this.FoSorba1.TabIndex = 3;
            // 
            // FoMentForma
            // 
            this.FoMentForma.Controls.Add(this.FoMentCSP);
            this.FoMentForma.Controls.Add(this.FoMentDAT);
            this.FoMentForma.Controls.Add(this.FoMentTXT);
            this.FoMentForma.Location = new System.Drawing.Point(44, 214);
            this.FoMentForma.Name = "FoMentForma";
            this.FoMentForma.Size = new System.Drawing.Size(124, 132);
            this.FoMentForma.TabIndex = 4;
            this.FoMentForma.TabStop = false;
            this.FoMentForma.Text = "Mentések formája";
            // 
            // FoMentTXT
            // 
            this.FoMentTXT.AutoSize = true;
            this.FoMentTXT.Checked = true;
            this.FoMentTXT.Location = new System.Drawing.Point(20, 33);
            this.FoMentTXT.Name = "FoMentTXT";
            this.FoMentTXT.Size = new System.Drawing.Size(46, 17);
            this.FoMentTXT.TabIndex = 0;
            this.FoMentTXT.TabStop = true;
            this.FoMentTXT.Text = "TXT";
            this.FoMentTXT.UseVisualStyleBackColor = true;
            // 
            // FoMentDAT
            // 
            this.FoMentDAT.AutoSize = true;
            this.FoMentDAT.Location = new System.Drawing.Point(20, 70);
            this.FoMentDAT.Name = "FoMentDAT";
            this.FoMentDAT.Size = new System.Drawing.Size(47, 17);
            this.FoMentDAT.TabIndex = 1;
            this.FoMentDAT.Text = "DAT";
            this.FoMentDAT.UseVisualStyleBackColor = true;
            // 
            // FoMentCSP
            // 
            this.FoMentCSP.AutoSize = true;
            this.FoMentCSP.Location = new System.Drawing.Point(20, 109);
            this.FoMentCSP.Name = "FoMentCSP";
            this.FoMentCSP.Size = new System.Drawing.Size(46, 17);
            this.FoMentCSP.TabIndex = 2;
            this.FoMentCSP.Text = "CSP";
            this.FoMentCSP.UseVisualStyleBackColor = true;
            // 
            // FoNeme
            // 
            this.FoNeme.Controls.Add(this.FoFerfi);
            this.FoNeme.Controls.Add(this.FoNo);
            this.FoNeme.Location = new System.Drawing.Point(192, 247);
            this.FoNeme.Name = "FoNeme";
            this.FoNeme.Size = new System.Drawing.Size(123, 100);
            this.FoNeme.TabIndex = 5;
            this.FoNeme.TabStop = false;
            this.FoNeme.Text = "Neme";
            // 
            // FoNo
            // 
            this.FoNo.AutoSize = true;
            this.FoNo.Location = new System.Drawing.Point(20, 19);
            this.FoNo.Name = "FoNo";
            this.FoNo.Size = new System.Drawing.Size(39, 17);
            this.FoNo.TabIndex = 0;
            this.FoNo.TabStop = true;
            this.FoNo.Text = "Nő";
            this.FoNo.UseVisualStyleBackColor = true;
            // 
            // FoFerfi
            // 
            this.FoFerfi.AutoSize = true;
            this.FoFerfi.Location = new System.Drawing.Point(20, 58);
            this.FoFerfi.Name = "FoFerfi";
            this.FoFerfi.Size = new System.Drawing.Size(45, 17);
            this.FoFerfi.TabIndex = 1;
            this.FoFerfi.TabStop = true;
            this.FoFerfi.Text = "Férfi";
            this.FoFerfi.UseVisualStyleBackColor = true;
            // 
            // FoBeolvas
            // 
            this.FoBeolvas.Location = new System.Drawing.Point(354, 161);
            this.FoBeolvas.Name = "FoBeolvas";
            this.FoBeolvas.Size = new System.Drawing.Size(75, 23);
            this.FoBeolvas.TabIndex = 6;
            this.FoBeolvas.Text = "Beolvas";
            this.FoBeolvas.UseVisualStyleBackColor = true;
            this.FoBeolvas.Click += new System.EventHandler(this.FoBeolvas_Click);
            // 
            // FoKiir
            // 
            this.FoKiir.Location = new System.Drawing.Point(354, 320);
            this.FoKiir.Name = "FoKiir";
            this.FoKiir.Size = new System.Drawing.Size(75, 23);
            this.FoKiir.TabIndex = 7;
            this.FoKiir.Text = "Kiír";
            this.FoKiir.UseVisualStyleBackColor = true;
            this.FoKiir.Click += new System.EventHandler(this.FoKiir_Click);
            // 
            // FoMegnyit
            // 
            this.FoMegnyit.FileName = "adatok";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 406);
            this.Controls.Add(this.FoKiir);
            this.Controls.Add(this.FoBeolvas);
            this.Controls.Add(this.FoNeme);
            this.Controls.Add(this.FoMentForma);
            this.Controls.Add(this.FoSorba1);
            this.Controls.Add(this.FoSorba);
            this.Controls.Add(this.FoMentHely);
            this.Controls.Add(this.FoSzoveg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FoMentHely.ResumeLayout(false);
            this.FoMentHely.PerformLayout();
            this.FoMentForma.ResumeLayout(false);
            this.FoMentForma.PerformLayout();
            this.FoNeme.ResumeLayout(false);
            this.FoNeme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FoSzoveg;
        private System.Windows.Forms.GroupBox FoMentHely;
        private System.Windows.Forms.CheckBox Fomentemail;
        private System.Windows.Forms.CheckBox Fomentdb;
        private System.Windows.Forms.CheckBox Fomentfajl;
        private System.Windows.Forms.CheckBox Fomentmind;
        private System.Windows.Forms.CheckBox FoSorba;
        private System.Windows.Forms.ComboBox FoSorba1;
        private System.Windows.Forms.GroupBox FoMentForma;
        private System.Windows.Forms.RadioButton FoMentCSP;
        private System.Windows.Forms.RadioButton FoMentDAT;
        private System.Windows.Forms.RadioButton FoMentTXT;
        private System.Windows.Forms.GroupBox FoNeme;
        private System.Windows.Forms.RadioButton FoFerfi;
        private System.Windows.Forms.RadioButton FoNo;
        private System.Windows.Forms.Button FoBeolvas;
        private System.Windows.Forms.Button FoKiir;
        private System.Windows.Forms.OpenFileDialog FoMegnyit;
    }
}


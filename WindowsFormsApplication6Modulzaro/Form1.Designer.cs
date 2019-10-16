namespace WindowsFormsApplication6Modulzaro
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
            this.mindenelem = new System.Windows.Forms.ListBox();
            this.asztalokreszletek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mutat = new System.Windows.Forms.Button();
            this.asztalok = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kilep = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.osszasztal = new System.Windows.Forms.CheckBox();
            this.ossz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mindenelem
            // 
            this.mindenelem.FormattingEnabled = true;
            this.mindenelem.Location = new System.Drawing.Point(39, 78);
            this.mindenelem.Name = "mindenelem";
            this.mindenelem.Size = new System.Drawing.Size(176, 355);
            this.mindenelem.TabIndex = 0;
            // 
            // asztalokreszletek
            // 
            this.asztalokreszletek.Location = new System.Drawing.Point(322, 78);
            this.asztalokreszletek.Multiline = true;
            this.asztalokreszletek.Name = "asztalokreszletek";
            this.asztalokreszletek.Size = new System.Drawing.Size(160, 137);
            this.asztalokreszletek.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minden asztal";
            // 
            // mutat
            // 
            this.mutat.Location = new System.Drawing.Point(140, 22);
            this.mutat.Name = "mutat";
            this.mutat.Size = new System.Drawing.Size(75, 23);
            this.mutat.TabIndex = 3;
            this.mutat.Text = "Mutat";
            this.mutat.UseVisualStyleBackColor = true;
            this.mutat.Click += new System.EventHandler(this.mutat_Click);
            // 
            // asztalok
            // 
            this.asztalok.FormattingEnabled = true;
            this.asztalok.Location = new System.Drawing.Point(366, 24);
            this.asztalok.Name = "asztalok";
            this.asztalok.Size = new System.Drawing.Size(116, 21);
            this.asztalok.TabIndex = 4;
            this.asztalok.SelectedValueChanged += new System.EventHandler(this.asztalok_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Asztal:";
            // 
            // kilep
            // 
            this.kilep.Location = new System.Drawing.Point(407, 410);
            this.kilep.Name = "kilep";
            this.kilep.Size = new System.Drawing.Size(75, 23);
            this.kilep.TabIndex = 6;
            this.kilep.Text = "Kilépés";
            this.kilep.UseVisualStyleBackColor = true;
            this.kilep.Click += new System.EventHandler(this.kilep_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fogyaztás:";
            // 
            // osszasztal
            // 
            this.osszasztal.AutoSize = true;
            this.osszasztal.Location = new System.Drawing.Point(328, 248);
            this.osszasztal.Name = "osszasztal";
            this.osszasztal.Size = new System.Drawing.Size(90, 17);
            this.osszasztal.TabIndex = 9;
            this.osszasztal.Text = "Összes asztal";
            this.osszasztal.UseVisualStyleBackColor = true;
            this.osszasztal.CheckedChanged += new System.EventHandler(this.osszasztal_CheckedChanged);
            // 
            // ossz
            // 
            this.ossz.Location = new System.Drawing.Point(390, 287);
            this.ossz.Name = "ossz";
            this.ossz.Size = new System.Drawing.Size(92, 20);
            this.ossz.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 456);
            this.Controls.Add(this.ossz);
            this.Controls.Add(this.osszasztal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kilep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.asztalok);
            this.Controls.Add(this.mutat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asztalokreszletek);
            this.Controls.Add(this.mindenelem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mindenelem;
        private System.Windows.Forms.TextBox asztalokreszletek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mutat;
        private System.Windows.Forms.ComboBox asztalok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kilep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox osszasztal;
        private System.Windows.Forms.TextBox ossz;
    }
}


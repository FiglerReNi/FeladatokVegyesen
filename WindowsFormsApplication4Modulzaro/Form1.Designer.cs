namespace WindowsFormsApplication4Modulzaro
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
            this.Szovegmezo = new System.Windows.Forms.ListBox();
            this.Tarolo = new System.Windows.Forms.GroupBox();
            this.TXT = new System.Windows.Forms.RadioButton();
            this.CSV = new System.Windows.Forms.RadioButton();
            this.DAT = new System.Windows.Forms.RadioButton();
            this.Sorba1 = new System.Windows.Forms.CheckBox();
            this.Sorba2 = new System.Windows.Forms.ComboBox();
            this.Megnyit = new System.Windows.Forms.Button();
            this.Ment = new System.Windows.Forms.Button();
            this.Kilép = new System.Windows.Forms.Button();
            this.Tarolo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Szovegmezo
            // 
            this.Szovegmezo.FormattingEnabled = true;
            this.Szovegmezo.Location = new System.Drawing.Point(39, 36);
            this.Szovegmezo.Name = "Szovegmezo";
            this.Szovegmezo.Size = new System.Drawing.Size(132, 134);
            this.Szovegmezo.TabIndex = 0;
            // 
            // Tarolo
            // 
            this.Tarolo.Controls.Add(this.DAT);
            this.Tarolo.Controls.Add(this.CSV);
            this.Tarolo.Controls.Add(this.TXT);
            this.Tarolo.Location = new System.Drawing.Point(51, 198);
            this.Tarolo.Name = "Tarolo";
            this.Tarolo.Size = new System.Drawing.Size(120, 137);
            this.Tarolo.TabIndex = 1;
            this.Tarolo.TabStop = false;
            this.Tarolo.Text = "Típus";
            // 
            // TXT
            // 
            this.TXT.AutoSize = true;
            this.TXT.Location = new System.Drawing.Point(7, 34);
            this.TXT.Name = "TXT";
            this.TXT.Size = new System.Drawing.Size(46, 17);
            this.TXT.TabIndex = 0;
            this.TXT.TabStop = true;
            this.TXT.Text = "TXT";
            this.TXT.UseVisualStyleBackColor = true;
            // 
            // CSV
            // 
            this.CSV.AutoSize = true;
            this.CSV.Location = new System.Drawing.Point(7, 73);
            this.CSV.Name = "CSV";
            this.CSV.Size = new System.Drawing.Size(46, 17);
            this.CSV.TabIndex = 1;
            this.CSV.TabStop = true;
            this.CSV.Text = "CSV";
            this.CSV.UseVisualStyleBackColor = true;
            // 
            // DAT
            // 
            this.DAT.AutoSize = true;
            this.DAT.Location = new System.Drawing.Point(7, 114);
            this.DAT.Name = "DAT";
            this.DAT.Size = new System.Drawing.Size(47, 17);
            this.DAT.TabIndex = 2;
            this.DAT.TabStop = true;
            this.DAT.Text = "DAT";
            this.DAT.UseVisualStyleBackColor = true;
            // 
            // Sorba1
            // 
            this.Sorba1.AutoSize = true;
            this.Sorba1.Location = new System.Drawing.Point(222, 36);
            this.Sorba1.Name = "Sorba1";
            this.Sorba1.Size = new System.Drawing.Size(89, 17);
            this.Sorba1.TabIndex = 2;
            this.Sorba1.Text = "Sorba rendez";
            this.Sorba1.UseVisualStyleBackColor = true;
            this.Sorba1.CheckedChanged += new System.EventHandler(this.Sorba1_CheckedChanged);
            // 
            // Sorba2
            // 
            this.Sorba2.FormattingEnabled = true;
            this.Sorba2.Location = new System.Drawing.Point(222, 84);
            this.Sorba2.Name = "Sorba2";
            this.Sorba2.Size = new System.Drawing.Size(121, 21);
            this.Sorba2.TabIndex = 3;
            // 
            // Megnyit
            // 
            this.Megnyit.Location = new System.Drawing.Point(222, 198);
            this.Megnyit.Name = "Megnyit";
            this.Megnyit.Size = new System.Drawing.Size(75, 23);
            this.Megnyit.TabIndex = 4;
            this.Megnyit.Text = "Megnyit";
            this.Megnyit.UseVisualStyleBackColor = true;
            // 
            // Ment
            // 
            this.Ment.Location = new System.Drawing.Point(222, 255);
            this.Ment.Name = "Ment";
            this.Ment.Size = new System.Drawing.Size(75, 23);
            this.Ment.TabIndex = 5;
            this.Ment.Text = "Mentés";
            this.Ment.UseVisualStyleBackColor = true;
            this.Ment.Click += new System.EventHandler(this.Ment_Click);
            // 
            // Kilép
            // 
            this.Kilép.Location = new System.Drawing.Point(222, 302);
            this.Kilép.Name = "Kilép";
            this.Kilép.Size = new System.Drawing.Size(75, 23);
            this.Kilép.TabIndex = 6;
            this.Kilép.Text = "Kilépés";
            this.Kilép.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 389);
            this.Controls.Add(this.Kilép);
            this.Controls.Add(this.Ment);
            this.Controls.Add(this.Megnyit);
            this.Controls.Add(this.Sorba2);
            this.Controls.Add(this.Sorba1);
            this.Controls.Add(this.Tarolo);
            this.Controls.Add(this.Szovegmezo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tarolo.ResumeLayout(false);
            this.Tarolo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Szovegmezo;
        private System.Windows.Forms.GroupBox Tarolo;
        private System.Windows.Forms.RadioButton DAT;
        private System.Windows.Forms.RadioButton CSV;
        private System.Windows.Forms.RadioButton TXT;
        private System.Windows.Forms.CheckBox Sorba1;
        private System.Windows.Forms.ComboBox Sorba2;
        private System.Windows.Forms.Button Megnyit;
        private System.Windows.Forms.Button Ment;
        private System.Windows.Forms.Button Kilép;
    }
}


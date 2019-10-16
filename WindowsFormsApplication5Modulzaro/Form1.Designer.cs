namespace WindowsFormsApplication5Modulzaro
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
            this.jarmulista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.magassag = new System.Windows.Forms.TextBox();
            this.szelesseg = new System.Windows.Forms.TextBox();
            this.db = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jarmulista
            // 
            this.jarmulista.FormattingEnabled = true;
            this.jarmulista.Location = new System.Drawing.Point(26, 47);
            this.jarmulista.Name = "jarmulista";
            this.jarmulista.Size = new System.Drawing.Size(121, 21);
            this.jarmulista.TabIndex = 0;
            this.jarmulista.SelectedValueChanged += new System.EventHandler(this.jarmulista_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jármű adatai:";
            // 
            // magassag
            // 
            this.magassag.Location = new System.Drawing.Point(225, 47);
            this.magassag.Name = "magassag";
            this.magassag.Size = new System.Drawing.Size(42, 20);
            this.magassag.TabIndex = 2;
            // 
            // szelesseg
            // 
            this.szelesseg.Location = new System.Drawing.Point(367, 48);
            this.szelesseg.Name = "szelesseg";
            this.szelesseg.Size = new System.Drawing.Size(58, 20);
            this.szelesseg.TabIndex = 3;
            // 
            // db
            // 
            this.db.Location = new System.Drawing.Point(519, 46);
            this.db.Name = "db";
            this.db.Size = new System.Drawing.Size(56, 20);
            this.db.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "M:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SZ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DB:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 96);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.db);
            this.Controls.Add(this.szelesseg);
            this.Controls.Add(this.magassag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jarmulista);
            this.Name = "Form1";
            this.Text = "Járművek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox jarmulista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox magassag;
        private System.Windows.Forms.TextBox szelesseg;
        private System.Windows.Forms.TextBox db;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


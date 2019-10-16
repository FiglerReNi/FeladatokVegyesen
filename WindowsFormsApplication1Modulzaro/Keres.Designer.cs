namespace WindowsFormsApplication1Modulzaro
{
    partial class Keres
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
            this.Keresszoveg1 = new System.Windows.Forms.Label();
            this.Keresszoveg2 = new System.Windows.Forms.TextBox();
            this.Keresgomb1 = new System.Windows.Forms.Button();
            this.keresgomb2 = new System.Windows.Forms.Button();
            this.keresbox = new System.Windows.Forms.CheckBox();
            this.keresbox2 = new System.Windows.Forms.GroupBox();
            this.keresaktpozi = new System.Windows.Forms.RadioButton();
            this.kereselejetol = new System.Windows.Forms.RadioButton();
            this.keresbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Keresszoveg1
            // 
            this.Keresszoveg1.AutoSize = true;
            this.Keresszoveg1.Location = new System.Drawing.Point(33, 22);
            this.Keresszoveg1.Name = "Keresszoveg1";
            this.Keresszoveg1.Size = new System.Drawing.Size(61, 13);
            this.Keresszoveg1.TabIndex = 0;
            this.Keresszoveg1.Text = "Keresendő:";
            // 
            // Keresszoveg2
            // 
            this.Keresszoveg2.Location = new System.Drawing.Point(123, 22);
            this.Keresszoveg2.Name = "Keresszoveg2";
            this.Keresszoveg2.Size = new System.Drawing.Size(273, 20);
            this.Keresszoveg2.TabIndex = 1;
            // 
            // Keresgomb1
            // 
            this.Keresgomb1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Keresgomb1.Location = new System.Drawing.Point(411, 19);
            this.Keresgomb1.Name = "Keresgomb1";
            this.Keresgomb1.Size = new System.Drawing.Size(125, 23);
            this.Keresgomb1.TabIndex = 2;
            this.Keresgomb1.Text = "Következő keresés";
            this.Keresgomb1.UseVisualStyleBackColor = true;
            // 
            // keresgomb2
            // 
            this.keresgomb2.Location = new System.Drawing.Point(411, 84);
            this.keresgomb2.Name = "keresgomb2";
            this.keresgomb2.Size = new System.Drawing.Size(125, 23);
            this.keresgomb2.TabIndex = 3;
            this.keresgomb2.Text = "Mégse";
            this.keresgomb2.UseVisualStyleBackColor = true;
            // 
            // keresbox
            // 
            this.keresbox.AutoSize = true;
            this.keresbox.Location = new System.Drawing.Point(12, 100);
            this.keresbox.Name = "keresbox";
            this.keresbox.Size = new System.Drawing.Size(205, 17);
            this.keresbox.TabIndex = 4;
            this.keresbox.Text = "Kis- és nagybetűk megkülönböztetése";
            this.keresbox.UseVisualStyleBackColor = true;
            // 
            // keresbox2
            // 
            this.keresbox2.Controls.Add(this.keresaktpozi);
            this.keresbox2.Controls.Add(this.kereselejetol);
            this.keresbox2.Location = new System.Drawing.Point(140, 48);
            this.keresbox2.Name = "keresbox2";
            this.keresbox2.Size = new System.Drawing.Size(243, 42);
            this.keresbox2.TabIndex = 5;
            this.keresbox2.TabStop = false;
            this.keresbox2.Text = "Irány";
            // 
            // keresaktpozi
            // 
            this.keresaktpozi.AutoSize = true;
            this.keresaktpozi.Location = new System.Drawing.Point(85, 19);
            this.keresaktpozi.Name = "keresaktpozi";
            this.keresaktpozi.Size = new System.Drawing.Size(111, 17);
            this.keresaktpozi.TabIndex = 1;
            this.keresaktpozi.TabStop = true;
            this.keresaktpozi.Text = "Aktuális pozíciótól";
            this.keresaktpozi.UseVisualStyleBackColor = true;
            // 
            // kereselejetol
            // 
            this.kereselejetol.AutoSize = true;
            this.kereselejetol.Checked = true;
            this.kereselejetol.Location = new System.Drawing.Point(15, 19);
            this.kereselejetol.Name = "kereselejetol";
            this.kereselejetol.Size = new System.Drawing.Size(59, 17);
            this.kereselejetol.TabIndex = 0;
            this.kereselejetol.TabStop = true;
            this.kereselejetol.Text = "Elejétől";
            this.kereselejetol.UseVisualStyleBackColor = true;
            // 
            // Keres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 129);
            this.Controls.Add(this.keresbox2);
            this.Controls.Add(this.keresbox);
            this.Controls.Add(this.keresgomb2);
            this.Controls.Add(this.Keresgomb1);
            this.Controls.Add(this.Keresszoveg2);
            this.Controls.Add(this.Keresszoveg1);
            this.Name = "Keres";
            this.Text = "Keres";
            this.keresbox2.ResumeLayout(false);
            this.keresbox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Keresszoveg1;
        private System.Windows.Forms.Button Keresgomb1;
        private System.Windows.Forms.Button keresgomb2;
        private System.Windows.Forms.CheckBox keresbox;
        private System.Windows.Forms.GroupBox keresbox2;
        internal System.Windows.Forms.TextBox Keresszoveg2;
        internal System.Windows.Forms.RadioButton keresaktpozi;
        internal System.Windows.Forms.RadioButton kereselejetol;
    }
}
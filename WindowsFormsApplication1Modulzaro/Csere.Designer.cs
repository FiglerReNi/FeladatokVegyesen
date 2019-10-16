namespace WindowsFormsApplication1Modulzaro
{
    partial class Csere
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
            this.csereszoveg1 = new System.Windows.Forms.Label();
            this.csereszoveg2 = new System.Windows.Forms.Label();
            this.cserebeir1 = new System.Windows.Forms.TextBox();
            this.cserebeir2 = new System.Windows.Forms.TextBox();
            this.cseregomb1 = new System.Windows.Forms.Button();
            this.cseregomb2 = new System.Windows.Forms.Button();
            this.cserebox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // csereszoveg1
            // 
            this.csereszoveg1.AutoSize = true;
            this.csereszoveg1.Location = new System.Drawing.Point(33, 24);
            this.csereszoveg1.Name = "csereszoveg1";
            this.csereszoveg1.Size = new System.Drawing.Size(21, 13);
            this.csereszoveg1.TabIndex = 0;
            this.csereszoveg1.Text = "Mit";
            // 
            // csereszoveg2
            // 
            this.csereszoveg2.AutoSize = true;
            this.csereszoveg2.Location = new System.Drawing.Point(33, 63);
            this.csereszoveg2.Name = "csereszoveg2";
            this.csereszoveg2.Size = new System.Drawing.Size(27, 13);
            this.csereszoveg2.TabIndex = 1;
            this.csereszoveg2.Text = "Mire";
            // 
            // cserebeir1
            // 
            this.cserebeir1.Location = new System.Drawing.Point(136, 24);
            this.cserebeir1.Name = "cserebeir1";
            this.cserebeir1.Size = new System.Drawing.Size(265, 20);
            this.cserebeir1.TabIndex = 2;
            // 
            // cserebeir2
            // 
            this.cserebeir2.Location = new System.Drawing.Point(136, 63);
            this.cserebeir2.Name = "cserebeir2";
            this.cserebeir2.Size = new System.Drawing.Size(265, 20);
            this.cserebeir2.TabIndex = 3;
            // 
            // cseregomb1
            // 
            this.cseregomb1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cseregomb1.Location = new System.Drawing.Point(445, 20);
            this.cseregomb1.Name = "cseregomb1";
            this.cseregomb1.Size = new System.Drawing.Size(75, 23);
            this.cseregomb1.TabIndex = 4;
            this.cseregomb1.Text = "Cserél";
            this.cseregomb1.UseVisualStyleBackColor = true;
            // 
            // cseregomb2
            // 
            this.cseregomb2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cseregomb2.Location = new System.Drawing.Point(445, 59);
            this.cseregomb2.Name = "cseregomb2";
            this.cseregomb2.Size = new System.Drawing.Size(75, 23);
            this.cseregomb2.TabIndex = 5;
            this.cseregomb2.Text = "Mégsem";
            this.cseregomb2.UseVisualStyleBackColor = true;
            // 
            // cserebox
            // 
            this.cserebox.AutoSize = true;
            this.cserebox.Location = new System.Drawing.Point(36, 97);
            this.cserebox.Name = "cserebox";
            this.cserebox.Size = new System.Drawing.Size(204, 17);
            this.cserebox.TabIndex = 6;
            this.cserebox.Text = "kis- és nagybetűk megkülönböztetése";
            this.cserebox.UseVisualStyleBackColor = true;
            // 
            // Csere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 126);
            this.Controls.Add(this.cserebox);
            this.Controls.Add(this.cseregomb2);
            this.Controls.Add(this.cseregomb1);
            this.Controls.Add(this.cserebeir2);
            this.Controls.Add(this.cserebeir1);
            this.Controls.Add(this.csereszoveg2);
            this.Controls.Add(this.csereszoveg1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Csere";
            this.Text = "Csere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label csereszoveg1;
        private System.Windows.Forms.Label csereszoveg2;
        private System.Windows.Forms.CheckBox cserebox;
        internal System.Windows.Forms.TextBox cserebeir1;
        internal System.Windows.Forms.TextBox cserebeir2;
        internal System.Windows.Forms.Button cseregomb1;
        internal System.Windows.Forms.Button cseregomb2;
    }
}
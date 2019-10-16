namespace WindowsFormsApplication1Modulzaro
{
    partial class Fo
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
            this.components = new System.ComponentModel.Container();
            this.Fomenu = new System.Windows.Forms.MenuStrip();
            this.Fomenufajl = new System.Windows.Forms.ToolStripMenuItem();
            this.Fomenufajluj = new System.Windows.Forms.ToolStripMenuItem();
            this.Fomenufajlmegnyitas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Fomenufajlmentes = new System.Windows.Forms.ToolStripMenuItem();
            this.Mentes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Fomenufajlkilepes = new System.Windows.Forms.ToolStripMenuItem();
            this.Fomenuszerkesztes = new System.Windows.Forms.ToolStripMenuItem();
            this.Fomenuszerkesztesvisszavonas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Fomenuszerkesztesmasol = new System.Windows.Forms.ToolStripMenuItem();
            this.Fomenuszerkeszteskivag = new System.Windows.Forms.ToolStripMenuItem();
            this.Fomenuszerkesztesbeilleszt = new System.Windows.Forms.ToolStripMenuItem();
            this.Fomenuszerkesztestorol = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Fomenuszerkeszteskeres = new System.Windows.Forms.ToolStripMenuItem();
            this.Fomenuszerkesztescsere = new System.Windows.Forms.ToolStripMenuItem();
            this.Fomenuformátum = new System.Windows.Forms.ToolStripMenuItem();
            this.Fomenuformátumbetutipus = new System.Windows.Forms.ToolStripMenuItem();
            this.Fomenuformátumirasvedett = new System.Windows.Forms.ToolStripMenuItem();
            this.Almenu = new System.Windows.Forms.ToolStrip();
            this.Almenuuj1 = new System.Windows.Forms.ToolStripLabel();
            this.Almenuuj2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Almenumegnyitas = new System.Windows.Forms.ToolStripButton();
            this.Almenumentes = new System.Windows.Forms.ToolStripButton();
            this.almenumentesmaskent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.almenubetutipus = new System.Windows.Forms.ToolStripButton();
            this.Gyorsmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.visszavonásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.másolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kivágToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beillesztToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Szoveg = new System.Windows.Forms.RichTextBox();
            this.Fomegnyitablak = new System.Windows.Forms.OpenFileDialog();
            this.Fomentablak = new System.Windows.Forms.SaveFileDialog();
            this.Betuablak = new System.Windows.Forms.FontDialog();
            this.Fomenu.SuspendLayout();
            this.Almenu.SuspendLayout();
            this.Gyorsmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fomenu
            // 
            this.Fomenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fomenufajl,
            this.Fomenuszerkesztes,
            this.Fomenuformátum});
            this.Fomenu.Location = new System.Drawing.Point(0, 0);
            this.Fomenu.Name = "Fomenu";
            this.Fomenu.Size = new System.Drawing.Size(830, 24);
            this.Fomenu.TabIndex = 0;
            this.Fomenu.Text = "menuStrip1";
            // 
            // Fomenufajl
            // 
            this.Fomenufajl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fomenufajluj,
            this.Fomenufajlmegnyitas,
            this.toolStripSeparator1,
            this.Fomenufajlmentes,
            this.Mentes,
            this.toolStripSeparator2,
            this.Fomenufajlkilepes});
            this.Fomenufajl.Name = "Fomenufajl";
            this.Fomenufajl.Size = new System.Drawing.Size(37, 20);
            this.Fomenufajl.Text = "&Fájl";
            // 
            // Fomenufajluj
            // 
            this.Fomenufajluj.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Document_New_32;
            this.Fomenufajluj.Name = "Fomenufajluj";
            this.Fomenufajluj.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Fomenufajluj.Size = new System.Drawing.Size(172, 22);
            this.Fomenufajluj.Text = "Új";
            this.Fomenufajluj.Click += new System.EventHandler(this.Fomenufajluj_Click);
            // 
            // Fomenufajlmegnyitas
            // 
            this.Fomenufajlmegnyitas.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Document_Open_32;
            this.Fomenufajlmegnyitas.Name = "Fomenufajlmegnyitas";
            this.Fomenufajlmegnyitas.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Fomenufajlmegnyitas.Size = new System.Drawing.Size(172, 22);
            this.Fomenufajlmegnyitas.Text = "Megnyitás";
            this.Fomenufajlmegnyitas.Click += new System.EventHandler(this.Fomenufajlmegnyitas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // Fomenufajlmentes
            // 
            this.Fomenufajlmentes.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Document_Save_32;
            this.Fomenufajlmentes.Name = "Fomenufajlmentes";
            this.Fomenufajlmentes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Fomenufajlmentes.Size = new System.Drawing.Size(172, 22);
            this.Fomenufajlmentes.Text = "Menté&s";
            this.Fomenufajlmentes.Click += new System.EventHandler(this.Fomenufajlmentes_Click);
            // 
            // Mentes
            // 
            this.Mentes.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Document_Save_As_32;
            this.Mentes.Name = "Mentes";
            this.Mentes.Size = new System.Drawing.Size(172, 22);
            this.Mentes.Text = "Mentés másként";
            this.Mentes.Click += new System.EventHandler(this.Fomenufajlmentesmaskent_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // Fomenufajlkilepes
            // 
            this.Fomenufajlkilepes.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Application_Exit_32;
            this.Fomenufajlkilepes.Name = "Fomenufajlkilepes";
            this.Fomenufajlkilepes.Size = new System.Drawing.Size(172, 22);
            this.Fomenufajlkilepes.Text = "Kilépés";
            this.Fomenufajlkilepes.Click += new System.EventHandler(this.Fomenufajlkilepes_Click);
            // 
            // Fomenuszerkesztes
            // 
            this.Fomenuszerkesztes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fomenuszerkesztesvisszavonas,
            this.toolStripSeparator3,
            this.Fomenuszerkesztesmasol,
            this.Fomenuszerkeszteskivag,
            this.Fomenuszerkesztesbeilleszt,
            this.Fomenuszerkesztestorol,
            this.toolStripSeparator4,
            this.Fomenuszerkeszteskeres,
            this.Fomenuszerkesztescsere});
            this.Fomenuszerkesztes.Name = "Fomenuszerkesztes";
            this.Fomenuszerkesztes.Size = new System.Drawing.Size(77, 20);
            this.Fomenuszerkesztes.Text = "Szerkesztés";
            // 
            // Fomenuszerkesztesvisszavonas
            // 
            this.Fomenuszerkesztesvisszavonas.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Edit_Undo_32;
            this.Fomenuszerkesztesvisszavonas.Name = "Fomenuszerkesztesvisszavonas";
            this.Fomenuszerkesztesvisszavonas.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Fomenuszerkesztesvisszavonas.Size = new System.Drawing.Size(177, 22);
            this.Fomenuszerkesztesvisszavonas.Text = "Visszavonás";
            this.Fomenuszerkesztesvisszavonas.Click += new System.EventHandler(this.Fomenuszerkesztesvisszavonas_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(174, 6);
            // 
            // Fomenuszerkesztesmasol
            // 
            this.Fomenuszerkesztesmasol.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Edit_Copy_32;
            this.Fomenuszerkesztesmasol.Name = "Fomenuszerkesztesmasol";
            this.Fomenuszerkesztesmasol.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Fomenuszerkesztesmasol.Size = new System.Drawing.Size(177, 22);
            this.Fomenuszerkesztesmasol.Text = "&Másol";
            this.Fomenuszerkesztesmasol.Click += new System.EventHandler(this.Fomenuszerkesztesmasol_Click);
            // 
            // Fomenuszerkeszteskivag
            // 
            this.Fomenuszerkeszteskivag.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Edit_Cut_32;
            this.Fomenuszerkeszteskivag.Name = "Fomenuszerkeszteskivag";
            this.Fomenuszerkeszteskivag.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Fomenuszerkeszteskivag.Size = new System.Drawing.Size(177, 22);
            this.Fomenuszerkeszteskivag.Text = "Kivág";
            this.Fomenuszerkeszteskivag.Click += new System.EventHandler(this.Fomenuszerkeszteskivag_Click);
            // 
            // Fomenuszerkesztesbeilleszt
            // 
            this.Fomenuszerkesztesbeilleszt.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Edit_Paste_32;
            this.Fomenuszerkesztesbeilleszt.Name = "Fomenuszerkesztesbeilleszt";
            this.Fomenuszerkesztesbeilleszt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Fomenuszerkesztesbeilleszt.Size = new System.Drawing.Size(177, 22);
            this.Fomenuszerkesztesbeilleszt.Text = "Beilleszt";
            this.Fomenuszerkesztesbeilleszt.Click += new System.EventHandler(this.Fomenuszerkesztesbeilleszt_Click);
            // 
            // Fomenuszerkesztestorol
            // 
            this.Fomenuszerkesztestorol.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Edit_Delete_32;
            this.Fomenuszerkesztestorol.Name = "Fomenuszerkesztestorol";
            this.Fomenuszerkesztestorol.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.Fomenuszerkesztestorol.Size = new System.Drawing.Size(177, 22);
            this.Fomenuszerkesztestorol.Text = "Töröl";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(174, 6);
            // 
            // Fomenuszerkeszteskeres
            // 
            this.Fomenuszerkeszteskeres.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Edit_Find_32;
            this.Fomenuszerkeszteskeres.Name = "Fomenuszerkeszteskeres";
            this.Fomenuszerkeszteskeres.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.Fomenuszerkeszteskeres.Size = new System.Drawing.Size(177, 22);
            this.Fomenuszerkeszteskeres.Text = "Keres...";
            this.Fomenuszerkeszteskeres.Click += new System.EventHandler(this.Fomenuszerkeszteskeres_Click);
            // 
            // Fomenuszerkesztescsere
            // 
            this.Fomenuszerkesztescsere.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Edit_Find_Replace_32;
            this.Fomenuszerkesztescsere.Name = "Fomenuszerkesztescsere";
            this.Fomenuszerkesztescsere.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.Fomenuszerkesztescsere.Size = new System.Drawing.Size(177, 22);
            this.Fomenuszerkesztescsere.Text = "Csere...";
            this.Fomenuszerkesztescsere.Click += new System.EventHandler(this.Fomenuszerkesztescsere_Click);
            // 
            // Fomenuformátum
            // 
            this.Fomenuformátum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fomenuformátumbetutipus,
            this.Fomenuformátumirasvedett});
            this.Fomenuformátum.Name = "Fomenuformátum";
            this.Fomenuformátum.Size = new System.Drawing.Size(75, 20);
            this.Fomenuformátum.Text = "Formátum";
            // 
            // Fomenuformátumbetutipus
            // 
            this.Fomenuformátumbetutipus.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Font_X_Generic_321;
            this.Fomenuformátumbetutipus.Name = "Fomenuformátumbetutipus";
            this.Fomenuformátumbetutipus.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.Fomenuformátumbetutipus.Size = new System.Drawing.Size(196, 22);
            this.Fomenuformátumbetutipus.Text = "Betűtípus";
            this.Fomenuformátumbetutipus.Click += new System.EventHandler(this.Fomenuformátumbetutipus_Click);
            // 
            // Fomenuformátumirasvedett
            // 
            this.Fomenuformátumirasvedett.Checked = true;
            this.Fomenuformátumirasvedett.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Fomenuformátumirasvedett.Name = "Fomenuformátumirasvedett";
            this.Fomenuformátumirasvedett.Size = new System.Drawing.Size(196, 22);
            this.Fomenuformátumirasvedett.Text = "Írásvédett";
            this.Fomenuformátumirasvedett.Click += new System.EventHandler(this.Fomenuformátumirasvedett_Click);
            // 
            // Almenu
            // 
            this.Almenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Almenuuj1,
            this.Almenuuj2,
            this.toolStripSeparator5,
            this.Almenumegnyitas,
            this.Almenumentes,
            this.almenumentesmaskent,
            this.toolStripSeparator6,
            this.almenubetutipus});
            this.Almenu.Location = new System.Drawing.Point(0, 24);
            this.Almenu.Name = "Almenu";
            this.Almenu.Size = new System.Drawing.Size(830, 25);
            this.Almenu.TabIndex = 1;
            this.Almenu.Text = "toolStrip1";
            // 
            // Almenuuj1
            // 
            this.Almenuuj1.Name = "Almenuuj1";
            this.Almenuuj1.Size = new System.Drawing.Size(18, 22);
            this.Almenuuj1.Text = "Új";
            // 
            // Almenuuj2
            // 
            this.Almenuuj2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Almenuuj2.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Document_New_32;
            this.Almenuuj2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Almenuuj2.Name = "Almenuuj2";
            this.Almenuuj2.Size = new System.Drawing.Size(23, 22);
            this.Almenuuj2.Text = "toolStripButton1";
            this.Almenuuj2.ToolTipText = "Új";
            this.Almenuuj2.Click += new System.EventHandler(this.Almenuuj2_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // Almenumegnyitas
            // 
            this.Almenumegnyitas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Almenumegnyitas.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Document_Open_32;
            this.Almenumegnyitas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Almenumegnyitas.Name = "Almenumegnyitas";
            this.Almenumegnyitas.Size = new System.Drawing.Size(23, 22);
            this.Almenumegnyitas.Text = "toolStripButton2";
            this.Almenumegnyitas.ToolTipText = "Megnyitás";
            // 
            // Almenumentes
            // 
            this.Almenumentes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Almenumentes.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Document_Save_32;
            this.Almenumentes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Almenumentes.Name = "Almenumentes";
            this.Almenumentes.Size = new System.Drawing.Size(23, 22);
            this.Almenumentes.Text = "toolStripButton3";
            this.Almenumentes.ToolTipText = "Mentés";
            // 
            // almenumentesmaskent
            // 
            this.almenumentesmaskent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.almenumentesmaskent.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Document_Save_As_32;
            this.almenumentesmaskent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.almenumentesmaskent.Name = "almenumentesmaskent";
            this.almenumentesmaskent.Size = new System.Drawing.Size(23, 22);
            this.almenumentesmaskent.Text = "toolStripButton4";
            this.almenumentesmaskent.ToolTipText = "Mentés másként";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // almenubetutipus
            // 
            this.almenubetutipus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.almenubetutipus.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Font_X_Generic_321;
            this.almenubetutipus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.almenubetutipus.Name = "almenubetutipus";
            this.almenubetutipus.Size = new System.Drawing.Size(23, 22);
            this.almenubetutipus.Text = "toolStripButton5";
            this.almenubetutipus.ToolTipText = "Betűtípus";
            this.almenubetutipus.Click += new System.EventHandler(this.almenubetutipus_Click);
            // 
            // Gyorsmenu
            // 
            this.Gyorsmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visszavonásToolStripMenuItem,
            this.toolStripSeparator7,
            this.másolToolStripMenuItem,
            this.kivágToolStripMenuItem,
            this.beillesztToolStripMenuItem});
            this.Gyorsmenu.Name = "Gyorsmenu";
            this.Gyorsmenu.Size = new System.Drawing.Size(178, 98);
            // 
            // visszavonásToolStripMenuItem
            // 
            this.visszavonásToolStripMenuItem.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Edit_Undo_32;
            this.visszavonásToolStripMenuItem.Name = "visszavonásToolStripMenuItem";
            this.visszavonásToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.visszavonásToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.visszavonásToolStripMenuItem.Text = "Visszavonás";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(174, 6);
            // 
            // másolToolStripMenuItem
            // 
            this.másolToolStripMenuItem.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Edit_Copy_32;
            this.másolToolStripMenuItem.Name = "másolToolStripMenuItem";
            this.másolToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.másolToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.másolToolStripMenuItem.Text = "Másol";
            // 
            // kivágToolStripMenuItem
            // 
            this.kivágToolStripMenuItem.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Edit_Cut_32;
            this.kivágToolStripMenuItem.Name = "kivágToolStripMenuItem";
            this.kivágToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kivágToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.kivágToolStripMenuItem.Text = "Kivág";
            // 
            // beillesztToolStripMenuItem
            // 
            this.beillesztToolStripMenuItem.Image = global::WindowsFormsApplication1Modulzaro.Properties.Resources.Gnome_Edit_Paste_32;
            this.beillesztToolStripMenuItem.Name = "beillesztToolStripMenuItem";
            this.beillesztToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.beillesztToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.beillesztToolStripMenuItem.Text = "Beilleszt";
            // 
            // Szoveg
            // 
            this.Szoveg.ContextMenuStrip = this.Gyorsmenu;
            this.Szoveg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Szoveg.Location = new System.Drawing.Point(0, 49);
            this.Szoveg.Name = "Szoveg";
            this.Szoveg.Size = new System.Drawing.Size(830, 353);
            this.Szoveg.TabIndex = 3;
            this.Szoveg.Text = "alma\nbanán\nkörte málna alma\nbanán";
            // 
            // Fomegnyitablak
            // 
            this.Fomegnyitablak.FileName = "openFileDialog1";
            this.Fomegnyitablak.Filter = "minden (*.*)|*.*|csak szöveg (*.txt)|*.txt|formázott (*.rtf)|*.rtf|adat (*.csv)|*" +
    ".csv";
            this.Fomegnyitablak.FilterIndex = 2;
            // 
            // Fomentablak
            // 
            this.Fomentablak.Filter = "minden (*.*)|*.*|csak szöveg (*.txt)|*.txt|formázott (*.rtf)|*.rtf|adat (*.csv)|*" +
    ".csv";
            this.Fomentablak.FilterIndex = 2;
            // 
            // Fo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 402);
            this.Controls.Add(this.Szoveg);
            this.Controls.Add(this.Almenu);
            this.Controls.Add(this.Fomenu);
            this.MainMenuStrip = this.Fomenu;
            this.Name = "Fo";
            this.Text = "Jegyzettömb v1.0";
            this.Load += new System.EventHandler(this.Fo_Load);
            this.Fomenu.ResumeLayout(false);
            this.Fomenu.PerformLayout();
            this.Almenu.ResumeLayout(false);
            this.Almenu.PerformLayout();
            this.Gyorsmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Fomenu;
        private System.Windows.Forms.ToolStripMenuItem Fomenufajl;
        private System.Windows.Forms.ToolStripMenuItem Fomenufajluj;
        private System.Windows.Forms.ToolStripMenuItem Fomenufajlmegnyitas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Fomenufajlmentes;
        private System.Windows.Forms.ToolStripMenuItem Mentes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Fomenufajlkilepes;
        private System.Windows.Forms.ToolStripMenuItem Fomenuszerkesztes;
        private System.Windows.Forms.ToolStripMenuItem Fomenuformátum;
        private System.Windows.Forms.ToolStripMenuItem Fomenuszerkesztesvisszavonas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Fomenuszerkesztesmasol;
        private System.Windows.Forms.ToolStripMenuItem Fomenuszerkeszteskivag;
        private System.Windows.Forms.ToolStripMenuItem Fomenuszerkesztestorol;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem Fomenuszerkeszteskeres;
        private System.Windows.Forms.ToolStripMenuItem Fomenuszerkesztescsere;
        private System.Windows.Forms.ToolStripMenuItem Fomenuszerkesztesbeilleszt;
        private System.Windows.Forms.ToolStripMenuItem Fomenuformátumbetutipus;
        private System.Windows.Forms.ToolStripMenuItem Fomenuformátumirasvedett;
        private System.Windows.Forms.ToolStrip Almenu;
        private System.Windows.Forms.ToolStripLabel Almenuuj1;
        private System.Windows.Forms.ToolStripButton Almenuuj2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton Almenumegnyitas;
        private System.Windows.Forms.ToolStripButton Almenumentes;
        private System.Windows.Forms.ToolStripButton almenumentesmaskent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton almenubetutipus;
        private System.Windows.Forms.ContextMenuStrip Gyorsmenu;
        private System.Windows.Forms.ToolStripMenuItem visszavonásToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem másolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kivágToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beillesztToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog Fomegnyitablak;
        private System.Windows.Forms.SaveFileDialog Fomentablak;
        private System.Windows.Forms.FontDialog Betuablak;
        internal System.Windows.Forms.RichTextBox Szoveg;
    }
}


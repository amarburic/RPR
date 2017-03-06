namespace NSBiblioteka {
    partial class AdminForma {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonUposlenik = new System.Windows.Forms.RadioButton();
            this.radioButtonClan = new System.Windows.Forms.RadioButton();
            this.radioButtonKnjiga = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonIzmjena = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serijalizacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.serijalizujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserijalizujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarnoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.članovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.članoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uposlenikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.članoveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uposlenikeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.članoveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.uposlenikeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.članoveToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.uposlenikeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonUposlenik);
            this.groupBox1.Controls.Add(this.radioButtonClan);
            this.groupBox1.Controls.Add(this.radioButtonKnjiga);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izbor";
            // 
            // radioButtonUposlenik
            // 
            this.radioButtonUposlenik.AutoSize = true;
            this.radioButtonUposlenik.Location = new System.Drawing.Point(104, 80);
            this.radioButtonUposlenik.Name = "radioButtonUposlenik";
            this.radioButtonUposlenik.Size = new System.Drawing.Size(72, 17);
            this.radioButtonUposlenik.TabIndex = 3;
            this.radioButtonUposlenik.TabStop = true;
            this.radioButtonUposlenik.Text = "Uposlenik";
            this.radioButtonUposlenik.UseVisualStyleBackColor = true;
            // 
            // radioButtonClan
            // 
            this.radioButtonClan.AutoSize = true;
            this.radioButtonClan.Location = new System.Drawing.Point(104, 49);
            this.radioButtonClan.Name = "radioButtonClan";
            this.radioButtonClan.Size = new System.Drawing.Size(46, 17);
            this.radioButtonClan.TabIndex = 2;
            this.radioButtonClan.TabStop = true;
            this.radioButtonClan.Text = "Član";
            this.radioButtonClan.UseVisualStyleBackColor = true;
            // 
            // radioButtonKnjiga
            // 
            this.radioButtonKnjiga.AutoSize = true;
            this.radioButtonKnjiga.Checked = true;
            this.radioButtonKnjiga.Location = new System.Drawing.Point(104, 18);
            this.radioButtonKnjiga.Name = "radioButtonKnjiga";
            this.radioButtonKnjiga.Size = new System.Drawing.Size(54, 17);
            this.radioButtonKnjiga.TabIndex = 1;
            this.radioButtonKnjiga.TabStop = true;
            this.radioButtonKnjiga.Text = "Knjiga";
            this.radioButtonKnjiga.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip objekta:";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(176, 147);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonIzmjena
            // 
            this.buttonIzmjena.Location = new System.Drawing.Point(87, 147);
            this.buttonIzmjena.Name = "buttonIzmjena";
            this.buttonIzmjena.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmjena.TabIndex = 3;
            this.buttonIzmjena.Text = "Izmijeni/Briši";
            this.buttonIzmjena.UseVisualStyleBackColor = true;
            this.buttonIzmjena.Click += new System.EventHandler(this.buttonIzmjena_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serijalizacijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(260, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serijalizacijaToolStripMenuItem
            // 
            this.serijalizacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serijalizujToolStripMenuItem,
            this.deserijalizujToolStripMenuItem});
            this.serijalizacijaToolStripMenuItem.Name = "serijalizacijaToolStripMenuItem";
            this.serijalizacijaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.serijalizacijaToolStripMenuItem.Text = "Serijalizacija";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 174);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(260, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // serijalizujToolStripMenuItem
            // 
            this.serijalizujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarnoToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.serijalizujToolStripMenuItem.Name = "serijalizujToolStripMenuItem";
            this.serijalizujToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.serijalizujToolStripMenuItem.Text = "Serijalizuj";
            // 
            // deserijalizujToolStripMenuItem
            // 
            this.deserijalizujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarnoToolStripMenuItem1,
            this.xMLToolStripMenuItem1});
            this.deserijalizujToolStripMenuItem.Name = "deserijalizujToolStripMenuItem";
            this.deserijalizujToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deserijalizujToolStripMenuItem.Text = "Deserijalizuj";
            // 
            // binarnoToolStripMenuItem
            // 
            this.binarnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.članovToolStripMenuItem,
            this.članoveToolStripMenuItem,
            this.uposlenikeToolStripMenuItem});
            this.binarnoToolStripMenuItem.Name = "binarnoToolStripMenuItem";
            this.binarnoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.binarnoToolStripMenuItem.Text = "Binarno";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigeToolStripMenuItem,
            this.članoveToolStripMenuItem1,
            this.uposlenikeToolStripMenuItem1});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // binarnoToolStripMenuItem1
            // 
            this.binarnoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigeToolStripMenuItem1,
            this.članoveToolStripMenuItem2,
            this.uposlenikeToolStripMenuItem2});
            this.binarnoToolStripMenuItem1.Name = "binarnoToolStripMenuItem1";
            this.binarnoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.binarnoToolStripMenuItem1.Text = "Binarno";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigeToolStripMenuItem2,
            this.članoveToolStripMenuItem3,
            this.uposlenikeToolStripMenuItem3});
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            // 
            // članovToolStripMenuItem
            // 
            this.članovToolStripMenuItem.Name = "članovToolStripMenuItem";
            this.članovToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.članovToolStripMenuItem.Text = "Knjige";
            this.članovToolStripMenuItem.Click += new System.EventHandler(this.članovToolStripMenuItem_Click);
            // 
            // članoveToolStripMenuItem
            // 
            this.članoveToolStripMenuItem.Name = "članoveToolStripMenuItem";
            this.članoveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.članoveToolStripMenuItem.Text = "Članove";
            this.članoveToolStripMenuItem.Click += new System.EventHandler(this.članoveToolStripMenuItem_Click);
            // 
            // uposlenikeToolStripMenuItem
            // 
            this.uposlenikeToolStripMenuItem.Name = "uposlenikeToolStripMenuItem";
            this.uposlenikeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uposlenikeToolStripMenuItem.Text = "Uposlenike";
            this.uposlenikeToolStripMenuItem.Click += new System.EventHandler(this.uposlenikeToolStripMenuItem_Click_1);
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            this.knjigeToolStripMenuItem.Click += new System.EventHandler(this.knjigeToolStripMenuItem_Click_1);
            // 
            // članoveToolStripMenuItem1
            // 
            this.članoveToolStripMenuItem1.Name = "članoveToolStripMenuItem1";
            this.članoveToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.članoveToolStripMenuItem1.Text = "Članove";
            this.članoveToolStripMenuItem1.Click += new System.EventHandler(this.članoveToolStripMenuItem1_Click);
            // 
            // uposlenikeToolStripMenuItem1
            // 
            this.uposlenikeToolStripMenuItem1.Name = "uposlenikeToolStripMenuItem1";
            this.uposlenikeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.uposlenikeToolStripMenuItem1.Text = "Uposlenike";
            this.uposlenikeToolStripMenuItem1.Click += new System.EventHandler(this.uposlenikeToolStripMenuItem1_Click_1);
            // 
            // knjigeToolStripMenuItem1
            // 
            this.knjigeToolStripMenuItem1.Name = "knjigeToolStripMenuItem1";
            this.knjigeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.knjigeToolStripMenuItem1.Text = "Knjige";
            this.knjigeToolStripMenuItem1.Click += new System.EventHandler(this.knjigeToolStripMenuItem1_Click_1);
            // 
            // članoveToolStripMenuItem2
            // 
            this.članoveToolStripMenuItem2.Name = "članoveToolStripMenuItem2";
            this.članoveToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.članoveToolStripMenuItem2.Text = "Članove";
            this.članoveToolStripMenuItem2.Click += new System.EventHandler(this.članoveToolStripMenuItem2_Click);
            // 
            // uposlenikeToolStripMenuItem2
            // 
            this.uposlenikeToolStripMenuItem2.Name = "uposlenikeToolStripMenuItem2";
            this.uposlenikeToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.uposlenikeToolStripMenuItem2.Text = "Uposlenike";
            this.uposlenikeToolStripMenuItem2.Click += new System.EventHandler(this.uposlenikeToolStripMenuItem2_Click);
            // 
            // knjigeToolStripMenuItem2
            // 
            this.knjigeToolStripMenuItem2.Name = "knjigeToolStripMenuItem2";
            this.knjigeToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.knjigeToolStripMenuItem2.Text = "Knjige";
            this.knjigeToolStripMenuItem2.Click += new System.EventHandler(this.knjigeToolStripMenuItem2_Click);
            // 
            // članoveToolStripMenuItem3
            // 
            this.članoveToolStripMenuItem3.Name = "članoveToolStripMenuItem3";
            this.članoveToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.članoveToolStripMenuItem3.Text = "Članove";
            this.članoveToolStripMenuItem3.Click += new System.EventHandler(this.članoveToolStripMenuItem3_Click);
            // 
            // uposlenikeToolStripMenuItem3
            // 
            this.uposlenikeToolStripMenuItem3.Name = "uposlenikeToolStripMenuItem3";
            this.uposlenikeToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.uposlenikeToolStripMenuItem3.Text = "Uposlenike";
            this.uposlenikeToolStripMenuItem3.Click += new System.EventHandler(this.uposlenikeToolStripMenuItem3_Click);
            // 
            // AdminForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 196);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonIzmjena);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForma";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForma_FormClosed);
            this.Load += new System.EventHandler(this.AdminForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonUposlenik;
        private System.Windows.Forms.RadioButton radioButtonClan;
        private System.Windows.Forms.RadioButton radioButtonKnjiga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonIzmjena;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serijalizacijaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem serijalizujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem članovToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem članoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uposlenikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem članoveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uposlenikeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deserijalizujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarnoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem članoveToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem uposlenikeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem članoveToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem uposlenikeToolStripMenuItem3;
    }
}
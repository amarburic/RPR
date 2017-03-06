namespace NSBiblioteka {
    partial class RegistracijeKnjigeForma {
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
            this.knjigaKontrola1 = new NSBiblioteka.KnjigaKontrola();
            this.buttonSpasi = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // knjigaKontrola1
            // 
            this.knjigaKontrola1.AnimKuca = "";
            this.knjigaKontrola1.Autori = "";
            this.knjigaKontrola1.BrojIzdanja = 1;
            this.knjigaKontrola1.Dostupno = 0;
            this.knjigaKontrola1.Godina = 2000;
            this.knjigaKontrola1.ISBN = "";
            this.knjigaKontrola1.Izdavac = "";
            this.knjigaKontrola1.Konferencija = "";
            this.knjigaKontrola1.Location = new System.Drawing.Point(3, 3);
            this.knjigaKontrola1.NaCitanju = 0;
            this.knjigaKontrola1.Name = "knjigaKontrola1";
            this.knjigaKontrola1.Naslov = "";
            this.knjigaKontrola1.Oblast = "";
            this.knjigaKontrola1.Size = new System.Drawing.Size(414, 420);
            this.knjigaKontrola1.Specijalno = false;
            this.knjigaKontrola1.TabIndex = 0;
            this.knjigaKontrola1.Umjetnici = "";
            // 
            // buttonSpasi
            // 
            this.buttonSpasi.Location = new System.Drawing.Point(307, 429);
            this.buttonSpasi.Name = "buttonSpasi";
            this.buttonSpasi.Size = new System.Drawing.Size(110, 23);
            this.buttonSpasi.TabIndex = 2;
            this.buttonSpasi.Text = "Spasi";
            this.buttonSpasi.UseVisualStyleBackColor = true;
            this.buttonSpasi.Click += new System.EventHandler(this.buttonSpasi_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(416, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // RegistracijeKnjigeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 490);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSpasi);
            this.Controls.Add(this.knjigaKontrola1);
            this.Name = "RegistracijeKnjigeForma";
            this.Text = "Registracija knjige";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KnjigaKontrola knjigaKontrola1;
        private System.Windows.Forms.Button buttonSpasi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
namespace NSBiblioteka {
    partial class RegistracijaClanaForma {
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
            this.clanKontrola1 = new NSBiblioteka.ClanKontrola();
            this.buttonSpasi = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clanKontrola1
            // 
            this.clanKontrola1.Location = new System.Drawing.Point(3, 3);
            this.clanKontrola1.Name = "clanKontrola1";
            this.clanKontrola1.Size = new System.Drawing.Size(369, 493);
            this.clanKontrola1.TabIndex = 0;
            // 
            // buttonSpasi
            // 
            this.buttonSpasi.Location = new System.Drawing.Point(252, 501);
            this.buttonSpasi.Name = "buttonSpasi";
            this.buttonSpasi.Size = new System.Drawing.Size(110, 23);
            this.buttonSpasi.TabIndex = 1;
            this.buttonSpasi.Text = "Spasi";
            this.buttonSpasi.UseVisualStyleBackColor = true;
            this.buttonSpasi.Click += new System.EventHandler(this.buttonSpasi_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(374, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // RegistracijaClanaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSpasi);
            this.Controls.Add(this.clanKontrola1);
            this.Name = "RegistracijaClanaForma";
            this.Text = "Registracija člana";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClanKontrola clanKontrola1;
        private System.Windows.Forms.Button buttonSpasi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
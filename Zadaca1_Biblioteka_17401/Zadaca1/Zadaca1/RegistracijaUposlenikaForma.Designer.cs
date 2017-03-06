namespace NSBiblioteka {
    partial class RegistracijaUposlenikaForma {
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
            this.buttonSpasi = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.uposlenikKontrola1 = new NSBiblioteka.UposlenikKontrola();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSpasi
            // 
            this.buttonSpasi.Location = new System.Drawing.Point(263, 377);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(375, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // uposlenikKontrola1
            // 
            this.uposlenikKontrola1.Location = new System.Drawing.Point(3, 3);
            this.uposlenikKontrola1.Name = "uposlenikKontrola1";
            this.uposlenikKontrola1.Size = new System.Drawing.Size(370, 368);
            this.uposlenikKontrola1.TabIndex = 0;
            // 
            // RegistracijaUposlenikaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 431);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSpasi);
            this.Controls.Add(this.uposlenikKontrola1);
            this.Name = "RegistracijaUposlenikaForma";
            this.Text = "Registracija uposlenika";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UposlenikKontrola uposlenikKontrola1;
        private System.Windows.Forms.Button buttonSpasi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
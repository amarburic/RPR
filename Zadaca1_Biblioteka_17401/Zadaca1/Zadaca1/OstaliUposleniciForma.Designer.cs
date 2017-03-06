namespace NSBiblioteka {
    partial class OstaliUposleniciForma {
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
            this.Profil = new System.Windows.Forms.TabPage();
            this.uposlenikKontrola1 = new NSBiblioteka.UposlenikKontrola();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Profil.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Profil
            // 
            this.Profil.Controls.Add(this.uposlenikKontrola1);
            this.Profil.Location = new System.Drawing.Point(4, 22);
            this.Profil.Name = "Profil";
            this.Profil.Padding = new System.Windows.Forms.Padding(3);
            this.Profil.Size = new System.Drawing.Size(384, 382);
            this.Profil.TabIndex = 0;
            this.Profil.Text = "Profil";
            this.Profil.UseVisualStyleBackColor = true;
            // 
            // uposlenikKontrola1
            // 
            this.uposlenikKontrola1.Location = new System.Drawing.Point(3, 0);
            this.uposlenikKontrola1.Name = "uposlenikKontrola1";
            this.uposlenikKontrola1.Size = new System.Drawing.Size(370, 368);
            this.uposlenikKontrola1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Profil);
            this.tabControl1.Location = new System.Drawing.Point(1, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(392, 408);
            this.tabControl1.TabIndex = 1;
            // 
            // OstaliUposleniciForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 419);
            this.Controls.Add(this.tabControl1);
            this.Name = "OstaliUposleniciForma";
            this.Text = "Uposlenik";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OstaliUposleniciForma_FormClosed);
            this.Load += new System.EventHandler(this.OstaliUposleniciForma_Load);
            this.Profil.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Profil;
        private UposlenikKontrola uposlenikKontrola1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
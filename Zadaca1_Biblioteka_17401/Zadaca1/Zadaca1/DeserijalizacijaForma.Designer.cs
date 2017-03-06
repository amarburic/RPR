namespace NSBiblioteka
{
    partial class DeserijalizacijaForma
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
            this.buttonSpasi = new System.Windows.Forms.Button();
            this.listBoxDeserijalizovani = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonSpasi
            // 
            this.buttonSpasi.Location = new System.Drawing.Point(280, 316);
            this.buttonSpasi.Name = "buttonSpasi";
            this.buttonSpasi.Size = new System.Drawing.Size(122, 23);
            this.buttonSpasi.TabIndex = 0;
            this.buttonSpasi.Text = "Spasi u bazu";
            this.buttonSpasi.UseVisualStyleBackColor = true;
            // 
            // listBoxDeserijalizovani
            // 
            this.listBoxDeserijalizovani.FormattingEnabled = true;
            this.listBoxDeserijalizovani.Location = new System.Drawing.Point(13, 13);
            this.listBoxDeserijalizovani.Name = "listBoxDeserijalizovani";
            this.listBoxDeserijalizovani.ScrollAlwaysVisible = true;
            this.listBoxDeserijalizovani.Size = new System.Drawing.Size(389, 290);
            this.listBoxDeserijalizovani.TabIndex = 1;
            // 
            // DeserijalizacijaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 351);
            this.Controls.Add(this.listBoxDeserijalizovani);
            this.Controls.Add(this.buttonSpasi);
            this.Name = "DeserijalizacijaForma";
            this.Text = "Deserijalizacija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSpasi;
        private System.Windows.Forms.ListBox listBoxDeserijalizovani;
    }
}
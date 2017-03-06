namespace NSBiblioteka {
    partial class Pretraga {
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUnos = new System.Windows.Forms.TextBox();
            this.buttonBrisi = new System.Windows.Forms.Button();
            this.buttonIzmijeni = new System.Windows.Forms.Button();
            this.buttonOdaberi = new System.Windows.Forms.Button();
            this.listBoxRezultat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Traži:";
            // 
            // textBoxUnos
            // 
            this.textBoxUnos.Location = new System.Drawing.Point(53, 13);
            this.textBoxUnos.Name = "textBoxUnos";
            this.textBoxUnos.Size = new System.Drawing.Size(219, 20);
            this.textBoxUnos.TabIndex = 1;
            this.textBoxUnos.TextChanged += new System.EventHandler(this.textBoxUnos_TextChanged);
            // 
            // buttonBrisi
            // 
            this.buttonBrisi.Location = new System.Drawing.Point(116, 195);
            this.buttonBrisi.Name = "buttonBrisi";
            this.buttonBrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonBrisi.TabIndex = 3;
            this.buttonBrisi.Text = "Obriši";
            this.buttonBrisi.UseVisualStyleBackColor = true;
            this.buttonBrisi.Click += new System.EventHandler(this.buttonBrisi_Click);
            // 
            // buttonIzmijeni
            // 
            this.buttonIzmijeni.Location = new System.Drawing.Point(197, 195);
            this.buttonIzmijeni.Name = "buttonIzmijeni";
            this.buttonIzmijeni.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmijeni.TabIndex = 4;
            this.buttonIzmijeni.Text = "Izmijeni";
            this.buttonIzmijeni.UseVisualStyleBackColor = true;
            this.buttonIzmijeni.Click += new System.EventHandler(this.buttonIzmijeni_Click);
            // 
            // buttonOdaberi
            // 
            this.buttonOdaberi.Location = new System.Drawing.Point(197, 195);
            this.buttonOdaberi.Name = "buttonOdaberi";
            this.buttonOdaberi.Size = new System.Drawing.Size(75, 23);
            this.buttonOdaberi.TabIndex = 5;
            this.buttonOdaberi.Text = "Odaberi";
            this.buttonOdaberi.UseVisualStyleBackColor = true;
            this.buttonOdaberi.Click += new System.EventHandler(this.buttonOdaberi_Click);
            // 
            // listBoxRezultat
            // 
            this.listBoxRezultat.FormattingEnabled = true;
            this.listBoxRezultat.HorizontalScrollbar = true;
            this.listBoxRezultat.Location = new System.Drawing.Point(12, 39);
            this.listBoxRezultat.Name = "listBoxRezultat";
            this.listBoxRezultat.Size = new System.Drawing.Size(260, 147);
            this.listBoxRezultat.TabIndex = 6;
            // 
            // Pretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 230);
            this.Controls.Add(this.listBoxRezultat);
            this.Controls.Add(this.buttonIzmijeni);
            this.Controls.Add(this.buttonBrisi);
            this.Controls.Add(this.textBoxUnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOdaberi);
            this.Name = "Pretraga";
            this.Text = "Pretraga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUnos;
        private System.Windows.Forms.Button buttonBrisi;
        private System.Windows.Forms.Button buttonIzmijeni;
        private System.Windows.Forms.Button buttonOdaberi;
        private System.Windows.Forms.ListBox listBoxRezultat;
    }
}
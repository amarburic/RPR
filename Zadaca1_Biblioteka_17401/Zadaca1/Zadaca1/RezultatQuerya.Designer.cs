namespace NSBiblioteka {
    partial class RezultatQuerya {
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
            this.dataGridViewRezultat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezultat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezultat
            // 
            this.dataGridViewRezultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezultat.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewRezultat.Name = "dataGridViewRezultat";
            this.dataGridViewRezultat.Size = new System.Drawing.Size(423, 336);
            this.dataGridViewRezultat.TabIndex = 0;
            // 
            // RezultatQuerya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 361);
            this.Controls.Add(this.dataGridViewRezultat);
            this.Name = "RezultatQuerya";
            this.Text = "Rezultat Querya";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezultat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRezultat;
    }
}
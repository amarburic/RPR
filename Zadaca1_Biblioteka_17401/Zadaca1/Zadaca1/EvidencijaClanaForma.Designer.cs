namespace NSBiblioteka {
    partial class EvidencijaClanaForma {
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSpasi = new System.Windows.Forms.Button();
            this.clanKontrola1 = new NSBiblioteka.ClanKontrola();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxListaZaduzenja = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.razdužiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 558);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSpasi);
            this.tabPage1.Controls.Add(this.clanKontrola1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(379, 532);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSpasi
            // 
            this.buttonSpasi.Location = new System.Drawing.Point(269, 499);
            this.buttonSpasi.Name = "buttonSpasi";
            this.buttonSpasi.Size = new System.Drawing.Size(98, 23);
            this.buttonSpasi.TabIndex = 2;
            this.buttonSpasi.Text = "Spasi";
            this.buttonSpasi.UseVisualStyleBackColor = true;
            this.buttonSpasi.Click += new System.EventHandler(this.buttonSpasi_Click_1);
            // 
            // clanKontrola1
            // 
            this.clanKontrola1.Location = new System.Drawing.Point(0, 0);
            this.clanKontrola1.Name = "clanKontrola1";
            this.clanKontrola1.Size = new System.Drawing.Size(369, 493);
            this.clanKontrola1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(379, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Evidencija";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAPOMENA:\r\nDesnim klikom na odgovarajući element zadužujete\r\ni razdužujete knjige" +
    ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxListaZaduzenja);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista zaduženja";
            // 
            // listBoxListaZaduzenja
            // 
            this.listBoxListaZaduzenja.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxListaZaduzenja.FormattingEnabled = true;
            this.listBoxListaZaduzenja.Location = new System.Drawing.Point(7, 20);
            this.listBoxListaZaduzenja.Name = "listBoxListaZaduzenja";
            this.listBoxListaZaduzenja.Size = new System.Drawing.Size(356, 446);
            this.listBoxListaZaduzenja.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.razdužiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 48);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.dodajToolStripMenuItem.Text = "Zaduži";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click_1);
            // 
            // razdužiToolStripMenuItem
            // 
            this.razdužiToolStripMenuItem.Name = "razdužiToolStripMenuItem";
            this.razdužiToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.razdužiToolStripMenuItem.Text = "Razduži";
            this.razdužiToolStripMenuItem.Click += new System.EventHandler(this.razdužiToolStripMenuItem_Click_1);
            // 
            // EvidencijaClanaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 564);
            this.Controls.Add(this.tabControl1);
            this.Name = "EvidencijaClanaForma";
            this.Text = "Evidencija člana";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ClanKontrola clanKontrola1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxListaZaduzenja;
        private System.Windows.Forms.Button buttonSpasi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem razdužiToolStripMenuItem;
    }
}
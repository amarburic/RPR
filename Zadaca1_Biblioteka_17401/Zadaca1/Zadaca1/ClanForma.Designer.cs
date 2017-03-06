namespace NSBiblioteka {
    partial class ClanForma {
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
            this.tabPageZelje = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.checkedListBoxLista = new System.Windows.Forms.CheckedListBox();
            this.tabPageKnjige = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewPosudjene = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageProfil = new System.Windows.Forms.TabPage();
            this.clanKontrola1 = new NSBiblioteka.ClanKontrola();
            this.tabControlAnaliza = new System.Windows.Forms.TabControl();
            this.tabPageZelje.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPageKnjige.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageProfil.SuspendLayout();
            this.tabControlAnaliza.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageZelje
            // 
            this.tabPageZelje.Controls.Add(this.groupBox4);
            this.tabPageZelje.Location = new System.Drawing.Point(4, 22);
            this.tabPageZelje.Name = "tabPageZelje";
            this.tabPageZelje.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageZelje.Size = new System.Drawing.Size(388, 517);
            this.tabPageZelje.TabIndex = 2;
            this.tabPageZelje.Text = "Lista želja";
            this.tabPageZelje.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonDodaj);
            this.groupBox4.Controls.Add(this.buttonObrisi);
            this.groupBox4.Controls.Add(this.checkedListBoxLista);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 505);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(110, 476);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(123, 23);
            this.buttonDodaj.TabIndex = 5;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(248, 476);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(123, 23);
            this.buttonObrisi.TabIndex = 4;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // checkedListBoxLista
            // 
            this.checkedListBoxLista.FormattingEnabled = true;
            this.checkedListBoxLista.Location = new System.Drawing.Point(6, 16);
            this.checkedListBoxLista.Name = "checkedListBoxLista";
            this.checkedListBoxLista.Size = new System.Drawing.Size(365, 454);
            this.checkedListBoxLista.TabIndex = 0;
            this.checkedListBoxLista.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxLista_ItemCheck);
            // 
            // tabPageKnjige
            // 
            this.tabPageKnjige.Controls.Add(this.groupBox1);
            this.tabPageKnjige.Location = new System.Drawing.Point(4, 22);
            this.tabPageKnjige.Name = "tabPageKnjige";
            this.tabPageKnjige.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKnjige.Size = new System.Drawing.Size(388, 517);
            this.tabPageKnjige.TabIndex = 1;
            this.tabPageKnjige.Text = "Knjige";
            this.tabPageKnjige.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewPosudjene);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trenutno posuđene knjige";
            // 
            // listViewPosudjene
            // 
            this.listViewPosudjene.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPosudjene.Location = new System.Drawing.Point(6, 19);
            this.listViewPosudjene.Name = "listViewPosudjene";
            this.listViewPosudjene.Size = new System.Drawing.Size(370, 486);
            this.listViewPosudjene.TabIndex = 0;
            this.listViewPosudjene.UseCompatibleStateImageBehavior = false;
            this.listViewPosudjene.View = System.Windows.Forms.View.Details;
            this.listViewPosudjene.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naziv knjige";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Autor(i)";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rok za vraćanje";
            this.columnHeader3.Width = 149;
            // 
            // tabPageProfil
            // 
            this.tabPageProfil.Controls.Add(this.clanKontrola1);
            this.tabPageProfil.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfil.Name = "tabPageProfil";
            this.tabPageProfil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfil.Size = new System.Drawing.Size(388, 517);
            this.tabPageProfil.TabIndex = 0;
            this.tabPageProfil.Text = "Profil";
            this.tabPageProfil.UseVisualStyleBackColor = true;
            // 
            // clanKontrola1
            // 
            this.clanKontrola1.Location = new System.Drawing.Point(10, 6);
            this.clanKontrola1.Name = "clanKontrola1";
            this.clanKontrola1.Size = new System.Drawing.Size(369, 505);
            this.clanKontrola1.TabIndex = 0;
            // 
            // tabControlAnaliza
            // 
            this.tabControlAnaliza.Controls.Add(this.tabPageProfil);
            this.tabControlAnaliza.Controls.Add(this.tabPageKnjige);
            this.tabControlAnaliza.Controls.Add(this.tabPageZelje);
            this.tabControlAnaliza.Location = new System.Drawing.Point(4, 3);
            this.tabControlAnaliza.Name = "tabControlAnaliza";
            this.tabControlAnaliza.SelectedIndex = 0;
            this.tabControlAnaliza.Size = new System.Drawing.Size(396, 543);
            this.tabControlAnaliza.TabIndex = 0;
            // 
            // ClanForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 550);
            this.Controls.Add(this.tabControlAnaliza);
            this.Name = "ClanForma";
            this.Text = "Član";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClanForma_FormClosed);
            this.Load += new System.EventHandler(this.ClanForma_Load);
            this.tabPageZelje.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabPageKnjige.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPageProfil.ResumeLayout(false);
            this.tabControlAnaliza.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageZelje;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.CheckedListBox checkedListBoxLista;
        private System.Windows.Forms.TabPage tabPageKnjige;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewPosudjene;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabPageProfil;
        private ClanKontrola clanKontrola1;
        private System.Windows.Forms.TabControl tabControlAnaliza;
    }
}
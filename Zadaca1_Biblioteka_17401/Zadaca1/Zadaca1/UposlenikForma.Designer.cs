namespace NSBiblioteka {
    partial class UposlenikForma {
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Profil = new System.Windows.Forms.TabPage();
            this.uposlenikKontrola1 = new NSBiblioteka.UposlenikKontrola();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonClan = new System.Windows.Forms.RadioButton();
            this.radioButtonKnjiga = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Analiza = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPrikaz1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonStanjeClanova = new System.Windows.Forms.RadioButton();
            this.radioButtonStanjeKnjiga = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.Profil.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Analiza.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Profil);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Analiza);
            this.tabControl1.Location = new System.Drawing.Point(2, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(392, 408);
            this.tabControl1.TabIndex = 0;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonOK);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(384, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Evidencija";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(276, 346);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(96, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonClan);
            this.groupBox2.Controls.Add(this.radioButtonKnjiga);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izbor";
            // 
            // radioButtonClan
            // 
            this.radioButtonClan.AutoSize = true;
            this.radioButtonClan.Location = new System.Drawing.Point(159, 96);
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
            this.radioButtonKnjiga.Location = new System.Drawing.Point(159, 45);
            this.radioButtonKnjiga.Name = "radioButtonKnjiga";
            this.radioButtonKnjiga.Size = new System.Drawing.Size(54, 17);
            this.radioButtonKnjiga.TabIndex = 1;
            this.radioButtonKnjiga.TabStop = true;
            this.radioButtonKnjiga.Text = "Knjiga";
            this.radioButtonKnjiga.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Objekat:";
            // 
            // Analiza
            // 
            this.Analiza.Controls.Add(this.groupBox3);
            this.Analiza.Controls.Add(this.groupBox1);
            this.Analiza.Location = new System.Drawing.Point(4, 22);
            this.Analiza.Name = "Analiza";
            this.Analiza.Size = new System.Drawing.Size(384, 382);
            this.Analiza.TabIndex = 2;
            this.Analiza.Text = "Analiza";
            this.Analiza.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(3, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 182);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Analitičke funkcije";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(211, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Dobna struktura";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Spolna struktura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPrikaz1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButtonStanjeClanova);
            this.groupBox1.Controls.Add(this.radioButtonStanjeKnjiga);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stanje";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonPrikaz1
            // 
            this.buttonPrikaz1.Location = new System.Drawing.Point(252, 143);
            this.buttonPrikaz1.Name = "buttonPrikaz1";
            this.buttonPrikaz1.Size = new System.Drawing.Size(103, 23);
            this.buttonPrikaz1.TabIndex = 3;
            this.buttonPrikaz1.Text = "Prikaži";
            this.buttonPrikaz1.UseVisualStyleBackColor = true;
            this.buttonPrikaz1.Click += new System.EventHandler(this.buttonPrikaz1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stanje: ";
            // 
            // radioButtonStanjeClanova
            // 
            this.radioButtonStanjeClanova.AutoSize = true;
            this.radioButtonStanjeClanova.Location = new System.Drawing.Point(129, 104);
            this.radioButtonStanjeClanova.Name = "radioButtonStanjeClanova";
            this.radioButtonStanjeClanova.Size = new System.Drawing.Size(64, 17);
            this.radioButtonStanjeClanova.TabIndex = 1;
            this.radioButtonStanjeClanova.TabStop = true;
            this.radioButtonStanjeClanova.Text = "Članova";
            this.radioButtonStanjeClanova.UseVisualStyleBackColor = true;
            // 
            // radioButtonStanjeKnjiga
            // 
            this.radioButtonStanjeKnjiga.AutoSize = true;
            this.radioButtonStanjeKnjiga.Checked = true;
            this.radioButtonStanjeKnjiga.Location = new System.Drawing.Point(129, 62);
            this.radioButtonStanjeKnjiga.Name = "radioButtonStanjeKnjiga";
            this.radioButtonStanjeKnjiga.Size = new System.Drawing.Size(54, 17);
            this.radioButtonStanjeKnjiga.TabIndex = 0;
            this.radioButtonStanjeKnjiga.TabStop = true;
            this.radioButtonStanjeKnjiga.Text = "Knjiga";
            this.radioButtonStanjeKnjiga.UseVisualStyleBackColor = true;
            // 
            // UposlenikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 415);
            this.Controls.Add(this.tabControl1);
            this.Name = "UposlenikForma";
            this.Text = "Uposlenik";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UposlenikForma_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.Profil.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Analiza.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Profil;
        private System.Windows.Forms.TabPage tabPage2;
        private UposlenikKontrola uposlenikKontrola1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonClan;
        private System.Windows.Forms.RadioButton radioButtonKnjiga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Analiza;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonStanjeClanova;
        private System.Windows.Forms.RadioButton radioButtonStanjeKnjiga;
        private System.Windows.Forms.Button buttonPrikaz1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}
namespace NSBiblioteka {
    partial class KnjigaKontrola {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAutori = new System.Windows.Forms.TextBox();
            this.textBoxNaslov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxNaucniRad = new System.Windows.Forms.GroupBox();
            this.textBoxKonferencija = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxOblast = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxStrip = new System.Windows.Forms.GroupBox();
            this.checkBoxPosebno = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownBrojIzdanja = new System.Windows.Forms.NumericUpDown();
            this.textBoxUmjetnici = new System.Windows.Forms.TextBox();
            this.textBoxAnimKuca = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownGodina = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIzdavac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDownNaCitanju = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownDostupno = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxNaucniRad.SuspendLayout();
            this.groupBoxStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojIzdanja)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGodina)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNaCitanju)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDostupno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAutori);
            this.groupBox1.Controls.Add(this.textBoxNaslov);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opći podaci";
            // 
            // textBoxAutori
            // 
            this.textBoxAutori.Location = new System.Drawing.Point(57, 53);
            this.textBoxAutori.Multiline = true;
            this.textBoxAutori.Name = "textBoxAutori";
            this.textBoxAutori.Size = new System.Drawing.Size(122, 84);
            this.textBoxAutori.TabIndex = 3;
            // 
            // textBoxNaslov
            // 
            this.textBoxNaslov.Location = new System.Drawing.Point(58, 24);
            this.textBoxNaslov.Name = "textBoxNaslov";
            this.textBoxNaslov.Size = new System.Drawing.Size(122, 20);
            this.textBoxNaslov.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor(i):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxTip);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBoxNaucniRad);
            this.groupBox2.Controls.Add(this.groupBoxStrip);
            this.groupBox2.Location = new System.Drawing.Point(4, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodatno";
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Items.AddRange(new object[] {
            "Obična",
            "Strip",
            "Naučni rad"});
            this.comboBoxTip.Location = new System.Drawing.Point(11, 96);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(111, 21);
            this.comboBoxTip.TabIndex = 5;
            this.comboBoxTip.SelectedIndexChanged += new System.EventHandler(this.comboBoxTip_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tip knjige:";
            // 
            // groupBoxNaucniRad
            // 
            this.groupBoxNaucniRad.Controls.Add(this.textBoxKonferencija);
            this.groupBoxNaucniRad.Controls.Add(this.label13);
            this.groupBoxNaucniRad.Controls.Add(this.textBoxOblast);
            this.groupBoxNaucniRad.Controls.Add(this.label12);
            this.groupBoxNaucniRad.Location = new System.Drawing.Point(146, 10);
            this.groupBoxNaucniRad.Name = "groupBoxNaucniRad";
            this.groupBoxNaucniRad.Size = new System.Drawing.Size(261, 176);
            this.groupBoxNaucniRad.TabIndex = 13;
            this.groupBoxNaucniRad.TabStop = false;
            this.groupBoxNaucniRad.Text = "Naučni rad";
            this.groupBoxNaucniRad.Visible = false;
            // 
            // textBoxKonferencija
            // 
            this.textBoxKonferencija.Location = new System.Drawing.Point(92, 103);
            this.textBoxKonferencija.Name = "textBoxKonferencija";
            this.textBoxKonferencija.Size = new System.Drawing.Size(162, 20);
            this.textBoxKonferencija.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Konferencija:";
            // 
            // textBoxOblast
            // 
            this.textBoxOblast.Location = new System.Drawing.Point(92, 54);
            this.textBoxOblast.Name = "textBoxOblast";
            this.textBoxOblast.Size = new System.Drawing.Size(162, 20);
            this.textBoxOblast.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Oblast:";
            // 
            // groupBoxStrip
            // 
            this.groupBoxStrip.Controls.Add(this.checkBoxPosebno);
            this.groupBoxStrip.Controls.Add(this.label11);
            this.groupBoxStrip.Controls.Add(this.numericUpDownBrojIzdanja);
            this.groupBoxStrip.Controls.Add(this.textBoxUmjetnici);
            this.groupBoxStrip.Controls.Add(this.textBoxAnimKuca);
            this.groupBoxStrip.Controls.Add(this.label10);
            this.groupBoxStrip.Controls.Add(this.label9);
            this.groupBoxStrip.Location = new System.Drawing.Point(146, 10);
            this.groupBoxStrip.Name = "groupBoxStrip";
            this.groupBoxStrip.Size = new System.Drawing.Size(261, 176);
            this.groupBoxStrip.TabIndex = 6;
            this.groupBoxStrip.TabStop = false;
            this.groupBoxStrip.Text = "Strip";
            this.groupBoxStrip.Visible = false;
            // 
            // checkBoxPosebno
            // 
            this.checkBoxPosebno.AutoSize = true;
            this.checkBoxPosebno.Location = new System.Drawing.Point(107, 139);
            this.checkBoxPosebno.Name = "checkBoxPosebno";
            this.checkBoxPosebno.Size = new System.Drawing.Size(104, 17);
            this.checkBoxPosebno.TabIndex = 12;
            this.checkBoxPosebno.Text = "Posebno izdanje";
            this.checkBoxPosebno.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Broj izdanja:";
            // 
            // numericUpDownBrojIzdanja
            // 
            this.numericUpDownBrojIzdanja.Location = new System.Drawing.Point(107, 113);
            this.numericUpDownBrojIzdanja.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBrojIzdanja.Name = "numericUpDownBrojIzdanja";
            this.numericUpDownBrojIzdanja.Size = new System.Drawing.Size(148, 20);
            this.numericUpDownBrojIzdanja.TabIndex = 10;
            this.numericUpDownBrojIzdanja.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxUmjetnici
            // 
            this.textBoxUmjetnici.Location = new System.Drawing.Point(107, 50);
            this.textBoxUmjetnici.Multiline = true;
            this.textBoxUmjetnici.Name = "textBoxUmjetnici";
            this.textBoxUmjetnici.Size = new System.Drawing.Size(148, 57);
            this.textBoxUmjetnici.TabIndex = 4;
            // 
            // textBoxAnimKuca
            // 
            this.textBoxAnimKuca.Location = new System.Drawing.Point(107, 24);
            this.textBoxAnimKuca.Name = "textBoxAnimKuca";
            this.textBoxAnimKuca.Size = new System.Drawing.Size(148, 20);
            this.textBoxAnimKuca.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Umjetnik(ci):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Animatorska kuća:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownGodina);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxIzdavac);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxISBN);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(197, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 152);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Izdanje";
            // 
            // numericUpDownGodina
            // 
            this.numericUpDownGodina.Location = new System.Drawing.Point(94, 108);
            this.numericUpDownGodina.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numericUpDownGodina.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numericUpDownGodina.Name = "numericUpDownGodina";
            this.numericUpDownGodina.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownGodina.TabIndex = 9;
            this.numericUpDownGodina.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Godina izdanja:";
            // 
            // textBoxIzdavac
            // 
            this.textBoxIzdavac.Location = new System.Drawing.Point(61, 66);
            this.textBoxIzdavac.Name = "textBoxIzdavac";
            this.textBoxIzdavac.Size = new System.Drawing.Size(133, 20);
            this.textBoxIzdavac.TabIndex = 7;
            this.textBoxIzdavac.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Izdavač:";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(61, 24);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(133, 20);
            this.textBoxISBN.TabIndex = 5;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxISBN_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISBN:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDownNaCitanju);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.numericUpDownDostupno);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(4, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(407, 62);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dostupnost";
            // 
            // numericUpDownNaCitanju
            // 
            this.numericUpDownNaCitanju.Location = new System.Drawing.Point(286, 21);
            this.numericUpDownNaCitanju.Name = "numericUpDownNaCitanju";
            this.numericUpDownNaCitanju.Size = new System.Drawing.Size(101, 20);
            this.numericUpDownNaCitanju.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Na čitanju:";
            // 
            // numericUpDownDostupno
            // 
            this.numericUpDownDostupno.Location = new System.Drawing.Point(71, 21);
            this.numericUpDownDostupno.Name = "numericUpDownDostupno";
            this.numericUpDownDostupno.Size = new System.Drawing.Size(114, 20);
            this.numericUpDownDostupno.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dostupno:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // KnjigaKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "KnjigaKontrola";
            this.Size = new System.Drawing.Size(414, 420);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxNaucniRad.ResumeLayout(false);
            this.groupBoxNaucniRad.PerformLayout();
            this.groupBoxStrip.ResumeLayout(false);
            this.groupBoxStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojIzdanja)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGodina)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNaCitanju)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDostupno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAutori;
        private System.Windows.Forms.TextBox textBoxNaslov;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxIzdavac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownGodina;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericUpDownNaCitanju;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownDostupno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxStrip;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownBrojIzdanja;
        private System.Windows.Forms.TextBox textBoxUmjetnici;
        private System.Windows.Forms.TextBox textBoxAnimKuca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxPosebno;
        private System.Windows.Forms.GroupBox groupBoxNaucniRad;
        private System.Windows.Forms.TextBox textBoxKonferencija;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxOblast;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

using System.Windows.Forms;

namespace NSBiblioteka {
    partial class ClanKontrola : UserControl {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxClanarina = new System.Windows.Forms.MaskedTextBox();
            this.labelClanarina = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPlacanje = new System.Windows.Forms.ComboBox();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.textBoxKomentar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.osobaKontrola1 = new NSBiblioteka.OsobaKontrola();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxClanarina);
            this.groupBox1.Controls.Add(this.labelClanarina);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxPlacanje);
            this.groupBox1.Controls.Add(this.comboBoxTip);
            this.groupBox1.Controls.Add(this.textBoxKomentar);
            this.groupBox1.Location = new System.Drawing.Point(3, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o članstvu";
            // 
            // maskedTextBoxClanarina
            // 
            this.maskedTextBoxClanarina.Location = new System.Drawing.Point(260, 25);
            this.maskedTextBoxClanarina.Name = "maskedTextBoxClanarina";
            this.maskedTextBoxClanarina.ReadOnly = true;
            this.maskedTextBoxClanarina.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxClanarina.TabIndex = 11;
            // 
            // labelClanarina
            // 
            this.labelClanarina.AutoSize = true;
            this.labelClanarina.Location = new System.Drawing.Point(199, 28);
            this.labelClanarina.Name = "labelClanarina";
            this.labelClanarina.Size = new System.Drawing.Size(54, 13);
            this.labelClanarina.TabIndex = 9;
            this.labelClanarina.Text = "Članarina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Komentar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tip plaćanja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tip člana:";
            // 
            // comboBoxPlacanje
            // 
            this.comboBoxPlacanje.FormattingEnabled = true;
            this.comboBoxPlacanje.Items.AddRange(new object[] {
            "Mjesečno",
            "Godišnje"});
            this.comboBoxPlacanje.Location = new System.Drawing.Point(89, 56);
            this.comboBoxPlacanje.Name = "comboBoxPlacanje";
            this.comboBoxPlacanje.Size = new System.Drawing.Size(104, 21);
            this.comboBoxPlacanje.TabIndex = 5;
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Items.AddRange(new object[] {
            "Obični",
            "Student",
            "Student - Master",
            "Profesor"});
            this.comboBoxTip.Location = new System.Drawing.Point(89, 25);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(104, 21);
            this.comboBoxTip.TabIndex = 4;
            // 
            // textBoxKomentar
            // 
            this.textBoxKomentar.Location = new System.Drawing.Point(6, 105);
            this.textBoxKomentar.Multiline = true;
            this.textBoxKomentar.Name = "textBoxKomentar";
            this.textBoxKomentar.Size = new System.Drawing.Size(354, 67);
            this.textBoxKomentar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip člana: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip plaćanja: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Komentar:";
            // 
            // osobaKontrola1
            // 
            this.osobaKontrola1.Location = new System.Drawing.Point(0, 0);
            this.osobaKontrola1.Name = "osobaKontrola1";
            this.osobaKontrola1.Size = new System.Drawing.Size(370, 310);
            this.osobaKontrola1.TabIndex = 2;
            // 
            // ClanKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.osobaKontrola1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClanKontrola";
            this.Size = new System.Drawing.Size(369, 493);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPlacanje;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.TextBox textBoxKomentar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private MaskedTextBox maskedTextBoxClanarina;
        private Label labelClanarina;
        private OsobaKontrola osobaKontrola1;
    }
}

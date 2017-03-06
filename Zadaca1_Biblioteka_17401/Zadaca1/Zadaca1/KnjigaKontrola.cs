using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBiblioteka {
    public partial class KnjigaKontrola : UserControl {

        Knjiga k;
        bool ISBNReset;

        public KnjigaKontrola()
        {
            InitializeComponent();
            groupBoxNaucniRad.Visible = false;
            groupBoxStrip.Visible = false;
            comboBoxTip.SelectedIndex = 0;
            numericUpDownNaCitanju.Enabled = false;
            ISBNReset = false;
            
        }

        public virtual void Popuni(Knjiga k)
        {
            this.k = k;
            textBoxNaslov.Text = k.Naslov;
            textBoxAutori.Text = k.AutoriKaoString();
            textBoxISBN.Text = k.ISBN.ToString();
            textBoxIzdavac.Text = k.Izdavac;
            numericUpDownGodina.Value = k.GodinaIzdanja;
            if (k.Zaduzena)
                numericUpDownNaCitanju.Value = 1;
            if (k is Strip)
            {
                Strip s = k as Strip;
                comboBoxTip.SelectedIndex = 1;
                groupBoxStrip.Visible = true;
                textBoxAnimKuca.Text = s.AnimatorskaKuca;
                textBoxUmjetnici.Text = s.UmjetniciKaoString();
                numericUpDownBrojIzdanja.Value = s.BrojIzdanja;
                checkBoxPosebno.Checked = s.SpecijalnoIzdanje;
            } 
            else if(k is NaucniRad)
            {
                NaucniRad n = k as NaucniRad;
                comboBoxTip.SelectedIndex = 2;
                groupBoxNaucniRad.Visible = true;
                textBoxKonferencija.Text = n.Konferencija;
                textBoxOblast.Text = n.Oblast;
            }
        }

        public void Zakljucaj()
        {
            numericUpDownDostupno.Enabled = false;
            numericUpDownNaCitanju.Enabled = false;
            textBoxNaslov.ReadOnly = true;
            textBoxAutori.ReadOnly = true;
            textBoxISBN.ReadOnly = true;
            textBoxIzdavac.ReadOnly = true;
            numericUpDownGodina.Enabled = false;
            textBoxAnimKuca.ReadOnly = true;
            textBoxUmjetnici.ReadOnly = true;
            numericUpDownBrojIzdanja.Enabled = false;
            checkBoxPosebno.Enabled = false;
            textBoxKonferencija.ReadOnly = true;
            textBoxOblast.ReadOnly = true;
            ZakljucajTip();
        }

        public void OtkljucajDostupnost()
        {
            numericUpDownDostupno.Enabled = true;
        }

        public void ZakljucajTip()
        {
            comboBoxTip.Enabled = false;
        }

        public void Resetuj()
        {
            numericUpDownDostupno.Value = 0;
            numericUpDownNaCitanju.Value = 0;
            textBoxNaslov.Text = "";
            textBoxAutori.Text = "";
            textBoxISBN.Text = "";
            textBoxIzdavac.Text = "";
            numericUpDownGodina.Value = 2000;
            textBoxAnimKuca.Text = "";
            textBoxUmjetnici.Text = "";
            numericUpDownBrojIzdanja.Value = 1;
            checkBoxPosebno.Checked = false;
            textBoxKonferencija.Text = "";
            textBoxOblast.Text = "";
            comboBoxTip.SelectedIndex = 1;
            groupBoxNaucniRad.Visible = false;
            groupBoxStrip.Visible = false;
            ISBNReset = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxNaucniRad.Visible = false;
            groupBoxStrip.Visible = false;
            if (comboBoxTip.SelectedIndex == 1)
            {
                groupBoxStrip.Visible = true;
            }
            else if (comboBoxTip.SelectedIndex == 2)
            {
                groupBoxNaucniRad.Visible = true;
            }
               
        }

        public String Naslov { get { return textBoxNaslov.Text; } set { textBoxNaslov.Text = value; } }
        public String Autori { get { return textBoxAutori.Text;  } set { textBoxAutori.Text = value; } }
        public String ISBN { get { return textBoxISBN.Text;  } set { textBoxISBN.Text = value;  } }
        public String Izdavac { get { return textBoxIzdavac.Text;  } set { textBoxIzdavac.Text = value; } }
        public int Godina { get { return (int)numericUpDownGodina.Value;  } set { numericUpDownGodina.Value = value; } }
        public int Dostupno { get { return (int)numericUpDownDostupno.Value;  } set { numericUpDownDostupno.Value = value; } }
        public int NaCitanju { get { return (int)numericUpDownNaCitanju.Value; } set { numericUpDownNaCitanju.Value = value;  } }
        public int Tip { get { return comboBoxTip.SelectedIndex; } }
        public String AnimKuca { get { return textBoxAnimKuca.Text;  } set { textBoxAnimKuca.Text = value; } }
        public String Umjetnici { get { return textBoxUmjetnici.Text;  } set { textBoxUmjetnici.Text = value;  } }
        public int BrojIzdanja { get { return (int)numericUpDownBrojIzdanja.Value;  } set { numericUpDownBrojIzdanja.Value = value;  } } 
        public Boolean Specijalno { get { return checkBoxPosebno.Checked; } set { checkBoxPosebno.Checked = value; } }
        public String Konferencija { get { return textBoxKonferencija.Text;  } set { textBoxKonferencija.Text = value;  } }
        public String Oblast { get { return textBoxOblast.Text;  } set { textBoxOblast.Text = value;  } }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxISBN, "");
            if (!ISBNReset)
            {
                try
                {
                    Knjiga.StaticnaValidirajISBN(ISBN, Godina);

                }
                catch (Exception exc)
                {
                    errorProvider1.SetError(textBoxISBN, exc.Message);
                }
            }
            else
                ISBNReset = false;
        }
    }

}

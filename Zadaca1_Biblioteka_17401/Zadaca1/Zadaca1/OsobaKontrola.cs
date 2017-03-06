using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatumBiblioteka;

namespace NSBiblioteka {
    public partial class OsobaKontrola : UserControl {
        protected Osoba o;
        protected Biblioteka bibl;

        Boolean lozinkaIzmijenjena;
        Boolean pristupljenoLozinki;
        Boolean kimeReset;
        public OsobaKontrola()
        {
            InitializeComponent();
            lozinkaIzmijenjena = false;
            pristupljenoLozinki = false;
            kimeReset = false;
            comboBoxSpol.SelectedIndex = 0;
            o = null;
        }

        public virtual void Popuni(Osoba o)
        {
            this.o = o;
            slikaKontrola1.Popuni(o.Slika, DateTime.Now);
            textBoxIme.Text = o.Ime;
            textBoxPrezime.Text = o.Prezime;
            comboBoxSpol.Text = o.SpolOsobe.ToString()[0] + "";
            dateTimePickerDatumRodjenja.Value = o.DatumRodjenja.kaoDateTime();
            maskedTextBoxJMBG.Text = o.MaticniBroj;
            textBoxKorisnickoIme.Text = o.KorisnickoIme;
            textBoxLozinka.Text = "    ";
        }

        public virtual void Zakljucaj()
        {
            slikaKontrola1.Zakljucaj();
            textBoxIme.ReadOnly = true;
            textBoxPrezime.ReadOnly = true;
            comboBoxSpol.Enabled = false;
            dateTimePickerDatumRodjenja.Enabled = false;
            maskedTextBoxJMBG.ReadOnly = true;
            textBoxKorisnickoIme.ReadOnly = true;
            textBoxLozinka.ReadOnly = true;
        }

        public void Resetuj()
        {
            slikaKontrola1.Resetuj();
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            comboBoxSpol.SelectedIndex = 0;
            dateTimePickerDatumRodjenja.Value = DateTime.Now;
            maskedTextBoxJMBG.Text = "";
            textBoxKorisnickoIme.Text = "";
            textBoxLozinka.Text = "";
            kimeReset = true;
        }

        private void textBoxLozinka_TextChanged(object sender, EventArgs e)
        {
            if(pristupljenoLozinki)
                lozinkaIzmijenjena = true;
        }

        public Boolean LozinkaIzmijenjena { get { return lozinkaIzmijenjena; } set { lozinkaIzmijenjena = pristupljenoLozinki = value; } }

        public String Prezime { get { return textBoxPrezime.Text; } }
        public String Ime { get { return textBoxIme.Text; } }
        public Datum DatumRodjenja { get { return new Datum(dateTimePickerDatumRodjenja.Value); } }
        public Osoba.Spol Spol { get { return (Osoba.Spol)comboBoxSpol.SelectedIndex; } }
        public String JMBG { get { return maskedTextBoxJMBG.Text; } }
        public Image Slika { get { return slikaKontrola1.Slika; } }
        public String Lozinka { get { return textBoxLozinka.Text; } }
        public String KorisnickoIme { get { return textBoxKorisnickoIme.Text; } }

        private void textBoxLozinka_Enter(object sender, EventArgs e)
        {
            pristupljenoLozinki = true;
        }

        private void maskedTextBoxJMBG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider1.SetError(maskedTextBoxJMBG, "");
            try
            {
                if (o != null)
                    o.ValidirajJMBG(JMBG, Spol, DatumRodjenja);
                else
                    Osoba.StaticnaValidirajJMBG(JMBG, Spol, DatumRodjenja);
            }
            catch (Exception exc)
            {
                errorProvider1.SetError(maskedTextBoxJMBG, exc.Message);
            }
        }

        private void textBoxKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.SetError(textBoxKorisnickoIme, "");
            if (!kimeReset)
            {
                try
                {
                    if (o != null)
                        o.ValidirajKorisnickoIme(KorisnickoIme);
                    else
                        Osoba.StaticnaValidirajKorisnickoIme(bibl, KorisnickoIme);

                }
                catch (Exception exc)
                {
                    errorProvider2.SetError(textBoxKorisnickoIme, exc.Message);
                }
            }
            else
                kimeReset = false;
        }

        public Biblioteka Bibl { set { bibl = value;  } }
    }
}

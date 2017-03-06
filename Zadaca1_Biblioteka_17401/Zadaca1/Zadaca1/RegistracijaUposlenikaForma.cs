using DatumBiblioteka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBiblioteka {
    public partial class RegistracijaUposlenikaForma : Form {
        public enum NacinRada { Registracija, Izmjena }

        Uposlenik u;
        Biblioteka bibl;
        NacinRada nacinRada;

        public RegistracijaUposlenikaForma(NacinRada nacinRada, Biblioteka bibl, Uposlenik u = null)
        {
            this.nacinRada = nacinRada;
            this.u = u;
            this.bibl = bibl;
            InitializeComponent();
            if (nacinRada == NacinRada.Izmjena)
                uposlenikKontrola1.Popuni(u);
            else
                uposlenikKontrola1.OsobaKontrola1.Bibl = bibl;

        }

        public void Spasi()
        {
            String Ime = uposlenikKontrola1.OsobaKontrola1.Ime,
                Prezime = uposlenikKontrola1.OsobaKontrola1.Prezime,
                JMBG = uposlenikKontrola1.OsobaKontrola1.JMBG,
                KorisnickoIme = uposlenikKontrola1.OsobaKontrola1.KorisnickoIme,
                Lozinka = uposlenikKontrola1.OsobaKontrola1.Lozinka;
            Datum DatumRodjenja = uposlenikKontrola1.OsobaKontrola1.DatumRodjenja;
            Osoba.Spol Spol = uposlenikKontrola1.OsobaKontrola1.Spol;
            Image Slika = uposlenikKontrola1.OsobaKontrola1.Slika;
            Uposlenik.Tip Tip = uposlenikKontrola1.Tip;

            if (nacinRada == NacinRada.Registracija)
                bibl.RegistrujUposlenika(
                    Ime,
                    Prezime,
                    JMBG,
                    DatumRodjenja,
                    Spol,
                    Slika,
                    KorisnickoIme,
                    Lozinka,
                    Tip
                    );
            else if (nacinRada == NacinRada.Izmjena)
            {
                u.ValidirajSve(JMBG, Spol, DatumRodjenja, KorisnickoIme);
                u.Ime = Ime;
                u.Prezime = Prezime;
                u.MaticniBroj = JMBG;
                u.KorisnickoIme = KorisnickoIme;
                if(uposlenikKontrola1.OsobaKontrola1.LozinkaIzmijenjena)
                    u.Lozinka = Lozinka;
                u.DatumRodjenja = DatumRodjenja;
                u.SpolOsobe = Spol;
                u.Slika = Slika;
                u.TipUposlenika = Tip;
            }

        }

        private void buttonSpasi_Click(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = "";
            try
            { 
                Spasi();
                uposlenikKontrola1.OsobaKontrola1.LozinkaIzmijenjena = false;
                if (nacinRada == NacinRada.Registracija)
                    uposlenikKontrola1.Resetuj();
                MessageBox.Show(this, "Spašeno", "Info", MessageBoxButtons.OK);
            }
            catch (Exception exc)
            {
                toolStripStatusLabel1.Text = exc.Message;
            }
}
    }
}

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
    public partial class RegistracijaClanaForma : Form {

        public enum Zastita { Admin, Uposlenik }
        public enum NacinRada { Registracija, Izmjena }

        Clan c;
        Biblioteka bibl;
        Zastita zastita;
        NacinRada nacinRada;

        public RegistracijaClanaForma(Zastita zastita, NacinRada nacinRada, Biblioteka bibl, Clan c = null)
        {
            this.zastita = zastita;
            this.nacinRada = nacinRada;
            this.c = c;
            this.bibl = bibl;
            InitializeComponent();

            if (nacinRada == NacinRada.Izmjena)
            {
                clanKontrola1.Popuni(c);
                clanKontrola1.ZakljucajTipClana();
            }
            else
                clanKontrola1.OsobaKontrola1.Bibl = bibl;
            if (zastita == Zastita.Uposlenik)
            {
                clanKontrola1.Zakljucaj();
                clanKontrola1.OtkljucajKomentar();
            }
        }

        public void Spasi()
        {
            String Ime = clanKontrola1.OsobaKontrola1.Ime, 
                Prezime = clanKontrola1.OsobaKontrola1.Prezime,
                JMBG = clanKontrola1.OsobaKontrola1.JMBG,
                KorisnickoIme = clanKontrola1.OsobaKontrola1.KorisnickoIme,
                Lozinka = clanKontrola1.OsobaKontrola1.Lozinka,
                Komentar = clanKontrola1.Komentar;
            Datum DatumRodjenja = clanKontrola1.OsobaKontrola1.DatumRodjenja;
            Osoba.Spol Spol = clanKontrola1.OsobaKontrola1.Spol;
            Image Slika = clanKontrola1.OsobaKontrola1.Slika;
            Clan.TipClana Tip = clanKontrola1.Tip;

            if (nacinRada == NacinRada.Registracija)
                bibl.RegistrujClana(
                    Ime, 
                    Prezime, 
                    JMBG, 
                    DatumRodjenja,
                    Spol, 
                    Slika, 
                    KorisnickoIme, 
                    Lozinka,
                    Komentar, 
                    Tip
                    );
            else if(nacinRada == NacinRada.Izmjena)
            {
                c.ValidirajSve(JMBG, Spol, DatumRodjenja, KorisnickoIme);
                c.Ime = Ime;
                c.Prezime = Prezime;
                c.MaticniBroj = JMBG;
                c.KorisnickoIme = KorisnickoIme;
                if(clanKontrola1.OsobaKontrola1.LozinkaIzmijenjena)
                    c.Lozinka = Lozinka;
                c.DatumRodjenja = DatumRodjenja;
                c.SpolOsobe = Spol;
                c.Slika = Slika;
                c.Komentar = Komentar;
            }

        }

        private void buttonSpasi_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            try
            {
                Spasi();
                clanKontrola1.OsobaKontrola1.LozinkaIzmijenjena = false;
                if (nacinRada == NacinRada.Registracija)
                    clanKontrola1.Resetuj();
                MessageBox.Show(this, "Spašeno", "Info", MessageBoxButtons.OK);
            }
            catch (Exception exc)
            {
                toolStripStatusLabel1.Text = exc.Message;
            }
        }
    }
}

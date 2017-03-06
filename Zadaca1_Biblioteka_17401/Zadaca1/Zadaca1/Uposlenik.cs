using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatumBiblioteka;
using System.Drawing;

namespace NSBiblioteka 
{
    [Serializable]
    public class Uposlenik : Osoba, IPretrazivObjekat 
    {
        public enum Tip { Uposlenik, Cistac, Domar };
       // private int sifra;

        private Tip tipUposlenika;

        public Uposlenik() { }

        public Uposlenik(string Ime, string Prezime, string MaticniBroj, Datum DatumRodjenja, 
            Spol SpolClana, Image Slika,  string korisnickoIme, string lozinka, Biblioteka Bibl, Tip tipUposlenika) 
            : base(Ime, Prezime, MaticniBroj, DatumRodjenja, SpolClana, Slika, korisnickoIme, lozinka, Bibl)
        {
            this.tipUposlenika = tipUposlenika;
        }

        public Tip TipUposlenika { get { return tipUposlenika; } set { tipUposlenika = value; } }
        /*
        public int Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }
        */
        public override String ToString()
        {
            String ret = sifra + " " + base.ToString();
            if (tipUposlenika == Tip.Domar)
                ret += " Domar";
            else if (tipUposlenika == Tip.Cistac)
                ret += " Čistač";
            return ret;
        }
    }
}

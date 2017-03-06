using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Enumeracija;

namespace UWP.Model {
    public class Uposlenik : Osoba {
        private TipUposlenika tip;
        
        public Uposlenik() { }

        public Uposlenik(string Ime, string Prezime, string MaticniBroj, DateTime DatumRodjenja,
            Spol SpolClana, Windows.UI.Xaml.Media.ImageSource Slika, TipUposlenika tip)
            : base(Ime, Prezime, MaticniBroj, DatumRodjenja, SpolClana, Slika)
        {
            this.Tip = tip;
        }

        public TipUposlenika Tip { get { return tip; } set { if ((int)value == -1) throw new Exception("Tip uposlenika neispravan"); else tip = value; } }

    }
}

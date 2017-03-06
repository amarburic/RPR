using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Enumeracija;
using Windows.UI.Xaml.Media;

namespace UWP.Model {

    public abstract class Osoba {

        protected int sifra;

        protected String ime;
        protected String prezime;
        protected String maticniBroj;
        protected DateTime datumRodjenja;
        protected ImageSource slika;
        protected Spol spolOsobe;

        public Osoba() { }

        public Osoba(String Ime, String Prezime, String MaticniBroj, DateTime DatumRodjenja, Spol SpolClana, ImageSource Slika)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.MaticniBroj = MaticniBroj;
            this.DatumRodjenja = DatumRodjenja;
            this.SpolOsobe = SpolClana;
            this.Slika = Slika;
            Validacija.ValidirajJMBG(MaticniBroj, SpolClana, DatumRodjenja);
        }

        public String Ime { get { return ime; } set { if (value == "") throw new Exception("Ime ne može biti prazno"); else ime = value; } }
        public String Prezime { get { return prezime; } set { if (value == "") throw new Exception("Prezime ne može biti prazno"); else prezime = value; } }
        public String MaticniBroj { get { return maticniBroj; } set { if (value == "") throw new Exception("Jmbg ne može biti prazan"); else maticniBroj = value; } }
        public DateTime DatumRodjenja { get { return datumRodjenja; } set { if (value == null) throw new Exception("Datum ne može biti null"); else datumRodjenja = value; } }
        public ImageSource Slika { get { return slika; } set { if (value == null) throw new Exception("Slika nije učitana"); else slika = value; } }
        public Spol SpolOsobe { get { return spolOsobe; } set { if ((int)value == -1) throw new Exception("Spol neispravan"); else spolOsobe = value; } }
        public int Sifra { get { return sifra; } set { sifra = value; } }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatumBiblioteka;
using System.Drawing;

namespace NSBiblioteka {
    [Serializable]
    public class MasterStudent : Student {

        public MasterStudent() { }

        public MasterStudent(Student s) : base(s)
        {

        }

        public MasterStudent(MasterStudent ms) : base(ms)
        {

        }

        public MasterStudent(String Ime, String Prezime,
            String MaticniBroj, Datum DatumRodjenja, Osoba.Spol SpolClana,
            Image Slika, String KorisnickoIme, String Lozinka,
            Biblioteka Bibl, String Komentar)
            : base(Ime, Prezime, MaticniBroj,
                    DatumRodjenja, SpolClana, Slika, KorisnickoIme, Lozinka, Bibl, Komentar)
        {
        }

        public override double Popust
        {
            get
            {
                return 0.125;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " - Master"; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatumBiblioteka;
using System.Drawing;
using System.Xml.Serialization;

namespace NSBiblioteka {
    [Serializable]
    public class Student : ClanSaEtfa {

        public Student() { }

        public Student(ClanSaEtfa c) : base(c)
        {

        }

        public Student(Student s) : base(s)
        {

        }

        public Student(String Ime, String Prezime,
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
                return 0.1;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Student";
        }
    }
}

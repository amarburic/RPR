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
    public class ClanSaEtfa : Clan {

        public ClanSaEtfa() { }

        public ClanSaEtfa(Clan c) : base(c)
        {

        }

        public ClanSaEtfa(ClanSaEtfa c) : base(c)
        {

        }

        public ClanSaEtfa(String Ime, String Prezime,
            String MaticniBroj, Datum DatumRodjenja, Osoba.Spol SpolClana,
            Image Slika, String KorisnickoIme, String Lozinka,
            Biblioteka Bibl, String Komentar)
            : base(Ime, Prezime, MaticniBroj,
                    DatumRodjenja, SpolClana, Slika, KorisnickoIme, Lozinka, Bibl, Komentar)
        {
        }

        public virtual double Popust { get; } 
        public override double Clanarina
        {
            get
            {
                return base.Clanarina * (1 - Popust);
            }
        }
        
    }
}

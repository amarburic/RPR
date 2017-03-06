using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatumBiblioteka;

namespace NSBiblioteka {
    [Serializable]
    public class Transakcija {
        public enum Tip { Zaduzenje, Razduzenje }

        private int knjiga;
        private int clan;
        private Tip tipTransakcije;
        private Datum datumZaduzenja, rok;

        public Transakcija() { }

        public Transakcija(int knjiga, int clan, Tip tipTransakcije, Datum rok, Datum datumZaduzenja)
        {
            this.knjiga = knjiga;
            this.clan = clan;
            this.tipTransakcije = tipTransakcije;
            this.rok = rok;
            this.datumZaduzenja = datumZaduzenja;
        }

        public Transakcija(Knjiga knjiga, Clan clan, Tip tipTransakcije, Datum rok, Datum datumZaduzenja)
        {
            this.knjiga = knjiga.Sifra;
            this.clan = clan.Sifra;
            this.tipTransakcije = tipTransakcije;
            this.rok = rok;
            this.datumZaduzenja = datumZaduzenja;
        }

        public Transakcija(Knjiga knjiga, Clan clan, Tip tipTransakcije, Datum rok) 
            : this(knjiga, clan, tipTransakcije, rok, Datum.Trenutni())
        {
        }

        public Transakcija(Knjiga knjiga, Clan clan, Tip tipTransakcije) 
            : this(knjiga, clan, tipTransakcije, Datum.Trenutni().Pomakni(Biblioteka.MAX_TRAJANJE_ZADUZENJA), Datum.Trenutni())
        {   
        }

        public int Knjiga { get { return knjiga; } set { knjiga = value; } }
        public int Clan { get { return clan; } set { clan = value; } }
        public Tip TipTransakcije { get { return tipTransakcije; } set { tipTransakcije = value; } }
        public Datum DatumZaduzenja { get { return datumZaduzenja; } set { datumZaduzenja = value; } }
        public Datum Rok
        {
            get { return rok; }
            set { rok = value;  }
        }

    }
}

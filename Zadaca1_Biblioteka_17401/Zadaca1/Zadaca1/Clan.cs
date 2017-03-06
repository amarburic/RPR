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
    [XmlInclude(typeof(ClanSaEtfa))]
    public class Clan : Osoba, IPretrazivObjekat {

        public enum TipPlacanja { Mjesecno, Godisnje }
        public enum TipClana { Obicni, Student, MasterStudent, Profesor }

        protected String komentar;
        protected Dob dobClana;
        protected TipPlacanja tipPlacanjaClanarine; 
        protected Boolean suspendovan;

        private List<int> zaduzeneKnjige;
        private List<ElementListeZelja> listaZelja;
        private List<Transakcija> transakcije;

        public Clan()
        {
           // transakcije = new List<Transakcija>();
        }
        
        public Clan(Osoba o, String komentar) : base(o)
        {
            this.komentar = komentar; 
        }

        public Clan(Clan c) : base(c)
        {
            komentar = c.komentar;
            dobClana = c.dobClana;
            tipPlacanjaClanarine = c.tipPlacanjaClanarine;
            suspendovan = c.suspendovan;
            zaduzeneKnjige = c.ZaduzeneKnjige;
            listaZelja = c.listaZelja;
            transakcije = c.transakcije;
        }

        public Clan(String Ime, String Prezime, 
            String MaticniBroj, Datum DatumRodjenja, Spol SpolClana,
            Image Slika,  
            String KorisnickoIme, String Lozinka, 
            Biblioteka Bibl, String Komentar) : base(Ime, Prezime,
            MaticniBroj, DatumRodjenja, SpolClana, Slika,
            KorisnickoIme, Lozinka,
            Bibl)
        {
            int zaokruzeneGodine = Datum.Trenutni().Godina - DatumRodjenja.Godina;
            if (zaokruzeneGodine< 13)
                this.dobClana = Dob.Dijete;
            else if(zaokruzeneGodine < 20)
                this.dobClana = Dob.Tinejdzer;
            else if (zaokruzeneGodine < 65)
                this.dobClana = Dob.Odrasli;
            else 
                this.dobClana = Dob.Stariji;
            this.komentar = Komentar;
            this.suspendovan = false;

            this.zaduzeneKnjige = new List<int>();
            this.listaZelja = new List<ElementListeZelja>();
            this.transakcije = new List<Transakcija>();

        }

        public void ZaduziKnjigu(int sifra)
        {
            Knjiga k = bibl.TraziKnjiguPoSifri(sifra);
            if (Suspendovan)
                throw new Exception("Clan je suspendovan");
            k.Zaduzi(this);
            transakcije.Add(new Transakcija(k, this, Transakcija.Tip.Zaduzenje));
            ZaduzeneKnjige.Add(sifra);
        }

        public void RazduziKnjigu(int sifra)
        {
            Knjiga k = bibl.TraziKnjiguPoSifri(sifra);
            for (int i = 0; i < ZaduzeneKnjige.Count; i++)
                if (ZaduzeneKnjige[i] == sifra)
                {
                    ZaduzeneKnjige.RemoveAt(i);
                    transakcije.Add(new Transakcija(k, this, Transakcija.Tip.Razduzenje));
                    Procitana(k); 
                    return;
                }

            throw new Exception("Data knjiga se ne nalazi kod korisnika");
        }

        public void DodajNaListuZelja(Knjiga kref)
        {
            int k = kref.Sifra;
            if(listaZelja.FindIndex(p => (p.SifraKnjige == k)) != -1)
            {
                throw new Exception("Knjiga se vec nalazi na listi zelja");
            }
            listaZelja.Add(new ElementListeZelja(k, false));
        }

        public void SkiniSaListeZelja(Knjiga kref)
        {
            int k = kref.Sifra;
            int i = listaZelja.FindIndex(p => (p.SifraKnjige == k));
            if (i == -1)
            {
                throw new Exception("Knjiga se ne nalazi na listi zelja");
            }
            ListaZelja.RemoveAt(i);
        }


        public void Procitana(Knjiga kref)
        {
            int k = kref.Sifra;
            int i = listaZelja.FindIndex(p => (p.SifraKnjige == k));
            if (i != -1)
                listaZelja[i].Procitana = true;
        }

        public void Zaboravljena(Knjiga kref)
        {
            int k = kref.Sifra;
            int i = listaZelja.FindIndex(p => (p.SifraKnjige == k));
            if (i != -1)
                listaZelja[i].Procitana = false;
        }

        public override string ToString()
        {
            return Sifra + " " + base.ToString();
        }

        public virtual double Clanarina
        {
            get
            {
                return bibl.CLANARINA_OSNOVICA; 
            }
        }

      //  public int Sifra { get { return sifra; } set { sifra = value; } } 
        public String Komentar { get { return komentar; } set { komentar = value; } }
        public Dob DobClana { get { return dobClana; } set { dobClana = value; } }
        public TipPlacanja TipPlacanjaClanarine { get { return tipPlacanjaClanarine; } set { tipPlacanjaClanarine = value; } }
        public TipClana TipClanaBiblioteke
        {
            get
            {
                if (this is MasterStudent)
                    return TipClana.MasterStudent;
                else if (this is Student)
                    return TipClana.Student;
                else if (this is Profesor)
                    return TipClana.Profesor;
                return TipClana.Obicni;
            }
        }
        public Boolean Suspendovan { get { return suspendovan; } set { suspendovan = value; } }
        public List<int> ZaduzeneKnjige { get { return zaduzeneKnjige; } set { zaduzeneKnjige = value;  } }
        [XmlIgnore]
        public List<Knjiga> ZaduzeneKnjigeRef
        {
            get
            {
                List<Knjiga> k = new List<Knjiga>();
                foreach (int sifra in zaduzeneKnjige)
                    k.Add(bibl.TraziKnjiguPoSifri(sifra));
                return k;
            }
        }
        [XmlIgnore]
        public List<Pair<Knjiga, bool>> ListaZelja
        {
            get
            {
                List<Pair<Knjiga, bool>> l = new List<Pair<Knjiga, bool>>();
                listaZelja.ForEach(x => l.Add(new Pair<Knjiga, bool>(bibl.TraziKnjiguPoSifri(x.SifraKnjige), x.Procitana)));
                return l;
            }
            set
            {
                List<Pair<Knjiga, bool>> l = value;
                listaZelja.Clear();
                l.ForEach(x => listaZelja.Add(new ElementListeZelja(x.First.Sifra, x.Second)));
            }
        }
        public List<ElementListeZelja> OriginalListaZelja
        {
            get { return listaZelja; }
            set { listaZelja = value; }
        }
        public List<Transakcija> Transakcije { get { return transakcije; } set { transakcije = value; } }
    }
}

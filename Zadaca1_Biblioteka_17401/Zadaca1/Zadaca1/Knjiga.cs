using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NSBiblioteka {
    [Serializable]
    public class Knjiga : IPretrazivObjekat {

        protected int sifra;
        protected String naslov;
        protected List<String> autori;
        protected ISBN isbn;
        protected String izdavac;
        protected int godinaIzdanja;

        protected bool zaduzena;
        protected int zaduzenik;

        protected List<Transakcija> transakcije;

        [NonSerialized]
        protected Biblioteka bibl;

        public Knjiga() { }

        public Knjiga(Knjiga k)
        {
            sifra = k.sifra;
            naslov = k.naslov;
            autori = k.autori;
            isbn = k.isbn;
            izdavac = k.izdavac;
            godinaIzdanja = k.godinaIzdanja;
            zaduzena = k.zaduzena;
            zaduzenik = k.zaduzenik;
            transakcije = k.transakcije;
            bibl = k.bibl;
        }

        public Knjiga(String naslov, List<String> autori, String isbn, String izdavac, int godinaIzdanja, Biblioteka bibl)
        {
            this.naslov = naslov;
            this.autori = autori;
            this.isbn = new ISBN(isbn);
            this.izdavac = izdavac;
            this.bibl = bibl;
            if (!ValidirajGodinu(godinaIzdanja))
                throw new Exception("Tip ISBN koda ne odgovara godini izdanja");
            this.godinaIzdanja = godinaIzdanja;
            this.isbn.ValidirajISBNTip(godinaIzdanja);
            this.zaduzena = false;
            this.zaduzenik = -1;
            this.transakcije = new List<Transakcija>();
        }

        public void Zaduzi(Clan zaduzenik)
        {
            if (zaduzena)
                throw new Exception("Knjiga je vec zaduzena");
            this.zaduzenik = zaduzenik.Sifra;
            transakcije.Add(new Transakcija(this, zaduzenik, Transakcija.Tip.Zaduzenje));
            zaduzena = true;
        }

        public void Razduzi()
        {
            Clan zaduzenik = bibl.TraziClanaPoSifri(this.zaduzenik);
            if (!zaduzena)
                throw new Exception("Knjiga nije zaduzena");
            zaduzenik.RazduziKnjigu(sifra);
            this.zaduzenik = -1;
            transakcije.Add(new Transakcija(this, zaduzenik, Transakcija.Tip.Razduzenje));
            zaduzena = false;
        }

        public bool DjelomicnoPoklapanje(String unos)
        {
            return (Naslov.Length >= unos.Length && Naslov.Substring(0, unos.Length).Equals(unos, 
                StringComparison.InvariantCultureIgnoreCase)
                || Autori.Exists(a => a.Split(' ').ToList().Exists(b => b.Length >= unos.Length 
                && b.Substring(0, unos.Length).Equals(unos, StringComparison.InvariantCultureIgnoreCase)))
                || Izdavac.Length >= unos.Length && Izdavac.Substring(0, unos.Length).Equals(unos, 
                StringComparison.InvariantCultureIgnoreCase));
        } 

        public string AutoriKaoString()
        {
            String s = "";
            if (autori.Count == 0)
                s += "Nepoznat";
            else
                for (int i = 0; i < autori.Count; i++)
                    s += autori[i] + ((i != autori.Count - 1) ? ", " : "");
            return s;
        }

        public override string ToString()
        {
            String s = String.Format("#{0} {1} - ", sifra, naslov);
            if (autori.Count == 0)
                s += "Nepoznat";
            else
                for (int i = 0; i < autori.Count; i++)
                    s += autori[i] + ((i != autori.Count - 1) ? ", " : "");
            s += String.Format(" {0} {1}. ",  izdavac, godinaIzdanja);
            return s;                 
        }

        public String SkraceniInfo()
        {
            String s = String.Format("{0} - ", naslov);
            if (autori.Count == 0)
                s += "Nepoznat autor";
            else
                for (int i = 0; i < autori.Count; i++)
                    s += autori[i] + ((i != autori.Count - 1) ? ", " : "");
            return s;

        }

        private bool ValidirajGodinu(int godinaIzdanja)
        {
            return godinaIzdanja > 0;
        }

        public void ValidirajSve(String ISBN, int GodinaIzdanja)
        {
            (new ISBN(ISBN)).ValidirajISBNTip(GodinaIzdanja);
        }

        public static void StaticnaValidirajISBN(String ISBN, int GodinaIzdanja)
        {
            (new ISBN(ISBN)).ValidirajISBNTip(GodinaIzdanja);
        }

        public int Sifra { get { return sifra; } set { sifra = value; } }
        public String Naslov { get { return naslov; } set { naslov = value; } }
        public List<String> Autori { get { return autori; } set { autori = value; } }
        public ISBN ISBN { get { return isbn; }  set { isbn = value; } }
        public String Izdavac { get { return izdavac; }  set { izdavac = value; } }
    
        public int GodinaIzdanja { get { return godinaIzdanja; }  set { godinaIzdanja = value; } }
        public bool Zaduzena { get { return zaduzena; }  set { zaduzena = value; } }
        public int Zaduzenik { get { return zaduzenik; } set { zaduzenik = value; } }
        public List<Transakcija> Transakcije { get { return transakcije; } set { transakcije = value; } }
        [XmlIgnore]
        public Biblioteka Bibl { get { return bibl; } set { bibl = value; } }


    }
}

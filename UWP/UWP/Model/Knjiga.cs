using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Model {
    public class Knjiga {

        protected int sifra;
        protected String naslov;
        protected List<String> autori;
        protected String isbn;
        protected String izdavac;
        protected int godinaIzdanja;

        public Knjiga() { }

        public Knjiga(String naslov, List<String> autori, String isbn, String izdavac, int godinaIzdanja)
        {
            Naslov = naslov;
            Autori = autori;
            Isbn = isbn;
            Izdavac = izdavac;
        }

        public String Naslov { get { return naslov; } set { if (value == "") throw new Exception("Naslov ne može biti prazan"); else naslov = value; } }
        public List<String> Autori { get { return autori; } set { if (value == null || value.Count == 0) throw new Exception("Autor ne može biti prazan"); else autori = value; } }
        public String Isbn { get { return isbn; } set { Validacija.ValidirajISBN(value);  isbn = value; } }
        public String Izdavac { get { return izdavac; } set { if (value == "") throw new Exception("Izdavač ne može biti prazan"); else izdavac = value; } }
        public int GodinaIzdanja { get { return godinaIzdanja; } set { godinaIzdanja = value; } }
    }
}

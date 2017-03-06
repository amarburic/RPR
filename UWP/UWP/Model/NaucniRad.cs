using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Model {
    public class NaucniRad : Knjiga {

        private string oblast;
        private string konferencija;

        public NaucniRad() { }

        public NaucniRad(String naslov, List<String> autori, String ISBN,
            String izdavac, int godinaIzdanja, String oblast, String konferencija) :
            base(naslov, autori, ISBN, izdavac, godinaIzdanja)
        {
            Oblast = oblast;
            Konferencija = konferencija;
        }

        public string Oblast { get { return oblast; } set { oblast = value; } }
        public string Konferencija { get { return konferencija; } set { konferencija = value; } }
    }
}

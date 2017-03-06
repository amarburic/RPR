using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSBiblioteka {
    [Serializable]
    public class NaucniRad : Knjiga, INaucniRad {
        private string oblast;
        private string konferencija;

        public NaucniRad() { } 

        public NaucniRad(Knjiga k, String oblast, String konferencija) : base(k)
        {
            this.oblast = oblast;
            this.konferencija = konferencija;
        }

        public NaucniRad(NaucniRad nr) : base(nr)
        {
            oblast = nr.oblast;
            konferencija = nr.konferencija;
        }

        public NaucniRad(String naslov, List<String> autori, String ISBN, 
            String izdavac, int godinaIzdanja,  Biblioteka bibl, String oblast, String konferencija) : 
            base(naslov, autori, ISBN, izdavac, godinaIzdanja, bibl)
        {
            Oblast = oblast;
            Konferencija = konferencija;      
        }

        public String generalneInformacije()
        {
            String s = String.Format(" {0} ", naslov);
            if (autori.Count == 0)
                s += "Nepoznat";
            else
                for (int i = 0; i < autori.Count; i++)
                    s += autori[i] + ((i != autori.Count - 1) ? ", " : "");
            s += String.Format(" {0} {1}. {2} {3}", 
                izdavac, godinaIzdanja, oblast, konferencija);
            return s;
        }

        public List<string> autoriRada()
        {
            return autori;
        }

        public string oblastRada()
        {
            return oblast;
        }

        public string oblikReferenciranja()
        {
            String ret = "";
            ret += naslov;
            int velicina = autori.Count;
            for (int i = 0; i < velicina; i++)
                ret += ", " + autori[i];
            ret += ", " + izdavac;
            ret += ", " + godinaIzdanja;
            return ret;                
        }

        public override String ToString()
        {
            return base.ToString() + String.Format("{0} {1}", oblast, konferencija);
        }

        public string Oblast { get { return oblast; } set { oblast = value; } }
        public string Konferencija { get { return konferencija; } set { konferencija = value; } }


    }
}

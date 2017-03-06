using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSBiblioteka {
    [Serializable]
    public class Strip : Knjiga {
        private String animatorskaKuca;
        private List<String> umjetnici;
        private int brojIzdanja;
        private Boolean specijalnoIzdanje;

        public Strip() { }

        public Strip(Knjiga k, String animatorskaKuca, List<String> umjetnici, int brojIzdanja, 
            Boolean specijalnoIzdanje = false) : base(k)
        {
            this.animatorskaKuca = animatorskaKuca;
            this.umjetnici = umjetnici;
            this.brojIzdanja = brojIzdanja;
            this.specijalnoIzdanje = specijalnoIzdanje; 
        }

        public Strip(Strip s) : base(s)
        {
            animatorskaKuca = s.animatorskaKuca;
            umjetnici = s.umjetnici;
            brojIzdanja = s.brojIzdanja;
            specijalnoIzdanje = s.specijalnoIzdanje;
        }

        public Strip(String naslov, List<String> autori, String ISBN, String izdavac, int godinaIzdanja, Biblioteka bibl, 
            String animatorskaKuca, List<String> umjetnici, int brojIzdanja, Boolean specijalnoIzdanje = false) 
            : base(naslov, autori, ISBN, izdavac,  godinaIzdanja, bibl)
        {
            AnimatorskaKuca = animatorskaKuca;
            Umjetnici = umjetnici;
            BrojIzdanja = brojIzdanja;
            SpecijalnoIzdanje = specijalnoIzdanje;
        }

        public string UmjetniciKaoString()
        {
            String s = "";
            if (umjetnici.Count == 0)
                s += "Nepoznat";
            else
                for (int i = 0; i < umjetnici.Count; i++)
                    s += umjetnici[i] + ((i != umjetnici.Count - 1) ? ", " : "");
            return s;
        }

        public override string ToString()
        {
            String s = base.ToString() + String.Format(" {0} ", animatorskaKuca);
            if (umjetnici.Count == 0)
                s += "Nepoznat";
            else
                for (int i = 0; i < umjetnici.Count; i++)
                    s += umjetnici[i] + ((i != umjetnici.Count - 1) ? ", " : "");
            s += String.Format(" No. {0}{1}", brojIzdanja, (specijalnoIzdanje ? " - Specijalno izdanje":""));
            return s;
        }

        public String AnimatorskaKuca { get { return animatorskaKuca; } set { animatorskaKuca = value; } }
        public List<String> Umjetnici { get { return umjetnici; } set { umjetnici = value; } }
        public int BrojIzdanja { get { return brojIzdanja; } set { brojIzdanja = value; } }
        public Boolean SpecijalnoIzdanje { get { return specijalnoIzdanje; } set { specijalnoIzdanje = value; } }
    }
}

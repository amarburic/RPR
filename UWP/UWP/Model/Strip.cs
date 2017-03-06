using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Model {
    public class Strip : Knjiga {
        private String animatorskaKuca;
        private List<String> umjetnici;
        private int brojIzdanja;
        private Boolean specijalnoIzdanje;

        public Strip(String naslov, List<String> autori, String ISBN, String izdavac, int godinaIzdanja,
           String animatorskaKuca, List<String> umjetnici, int brojIzdanja, Boolean specijalnoIzdanje = false)
           : base(naslov, autori, ISBN, izdavac, godinaIzdanja)
        {
            AnimatorskaKuca = animatorskaKuca;
            Umjetnici = umjetnici;
            BrojIzdanja = brojIzdanja;
            SpecijalnoIzdanje = specijalnoIzdanje;
        }

        public String AnimatorskaKuca { get { return animatorskaKuca; } set { animatorskaKuca = value; } }
        public List<String> Umjetnici { get { return umjetnici; } set { umjetnici = value; } }
        public int BrojIzdanja { get { return brojIzdanja; } set { brojIzdanja = value; } }
        public Boolean SpecijalnoIzdanje { get { return specijalnoIzdanje; } set { specijalnoIzdanje = value; } }

    }
}

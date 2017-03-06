using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Model;

namespace UWP.Kontroler {
    public class Biblioteka {

        private List<Knjiga> knjige;
        private List<Uposlenik> uposlenici;
        
        public Biblioteka()
        {
            knjige = new List<Knjiga>();
            uposlenici = new List<Uposlenik>();
        }

        public void RegistrujKnjigu(Knjiga k)
        {
            knjige.Add(k);
        }

        public void RegistrujUposlenika(Uposlenik u)
        {
            uposlenici.Add(u);
        }
    }
}

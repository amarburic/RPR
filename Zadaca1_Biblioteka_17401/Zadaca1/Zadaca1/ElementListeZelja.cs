using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSBiblioteka {
    [Serializable]
    public class ElementListeZelja {
        public int SifraKnjige;
        public Boolean Procitana;

        public ElementListeZelja() { }

        public ElementListeZelja(int SifraKnjige, Boolean Procitana)
        {
            this.SifraKnjige = SifraKnjige;
            this.Procitana = Procitana;
        }
    }
}

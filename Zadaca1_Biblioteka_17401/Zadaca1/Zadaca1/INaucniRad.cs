using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSBiblioteka {
    public interface INaucniRad {
        String generalneInformacije();
        List<String> autoriRada();
        String oblastRada();
        String oblikReferenciranja();
    }
}

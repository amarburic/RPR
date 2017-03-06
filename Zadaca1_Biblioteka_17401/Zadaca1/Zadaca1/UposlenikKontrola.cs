using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBiblioteka {
    public partial class UposlenikKontrola : UserControl {
        public UposlenikKontrola()
        {
            InitializeComponent();
            comboBoxTip.SelectedIndex = 0;
        }

        public void Popuni(Uposlenik u)
        {
            osobaKontrola1.Popuni(u);
            comboBoxTip.SelectedIndex = (int)u.TipUposlenika;
        }

        public void Zakljucaj()
        {
            osobaKontrola1.Zakljucaj();
            comboBoxTip.Enabled = false;
        }

        public void Resetuj()
        {
            osobaKontrola1.Resetuj();
            comboBoxTip.SelectedIndex = 0;
        }

        public Uposlenik.Tip Tip { get { return (Uposlenik.Tip)comboBoxTip.SelectedIndex; } }
        public OsobaKontrola OsobaKontrola1 { get { return osobaKontrola1; } }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBiblioteka {
    public partial class OstaliUposleniciForma : Form {

        Uposlenik u;

        public OstaliUposleniciForma(Uposlenik u)
        {
            this.u = u;
            InitializeComponent();
            uposlenikKontrola1.Popuni(u);
            uposlenikKontrola1.Zakljucaj();
        }

        private void OstaliUposleniciForma_Load(object sender, EventArgs e)
        {

        }

        private void OstaliUposleniciForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Visible = true;
        }
    }
}

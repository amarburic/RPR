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
    public partial class EvidencijaClanaForma : Form {

        Clan c;
        Biblioteka bibl;

        public EvidencijaClanaForma(Biblioteka bibl, Clan c)
        {
            this.c = c;
            this.bibl = bibl;
            InitializeComponent();
            clanKontrola1.Popuni(c);
            clanKontrola1.Zakljucaj();
            clanKontrola1.OtkljucajKomentar();
            PopuniZaduzenja();
        }

        public void Spasi()
        {
            c.Komentar = clanKontrola1.Komentar;
        }

        public void PopuniZaduzenja()
        {
            listBoxListaZaduzenja.Items.Clear();
            foreach (Knjiga k in c.ZaduzeneKnjigeRef)
                listBoxListaZaduzenja.Items.Add(k);
        }

        private void buttonSpasi_Click(object sender, EventArgs e)
        {
            Spasi();
        }

        private void dodajToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            using (var form = new Pretraga(c.Bibl, Pretraga.NacinRada.Odabir, typeof(Knjiga), true))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    bibl.IznajmiKnjigu(c.Sifra, (form.PovratniRezultat as Knjiga).Sifra);
                }
            }
            PopuniZaduzenja();
        }

        private void razdužiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bibl.VratiKnjigu(c.ZaduzeneKnjigeRef[listBoxListaZaduzenja.SelectedIndex].Sifra);
            PopuniZaduzenja();
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            razdužiToolStripMenuItem.Visible = false;
            if (listBoxListaZaduzenja.SelectedIndex == -1)
                dodajToolStripMenuItem.Visible = true;
            else
                razdužiToolStripMenuItem.Visible = true;
        }

        private void buttonSpasi_Click_1(object sender, EventArgs e)
        {
            Spasi();
            MessageBox.Show(this, "Spašeno", "Info", MessageBoxButtons.OK);
        }
    }
}

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

    public partial class EvidencijaKnjigeForma : Form {

        Knjiga k;
        Biblioteka bibl;

        public EvidencijaKnjigeForma(Biblioteka bibl, Knjiga k)
        {
            this.k = k;
            this.bibl = bibl;
            InitializeComponent();
            knjigaKontrola1.Popuni(k);
            knjigaKontrola1.Zakljucaj();
            knjigaKontrola1.OtkljucajDostupnost();
            PopuniZaduzenja();
        }

        public void Spasi()
        {
            //Dostupnost
        }

        public void PopuniZaduzenja()
        {
            listBoxListaZaduzenja.Items.Clear();
            if (k.Zaduzena)
            {
                var rezultat = k.Zaduzenik;

                listBoxListaZaduzenja.Items.Add(bibl.TraziClanaPoSifri(rezultat));
            }
        }

        private void buttonSpasi_Click(object sender, EventArgs e)
        {
            Spasi();
            MessageBox.Show(this, "Spašeno", "Info", MessageBoxButtons.OK);
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        { 

                using (var form = new Pretraga(k.Bibl, Pretraga.NacinRada.Odabir, typeof(Clan)))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        bibl.IznajmiKnjigu((form.PovratniRezultat as Clan).Sifra, k.Sifra);
                    }
                }
            PopuniZaduzenja();
        }

        private void razdužiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bibl.VratiKnjigu(k.Sifra);
            PopuniZaduzenja();
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            razdužiToolStripMenuItem.Visible = false;
            dodajToolStripMenuItem.Visible = false;
            if (listBoxListaZaduzenja.Items.Count == 0)
                dodajToolStripMenuItem.Visible = true;
            else
                razdužiToolStripMenuItem.Visible = true;
        }
    }
}

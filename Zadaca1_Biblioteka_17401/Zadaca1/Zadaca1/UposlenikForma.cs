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
    public partial class UposlenikForma : Form {

        Uposlenik u;

        public UposlenikForma(Uposlenik u)
        {
            this.u = u;
            InitializeComponent();
            uposlenikKontrola1.Popuni(u);
            uposlenikKontrola1.Zakljucaj();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonKnjiga.Checked)
            {
                using (var form = new Pretraga(u.Bibl, Pretraga.NacinRada.Odabir, typeof(Knjiga)))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        (new EvidencijaKnjigeForma(u.Bibl, form.PovratniRezultat as Knjiga)).Show(this);
                    }
                }
            }
            else if (radioButtonClan.Checked)
            {
                using (var form = new Pretraga(u.Bibl, Pretraga.NacinRada.Odabir, typeof(Clan)))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        (new EvidencijaClanaForma(u.Bibl, form.PovratniRezultat as Clan)).Show(this);
                    }
                }
            }
        }

        private void UposlenikForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Visible = true;
        }

        private void buttonPrikaz1_Click(object sender, EventArgs e)
        {
            if (radioButtonStanjeKnjiga.Checked)
                (new StanjeForma(u.Bibl, typeof(Knjiga))).Show(this);
            else if(radioButtonStanjeClanova.Checked)
                (new StanjeForma(u.Bibl, typeof(Clan))).Show(this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Analiza(u.Bibl, NSBiblioteka.Analiza.TipAnalize.SpolnaStruktura).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Analiza(u.Bibl, NSBiblioteka.Analiza.TipAnalize.DobnaStruktura).Show();
        }
    }
}

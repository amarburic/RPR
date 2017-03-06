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
    public partial class ClanForma : Form {

        Clan c;

        public ClanForma(Clan c)
        {
            this.c = c;
            InitializeComponent();
            clanKontrola1.Popuni(c);
            popuniListu(); 
            popuniPosudjene();
            clanKontrola1.Zakljucaj();
        }

        private void ClanForma_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
            listBoxRezultat.Items.Clear();
            if (textBoxPretraga.Text.Equals(""))
                return;
            foreach (Knjiga k in c.Bibl.ParcijalnaPretragaKnjiga(textBoxPretraga.Text))
                listBoxRezultat.Items.Add(k);
            */
        }

        private void buttonDodajNaListu_Click(object sender, EventArgs e)
        {
            /*
            int selected = listBoxRezultat.SelectedIndex;
            var result = c.Bibl.ParcijalnaPretragaKnjiga(textBoxPretraga.Text);
            c.DodajNaListuZelja(result[selected]);
            popuniListu();
            */
        }

        private void popuniListu()
        {
            checkedListBoxLista.Items.Clear();
            var lista = c.ListaZelja;
            for (int i = 0; i < lista.Count; i++) {
                checkedListBoxLista.Items.Add(lista[i].First);
                checkedListBoxLista.SetItemChecked(i, lista[i].Second);
            }
        }

        private void popuniPosudjene()
        {
            listViewPosudjene.Items.Clear();
            foreach(var k in c.ZaduzeneKnjigeRef)
            {
                string[] red = { k.Naslov, k.AutoriKaoString(), "" };
                var listViewItem = new ListViewItem(red);
                listViewPosudjene.Items.Add(listViewItem);
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            int selected = checkedListBoxLista.SelectedIndex;
            c.SkiniSaListeZelja(c.ListaZelja[selected].First);
            popuniListu();
        }

        private void checkedListBoxLista_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int selected = checkedListBoxLista.SelectedIndex;
            if(e.NewValue == CheckState.Checked)
                c.Procitana(c.ListaZelja[selected].First);
            else
                c.Zaboravljena(c.ListaZelja[selected].First);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            using (var form = new Pretraga(c.Bibl, Pretraga.NacinRada.Odabir, typeof(Knjiga)))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    c.DodajNaListuZelja(form.PovratniRezultat as Knjiga);
                    popuniListu();
                }
            }
        }

        private void ClanForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Visible = true;
        }
    }
}

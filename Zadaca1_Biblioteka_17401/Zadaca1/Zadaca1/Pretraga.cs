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
    public partial class Pretraga : Form {

        public enum NacinRada { Odabir, Izmjena }

        Type tip;
        NacinRada nacin;
        Biblioteka bibl;
        Object povratniRezultat;
        Boolean nezaduzeneKnjige;
        
        public Pretraga(Biblioteka bibl, NacinRada nacin, Type tip, Boolean nezaduzeneKnjige = false)
        {
            this.bibl = bibl;
            this.nacin = nacin;
            this.tip = tip;
            this.nezaduzeneKnjige = nezaduzeneKnjige;
            InitializeComponent();
            if(nacin == NacinRada.Odabir)
            {
                buttonBrisi.Visible = false;
                buttonIzmijeni.Visible = false;
            }
            else if(nacin == NacinRada.Izmjena)
            {
                buttonOdaberi.Visible = false;
            }
            Izlistaj();
        }

        private void textBoxUnos_TextChanged(object sender, EventArgs e)
        {

            Izlistaj();
        }

        public void Izlistaj()
        {
            if (tip.IsSubclassOf(typeof(Knjiga)) || tip == typeof(Knjiga))
            {
                var rezultat = bibl.ParcijalnaPretragaKnjiga(textBoxUnos.Text);
                if (nezaduzeneKnjige)
                    rezultat = rezultat.FindAll(k => !k.Zaduzena);
                listBoxRezultat.Items.Clear();
                foreach (Knjiga k in rezultat)
                    listBoxRezultat.Items.Add(k);
            }
            else if (tip.IsSubclassOf(typeof(Clan)) || tip == typeof(Clan))
            {
                var rezultat = bibl.ParcijalnaPretragaClanova(textBoxUnos.Text);
                listBoxRezultat.Items.Clear();
                foreach (Clan k in rezultat)
                    listBoxRezultat.Items.Add(k);
            }
            else if (tip.IsSubclassOf(typeof(Uposlenik)) || tip == typeof(Uposlenik))
            {
                var rezultat = bibl.ParcijalnaPretragaUposlenika(textBoxUnos.Text);
                listBoxRezultat.Items.Clear();
                foreach (Uposlenik k in rezultat)
                    listBoxRezultat.Items.Add(k);
            }
        }

        private void buttonOdaberi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            if (tip.IsSubclassOf(typeof(Knjiga)) || tip == typeof(Knjiga))
            {
                var listaRezultata = bibl.ParcijalnaPretragaKnjiga(textBoxUnos.Text);
                if (nezaduzeneKnjige)
                    listaRezultata = listaRezultata.FindAll(k => !k.Zaduzena);
                povratniRezultat = listaRezultata[listBoxRezultat.SelectedIndex];
            }
            else if (tip.IsSubclassOf(typeof(Clan)) || tip == typeof(Clan))
            {
                var listaRezultata = bibl.ParcijalnaPretragaClanova(textBoxUnos.Text);
                povratniRezultat = listaRezultata[listBoxRezultat.SelectedIndex];
            }
            else if (tip.IsSubclassOf(typeof(Uposlenik)) || tip == typeof(Uposlenik))
            {
                var listaRezultata = bibl.ParcijalnaPretragaUposlenika(textBoxUnos.Text);
                povratniRezultat = listaRezultata[listBoxRezultat.SelectedIndex];
            }
            this.Close();
        }

        public Object PovratniRezultat { get { return povratniRezultat; } }

        private void buttonIzmijeni_Click(object sender, EventArgs e)
        {
            if (tip.IsSubclassOf(typeof(Knjiga)) || tip == typeof(Knjiga))
            {
                var listaRezultata = bibl.ParcijalnaPretragaKnjiga(textBoxUnos.Text);
                Knjiga k = listaRezultata[listBoxRezultat.SelectedIndex];
                (new RegistracijeKnjigeForma(RegistracijeKnjigeForma.Zastita.Admin,
                    RegistracijeKnjigeForma.NacinRada.Izmjena, k.Bibl, k)).Show();
            }
            else if (tip.IsSubclassOf(typeof(Clan)) || tip == typeof(Clan))
            {
                var listaRezultata = bibl.ParcijalnaPretragaClanova(textBoxUnos.Text);
                Clan c = listaRezultata[listBoxRezultat.SelectedIndex];
                (new RegistracijaClanaForma(RegistracijaClanaForma.Zastita.Admin,
                    RegistracijaClanaForma.NacinRada.Izmjena, c.Bibl, c)).Show();
            }
            else if (tip.IsSubclassOf(typeof(Uposlenik)) || tip == typeof(Uposlenik))
            {
                var listaRezultata = bibl.ParcijalnaPretragaUposlenika(textBoxUnos.Text);
                Uposlenik u = listaRezultata[listBoxRezultat.SelectedIndex];
                (new RegistracijaUposlenikaForma(RegistracijaUposlenikaForma.NacinRada.Izmjena, u.Bibl, u)).Show();
            }
        }

        private void buttonBrisi_Click(object sender, EventArgs e)
        {
            if (tip.IsSubclassOf(typeof(Knjiga)) || tip == typeof(Knjiga))
            {
                var listaRezultata = bibl.ParcijalnaPretragaKnjiga(textBoxUnos.Text);
                Knjiga k = listaRezultata[listBoxRezultat.SelectedIndex];
                bibl.ObrisiKnjigu(k.Sifra);
                Izlistaj();

            }
            else if (tip.IsSubclassOf(typeof(Clan)) || tip == typeof(Clan))
            {
                var listaRezultata = bibl.ParcijalnaPretragaClanova(textBoxUnos.Text);
                Clan c = listaRezultata[listBoxRezultat.SelectedIndex];
                bibl.ObrisiClana(c.Sifra);
                Izlistaj();
            }
            else if (tip.IsSubclassOf(typeof(Uposlenik)) || tip == typeof(Uposlenik))
            {
                var listaRezultata = bibl.ParcijalnaPretragaUposlenika(textBoxUnos.Text);
                Uposlenik u = listaRezultata[listBoxRezultat.SelectedIndex];
                bibl.ObrisiUposlenika(u);
                Izlistaj();
            }
        }
    }
}

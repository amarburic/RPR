using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NSBiblioteka.Biblioteka;

namespace NSBiblioteka {
    public partial class AdminForma : Form {

        Biblioteka bibl;

        public AdminForma(Biblioteka bibl)
        {
            this.bibl = bibl;
            InitializeComponent();
        }

        private void buttonIzmjena_Click(object sender, EventArgs e)
        {
            if (radioButtonKnjiga.Checked)
                (new Pretraga(bibl, Pretraga.NacinRada.Izmjena, typeof(Knjiga))).Show(this);
            else if(radioButtonClan.Checked)
                (new Pretraga(bibl, Pretraga.NacinRada.Izmjena, typeof(Clan))).Show(this);
            else if (radioButtonUposlenik.Checked)
                (new Pretraga(bibl, Pretraga.NacinRada.Izmjena, typeof(Uposlenik))).Show(this);
        }

        private void AdminForma_Load(object sender, EventArgs e)
        {

        }

        private void AdminForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Visible = true;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {

           if (radioButtonClan.Checked)
                new RegistracijaClanaForma(
                    RegistracijaClanaForma.Zastita.Admin,
                    RegistracijaClanaForma.NacinRada.Registracija,
                    bibl)
                    .Show(this);
            else if (radioButtonUposlenik.Checked)
                new RegistracijaUposlenikaForma(
                    RegistracijaUposlenikaForma.NacinRada.Registracija,
                    bibl)
                    .Show(this);
            else if (radioButtonKnjiga.Checked)
                new RegistracijeKnjigeForma(RegistracijeKnjigeForma.Zastita.Admin, RegistracijeKnjigeForma.NacinRada.Registracija,
                    bibl).Show(this);

        }

        private String SerijalizacijaDialog(string nazivObjekta, string ext)
        {
            SaveFileDialog sfd = new SaveFileDialog() { FileName = nazivObjekta + ext, AddExtension = true, DefaultExt = ext, };
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.EndsWith(ext))
            {
                return sfd.FileName;
            }
            return null;
        }

        private String DeserijalizacijaDialog(string ext)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, CheckFileExists = true };
            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.EndsWith(ext))
            {
                return ofd.FileName;
            }
            return null;
        }

        private async void Serijaliziraj(Biblioteka.TipSerijalizacija tip, Biblioteka.ObjekatSerijalizacije objekat)
        {
            string[] nazivi = new string[] { "uposlenici", "clanovi", "knjige" };
            string[] nastavci = new string[] { ".xml", ".bin" };
            string path = SerijalizacijaDialog(nazivi[(int)objekat], nastavci[(int)tip]);
            if(path != null)
                await Task.Factory.StartNew(() =>
                {
                    Invoke(new Action(() => statusStrip1.Text = "Serijalizujem..."));
                    if (tip == TipSerijalizacija.Binarno)
                    {
                        if (objekat == ObjekatSerijalizacije.Knjige)
                            bibl.SerijalizirajKnjigeBinarno(path);
                        else if (objekat == ObjekatSerijalizacije.Clanovi)
                            bibl.SerijalizirajClanoveBinarno(path);
                        else if (objekat == ObjekatSerijalizacije.Uposlenici)
                            bibl.SerijalizirajUposlenikeBinarno(path);
                    }
                    else if (tip == TipSerijalizacija.XML)
                    {
                        if (objekat == ObjekatSerijalizacije.Knjige)
                            bibl.SerijalizirajKnjigeXML(path);
                        else if (objekat == ObjekatSerijalizacije.Clanovi)
                            bibl.SerijalizirajClanoveXML(path);
                        else if (objekat == ObjekatSerijalizacije.Uposlenici)
                            bibl.SerijalizirajUposlenikeXML(path);
                    }
                    Invoke(new Action(() => { if (!statusStrip1.IsDisposed) { statusStrip1.Text = "Završena serijalizacija"; } }));

                });
        }

        private async void Deserijaliziraj(Biblioteka.TipSerijalizacija tip, Biblioteka.ObjekatSerijalizacije objekat)
        {
            string[] nastavci = new string[] { ".xml", ".bin" };
            string path = DeserijalizacijaDialog(nastavci[(int)tip]);
            if (path != null)
                await Task.Factory.StartNew(() =>
                {
                    Invoke(new Action(() => statusStrip1.Text = "Deserijalizujem..."));
                    if (tip == TipSerijalizacija.Binarno)
                    {
                        if (objekat == ObjekatSerijalizacije.Knjige)
                            bibl.DeserijalizirajKnjigeBinarno(path);
                        else if (objekat == ObjekatSerijalizacije.Clanovi)
                            bibl.DeserijalizirajClanoveBinarno(path);
                        else if (objekat == ObjekatSerijalizacije.Uposlenici)
                            bibl.DeserijalizirajUposlenikeBinarno(path);
                    }
                    else if (tip == TipSerijalizacija.XML)
                    {
                        if (objekat == ObjekatSerijalizacije.Knjige)
                            bibl.DeserijalizirajKnjigeXML(path);
                        else if (objekat == ObjekatSerijalizacije.Clanovi)
                            bibl.DeserijalizirajClanoveXML(path);
                        else if (objekat == ObjekatSerijalizacije.Uposlenici)
                            bibl.DeserijalizirajUposlenikeXML(path);
                    }
                    if (objekat == ObjekatSerijalizacije.Knjige)
                        Invoke(new Action(() => new DeserijalizacijaForma(bibl.Knjige.Cast<object>().ToList()).Show()));
                    else if (objekat == ObjekatSerijalizacije.Clanovi)
                        Invoke(new Action(() => new DeserijalizacijaForma(bibl.Clanovi.Cast<object>().ToList()).Show()));
                    else if (objekat == ObjekatSerijalizacije.Uposlenici)
                        Invoke(new Action(() => new DeserijalizacijaForma(bibl.Uposlenici.Cast<object>().ToList()).Show()));
                    Invoke(new Action(() => { if (!statusStrip1.IsDisposed) { statusStrip1.Text = "Završena deserijalizacija"; } }));
                });
        }

        private void članovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serijaliziraj(TipSerijalizacija.Binarno, ObjekatSerijalizacije.Knjige);
        }

        private void članoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serijaliziraj(TipSerijalizacija.Binarno, ObjekatSerijalizacije.Clanovi);
        }

        private void uposlenikeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Serijaliziraj(TipSerijalizacija.Binarno, ObjekatSerijalizacije.Uposlenici);
        }

        private void knjigeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Serijaliziraj(TipSerijalizacija.XML, ObjekatSerijalizacije.Knjige);
        }

        private void članoveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Serijaliziraj(TipSerijalizacija.XML, ObjekatSerijalizacije.Clanovi);
        }

        private void uposlenikeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Serijaliziraj(TipSerijalizacija.XML, ObjekatSerijalizacije.Uposlenici);
        }

        private void knjigeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Deserijaliziraj(TipSerijalizacija.Binarno, ObjekatSerijalizacije.Knjige);
        }

        private void članoveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Deserijaliziraj(TipSerijalizacija.Binarno, ObjekatSerijalizacije.Clanovi);
        }

        private void uposlenikeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Deserijaliziraj(TipSerijalizacija.Binarno, ObjekatSerijalizacije.Uposlenici);
        }

        private void knjigeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Deserijaliziraj(TipSerijalizacija.XML, ObjekatSerijalizacije.Knjige);
        }

        private void članoveToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Deserijaliziraj(TipSerijalizacija.XML, ObjekatSerijalizacije.Clanovi);
        }

        private void uposlenikeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Deserijaliziraj(TipSerijalizacija.XML, ObjekatSerijalizacije.Uposlenici);
        }
    }
}

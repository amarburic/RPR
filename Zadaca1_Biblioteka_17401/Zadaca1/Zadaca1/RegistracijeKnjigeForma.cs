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
    public partial class RegistracijeKnjigeForma : Form {

        public enum Zastita { Admin, Uposlenik }
        public enum NacinRada { Registracija, Izmjena }

        Knjiga k;
        Biblioteka bibl;
        Zastita zastita;
        NacinRada nacinRada;

        public RegistracijeKnjigeForma(Zastita zastita, NacinRada nacinRada, Biblioteka bibl, Knjiga k = null)
        {
            this.zastita = zastita;
            this.nacinRada = nacinRada;
            this.k = k;
            this.bibl = bibl;
            InitializeComponent();

            if (nacinRada == NacinRada.Izmjena)
                knjigaKontrola1.Popuni(k);
            if (zastita == Zastita.Uposlenik)
            {
                knjigaKontrola1.Zakljucaj();
                knjigaKontrola1.OtkljucajDostupnost();
            }
        }

        public void Spasi()
        {
            String Naslov = knjigaKontrola1.Naslov, ISBN = knjigaKontrola1.ISBN,
                Izdavac = knjigaKontrola1.Izdavac;
            List<String> Autori = knjigaKontrola1.Autori.Split(',').ToList(),
                Umjetnici = knjigaKontrola1.Umjetnici.Split(',').ToList();
            int Godina = knjigaKontrola1.Godina, Dostupno = knjigaKontrola1.Dostupno,
                NaCitanju = knjigaKontrola1.NaCitanju, Tip = knjigaKontrola1.Tip;
            String AnimKuca = knjigaKontrola1.AnimKuca;
            int BrojIzdanja = knjigaKontrola1.BrojIzdanja;
            Boolean Specijalno = knjigaKontrola1.Specijalno;
            String Konferencija = knjigaKontrola1.Konferencija, Oblast = knjigaKontrola1.Oblast;

            if (nacinRada == NacinRada.Registracija)
            {
                if (Tip == 0)
                {
                    bibl.RegistrujKnjigu(Naslov, Autori, ISBN, Izdavac, Godina);
                }
                else if (Tip == 1)
                {
                    bibl.RegistrujStrip(Naslov, Autori, ISBN, Izdavac, Godina, AnimKuca, Umjetnici, BrojIzdanja, Specijalno);
                }
                else if (Tip == 2)
                {
                    bibl.RegistrujNaucniRad(Naslov, Autori, ISBN, Izdavac, Godina, Oblast, Konferencija);
                }
            }

            else if (nacinRada == NacinRada.Izmjena)
            {
                k.ValidirajSve(ISBN, Godina);
                k.Naslov = Naslov;
                k.Autori = Autori;
                k.ISBN = new ISBN(ISBN);
                k.GodinaIzdanja = Godina;

                if (Tip == 1)
                {
                    Strip s = k as Strip;
                    s.AnimatorskaKuca = AnimKuca;
                    s.Umjetnici = Umjetnici;
                    s.BrojIzdanja = BrojIzdanja;
                    s.SpecijalnoIzdanje = Specijalno;
                }
                else if (Tip == 2)
                {
                    NaucniRad n = k as NaucniRad;
                    n.Oblast = Oblast;
                    n.Konferencija = Konferencija;
                }
            }
        }

        private void buttonSpasi_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            try
            { 
                Spasi();
                if (nacinRada == NacinRada.Registracija)
                    knjigaKontrola1.Resetuj();
                MessageBox.Show(this, "Spašeno", "Info", MessageBoxButtons.OK);
            }
            catch (Exception exc)
            {
                toolStripStatusLabel1.Text = exc.Message;
            }
}
    }
}
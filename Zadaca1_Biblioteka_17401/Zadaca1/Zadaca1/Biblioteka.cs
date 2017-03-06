using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatumBiblioteka;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NSBiblioteka {
    public sealed partial class Biblioteka {
        public readonly double CLANARINA_OSNOVICA = 10;
        public readonly static int MAX_TRAJANJE_ZADUZENJA = 30;
        public int sljedeciOsobaId;
        public int sljedeciKnjigaId;
       // private int sljedeciUposlenikId;

        private List<Clan> clanovi;
        private List<Uposlenik> uposlenici;
        private List<Knjiga> knjige;

        private String adminKorisnickoIme, adminLozinka;

        private double mjesecnaZarada;

        public Biblioteka()
        {
            sljedeciOsobaId = sljedeciKnjigaId = 1;
            clanovi = new List<Clan>();
            uposlenici = new List<Uposlenik>();
            knjige = new List<Knjiga>();
            mjesecnaZarada = 0;

            adminKorisnickoIme = "admin";
            adminLozinka = Hesiranje.GetMd5Hash("admin");

        }

        public void RegistrujClana(String Ime, String Prezime,
            String MaticniBroj, Datum DatumRodjenja, Osoba.Spol SpolClana,
            Image Slika,
            String KorisnickoIme, String Lozinka, String Komentar = "", Clan.TipClana TipClana = Clan.TipClana.Obicni)
        {
            ValidirajKorisnickoIme(KorisnickoIme);
            switch(TipClana)
            {
            case Clan.TipClana.Obicni:
                clanovi.Add(new Clan(Ime, Prezime, MaticniBroj, 
                    DatumRodjenja, SpolClana, Slika, KorisnickoIme, Lozinka, this, Komentar));
                break;
            case Clan.TipClana.Student:
                clanovi.Add(new Student(Ime, Prezime, MaticniBroj,
                    DatumRodjenja, SpolClana, Slika, KorisnickoIme, Lozinka, this, Komentar));
                break;
            case Clan.TipClana.MasterStudent:
                clanovi.Add(new MasterStudent(Ime, Prezime, MaticniBroj,
                    DatumRodjenja, SpolClana, Slika, KorisnickoIme, Lozinka, this, Komentar));
                break;
            case Clan.TipClana.Profesor:
                clanovi.Add(new Profesor(Ime, Prezime, MaticniBroj,
                    DatumRodjenja, SpolClana, Slika, KorisnickoIme, Lozinka, this, Komentar));
                break;
            }
            clanovi[clanovi.Count - 1].Sifra = sljedeciOsobaId++;
            mjesecnaZarada += clanovi[clanovi.Count - 1].Clanarina;
        }
       
        public void ObrisiClana(int sifra)
        {
            if (!(sifra >= sljedeciOsobaId || sifra < 1))
                for (int i = 0; i < clanovi.Count; i++)
                    if (clanovi[i].Sifra == sifra)
                    {
                        for (int j = 0; i < clanovi[i].ZaduzeneKnjige.Count;)
                            TraziKnjiguPoSifri(clanovi[i].ZaduzeneKnjige[j]).Razduzi();
                        clanovi.RemoveAt(i);
                        return;
                    }
            throw new Exception("Clan nije pronadjen");
        }

        public void RegistrujUposlenika(String Ime, String Prezime,
            String MaticniBroj, Datum DatumRodjenja, Osoba.Spol SpolClana,
            Image Slika,
            String KorisnickoIme, String Lozinka, Uposlenik.Tip tip)
        {
            ValidirajKorisnickoIme(KorisnickoIme);
            uposlenici.Add(new Uposlenik(Ime, Prezime, MaticniBroj,
                    DatumRodjenja, SpolClana, Slika, KorisnickoIme, Lozinka, this, tip));
            uposlenici[uposlenici.Count - 1].Sifra = sljedeciOsobaId++;
        }

        public void ObrisiUposlenika(int sifra)
        {
            if (!(sifra >= sljedeciOsobaId || sifra < 1))
                for (int i = 0; i < uposlenici.Count; i++)
                    if (uposlenici[i].Sifra == sifra)
                    {
                        uposlenici.RemoveAt(i);
                        return;
                    }
            throw new Exception("Uposlenik nije pronadjen");
        }

        public void ObrisiUposlenika(Uposlenik u)
        {
            int indeks = uposlenici.FindIndex(a => a == u);
            if (indeks != -1)
                uposlenici.RemoveAt(indeks);
            else
                throw new Exception("Uposlenik nije pronadjen");
        }

        public void RegistrujKnjigu(String naslov, List<String> autori, String isbn, String izdavac, int godinaIzdanja)
        {
            knjige.Add(new Knjiga(naslov, autori, isbn, izdavac, godinaIzdanja, this));
            knjige[knjige.Count - 1].Sifra = sljedeciKnjigaId++;
        }

        public void RegistrujStrip(String naslov, List<String> autori, String isbn, String izdavac, int godinaIzdanja, String animatorskaKuca, List<String> umjetnici, int brojIzdanja, Boolean specijalnoIzdanje = false)
        {
            knjige.Add(new Strip(naslov, autori, isbn, izdavac, godinaIzdanja, this, animatorskaKuca, umjetnici, brojIzdanja, specijalnoIzdanje));
            knjige[knjige.Count - 1].Sifra = sljedeciKnjigaId++;
        }

        public void RegistrujNaucniRad(String naslov, List<String> autori, String isbn, String izdavac, int godinaIzdanja, String oblast, String konferencija)
        {
            knjige.Add(new NaucniRad(naslov, autori, isbn, izdavac, godinaIzdanja, this,  oblast, konferencija));
            knjige[knjige.Count - 1].Sifra = sljedeciKnjigaId++;
        }

        public void ObrisiKnjigu(int sifra)
        {
            if (!(sifra >= sljedeciKnjigaId || sifra < 1))
                for (int i = 0; i < knjige.Count; i++)
                    if (knjige[i].Sifra == sifra)
                    {
                        if (knjige[i].Zaduzena)
                            TraziClanaPoSifri(knjige[i].Zaduzenik).RazduziKnjigu(knjige[i].Sifra);
                        knjige.RemoveAt(i);
                        return;
                    }
            throw new Exception("Knjiga nije pronadjena");
        }

        public void IznajmiKnjigu(int sifraClana, int sifraKnjige)
        {
            TraziClanaPoSifri(sifraClana).ZaduziKnjigu(sifraKnjige);
        }

        public void VratiKnjigu(int sifraKnjige)
        {
            TraziKnjiguPoSifri(sifraKnjige).Razduzi();
        }

        public Knjiga TraziPoISBN(ISBN isbn)
        {
            foreach (Knjiga k in knjige)
                if (k.ISBN == isbn)
                    return k;
            throw new Exception("Knjiga nije pronadjena");
        }

        public Knjiga TraziKnjiguPoSifri(int sifra)
        {
            if (!(sifra >= sljedeciKnjigaId || sifra < 1))
                foreach (Knjiga k in knjige)
                    if (k.Sifra == sifra)
                        return k;
            throw new Exception("Knjiga nije pronadjena");
        }

        public List<Knjiga> ParcijalnaPretragaKnjiga(String unos)
        {

            List<Knjiga> pronadjeneKnjige = new List<Knjiga>();
            foreach (Knjiga k in knjige)
            {
                if (k.DjelomicnoPoklapanje(unos))
                    pronadjeneKnjige.Add(k);
            }
            pronadjeneKnjige.OrderBy(k => k.Sifra);
            return pronadjeneKnjige;
        }

        public List<Clan> ParcijalnaPretragaClanova(String unos)
        {
            List<Clan> pronadjeniClanovi = new List<Clan>();
            foreach (Clan c in clanovi)
            {
                if (c.DjelomicnoPoklapanje(unos))
                    pronadjeniClanovi.Add(c);
            }
            pronadjeniClanovi.OrderBy(c => c.Sifra);
            return pronadjeniClanovi;
        }

        public List<Uposlenik> ParcijalnaPretragaUposlenika(String unos)
        {
            List<Uposlenik> pronadjeniUposlenici = new List<Uposlenik>();
            foreach (Uposlenik u in uposlenici)
            {
                if (u.DjelomicnoPoklapanje(unos))
                    pronadjeniUposlenici.Add(u);
            }
            pronadjeniUposlenici.OrderBy(u => u.Sifra);
            return pronadjeniUposlenici;
        }

        public Clan TraziClanaPoSifri(int sifra)
        {
            if (!(sifra >= sljedeciOsobaId || sifra < 1))
                foreach (Clan c in clanovi)
                    if (c.Sifra == sifra)
                        return c;
            throw new Exception("Clan nije pronadjen");
        }

        public Uposlenik TraziUposlenikaPoSifri(int sifra)
        {
            if (!(sifra >= sljedeciOsobaId || sifra < 1))
                foreach (Uposlenik c in uposlenici)
                    if (c.Sifra == sifra)
                        return c;
            throw new Exception("Uposlenik nije pronadjen");
        }

        public List<Clan> TraziPoImenuClana(String ime, String prezime)
        {
            List<Clan> pronadjeniClanovi = new List<Clan>();
            foreach (Clan c in clanovi)
                if (c.Ime.Equals(ime) && c.Prezime.Equals(prezime))
                    pronadjeniClanovi.Add(c);
            if (pronadjeniClanovi.Count == 0)
                throw new Exception("Nijedan clan nije pronadjen");
            return pronadjeniClanovi;
        }

        public Osoba TraziPoUlozi(String korisnickoIme, String lozinka)
        {
            List<Osoba> l = uposlenici.Cast<Osoba>().ToList().Concat(clanovi.Cast<Osoba>().ToList()).ToList();
            foreach(Osoba o in l)
            {
                if (o.ProvjeraUloge(korisnickoIme, lozinka))
                    return o;
            }
            throw new Exception("Osoba sa datom ulogom ne postoji");
        }   

        public Boolean JeAdmin(String korisnickoIme, String lozinka)
        {
            return adminKorisnickoIme.Equals(korisnickoIme)
                && Hesiranje.GetMd5Hash(lozinka).Equals(adminLozinka);
        }

        public Boolean JeDuplikat(String korisnickoIme)
        {
            return clanovi.FindIndex(c => c.KorisnickoIme.Equals(korisnickoIme)) != -1
                || uposlenici.FindIndex(c => c.KorisnickoIme.Equals(korisnickoIme)) != -1;
        }

        public void ValidirajKorisnickoIme(String korisnickoIme)
        {
            if (korisnickoIme.Equals(""))
                throw new Exception("Korisnicko ime ne smije biti prazno");
            if(JeDuplikat(korisnickoIme))
                throw new Exception("Zauzeto korisnicko ime");
        }

        public double MjesecnaZarada
        {
            get
            {
                if (clanovi.Count == 0)
                    throw new Exception("Nema registrovanih clanova");
                return mjesecnaZarada;
            }
        }

        public void UcitajDefaultne()
        {
            sljedeciOsobaId = sljedeciKnjigaId = 1;
            clanovi = new List<Clan>();
            uposlenici = new List<Uposlenik>();
            knjige = new List<Knjiga>();
            mjesecnaZarada = 0;

            RegistrujKnjigu("Gospodar prstenova", new List<String> { "J R. R. Tolkien" }, "9780007273508", "Svjetlost", 2009);
            RegistrujKnjigu("Sofijin svijet", new List<String> { "Jostein Gardeer" }, "9785050048882", "Geopoetika", 2008);
            RegistrujKnjigu("Stranac", new List<String> { "Albert Camus" }, "0679720200", "Alnari", 2003);
            RegistrujClana("Amar", "Buric", "1106996190001", new Datum(11, 06, 1996), Clan.Spol.Musko, global::NSBiblioteka.Properties.Resources.aburic1, "aburic1", "12345", "");
            RegistrujClana("Irhad", "Omanovic", "2207996175015", new Datum(22, 7, 1996), Clan.Spol.Zensko, global::NSBiblioteka.Properties.Resources.iomanovic1, "iomanovic", "12345", "", Clan.TipClana.Student);
            RegistrujUposlenika("Neira", "Pulo", "2207996175015", new Datum(22, 7, 1996),Clan.Spol.Zensko, global::NSBiblioteka.Properties.Resources.npulo1, "npulo1", "12345", Uposlenik.Tip.Uposlenik);
            RegistrujUposlenika("Rasim", "Sabanovic", "0212996174139", new Datum(2, 12, 1996),Clan.Spol.Musko, global::NSBiblioteka.Properties.Resources.rsabanovic1, "rsabanovic1", "12345", Uposlenik.Tip.Domar);
            IznajmiKnjigu(1, 1);
            IznajmiKnjigu(1, 2);
        }

        public List<Clan> Clanovi { get { return clanovi;  } }
        public List<Uposlenik> Uposlenici { get { return uposlenici; } }
        public List<Knjiga> Knjige { get { return knjige; } }
    }
}

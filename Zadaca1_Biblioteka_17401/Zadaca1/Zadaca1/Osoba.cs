using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatumBiblioteka;
using System.Security.Cryptography;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System.Drawing.Imaging;

namespace NSBiblioteka {
    [Serializable]

    public abstract class Osoba : IPretrazivObjekat {
        public enum Spol { Musko, Zensko, Ostali }
        public enum Dob { Dijete, Tinejdzer, Odrasli, Stariji }

        protected int sifra;

        protected String ime;
        protected String prezime;
        protected String maticniBroj;
        protected Datum datumRodjenja;
        protected Image slika; 

        protected Spol spolOsobe;
        protected Dob dobOsobe;

        protected String korisnickoIme;
        protected String lozinka;

        [NonSerialized]
        protected Biblioteka bibl;

        public Osoba() { }

        public Osoba(Osoba o)
        {
            ime = o.ime;
            prezime = o.prezime;
            maticniBroj = o.maticniBroj;
            datumRodjenja = o.datumRodjenja;
            slika = o.slika;
            spolOsobe = o.spolOsobe;
            dobOsobe = o.dobOsobe;
            korisnickoIme = o.korisnickoIme;
            lozinka = o.lozinka;
            bibl = o.bibl;
            sifra = o.sifra;
        }

        public Osoba(String Ime, String Prezime, String MaticniBroj, Datum DatumRodjenja, Spol SpolClana, Image Slika, String korisnickoIme, String lozinka, Biblioteka Bibl)
        {
            ValidirajJMBG(MaticniBroj, SpolClana, DatumRodjenja);
            this.ime = Ime;
            this.prezime = Prezime;
            this.maticniBroj = MaticniBroj;
            this.datumRodjenja = DatumRodjenja;
            int zaokruzeneGodine = Datum.Trenutni().Godina - DatumRodjenja.Godina;
            if (zaokruzeneGodine < 13)
                this.dobOsobe = Dob.Dijete;
            else if (zaokruzeneGodine < 20)
                this.dobOsobe = Dob.Tinejdzer;
            else if (zaokruzeneGodine < 65)
                this.dobOsobe = Dob.Odrasli;
            else
                this.dobOsobe = Dob.Stariji;
            this.spolOsobe = SpolClana;
            this.slika = Slika;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = Hesiranje.GetMd5Hash(lozinka);
            this.bibl = Bibl;
        }

        public bool ProvjeraUloge(String korisnickoIme, String lozinka)
        {
            return this.korisnickoIme.Equals(korisnickoIme) && Hesiranje.VerifyMd5Hash(lozinka, this.lozinka);
        }

        public void ValidirajJMBG(String MaticniBroj, Spol SpolClana, Datum DatumRodjenja)
        {
            if (!ValidirajJMBG2(MaticniBroj, SpolClana, DatumRodjenja))
                throw new Exception("Neispravan JMBG");
        }

        private static bool ValidirajJMBG2(String MaticniBroj, Spol SpolClana, Datum DatumRodjenja)
        {
            if (MaticniBroj.Length != 13)
                return false;
            foreach (char c in MaticniBroj)
                if (c < '0' || c > '9')
                    return false;
            try
            {
                int dd = int.Parse(MaticniBroj.Substring(0, 2));
                int mm = int.Parse(MaticniBroj.Substring(2, 2));
                int ggg = int.Parse(MaticniBroj.Substring(4, 3));
                if (ggg / 100 != 0)
                    ggg += 1000;
                else
                    ggg += 2000;
                if (new Datum(dd, mm, ggg) != DatumRodjenja)
                    return false;
            }
            catch
            {
                return false;
            }
            int bbb = int.Parse(MaticniBroj.Substring(9, 3));
            if (bbb < 500 && SpolClana == Spol.Zensko || bbb > 499 && SpolClana == Spol.Musko)
                return false;
            int[] cifre = MaticniBroj.Select(cifra => int.Parse(cifra.ToString())).ToArray();
            int k = 0;
            for (int i = 0; i < 6; i++)
                k += (7 - i) * (cifre[i] + cifre[i + 6]);
            k %= 11;
            k = 11 - k;
            if (k != cifre[12])
                return false;
            return true;
        }

        public void ValidirajKorisnickoIme(String novo)
        {

            if (!korisnickoIme.Equals(novo))
            {
                bibl.ValidirajKorisnickoIme(novo);

            }
        }

        public static void StaticnaValidirajKorisnickoIme(Biblioteka bibl, string novo)
        {
            bibl.ValidirajKorisnickoIme(novo);

        }

        public static void StaticnaValidirajJMBG(String MaticniBroj, Spol SpolClana, Datum DatumRodjenja)
        {
            if (!ValidirajJMBG2(MaticniBroj, SpolClana, DatumRodjenja))
                throw new Exception("Neispravan JMBG");
        }

        public void ValidirajSve(String MaticniBroj, Spol SpolClana, Datum DatumRodjenja, String NovoKorisnickoIme)
        {
            ValidirajJMBG(MaticniBroj, SpolClana, DatumRodjenja);
            ValidirajKorisnickoIme(NovoKorisnickoIme);
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}"
               + " {4}", Ime, Prezime, MaticniBroj, DatumRodjenja, SpolOsobe);
        }

        public bool DjelomicnoPoklapanje(string unos)
        {

            return (Ime.Length >= unos.Length && Ime.Substring(0, unos.Length).Equals(unos,
                    StringComparison.InvariantCultureIgnoreCase)
                    || Prezime.Length >= unos.Length && Prezime.Substring(0, unos.Length).Equals(unos,
                    StringComparison.InvariantCultureIgnoreCase));
        }

        public String Ime { get { return ime; } set { ime = value; } }
        public String Prezime { get { return prezime; } set { prezime = value; } }
        public String MaticniBroj { get { return maticniBroj; } set { maticniBroj = value; } }
        public Datum DatumRodjenja { get { return datumRodjenja; } set { datumRodjenja = value; } }
        [XmlIgnore]
        public Image Slika { get { return slika; } set { slika = value; } }
        public byte[] ByteSlika
        {
            get
            {
                if (slika != null)
                { 
                    MemoryStream tmpStream = new MemoryStream();
                    slika.Save(tmpStream, ImageFormat.Png);
                    return tmpStream.ToArray();
                }
                return null;
            }
            set
            {
                if(value == null)
                {
                    slika = null;
                } 
                else
                {
                    using(var stream = new MemoryStream(value))
                    {
                        Bitmap bmp = new Bitmap(stream);
                        slika = bmp;
                    }
                }
            }
        }
        public Spol SpolOsobe { get { return spolOsobe; } set { spolOsobe = value; } }
        public Dob DobOsobe { get { return dobOsobe; } set { dobOsobe = value; } }
        [XmlIgnore]
        public Biblioteka Bibl { get { return bibl; } set { bibl = value; } }
        public String KorisnickoIme { get { return korisnickoIme;  } set { korisnickoIme = value; } }
        [XmlIgnore]
        public String Lozinka { get { return lozinka; } set { lozinka = Hesiranje.GetMd5Hash(value); } }
        public String HashLozinka { get { return lozinka; } set { lozinka = value; } }
        public int Sifra { get { return sifra;  } set { sifra = value; } }
    }
}

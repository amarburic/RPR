using DatumBiblioteka;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBiblioteka {
    public class BazaPodataka {

        private static readonly string ORACLE_USERNAME = "AB17401";
        private static readonly string ORACLE_PASSWORD = "Ttt2s02X";

        OracleConnection konekcija;
        Biblioteka bibl;

        public bool Ucitana { get; set; }
        public bool Spasena { get; set; } 
        public bool PokusajSpasavanja { get; set; }

        public BazaPodataka(Biblioteka bibl)
        {
            this.bibl = bibl;
            Ucitana = Program.POKRENI_BEZ_UCITAVANJA;
            Spasena = false;
            PokusajSpasavanja = false;
        }

        public void UcitajPodatke()
        {
            if (Program.POKRENI_BEZ_UCITAVANJA)
                throw new Exception();

            try
            {
                UspostaviKonekciju();
            } catch(Exception e)
            {
                throw new Exception("Konekcija");
            }
            Ucitana = true;
            try
            {
                UcitajUposlenike();
                UcitajClanove();
                UcitajKnjige();
            } catch(Exception e)
            {
                throw new Exception("Ucitavanje");
            }
            ZatvoriKonekciju();

            
        }

        public void SpasiPodatke()
        {
            if (PokusajSpasavanja)
                return;
            PokusajSpasavanja = true;

            UspostaviKonekciju();
            ObrisiSvePodatke();
            SpasiOsobe();
            SpasiUposlenike();
            SpasiClanove();
            SpasiClanoveSaEtfa();
            SpasiStudente();
            SpasiMasterStudente();
            SpasiKnjige();
            SpasiStripove();
            SpasiNaucneRadove();
            SpasiTransakcije();
            SpasiListeZelja();

            ZatvoriKonekciju();
            Spasena = true;
        }

        private void UcitajUposlenike()
        {
            using(OracleCommand cmd = konekcija.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Osoba o, Uposlenik u WHERE o.Sifra = u.Sifra";
                OracleDataAdapter adp = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                bibl.Uposlenici.Clear();
                foreach (DataRow row in ds.Tables[0].Rows)
                {

                    Datum DatumRodjenja = new Datum(Convert.ToDateTime(row["DatumRodjenja"].ToString()));

                    Image Slika;
                    byte[] Bajtovi = row["Slika"] as byte[];
                    if (Bajtovi == null)
                    {
                        Slika = null;
                    }
                    else
                    {
                        using (var stream = new MemoryStream(Bajtovi))
                        {
                            Bitmap bmp = new Bitmap(stream);
                            Slika = bmp;
                        }
                    }
                    bibl.Uposlenici.Add(new Uposlenik(row["Ime"].ToString(), row["Prezime"].ToString(),
                        row["MaticniBroj"].ToString(), DatumRodjenja,
                    (Osoba.Spol)Int32.Parse(row["Spol"].ToString()), Slika, row["KorisnickoIme"].ToString(), "", bibl,
                    (Uposlenik.Tip)Int32.Parse(row["TipUposlenika"].ToString())));
                    bibl.Uposlenici.Last().HashLozinka = row["Lozinka"].ToString();
                    bibl.Uposlenici.Last().Sifra = Int32.Parse(row["Sifra"].ToString());
                }

            }
        }

        private void UcitajClanove()
        {
            using (OracleCommand cmd = konekcija.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Osoba o, Clan c WHERE o.Sifra = c.Sifra";
                OracleDataAdapter adp = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                bibl.Clanovi.Clear();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Datum DatumRodjenja = new Datum(Convert.ToDateTime(row["DatumRodjenja"].ToString()));
                    Image Slika;
                    byte[] Bajtovi = row["Slika"] as byte[];
                    if (Bajtovi == null)
                    {
                        Slika = null;
                    }
                    else
                    {
                        using (var stream = new MemoryStream(Bajtovi))
                        {
                            Bitmap bmp = new Bitmap(stream);
                            Slika = bmp;
                        }
                    }
                    bibl.Clanovi.Add(new Clan(row["Ime"].ToString(), row["Prezime"].ToString(),
                        row["MaticniBroj"].ToString(), DatumRodjenja,
                        (Osoba.Spol)Int32.Parse(row["Spol"].ToString()), Slika, row["KorisnickoIme"].ToString(), "", bibl,
                        row["Komentar"].ToString()));
                    bibl.Clanovi.Last().HashLozinka = row["Lozinka"].ToString();
                    bibl.Clanovi.Last().Sifra = Int32.Parse(row["Sifra"].ToString());
                    bibl.Clanovi.Last().TipPlacanjaClanarine = (Clan.TipPlacanja)Int32.Parse(row["TipPlacanja"].ToString());
                    bibl.Clanovi.Last().Suspendovan = Int32.Parse(row["Suspendovan"].ToString()) == 1;
                    using (OracleCommand cmd2 = konekcija.CreateCommand())
                    {
                        cmd2.CommandText = "SELECT k.Sifra FROM Knjiga k WHERE k.Zaduzena = 1 and k.Zaduzenik = " +
                            bibl.Clanovi.Last().Sifra;
                        OracleDataAdapter adp2 = new OracleDataAdapter(cmd2);
                        DataSet ds2 = new DataSet();
                        adp2.Fill(ds2);
                        foreach (DataRow row2 in ds2.Tables[0].Rows)
                            bibl.Clanovi.Last().ZaduzeneKnjige.Add(Int32.Parse(row2["Sifra"].ToString()));
                    }
                    using (OracleCommand cmd2 = konekcija.CreateCommand())
                    {
                        cmd2.CommandText = "SELECT * FROM Transakcije t WHERE t.ClanSifra = " +
                            bibl.Clanovi.Last().Sifra;

                        OracleDataAdapter adp2 = new OracleDataAdapter(cmd2);
                        DataSet ds2 = new DataSet();
                        adp2.Fill(ds2);

                        foreach (DataRow row2 in ds2.Tables[0].Rows)
                        {
                            bibl.Clanovi.Last().Transakcije.Add(new Transakcija(Int32.Parse(row2["KnjigaSifra"].ToString()),
                              Int32.Parse(row2["ClanSifra"].ToString()), (Transakcija.Tip)Int32.Parse(row2["Tip"].ToString()),
                              new Datum(Convert.ToDateTime(row2["DatumZaduzenja"].ToString())),
                              new Datum(Convert.ToDateTime(row2["Rok"].ToString()))));
                        }
                    }
                    using (OracleCommand cmd2 = konekcija.CreateCommand())
                    {
                        cmd2.CommandText = "SELECT * FROM ElementListeZelja e WHERE e.ClanSifra = " +
                            bibl.Clanovi.Last().Sifra;
                        OracleDataAdapter adp2 = new OracleDataAdapter(cmd2);
                        DataSet ds2 = new DataSet();
                        adp2.Fill(ds2);
                        foreach (DataRow row2 in ds2.Tables[0].Rows)
                        {
                            bibl.Clanovi.Last().OriginalListaZelja.Add(new ElementListeZelja(Int32.Parse(row2["KnjigaSifra"].ToString()),
                                Int32.Parse(row2["Procitana"].ToString()) == 1));
                        }
                    }
                }
            }
            using (OracleCommand cmd = konekcija.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM ClanSaEtfa cetf, Clan c WHERE cetf.Sifra = c.Sifra";
                OracleDataAdapter adp = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int index = bibl.Clanovi.FindIndex(x => x.Sifra == Int32.Parse(row["Sifra"].ToString()));
                    bibl.Clanovi[index] = new ClanSaEtfa(bibl.Clanovi[index]);
                }
            }

            using (OracleCommand cmd = konekcija.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Profesor p, ClanSaEtfa cetf WHERE p.Sifra = cetf.Sifra";
                OracleDataAdapter adp = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int index = bibl.Clanovi.FindIndex(x => x.Sifra == Int32.Parse(row["Sifra"].ToString()));
                    bibl.Clanovi[index] = new Profesor(bibl.Clanovi[index] as ClanSaEtfa);
                }
            }

            using (OracleCommand cmd = konekcija.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Student s, ClanSaEtfa cetf WHERE s.Sifra = cetf.Sifra";
                OracleDataAdapter adp = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int index = bibl.Clanovi.FindIndex(x => x.Sifra == Int32.Parse(row["Sifra"].ToString()));
                    bibl.Clanovi[index] = new Student(bibl.Clanovi[index] as ClanSaEtfa);
                }
            }

            using (OracleCommand cmd = konekcija.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM MasterStudent ms, Student s WHERE ms.Sifra = s.Sifra";
                OracleDataAdapter adp = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int index = bibl.Clanovi.FindIndex(x => x.Sifra == Int32.Parse(row["Sifra"].ToString()));
                    bibl.Clanovi[index] = new MasterStudent(bibl.Clanovi[index] as Student);
                }
            }
            List<Osoba> l = bibl.Uposlenici.Cast<Osoba>().ToList().Concat(bibl.Clanovi.Cast<Osoba>().ToList()).ToList();
            if(l.Count > 0)
                bibl.sljedeciOsobaId = l.Aggregate((agg, next) => next.Sifra > agg.Sifra ? next : agg).Sifra + 1;
        }

        private void UcitajKnjige()
        {
            using (OracleCommand cmd = konekcija.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Knjiga";
                OracleDataAdapter adp = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                bibl.Knjige.Clear();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    
                    bibl.Knjige.Add(new Knjiga(row["Naslov"].ToString(), row["Autori"].ToString().Split(',').ToList(),
                        row["Isbn"].ToString(), row["Izdavac"].ToString(), Int32.Parse(row["GodinaZaduzenja"].ToString()), bibl));
                    bibl.Knjige.Last().Sifra = Int32.Parse(row["Sifra"].ToString());
                    bibl.Knjige.Last().Zaduzena = Int32.Parse(row["Zaduzena"].ToString()) == 1;
                    if (bibl.Knjige.Last().Zaduzena)
                        bibl.Knjige.Last().Zaduzenik = Int32.Parse(row["Zaduzenik"].ToString());
                    using (OracleCommand cmd2 = konekcija.CreateCommand())
                    {
                        cmd2.CommandText = "SELECT * FROM Transakcije t WHERE t.KnjigaSifra = " +
                            bibl.Knjige.Last().Sifra;

                        OracleDataAdapter adp2 = new OracleDataAdapter(cmd2);
                        DataSet ds2 = new DataSet();
                        adp2.Fill(ds2);

                        foreach (DataRow row2 in ds2.Tables[0].Rows)
                        {
                            bibl.Knjige.Last().Transakcije.Add(new Transakcija(Int32.Parse(row2["KnjigaSifra"].ToString()),
                              Int32.Parse(row2["ClanSifra"].ToString()), (Transakcija.Tip)Int32.Parse(row2["Tip"].ToString()),
                              new Datum(Convert.ToDateTime(row2["DatumZaduzenja"].ToString())),
                              new Datum(Convert.ToDateTime(row2["Rok"].ToString()))));
                        }
                    }
                }
            }
            using (OracleCommand cmd = konekcija.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Strip s, Knjiga k WHERE s.Sifra = k.Sifra";
                OracleDataAdapter adp = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int index = bibl.Knjige.FindIndex(x => x.Sifra == Int32.Parse(row["Sifra"].ToString()));
                    bibl.Knjige[index] = new Strip(bibl.Knjige[index], row["AnimatorskaKuca"].ToString(),
                        row["Umjetnici"].ToString().Split(',').ToList(), Int32.Parse(row["BrojIzdanja"].ToString()),
                        Int32.Parse(row["BrojIzdanja"].ToString()) == 1);
                }
            }

            using (OracleCommand cmd = konekcija.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM NaucniRad nr, Knjiga k WHERE nr.Sifra = k.Sifra";
                OracleDataAdapter adp = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int index = bibl.Knjige.FindIndex(x => x.Sifra == Int32.Parse(row["Sifra"].ToString()));
                    bibl.Knjige[index] = new NaucniRad(bibl.Knjige[index], row["Oblast"].ToString(),
                        row["Konferencija"].ToString());
                }
            }
            bibl.sljedeciKnjigaId = bibl.Knjige.Aggregate((agg, next) => next.Sifra > agg.Sifra ? next : agg).Sifra + 1;
        }

        private void SpasiOsobe()
        {
            List<Osoba> l = bibl.Uposlenici.Cast<Osoba>().ToList().Concat(bibl.Clanovi.Cast<Osoba>().ToList()).ToList();
            l = l.OrderBy(x => x.Sifra).ToList();
            foreach(Osoba o in l)
            {
                using (OracleCommand cmd = konekcija.CreateCommand())
                {
                    string sqlInsert = String.Format("insert into Osoba (Sifra, Ime, Prezime, MaticniBroj, " +
                        "DatumRodjenja, Slika, Spol, Dob, KorisnickoIme, Lozinka) values " +
                        "({0}, '{1}', '{2}', '{3}', {4}, :slika, {5}, {6}, '{7}', '{8}')",
                        o.Sifra, o.Ime, o.Prezime, o.MaticniBroj,
                        String.Format("To_Date({0} || '-' || {1} || '-' || {2}, 'DD-MM-YYYY')",
                        o.DatumRodjenja.Dan, o.DatumRodjenja.Mjesec, o.DatumRodjenja.Godina),
                        (int)o.SpolOsobe, (int)o.DobOsobe, o.KorisnickoIme, o.Lozinka);

                    cmd.CommandText = sqlInsert;
                    OracleParameter par = cmd.CreateParameter();
                    par.ParameterName = "slika";
                    par.OracleType = OracleType.Blob;
                    par.Value = o.ByteSlika;
                    cmd.Parameters.Add(par);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void SpasiUposlenike()
        {
            foreach (Uposlenik u in bibl.Uposlenici)
            {
                using (OracleCommand cmd = konekcija.CreateCommand())
                {
                    string sqlInsert = String.Format("insert into Uposlenik (Sifra, TipUposlenika) values " +
                        "({0}, {1})", u.Sifra, (int)u.TipUposlenika);
                    cmd.CommandText = sqlInsert;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void SpasiClanove()
        {
            foreach (Clan c in bibl.Clanovi)
            {
                using (OracleCommand cmd = konekcija.CreateCommand())
                {
                    string sqlInsert = String.Format("insert into Clan (Sifra, Komentar, TipPlacanja, Suspendovan) values " +
                        "({0}, '{1}', {2}, {3})", c.Sifra, c.Komentar, (int)c.TipPlacanjaClanarine, c.Suspendovan ? 1 : 0);
                    cmd.CommandText = sqlInsert;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void SpasiClanoveSaEtfa()
        {
            foreach (Clan c in bibl.Clanovi)
            {
                if(c is ClanSaEtfa)
                    using (OracleCommand cmd = konekcija.CreateCommand())
                    {
                        string sqlInsert = String.Format("insert into ClanSaEtfa (Sifra) values " +
                            "({0})", c.Sifra);
                        cmd.CommandText = sqlInsert;
                        cmd.ExecuteNonQuery();
                    }
            }
        }

        private void SpasiStudente()
        {
            foreach (Clan c in bibl.Clanovi)
            {
                if (c is Student)
                    using (OracleCommand cmd = konekcija.CreateCommand())
                    {
                        string sqlInsert = String.Format("insert into Student (Sifra) values " +
                            "({0})", c.Sifra);
                        cmd.CommandText = sqlInsert;
                        cmd.ExecuteNonQuery();
                    }
            }
        }

        private void SpasiMasterStudente()
        {
            foreach (Clan c in bibl.Clanovi)
            {
                if (c is MasterStudent)
                    using (OracleCommand cmd = konekcija.CreateCommand())
                    {
                        string sqlInsert = String.Format("insert into MasterStudent (Sifra) values " +
                            "({0})", c.Sifra);
                        cmd.CommandText = sqlInsert;
                        cmd.ExecuteNonQuery();
                    }
            }
        }

        private void SpasiProfesore()
        {
            foreach (Clan c in bibl.Clanovi)
            {
                if (c is Profesor)
                    using (OracleCommand cmd = konekcija.CreateCommand())
                    {
                        string sqlInsert = String.Format("insert into Profesor (Sifra) values " +
                            "({0})", c.Sifra);
                        cmd.CommandText = sqlInsert;
                        cmd.ExecuteNonQuery();
                    }
            }
        }

        private void SpasiKnjige()
        {
            foreach (Knjiga k in bibl.Knjige)
            {
                using (OracleCommand cmd = konekcija.CreateCommand())
                {
                    string sqlInsert = String.Format("insert into Knjiga (Sifra, Naslov, Autori, " + 
                        "ISBN, Izdavac, GodinaZaduzenja, Zaduzena, Zaduzenik) values " +
                        "({0}, '{1}', '{2}', '{3}', '{4}', {5}, {6}, {7})", k.Sifra, 
                        k.Naslov, k.AutoriKaoString(), k.ISBN, k.Izdavac, k.GodinaIzdanja, k.Zaduzena ? 1 : 0, k.Zaduzena ? k.Zaduzenik + "": "NULL");
                    cmd.CommandText = sqlInsert;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void SpasiStripove()
        {
            foreach (Knjiga k in bibl.Knjige)
            {
                if (k is Strip)
                    using (OracleCommand cmd = konekcija.CreateCommand())
                    {
                        Strip s = k as Strip;
                        string sqlInsert = String.Format("insert into Strip (Sifra, AnimatorskaKuca, Umjetnici, " + 
                            "BrojIzdanja, SpecijalnoIzdanje) values " +
                            "({0}, '{1}', '{2}', '{3}', {4})", s.Sifra, s.AnimatorskaKuca, s.UmjetniciKaoString(), s.BrojIzdanja, 
                            s.SpecijalnoIzdanje ? 1 : 0);
                        cmd.CommandText = sqlInsert;
                        cmd.ExecuteNonQuery();
                    }
            }
        }

        private void SpasiNaucneRadove()
        {
            foreach (Knjiga k in bibl.Knjige)
            {
                if (k is NaucniRad)
                    using (OracleCommand cmd = konekcija.CreateCommand())
                    {
                        NaucniRad nr = k as NaucniRad;
                        string sqlInsert = String.Format("insert into NaucniRad (Sifra, Oblast, Konferencija) values " +
                            "({0}, '{1}', '{2}')", nr.Sifra, nr.Oblast, nr.Konferencija);
                        cmd.CommandText = sqlInsert;
                        cmd.ExecuteNonQuery();
                    }
            }
        }

        private void SpasiListeZelja()
        {
            foreach (Clan c in bibl.Clanovi)
            {
                foreach(Pair<Knjiga, bool> p in c.ListaZelja)
                {
                    using (OracleCommand cmd = konekcija.CreateCommand())
                    {
                        string sqlInsert = String.Format("insert into ElementListeZelja (ClanSifra, KnjigaSifra, Procitana) values " +
                            "({0}, {1}, {2})", c.Sifra, p.First.Sifra, p.Second ? 1 : 0);
                        cmd.CommandText = sqlInsert;
                        cmd.ExecuteNonQuery();
                    }
                }

            }
        }

        private void SpasiTransakcije()
        {
            foreach (Clan c in bibl.Clanovi)
            {
                foreach (Transakcija t in c.Transakcije)
                {
                    using (OracleCommand cmd = konekcija.CreateCommand())
                    {
                        string sqlInsert = String.Format("insert into Transakcije (ClanSifra, KnjigaSifra," + 
                            "Tip, DatumZaduzenja, Rok) values " +
                            "({0}, {1}, {2}, {3}, {4})", c.Sifra, t.Knjiga, (int)t.TipTransakcije,
                            String.Format("To_Date({0} || '-' || {1} || '-' || {2}, 'DD-MM-YYYY')",
                            t.DatumZaduzenja.Dan, t.DatumZaduzenja.Mjesec, t.DatumZaduzenja.Godina),
                            String.Format("To_Date({0} || '-' || {1} || '-' || {2}, 'DD-MM-YYYY')",
                            t.Rok.Dan, t.Rok.Mjesec, t.Rok.Godina));
                        cmd.CommandText = sqlInsert;
                        cmd.ExecuteNonQuery();
                    }
                }

            }
        }

        private void ObrisiSvePodatke()
        {
            List<String> komande = global::NSBiblioteka.Properties.Resources.CiscenjeTabela.Split(';').ToList();
            foreach(String k in komande) 
                using (OracleCommand cmd = konekcija.CreateCommand())
                {
                    cmd.CommandText = k;
                    cmd.ExecuteNonQuery();
                }
        }

        private void UspostaviKonekciju()
        { 
                konekcija = new OracleConnection();
                konekcija.ConnectionString = @"Data Source= 
           (DESCRIPTION = 
               (ADDRESS = (PROTOCOL = TCP)(HOST = 80.65.65.66)(PORT = 1521)) 
               (CONNECT_DATA = 
               (SERVER = DEDICATED) 
               (SERVICE_NAME = etflab.db.lab.etf.unsa.ba)
               )
           );User Id= " + ORACLE_USERNAME + ";Password= " + ORACLE_PASSWORD + ";Persist Security Info=True;";
            try
            {
                konekcija.Open();
            } catch
            {
                throw new Exception("Nije se mogla uspostaviti veza sa bazom");
            }
        }

        private void ZatvoriKonekciju()
        {
            konekcija.Close();
        }
    }
}

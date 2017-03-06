using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatumBiblioteka;

namespace NSBiblioteka {
    class Meni { /*
        Biblioteka biblioteka;
        bool prviPut;
        public Meni(Biblioteka biblioteka)
        {
            this.biblioteka = biblioteka;
            prviPut = true;
        }

        public void Prikazi()
        {
            GlavniMeni();
        }

        void GlavniMeni()
        {
            bool ispravan, ponovi = true;
            int izbor;
            while (ponovi)
            {
                do
                {
                    Console.Clear();
                    if (prviPut)
                    {
                        prviPut = false;
                        Console.WriteLine(@"Dobro došli u >>Ime_Biblioteke_Iz_Klase_Biblioteka<< biblioteku! Odaberite jednu od opcija:");
                    }
                    Console.WriteLine("1. Registruj/Briši knjigu");
                    Console.WriteLine("2. Registruj/Briši člana");
                    Console.WriteLine("3. Iznajmi/Vrati knjigu");
                    Console.WriteLine("4. Pretraga");
                    Console.WriteLine("5. Analiza sadržaja");
                    Console.WriteLine("6. Izlaz");
                    izbor = int.Parse(Console.ReadLine());
                    ispravan = (izbor >= 1 && izbor <= 6);
                    if (!ispravan)
                        Console.WriteLine("Unesite ispravnu opciju.");
                } while (!ispravan);

                switch (izbor)
                {
                case 1:
                    RegistrujBrisiKnjiguMeni();
                    break;
                case 2:
                    RegistrujBrisiClanaMeni();
                    break;
                case 3:
                    IznajmiVratiKnjiguMeni();
                    break;
                case 4:
                    PretragaMeni();
                    break;
                case 5:
                    AnalizaSadrzajaMeni();
                    break;
                case 6:
                    ponovi = false;
                    Console.WriteLine("Dovidjenja");
                    Console.ReadLine();
                    break;
                }
            }
        }

        private void AnalizaSadrzajaMeni()
        {
            bool ispravan, ponovi = true;
            int izbor;
            while (ponovi)
            {
                do
                {
                    Console.WriteLine("1. Lista svih clanova");
                    Console.WriteLine("2. Lista svih knjiga");
                    Console.WriteLine("3. Mjesecna zarada");
                    Console.WriteLine("4. Spolna struktura clanova");
                    Console.WriteLine("5. Dobna struktura clanova");
                    Console.WriteLine("6. Top lista najcitanijih knjiga");
                    Console.WriteLine("7. Top lista najcitanijih autora");
                    Console.WriteLine("8. Povratak");
                    izbor = int.Parse(Console.ReadLine());
                    ispravan = (izbor >= 1 && izbor <= 8);
                    if (!ispravan)
                        Console.WriteLine("Unesite ispravnu opciju.");
                } while (!ispravan);

                switch (izbor)
                {
                case 1:
                    try
                    {
                        var rezultat = biblioteka.listaSvihClanova();
                        for (int i = 0; i < rezultat.Count; i++)
                            Console.WriteLine(i + 1 + ". \n" + rezultat[i]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        var rezultat = biblioteka.listaSvihKnjiga();
                        for (int i = 0; i < rezultat.Count; i++)
                            Console.WriteLine(i + 1 + ". \n" + rezultat[i]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Mjesecna zarada: " + biblioteka.MjesecnaZarada);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        List<int> rezultat = biblioteka.spolnaStruktura();
                        Console.WriteLine("Muskaraca: " + rezultat[0]);
                        Console.WriteLine("Zena: " + rezultat[1]);
                    } catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 5:
                    try
                    {
                        var dobi = Enum.GetValues(typeof(Clan.Dob)).Cast<Clan.Dob>().ToList();
                        List<int> rezultat = biblioteka.dobnaStruktura();
                        for (int i = 0; i < rezultat.Count; i++)
                            Console.WriteLine(dobi[i] + ": " + rezultat[i]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 6:
                    try
                    {
                        var rezultat = biblioteka.najcitanijeKnjige();
                        for (int i = 0; i < rezultat.Count; i++)
                            Console.WriteLine(i + 1 + ". " + rezultat[i]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 7:
                    try
                    {
                        var rezultat = biblioteka.najcitanijiAutori();
                        for (int i = 0; i < rezultat.Count; i++)
                            Console.WriteLine(i + 1 + ". " + rezultat[i]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 8:
                    ponovi = false;
                    break;
                }
            }
        }

        private void PretragaMeni()
        {
            bool ispravan, ponovi = true;
            int izbor;
            while (ponovi)
            {
                do
                {
                    Console.WriteLine("1. Trazi clana po sifri");
                    Console.WriteLine("2. Trazi clana po imenu");
                    Console.WriteLine("3. Trazi knjigu po sifri");
                    Console.WriteLine("4. Trazi knjigu po ISBN-u");
                    Console.WriteLine("5. Trazi knjigu parcijalno");
                    Console.WriteLine("6. Povratak");

                    izbor = int.Parse(Console.ReadLine());
                    ispravan = (izbor >= 1 && izbor <= 6);
                    if (!ispravan)
                        Console.WriteLine("Unesite ispravnu opciju.");
                } while (!ispravan);

                switch (izbor)
                {
                case 1:
                    int sifra;
                    Console.Write("Unesi sifru: ");
                    sifra = Int32.Parse(Console.ReadLine());
                    try
                    {
                        Console.WriteLine(biblioteka.TraziClanaPoSifri(sifra));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 2:
                    String ime, prezime;
                    Console.Write("Ime: ");
                    ime = Console.ReadLine();
                    Console.Write("Prezime: ");
                    prezime = Console.ReadLine();
                    try
                    {
                        int i = 1;
                        foreach(Clan c in biblioteka.TraziPoImenuClana(ime, prezime))
                            Console.WriteLine("" + i++ + ".\n" + c);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 3:
                    Console.Write("Unesi sifru: ");
                    sifra = Int32.Parse(Console.ReadLine());
                    try
                    {
                        Console.WriteLine(biblioteka.TraziKnjiguPoSifri(sifra));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 4:
                    String unos;
                    Console.Write("Unesi ISBN: ");
                    unos = Console.ReadLine();
                    try
                    {
                        Console.WriteLine(biblioteka.TraziPoISBN(new ISBN(unos)));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 5:
                    String keyword;
                    Console.Write("Pretrazi: ");
                    keyword = Console.ReadLine();
                    try
                    {
                        int i = 1;
                        foreach (Knjiga k in biblioteka.ParcijalnaPretragaKnjiga(keyword))
                            Console.WriteLine("" + i++ + ".\n" + k);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 6:
                    ponovi = false;
                    break;
                }
            }
        }

        private void IznajmiVratiKnjiguMeni()
        {
            bool ispravan, ponovi = true;
            int izbor;
            while (ponovi)
            {
                do
                {
                    Console.WriteLine("1. Iznajmi knjigu");
                    Console.WriteLine("2. Vrati knjigu");
                    Console.WriteLine("3. Povratak");

                    izbor = int.Parse(Console.ReadLine());
                    ispravan = (izbor >= 1 && izbor <= 3);
                    if (!ispravan)
                        Console.WriteLine("Unesite ispravnu opciju.");
                } while (!ispravan);

                switch (izbor)
                {
                case 1:
                    IznajmiKnjigu();
                    break;
                case 2:
                    VratiKnjigu();
                    break;
                case 3:
                    ponovi = false;
                    break;
                }
            }
        }

        private void VratiKnjigu()
        {
            int sifraKnjige;
            Console.Write("Unesite sifru knjige: ");
            sifraKnjige = Int32.Parse(Console.ReadLine());
            try
            {
                biblioteka.VratiKnjigu(sifraKnjige);
                Console.WriteLine("Knjiga uspjesno vracena");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void IznajmiKnjigu()
        {
            int sifraKnjige, sifraClana;
            Console.Write("Unesite sifru knjige: ");
            sifraKnjige = Int32.Parse(Console.ReadLine());
            Console.Write("Unesite sifru clana: ");
            sifraClana = Int32.Parse(Console.ReadLine());
            try
            {
                biblioteka.IznajmiKnjigu(sifraClana, sifraKnjige);
                Console.WriteLine("Knjiga uspjesno iznajmljena");
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void RegistrujBrisiClanaMeni()
        {
            bool ispravan, ponovi = true;
            int izbor;
            while (ponovi)
            {
                do
                {
                    Console.WriteLine("1. Registruj novog clana");
                    Console.WriteLine("2. Obriši clana");
                    Console.WriteLine("3. Povratak");

                    izbor = int.Parse(Console.ReadLine());
                    ispravan = (izbor >= 1 && izbor <= 3);
                    if (!ispravan)
                        Console.WriteLine("Unesite ispravnu opciju.");
                } while (!ispravan);

                switch (izbor)
                {
                case 1:
                    RegistrujNovogClana();
                    break;
                case 2:
                   ObrisiClana();
                    break;
                case 3:
                    ponovi = false;
                    break;
                }
            }
        }

        private void ObrisiClana()
        {
            int sifra;
            Console.Write("Sifra clana: ");
            sifra = Int32.Parse(Console.ReadLine());
            try
            {
                biblioteka.ObrisiClana(sifra);
                Console.WriteLine("Clan uspjesno obrisan");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void RegistrujNovogClana()
        {
            String ime, prezime, maticniBroj, komentar;
            Datum datumRodjenja;
            Clan.Spol spol;
            Clan.TipClana tip = Clan.TipClana.Obicni;
            Console.Write("Ime: ");
            ime = Console.ReadLine();
            Console.Write("Prezime: ");
            prezime = Console.ReadLine();
            Console.Write("JMBG: ");
            maticniBroj = Console.ReadLine();
            Console.Write("Datum rodjenja(dd/mm/gggg): ");
            String temp = Console.ReadLine();
            List<String> temp2 = temp.Split('/').ToList();
            datumRodjenja = new Datum(Int32.Parse(temp2[0]), Int32.Parse(temp2[1]), Int32.Parse(temp2[2]));
          //  Console.WriteLine("Komentar: ");
          //  komentar = Console.ReadLine();
            Console.Write("Spol[M/Z]: ");
            temp = Console.ReadLine();
            spol = temp.ToLower() == "m" ? Clan.Spol.Musko : Clan.Spol.Zensko;
            Console.Write("Tip clana[Obicni/Etfovac]: ");
            temp = Console.ReadLine();
            if(temp.ToLower() == "etfovac")
            {
                Console.Write("[Student/Profesor]: ");
                temp = Console.ReadLine();
                if (temp.ToLower() == "profesor")
                    tip = Clan.TipClana.Profesor;
                else
                {
                    tip = Clan.TipClana.Student;
                    Console.Write("[Bachelor/Master]: ");
                    temp = Console.ReadLine();
                    if (temp.ToLower() == "master")
                        tip = Clan.TipClana.MasterStudent;
                }
            }
            try
            {
                biblioteka.RegistrujClana(ime, prezime, maticniBroj, datumRodjenja, "", spol, tip);
                Console.WriteLine("Clan uspjesno registrovan");
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        private void RegistrujBrisiKnjiguMeni()
        {
            bool ispravan, ponovi = true;
            int izbor;
            while (ponovi)
            {
                do
                {
                    Console.WriteLine("1. Registruj novu knjigu");
                    Console.WriteLine("2. Obriši knjigu");
                    Console.WriteLine("3. Povratak");

                    izbor = int.Parse(Console.ReadLine());
                    ispravan = (izbor >= 1 && izbor <= 3);
                    if (!ispravan)
                        Console.WriteLine("Unesite ispravnu opciju.");
                } while (!ispravan);

                switch (izbor)
                {
                case 1:
                    RegistrujNovuKnjiguMeni();
                    break;
                case 2:
                    ObrisiKnjigu();
                    break;
                case 3:
                    ponovi = false;
                    break;
                }
            }
        }

        private void ObrisiKnjigu()
        {
            int sifra;
            Console.Write("Sifra knjige: ");
            sifra = Int32.Parse(Console.ReadLine());
            try
            {
                biblioteka.ObrisiKnjigu(sifra);
                Console.WriteLine("Knjiga uspjesno obrisana");
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void RegistrujNovuKnjiguMeni()
        {
            bool ispravan, ponovi = true;
            int izbor;
            while (ponovi)
            {
                do
                {
                    Console.WriteLine("1. Registruj obicnu knjigu");
                    Console.WriteLine("2. Registruj strip");
                    Console.WriteLine("3. Registruj naucni rad");
                    Console.WriteLine("4. Povratak");

                    izbor = int.Parse(Console.ReadLine());
                    ispravan = (izbor >= 1 && izbor <= 4);
                    if (!ispravan)
                        Console.WriteLine("Unesite ispravnu opciju.");
                } while (!ispravan);

                switch (izbor)
                {
                case 1:
                    RegistrujNovuKnjigu();
                    break;
                case 2:
                    RegistrujNoviStrip();
                    break;
                case 3:
                    RegistrujNaucniRad();
                    break;
                case 4:
                    ponovi = false;
                    break;
                }
            }
        }

        private void RegistrujNovuKnjigu()
        {
            String naslov, isbn, izdavac;
            List<String> autori;
            int godinaIzdanja;
            Console.Write("Naslov: ");
            naslov = Console.ReadLine();
            Console.Write("Autor(ako ih je vise, navesti u jednom redu odvojene zarezima):");
            autori = Console.ReadLine().Split(',').ToList();
            Console.Write("ISBN: ");
            isbn = Console.ReadLine();
            Console.Write("Izdavac: ");
            izdavac = Console.ReadLine();
            Console.Write("Godina izdanja: ");
            godinaIzdanja = Int32.Parse(Console.ReadLine());
            try
            {
                biblioteka.RegistrujKnjigu(naslov, autori, isbn, izdavac, godinaIzdanja);
                Console.WriteLine("Knjiga uspjesno registrovana");
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void RegistrujNoviStrip()
        {
            String naslov, isbn, izdavac, animatorskaKuca;
            List<String> autori, umjetnici;
            int godinaIzdanja, brojIzdanja;
            Boolean specijalnoIzdanje;
        Console.Write("Naslov: ");
            naslov = Console.ReadLine();
            Console.Write("Autor(ako ih je vise, navesti u jednom redu odvojene zarezima):");
            autori = Console.ReadLine().Split(',').ToList();
            Console.Write("ISBN: ");
            isbn = Console.ReadLine();
            Console.Write("Izdavac: ");
            izdavac = Console.ReadLine();
            Console.Write("Godina izdanja: ");
            godinaIzdanja = Int32.Parse(Console.ReadLine());
            Console.Write("Animatorska kuca:");
            animatorskaKuca = Console.ReadLine();
            Console.Write("Umjetnik(ako ih je vise, navesti u jednom redu odvojene zarezima):");
            umjetnici = Console.ReadLine().Split(',').ToList();
            Console.Write("Broj izdanja: ");
            brojIzdanja = Int32.Parse(Console.ReadLine());
            Console.Write("Specijalno izdanje[D/N]: ");
            String temp = Console.ReadLine();
            specijalnoIzdanje = temp.Equals("D");
            try
            {
                biblioteka.RegistrujStrip(naslov, autori, isbn, izdavac, godinaIzdanja, animatorskaKuca, umjetnici, brojIzdanja, specijalnoIzdanje);
                Console.WriteLine("Strip uspjesno registrovan");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void RegistrujNaucniRad()
        {
            String naslov, isbn, izdavac, oblast, konferencija;
            List<String> autori;
            int godinaIzdanja;
            Console.Write("Naslov: ");
            naslov = Console.ReadLine();
            Console.Write("Autor(ako ih je vise, navesti u jednom redu odvojene zarezima): ");
            autori = Console.ReadLine().Split(',').ToList();
            Console.Write("ISBN: ");
            isbn = Console.ReadLine();
            Console.Write("Izdavac: ");
            izdavac = Console.ReadLine();
            Console.Write("Godina izdanja: ");
            godinaIzdanja = Int32.Parse(Console.ReadLine());
            Console.Write("Oblast: ");
            oblast = Console.ReadLine();
            Console.Write("Konferencija: ");
            konferencija = Console.ReadLine();
            try
            {
                biblioteka.RegistrujNaucniRad(naslov, autori, isbn, izdavac, godinaIzdanja, oblast, konferencija);
                Console.WriteLine("Naucni rad uspjesno registrovan");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        */
    }
    
}

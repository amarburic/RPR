using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NSBiblioteka {
    public sealed partial class Biblioteka {

        public enum TipSerijalizacija { XML, Binarno }
        public enum ObjekatSerijalizacije { Uposlenici, Clanovi, Knjige }

        public void SerijalizirajClanoveBinarno(string path)
        {
            SerijalizujBinarno(path, clanovi);
        }

        public void DeserijalizirajClanoveBinarno(string path)
        {
            clanovi = DeserijalizujBinarno(path) as List<Clan>;
            List<Osoba> l = uposlenici.Cast<Osoba>().ToList().Concat(clanovi.Cast<Osoba>().ToList()).ToList();
            sljedeciOsobaId = l.Aggregate((agg, next) => next.Sifra > agg.Sifra ? next : agg).Sifra + 1;
            foreach (Clan c in clanovi)
                c.Bibl = this;
        }

        public void SerijalizirajUposlenikeBinarno(string path)
        {
            SerijalizujBinarno(path, uposlenici);
        }

        public void DeserijalizirajUposlenikeBinarno(string path)
        {
            uposlenici = DeserijalizujBinarno(path) as List<Uposlenik>;
            List<Osoba> l = uposlenici.Cast<Osoba>().ToList().Concat(clanovi.Cast<Osoba>().ToList()).ToList();
            sljedeciOsobaId = l.Aggregate((agg, next) => next.Sifra > agg.Sifra ? next : agg).Sifra + 1;
            foreach (Uposlenik u in uposlenici)
                u.Bibl = this;
        }

        public void SerijalizirajKnjigeBinarno(string path)
        {
            SerijalizujBinarno(path, knjige);
        }

        public void DeserijalizirajKnjigeBinarno(string path)
        {
            knjige = DeserijalizujBinarno(path) as List<Knjiga>;
            sljedeciKnjigaId = knjige.Aggregate((agg, next) => next.Sifra > agg.Sifra ? next : agg).Sifra + 1;
            foreach (Knjiga k in knjige)
                k.Bibl = this;
        }

        private void SerijalizujBinarno(string path, object objekat)
        {
            IFormatter serijalizer = new BinaryFormatter();
            FileStream streamDatoteke = new FileStream(path, FileMode.Create);
            serijalizer.Serialize(streamDatoteke, objekat);
            streamDatoteke.Close();
        }

        private object DeserijalizujBinarno(string path)
        {
            IFormatter serijalizer = new BinaryFormatter();
            FileStream streamDatoteke = new FileStream(path, FileMode.Open);
            object ret = serijalizer.Deserialize(streamDatoteke);
            streamDatoteke.Close();
            return ret;
        }

        private void SerijalizujXML(string path, object objekat, Type type, List<Type> naslijedjeni = null)
        {

            XmlSerializer xs;
            if (naslijedjeni == null)
                xs = new XmlSerializer(type);
            else
                xs = new XmlSerializer(type, naslijedjeni.ToArray());
            using (Stream s = File.Create(path))
                xs.Serialize(s, objekat);
        }

        private object DeserijalizujXML(string path, Type type, List<Type> naslijedjeni = null)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                XmlReader reader = XmlReader.Create(fs);
                XmlSerializer xs;
                if (naslijedjeni == null)
                    xs = new XmlSerializer(type);
                else
                    xs = new XmlSerializer(type, naslijedjeni.ToArray());
                return xs.Deserialize(reader);
            }
        }

        public void SerijalizirajClanoveXML(string path)
        {
            SerijalizujXML(path, clanovi, typeof(List<Clan>), 
                new List<Type>() { typeof(ClanSaEtfa), typeof(Student), typeof(MasterStudent), typeof(Profesor)});
        }

        public void DeserijalizirajClanoveXML(string path)
        {
            clanovi = DeserijalizujXML(path, typeof(List<Clan>), 
                new List<Type>() { typeof(ClanSaEtfa), typeof(Student), typeof(MasterStudent), typeof(Profesor) }) as List<Clan>;
            sljedeciOsobaId = clanovi.Aggregate((agg, next) => next.Sifra > agg.Sifra ? next : agg).Sifra + 1;
            foreach (Clan c in clanovi)
                c.Bibl = this;
        }

        public void SerijalizirajUposlenikeXML(string path)
        {
            SerijalizujXML(path, uposlenici, typeof(List<Uposlenik>));
        }

        public void DeserijalizirajUposlenikeXML(string path)
        {
            uposlenici = DeserijalizujXML(path, typeof(List<Uposlenik>)) as List<Uposlenik>;
            sljedeciOsobaId = uposlenici.Aggregate((agg, next) => next.Sifra > agg.Sifra ? next : agg).Sifra + 1;
            foreach (Uposlenik u in uposlenici)
                u.Bibl = this;
        }

        public void SerijalizirajKnjigeXML(string path)
        {
            SerijalizujXML(path, knjige, typeof(List<Knjiga>), 
                new List<Type>() { typeof(Strip), typeof(NaucniRad)});
        }

        public void DeserijalizirajKnjigeXML(string path)
        {
            knjige = DeserijalizujXML(path, typeof(List<Knjiga>), 
                new List<Type>() { typeof(Strip), typeof(NaucniRad) }) as List<Knjiga>;
            sljedeciKnjigaId = knjige.Aggregate((agg, next) => next.Sifra > agg.Sifra ? next : agg).Sifra + 1;
            foreach (Knjiga k in knjige)
                k.Bibl = this;
        }

    }
}

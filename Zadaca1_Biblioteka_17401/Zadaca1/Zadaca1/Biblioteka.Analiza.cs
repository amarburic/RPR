using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSBiblioteka {
    public sealed partial class Biblioteka {
        public List<String> listaSvihKnjiga()
        {
            if (knjige.Count == 0)
                throw new Exception("Nema registrovanih knjiga");
            List<String> lista = new List<String>();
            foreach (Knjiga k in knjige)
                lista.Add(k.ToString());
            return lista;
        }

        public List<String> listaSvihClanova()
        {
            if (clanovi.Count == 0)
                throw new Exception("Nema registrovanih clanova");
            List<String> lista = new List<String>();
            foreach (Clan c in clanovi)
                lista.Add(c.ToString());
            return lista;
        }
        
        public List<Knjiga> listaSvihZaduzenihKnjiga()
        {
            return knjige.FindAll(k => k.Zaduzena);
        }

        public List<Knjiga> listaSvihNezaduzenihKnjiga()
        {
            return knjige.FindAll(k => !k.Zaduzena);
        }

        public List<int> dobnaStruktura()
        {
            if (clanovi.Count == 0)
                throw new Exception("Nema registrovanih clanova");
            int kapacitet = (int)Enum.GetNames(typeof(Clan.Dob)).Length;
            List<int> lista = Enumerable.Repeat(0, kapacitet).ToList();
            foreach (Clan c in clanovi)
                lista[(int)c.DobClana]++;
            return lista;
        }

        public List<int> spolnaStruktura()
        {
            if (clanovi.Count == 0)
                throw new Exception("Nema registrovanih clanova");
            int kapacitet = (int)Enum.GetNames(typeof(Clan.Spol)).Length;
            List<int> lista = Enumerable.Repeat(0, kapacitet).ToList();
            foreach (Clan c in clanovi)
            {
                lista[(int)c.SpolOsobe]++;
            }
            return lista;    
        }

        public List<String> najcitanijeKnjige()
        {
            if(knjige.Count == 0)
                throw new Exception("Nema registrovanih knjiga");
            List<String> lista = new List<String>();
            ConcurrentDictionary<Knjiga, int> brojPodizanja = new ConcurrentDictionary<Knjiga, int>();
            System.Threading.Tasks.Parallel.ForEach(knjige, k =>
            {
                System.Threading.Tasks.Parallel.ForEach(k.Transakcije, t =>
                {
                    brojPodizanja.AddOrUpdate(k, (key) => { return 1; }, (key, value) => { return value + 1; });
                });
            });
            var temp = brojPodizanja.ToList();
            temp.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            for (int i = 0; i < Math.Min(10, temp.Count); i++)
                if(temp[i].Value != 0)
                    lista.Add(temp[i].Key.SkraceniInfo());
            if (lista.Count == 0)
                throw new Exception("Nije bilo podizanja knjiga");
            return lista;
        }
        
        public List<String> najcitanijiAutori()
        {
            if (knjige.Count == 0)
                throw new Exception("Nema registrovanih knjiga");
            List<String> lista = new List<String>();
            ConcurrentDictionary<String, int> brojPodizanja = new ConcurrentDictionary<String, int>();
            System.Threading.Tasks.Parallel.ForEach(knjige, k =>
            {
                System.Threading.Tasks.Parallel.ForEach(k.Transakcije, t =>
                {
                    if (t.TipTransakcije == Transakcija.Tip.Zaduzenje)
                        System.Threading.Tasks.Parallel.ForEach(TraziKnjiguPoSifri(t.Knjiga).Autori, autor =>
                        {
                           brojPodizanja.AddOrUpdate(autor, (key) => { return 1; }, (key, value) => { return value + 1; });     
                        });
                });
            });
            var temp = brojPodizanja.ToList();
            temp.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            for (int i = 0; i < Math.Min(10, temp.Count); i++)
                if (temp[i].Value != 0)
                      lista.Add(temp[i].Key);
            if (lista.Count == 0)
                throw new Exception("Nije bilo podizanja knjiga");
            return lista;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumBiblioteka {
    [Serializable]
    public class Datum {
        private int dan, mjesec, godina;

        public Datum()
        {
            dan = DateTime.Now.Day;
            mjesec = DateTime.Now.Month;
            godina = DateTime.Now.Year;
        }

        public Datum(int dan, int mjesec, int godina)
        {
            if (!ValidirajDatum(dan, mjesec, godina))
                throw new Exception("Neispravan datum");
            this.dan = dan;
            this.mjesec = mjesec;
            this.godina = godina;
        }

        public Datum(DateTime dt)
        {
            this.dan = dt.Day;
            this.mjesec = dt.Month;
            this.godina = dt.Year;
        }

        private bool ValidirajDatum(int dan, int mjesec, int godina)
        {
            int[] daniUMjesecu = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (godina < 0 || mjesec < 0 || mjesec > 12 || dan < 0 || dan > daniUMjesecu[mjesec - 1])
                return false;
            if (mjesec == 2 && !(godina % 4 == 0 && !(godina % 100 == 0 && !(godina % 400 == 0))) && dan > 28)
                return false;
            return true;
        }

        public static Datum Trenutni()
        {
            return new Datum(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
        }

        public static bool operator <(Datum d1, Datum d2)
        {
            return Uporedi(d1, d2) < 0;
        }

        public static bool operator >(Datum d1, Datum d2)
        {
            return Uporedi(d1, d2) > 0;
        }

        public static bool operator ==(Datum d1, Datum d2)
        {
            return Uporedi(d1, d2) == 0;
        }

        public static bool operator !=(Datum d1, Datum d2)
        {
            return Uporedi(d1, d2) != 0;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Datum)) return false;

            return this == (Datum)obj;
        }

        public static bool operator <=(Datum d1, Datum d2)
        {
            return Uporedi(d1, d2) <= 0;
        }

        public static bool operator >=(Datum d1, Datum d2)
        {
            return Uporedi(d1, d2) >= 0;
        }

        public static int Uporedi(Datum d1, Datum d2)
        {
            if (d1.godina - d2.godina != 0)
                return d1.godina - d2.godina;
            if (d1.mjesec - d2.mjesec != 0)
                return d1.mjesec - d2.mjesec;
            if (d1.dan - d2.dan != 0)
                return d1.dan - d2.dan;
            return 0;
        }
        
        public Datum Pomakni(int dani)
        {
            DateTime d = kaoDateTime().AddDays(dani);
            return new Datum(d.Day, d.Month, d.Year);
        }   
        
        public DateTime kaoDateTime()
        {
            return new DateTime(godina, mjesec, dan);
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}",
                dan.ToString().PadLeft(2, '0'),
                mjesec.ToString().PadLeft(2, '0'),
                godina.ToString().PadLeft(4, '0'));
        }

        public int Dan
        {
            get
            {
                return dan;
            }
            set
            {
                if (!ValidirajDatum(value, mjesec, godina))
                    throw new Exception("Neispravan datum");
                dan = value;
            }
        }

        public int Mjesec
        {
            get
            {
                return mjesec;
            }
            set
            {
                if (!ValidirajDatum(dan, value, godina))
                    throw new Exception("Neispravan datum");
                mjesec = value;
            }
        }

        public int Godina
        {
            get
            {
                return godina;
            }
            set
            {
                if (!ValidirajDatum(dan, mjesec, value))
                    throw new Exception("Neispravan datum");
                godina = value;
            }
        }
    }
}

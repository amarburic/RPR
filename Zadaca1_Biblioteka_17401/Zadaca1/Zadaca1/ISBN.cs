using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatumBiblioteka;

namespace NSBiblioteka {
    [Serializable]
    public class ISBN {
        public enum TipIsbna { ISBN10, ISBN13 }

        private readonly static Datum DatumPromjene = new Datum(1, 1, 2007); 

        public String vrijednost { get; set; }
        private delegate bool TipIsbnValidacije(String s);
        public TipIsbna tip { get; set; } 
        
        public ISBN() { }

        public ISBN(String vrijednost)
        {
            if (!ValidirajISBN(vrijednost))
                throw new Exception("Neispravan ISBN");
            this.vrijednost = vrijednost;
            this.tip = (vrijednost.Count() == 10) ? TipIsbna.ISBN10 : TipIsbna.ISBN13;
        }

        public override string ToString()
        {
            return vrijednost;
        }

        public bool ValidirajISBNTip(Datum datum)
        {
            if (datum < DatumPromjene && tip != TipIsbna.ISBN10
                || datum >= DatumPromjene && tip != TipIsbna.ISBN13)
                return false;
            return true;
        }

        public bool ValidirajISBNTip(int godina)
        {
            return ValidirajISBNTip(new Datum(1, 1, godina));
        }

        private bool ValidirajISBN(String ISBN)
        {
            TipIsbnValidacije delegat = null; 
            if (ISBN.Length != 0)
            {
                if (ISBN.Contains("-"))
                    ISBN = ISBN.Replace("-", "");
                for (int i = 0; i < ISBN.Length - 1; i++)
                    if (!char.IsDigit(ISBN[i]))
                        return false;

                if (ISBN.Length == 10)
                    delegat = ValidirajISBN10;
                else if (ISBN.Length == 13)
                    delegat = ValidirajISBN13;
                else delegat = ((s) => false );
            }

            return delegat(ISBN);
        }

        private bool ValidirajISBN10(String ISBN)
        {
            bool ispravan = false;

            char zadnjaCifra = ISBN[ISBN.Length - 1];

            int suma = 0;
            for (int i = 0; i < 9; i++)
                suma += int.Parse(ISBN[i].ToString()) * (i + 1);

            suma %= 11;
            int temp;

            if (zadnjaCifra == 'X')
                ispravan = (suma == 10);
            else if (int.TryParse(zadnjaCifra.ToString(), out temp))
                ispravan = (suma == int.Parse(zadnjaCifra.ToString()));
            else return false;
            return ispravan;
        }

        private bool ValidirajISBN13(string ISBN)
        {
            bool ispravan = false;
            if (!char.IsDigit(ISBN[ISBN.Length - 1]))
                return false;
            int suma = 0;
            for (int i = 0; i < 12; i++)
                suma += int.Parse(ISBN[i].ToString()) * (i % 2 == 1 ? 3 : 1);

            suma %= 10;
            int kontrolnaCifra = 10 - suma;
            if (kontrolnaCifra == 10)
                kontrolnaCifra = 0;

            ispravan = (kontrolnaCifra == int.Parse(ISBN[12].ToString()));

            return ispravan;
        }
 
    }
}

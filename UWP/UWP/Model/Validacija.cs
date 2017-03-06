using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Enumeracija;

namespace UWP.Model {
    public class Validacija {

        public static void ValidirajJMBG(String MaticniBroj, Spol SpolClana, DateTime DatumRodjenja)
        {
            if (MaticniBroj.Length != 13)
                throw new Exception("Neispravna duzina JMBGa");
            foreach (char c in MaticniBroj)
                if (c < '0' || c > '9')
                    throw new Exception("Neispravni znakovi JMBGa");
            int dd = int.Parse(MaticniBroj.Substring(0, 2));
            int mm = int.Parse(MaticniBroj.Substring(2, 2));
            int ggg = int.Parse(MaticniBroj.Substring(4, 3));
            if (ggg / 100 != 0)
                ggg += 1000;
            else
                ggg += 2000;
            if (new DateTime(ggg, mm, dd) != DatumRodjenja)
                throw new Exception("Neispravan datum JMBGa");
            int bbb = int.Parse(MaticniBroj.Substring(9, 3));
            if (bbb < 500 && SpolClana == Spol.Zensko || bbb > 499 && SpolClana == Spol.Musko)
                throw new Exception("Neispravan spol JMBGa");
            int[] cifre = MaticniBroj.Select(cifra => int.Parse(cifra.ToString())).ToArray();
            int k = 0;
            for (int i = 0; i < 6; i++)
                k += (7 - i) * (cifre[i] + cifre[i + 6]);
            k %= 11;
            k = 11 - k;
            if (k != cifre[12])
                throw new Exception("Neispravna kontrolna vrijednost JMBGa");
        }

        public static void ValidirajISBN(String ISBN)
        {
            if (ISBN.Length != 0)
            {
                if (ISBN.Contains("-"))
                    ISBN = ISBN.Replace("-", "");
                for (int i = 0; i < ISBN.Length - 1; i++)
                    if (!char.IsDigit(ISBN[i]))
                        throw new Exception("Nelegalni karakteri u isbnu");

                if (ISBN.Length == 10)
                    ValidirajISBN10(ISBN);
                else if (ISBN.Length == 13)
                    ValidirajISBN13(ISBN);
                else throw new Exception("Neispravan broj cifara Isbna.");
            }

        }

        private static void ValidirajISBN10(String ISBN)
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
            if (!ispravan)
                throw new Exception("Isbn nije validan");
        }

        private static void ValidirajISBN13(string ISBN)
        {
            bool ispravan = false;
            if (!char.IsDigit(ISBN[ISBN.Length - 1]))
                throw new Exception("Isbn se sastoji od nelegalnih karaktera");
            int suma = 0;
            for (int i = 0; i < 12; i++)
                suma += int.Parse(ISBN[i].ToString()) * (i % 2 == 1 ? 3 : 1);

            suma %= 10;
            int kontrolnaCifra = 10 - suma;
            if (kontrolnaCifra == 10)
                kontrolnaCifra = 0;

            ispravan = (kontrolnaCifra == int.Parse(ISBN[12].ToString()));
            if(!ispravan)
                throw new Exception("Isbn nije validan");
        }
    }
}

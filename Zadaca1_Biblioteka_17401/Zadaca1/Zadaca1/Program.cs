using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatumBiblioteka;

namespace NSBiblioteka {
    public class Program {
        /*
        static void Main(string[] args)
        {
            Biblioteka biblioteka = new Biblioteka();
            biblioteka.RegistrujKnjigu("Gospodar prstenova", new List<String> { "J R. R. Tolkien" }, "9780007273508", "Svjetlost", 2009);
            biblioteka.RegistrujKnjigu("Sofijin svijet", new List<String> { "Jostein Gardeer" }, "9785050048882", "Geopoetika", 2008);
            biblioteka.RegistrujKnjigu("Stranac", new List<String> { "Albert Camus" }, "0679720200", "Alnari", 2003);
            biblioteka.RegistrujClana("Amar", "Buric", "1106996190001", new Datum(11, 06, 1996), "", Clan.Spol.Musko);
            biblioteka.RegistrujClana("Rasim", "Sabanovic", "0212996174139", new Datum(2, 12, 1996), "", Clan.Spol.Musko);
            biblioteka.RegistrujClana("Neira", "Pulo", "2207996175015", new Datum(22, 7, 1996), "", Clan.Spol.Zensko, Clan.TipClana.Student);
            Meni meni = new Meni(biblioteka);
            meni.Prikazi();
        }
        */

        public static readonly bool DEBUG = false;
        public static readonly bool POKRENI_BEZ_UCITAVANJA = false;

        [STAThread]
        static void Main()
        {
            Biblioteka biblioteka = new Biblioteka();
            BazaPodataka baza = new BazaPodataka(biblioteka);
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login(biblioteka, baza));
            }
            catch
            {
                MessageBox.Show("Doslo je do greske");
            }
            finally
            {
             //   baza.SpasiPodatke();
            }
        }
    }
}

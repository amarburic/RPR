using DatumBiblioteka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBiblioteka {
    public partial class Login : Form {

        Biblioteka bibl;
        BazaPodataka baza; 

        int pozicijaPoligona, smjerPoligona, rotacijaSiljaka;
        System.Threading.Timer mTimer;
        private const int BRZINA_ANIMACIJE = 50; 

        public Login(Biblioteka bibl, BazaPodataka baza)
        {
            InitializeComponent();
            this.bibl = bibl;
            this.baza = baza;
            
            Task.Factory.StartNew(() =>
            {
                var ucitavanjeForma = new UcitavanjeForma("Učitavanje iz baze");
                BeginInvoke(new Action(() => ucitavanjeForma.Show()));
                BeginInvoke(new Action(() => ucitavanjeForma.BringToFront()));
                try
                {
                    baza.UcitajPodatke();
                } catch(Exception e)
                {
                    if(e.Message == "Konekcija")
                        MessageBox.Show("Došlo je do problema pri povezivanju sa bazom. Učitavam hardkodirane vrijednosti. Progres neće biti spašen u bazu.");
                    bibl.UcitajDefaultne();
                }
                BeginInvoke(new Action(() => ucitavanjeForma.Close()));
            });


            Resetuj();
            textBoxUsername.Text = "admin";
            textBoxLozinka.Text = "admin";
            pozicijaPoligona = smjerPoligona = rotacijaSiljaka = 0;

            TimerCallback timercb = new TimerCallback(SljedeciFrejm);
            mTimer = new System.Threading.Timer(timercb, null, 0, BRZINA_ANIMACIJE);
        }

        protected void SljedeciFrejm(object o)
        {
            rotacijaSiljaka += 10;
            pozicijaPoligona += smjerPoligona * 10;
            if (pozicijaPoligona <= 0)
                smjerPoligona = 1;
            else if (pozicijaPoligona >= 80)
                smjerPoligona = -1;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.Graphics mojGrafickiObjekat; // Kreiranje vlastitog Graphics objekta
            mojGrafickiObjekat = this.CreateGraphics();
            SolidBrush mojBrush = new SolidBrush(System.Drawing.Color.Red);
            Pen pen = new Pen(System.Drawing.Color.Black, 3);
            Pen penOkvir = new Pen(System.Drawing.Color.Black, 1);
            Point[][] Siljci = new Point[4][]; // Definisanje niza tačaka
            for (int i = 0; i < 4; i++)
                Siljci[i] = new Point[3];
            int centarx = this.Width / 2, centary = this.Height / 4;
            int velSredine = 10, visina = 90;

         //   mojGrafickiObjekat.DrawRectangle(penOkvir, new Rectangle(10, 10, Width - 10, Height / 2 - 10));

            Siljci[0][0] = new Point(centarx - velSredine, centary + velSredine);
            Siljci[0][1] = new Point(centarx - velSredine, centary - velSredine);
            Siljci[0][2] = new Point(centarx - visina, centary);

            Siljci[1][0] = new Point(centarx - velSredine, centary - velSredine);
            Siljci[1][1] = new Point(centarx + velSredine, centary - velSredine);
            Siljci[1][2] = new Point(centarx, centary - visina);

            Siljci[2][0] = new Point(centarx + velSredine, centary - velSredine);
            Siljci[2][1] = new Point(centarx + velSredine, centary + velSredine);
            Siljci[2][2] = new Point(centarx + visina, centary);

            Siljci[3][0] = new Point(centarx + velSredine, centary + velSredine);
            Siljci[3][1] = new Point(centarx - velSredine, centary + velSredine);
            Siljci[3][2] = new Point(centarx, centary + visina);

            for(int i = 0; i < Siljci.Count(); i++)
                for(int j = 0; j < Siljci[0].Count(); j++)
                    Siljci[i][j] = Rotate(Siljci[i][j], new Point(centarx, centary), rotacijaSiljaka);
            for (int i = 0; i < 4; i++)
            {
                mojGrafickiObjekat.FillPolygon(mojBrush, Siljci[i]);
                mojGrafickiObjekat.DrawPolygon(pen, Siljci[i]);
            }

            Point[] Sredina = new Point[4];
            for (int i = 0; i < 4; i++)
                Sredina[i] = new Point(Siljci[i][0].X, Siljci[i][0].Y);
            mojGrafickiObjekat.FillPolygon(mojBrush, Sredina);

            Point[][] Poligoni = new Point[4][];
            for (int i = 0; i < 4; i++)
                Poligoni[i] = new Point[4];

            int kracaOsnovica = 10, duzaOsnovica = 20, sirina = 50;

            Poligoni[0][0] = new Point(centarx - pozicijaPoligona, centary + duzaOsnovica);
            Poligoni[0][1] = new Point(centarx - pozicijaPoligona, centary - duzaOsnovica);
            Poligoni[0][2] = new Point(centarx - pozicijaPoligona - sirina, centary + kracaOsnovica);
            Poligoni[0][3] = new Point(centarx - pozicijaPoligona - sirina, centary - kracaOsnovica);

            Poligoni[1][0] = new Point(centarx + pozicijaPoligona, centary + duzaOsnovica);
            Poligoni[1][1] = new Point(centarx + pozicijaPoligona, centary - duzaOsnovica);
            Poligoni[1][2] = new Point(centarx + pozicijaPoligona + sirina, centary + kracaOsnovica);
            Poligoni[1][3] = new Point(centarx + pozicijaPoligona + sirina, centary - kracaOsnovica);

            for (int i = 2 ; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    Poligoni[i][j] = Rotate(Poligoni[i - 2][j], new Point(centarx, centary), 90);

            mojBrush.Color = Color.Blue;

            for (int i = 0; i < 2; i++)
                mojGrafickiObjekat.FillPolygon(mojBrush, Poligoni[i]);

            mojBrush.Color = Color.Green;

            for (int i = 2; i < 4; i++)
                mojGrafickiObjekat.FillPolygon(mojBrush, Poligoni[i]);

            for (int i = 0; i < 4; i++)
                mojGrafickiObjekat.DrawPolygon(pen, Poligoni[i]);
        }

        public static Point Rotate(Point point, Point pivot, double angleDegree)
        {
            double angle = angleDegree * Math.PI / 180;
            double cos = Math.Cos(angle);
            double sin = Math.Sin(angle);
            int dx = point.X - pivot.X;
            int dy = point.Y - pivot.Y;
            double x = cos * dx - sin * dy + pivot.X;
            double y = sin * dx + cos * dy + pivot.Y;

            Point rotated = new Point((int)Math.Round(x), (int)Math.Round(y));
            return rotated;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!baza.Spasena && baza.Ucitana && !baza.PokusajSpasavanja)
            {
                e.Cancel = true;
                Task.Factory.StartNew(() =>
                {
                    SpasiBazu();
                });
            }

        }

        private void SpasiBazu()
        {
            var ucitavanjeForma = new UcitavanjeForma("Spašavanje u bazu");
            Invoke(new Action(() => ucitavanjeForma.Show()));
            try
            {
                baza.SpasiPodatke();
            } catch
            {
                MessageBox.Show("Došlo je do problema. Podaci nisu spašeni.");
            }
            Invoke(new Action(() => ucitavanjeForma.Close()));
            Invoke(new Action(() => this.Close()));
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void Resetuj()
        {
            textBoxLozinka.Text = "";
            textBoxUsername.Text = "";
            errorProvider1.SetError(textBoxLozinka, "");
            errorProvider2.SetError(textBoxUsername, "");
            toolStripStatusLabel1.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String korisnickoIme = textBoxUsername.Text, lozinka = textBoxLozinka.Text;
            try
            {
                if (bibl.JeAdmin(korisnickoIme, lozinka))
                {
                    var f = new AdminForma(bibl);
                    f.Show(this);
                    Visible = false;
                }
                else
                {
                    Osoba o = bibl.TraziPoUlozi(korisnickoIme, lozinka);
                    if (o is Clan)
                    {
                        (new ClanForma(o as Clan)).Show(this);
                        Visible = false;
                    }
                    else if (o is Uposlenik)
                    {
                        Uposlenik u = o as Uposlenik;
                        if (u.TipUposlenika == Uposlenik.Tip.Uposlenik)
                            (new UposlenikForma(u)).Show(this);
                        else
                            (new OstaliUposleniciForma(u)).Show(this);
                        Visible = false;
                    }
                }
                Resetuj();
            } catch (Exception exc)
            {
                String greska = exc.Message;
                errorProvider1.SetError(textBoxLozinka, greska);
                errorProvider2.SetError(textBoxUsername, greska);
                toolStripStatusLabel1.Text = greska;
               
            }
        }
    }
}

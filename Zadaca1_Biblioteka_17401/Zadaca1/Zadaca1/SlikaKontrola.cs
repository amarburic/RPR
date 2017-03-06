using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBiblioteka {
    public partial class SlikaKontrola : UserControl {
        public SlikaKontrola()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonOdabir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK && !String.IsNullOrWhiteSpace(ofd.FileName))
            {
                pictureBoxSlika.Image = ResizeImage(Image.FromFile(ofd.FileName), pictureBoxSlika.Size);
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if(dateTimePicker1.Value.CompareTo(DateTime.Now.AddMonths(-3)) < 0)
            {
                errorProvider1.SetError(dateTimePicker1, "Prestara slika");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dateTimePicker1, "");
            }
        }

        public void Popuni(Image Slika, DateTime DatumSlikanja)
        {
            this.Slika = Slika;
            this.DatumSlikanja = DatumSlikanja;
        }

        public void Zakljucaj()
        {
            dateTimePicker1.Visible = false;
            buttonOdabir.Visible = false;
            pictureBoxSlika.Size =
                new Size(pictureBoxSlika.Size.Width,
                dateTimePicker1.Location.Y +
                dateTimePicker1.Height -
                pictureBoxSlika.Location.Y);
            if(pictureBoxSlika.Image != null)
                pictureBoxSlika.Image =
                    ResizeImage(pictureBoxSlika.Image, pictureBoxSlika.Size);
        }

        public void Resetuj()
        {
            Slika = null;
            DatumSlikanja = DateTime.Now;

        }

        private Image ResizeImage(Image stara, Size novaVelicina)
        {
            return (Image)(new Bitmap(stara, novaVelicina));
        }

        public DateTime DatumSlikanja { get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; } }
        public Image Slika { get { return pictureBoxSlika.Image;  }
            set {
                if (value != null)
                    pictureBoxSlika.Image = ResizeImage(value, pictureBoxSlika.Size);
                else
                    pictureBoxSlika.Image = null;
            } }
    }
}

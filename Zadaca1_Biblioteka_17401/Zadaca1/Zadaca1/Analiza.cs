using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBiblioteka {
    public partial class Analiza : Form {

        public enum TipAnalize { SpolnaStruktura, DobnaStruktura}

        Biblioteka bibl;
        TipAnalize tip;

        int[] Values;
        string[] Legend;

        private Brush[] SliceBrushes =
        {
            Brushes.Red,
            Brushes.Blue,
            Brushes.Green,
            Brushes.Orange,
            Brushes.LightGreen,
      
            Brushes.LightBlue,
            
            Brushes.Lime,
            
            Brushes.Fuchsia,
            Brushes.Yellow,
            Brushes.Cyan,
        };

        private Pen[] SlicePens = { Pens.Black };


        public Analiza(Biblioteka bibl, TipAnalize tip)
        {
            InitializeComponent();
            this.bibl = bibl;
            this.tip = tip;
            if (tip == TipAnalize.SpolnaStruktura)
            {
                Values = bibl.spolnaStruktura().ToArray();
                Legend = new string[] { "Muskarci", "Žene", "Ostali" };
            }
            else if (tip == TipAnalize.DobnaStruktura)
            {
                Values = bibl.dobnaStruktura().ToArray();
                Legend = new string[] { "Dijete", "Tinejdžer", "Odrasli", "Stariji" };
            }

        }

        private void Analiza_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            if ((ClientSize.Width < 20) || (ClientSize.Height < 20)) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(
                10, 10, ClientSize.Height - 20, ClientSize.Height - 20);
            Rectangle rect2 = new Rectangle(
                rect.Right + 10, rect.Top, 20, 20);
            Rectangle rect3 = new Rectangle(
                rect2.Right + 10, rect2.Top, 60, rect2.Height);
            int yoffset = 10;
            DrawPieChart(e.Graphics, rect, SliceBrushes, SlicePens, Values);
            DrawLegend(e.Graphics, rect2, rect3, yoffset, SliceBrushes, SlicePens, Legend);
        }

        private static void DrawPieChart(Graphics gr,
            Rectangle rect, Brush[] brushes, Pen[] pens,
            int[] values)
        {
            float total = values.Sum();

            float start_angle = 0;
            for (int i = 0; i < values.Length; i++)
            {
                float sweep_angle = values[i] * 360f / total;
                gr.FillPie(brushes[i % brushes.Length],
                    rect, start_angle, sweep_angle);
                gr.DrawPie(pens[i % pens.Length],
                    rect, start_angle, sweep_angle);
                start_angle += sweep_angle;
            }
        }

        private void DrawLegend(Graphics gr, Rectangle rect, Rectangle rect2, int offset, Brush[] brushes, Pen[] pens, string[] vrijednosti)
        {
            for (int i = 0; i < vrijednosti.Count(); i++)
            {
                gr.FillRectangle(brushes[i], rect);
                gr.DrawRectangle(pens[0], rect);
                gr.DrawString(vrijednosti[i], Font, new SolidBrush(ForeColor),
                           rect2);
                rect = new Rectangle(rect.Left, rect.Bottom + offset, rect.Right - rect.Left, rect.Bottom - rect.Top);
                rect2 = new Rectangle(rect2.Left, rect2.Bottom + offset, rect2.Width, rect2.Height);
            }
            
        }
    }
}

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
    public partial class ClanKontrola : UserControl {

        public ClanKontrola()
        {
            InitializeComponent();
            maskedTextBoxClanarina.Enabled = false;
            comboBoxPlacanje.SelectedIndex = 0;
            comboBoxTip.SelectedIndex = 0;
        }

        public void Popuni(Clan c)
        {
            osobaKontrola1.Popuni(c);
            comboBoxPlacanje.SelectedIndex = (int)c.TipPlacanjaClanarine;
            comboBoxTip.SelectedIndex = (int)c.TipClanaBiblioteke;
            textBoxKomentar.Text = c.Komentar;
            maskedTextBoxClanarina.Text = c.Clanarina.ToString("0#.## KM");
        }

        public void Zakljucaj()
        {
            osobaKontrola1.Zakljucaj();
            comboBoxPlacanje.Enabled = false;
            comboBoxTip.Enabled = false;
            textBoxKomentar.ReadOnly = true;
        }

        public void ZakljucajTipClana()
        {
            comboBoxTip.Enabled = false;
        }

        public void OtkljucajKomentar()
        {
            textBoxKomentar.ReadOnly = false;
        }

        public void Resetuj()
        {
            comboBoxPlacanje.SelectedIndex = 0;
            comboBoxTip.SelectedIndex = 0;
            textBoxKomentar.Text = "";
            maskedTextBoxClanarina.Text = "";
        }

        public Clan.TipPlacanja Placanje { get { return (Clan.TipPlacanja)comboBoxPlacanje.SelectedIndex; } }
        public Clan.TipClana Tip { get { return (Clan.TipClana)comboBoxTip.SelectedIndex; } }
        public String Komentar { get { return textBoxKomentar.Text;  } }
        public OsobaKontrola OsobaKontrola1 { get { return osobaKontrola1; } }

    }
}

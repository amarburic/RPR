using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBiblioteka {
    public partial class UcitavanjeForma : Form {
        string Poruka;
        int brojTacaka;
        bool ugasena;
        System.Threading.Timer mTimer;
        private const int BRZINA_ANIMACIJE = 500;
        public UcitavanjeForma(String poruka)
        {
            Poruka = poruka;
            brojTacaka = 0;
            InitializeComponent();
            ugasena = false;
            TimerCallback timercb = new TimerCallback(Refresh);
            mTimer = new System.Threading.Timer(timercb, null, 0, BRZINA_ANIMACIJE);
        }

        protected void Refresh(object o)
        {
            if (IsHandleCreated && !label1.IsDisposed)
            {
                brojTacaka = (brojTacaka + 1) % 4;
                Invoke(new Action(() => { if (!ugasena) label1.Text = Poruka + new String('.', brojTacaka);  }));
            }
        }

        private void UcitavanjeForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            ugasena = true;
            
        }

        private void UcitavanjeForma_Load(object sender, EventArgs e)
        {
        }
    }
}

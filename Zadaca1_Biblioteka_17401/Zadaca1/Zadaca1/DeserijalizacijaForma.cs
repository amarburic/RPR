using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBiblioteka
{
    public partial class DeserijalizacijaForma : Form
    {

        List<object> lista;
        public DeserijalizacijaForma(List<object> list)
        {
            this.lista = list;
            InitializeComponent();
            PopuniListu();
        }

        private void PopuniListu()
        {
            foreach (object o in lista)
                listBoxDeserijalizovani.Items.Add(o.ToString());
        }
    }
}

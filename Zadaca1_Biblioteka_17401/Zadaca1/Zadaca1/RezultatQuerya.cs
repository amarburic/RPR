using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBiblioteka {
    public partial class RezultatQuerya : Form {
        DataSet ds;
        public RezultatQuerya(DataSet ds)
        {
            this.ds = ds;
            InitializeComponent();
            dataGridViewRezultat.DataSource = ds.Tables[0].DefaultView;
        }
    }
}

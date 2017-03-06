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
    public partial class StanjeForma : Form {

        Biblioteka bibl;
        Type tip;

        public StanjeForma(Biblioteka bibl, Type tip)
        {
            this.bibl = bibl;
            this.tip = tip;
            InitializeComponent();
            if(tip == typeof(Knjiga))
            {
                PostaviNaKnjige();
            }
            else if(tip == typeof(Clan))
            {
                PostaviNaClanove();
            }


        }

        public void PostaviNaClanove()
        {
            groupBoxZaduzeno.Text = "Zaduženja članova";
            groupBoxNezaduzeno.Text = "Lista svih članova";

            treeViewZaduzenja.Nodes.Clear();

            foreach (Clan c in bibl.Clanovi)
            {
                if (c.ZaduzeneKnjige.Count != 0)
                {
                    treeViewZaduzenja.Nodes.Add(c.Ime + " " + c.Prezime);
                    var djeca = treeViewZaduzenja.Nodes[treeViewZaduzenja.GetNodeCount(false) - 1].Nodes;
                    foreach (Knjiga k in c.ZaduzeneKnjigeRef)
                    {
                        djeca.Add(k.Naslov + " - " + k.AutoriKaoString());
                    }
                }

            }

            listBoxSlobodno.Items.Clear();

            foreach (Clan c in bibl.Clanovi)
            {
                listBoxSlobodno.Items.Add(c);
            }

            pređiNaČlanoveToolStripMenuItem.Visible = false;
            pređiNaKnjigeToolStripMenuItem.Visible = true;
        }

        public void PostaviNaKnjige()
        {


            groupBoxZaduzeno.Text = "Zadužene knjige";
            groupBoxNezaduzeno.Text = "Knjige u biblioteci";

            treeViewZaduzenja.Nodes.Clear();

            foreach (Knjiga k in bibl.listaSvihZaduzenihKnjiga())
            {
                Clan zaduzenik = bibl.TraziClanaPoSifri(k.Zaduzenik);
                treeViewZaduzenja.Nodes.Add(k.Naslov).Nodes.Add(zaduzenik.Ime + " " + zaduzenik.Prezime);
            }

            listBoxSlobodno.Items.Clear();

            foreach (Knjiga k in bibl.listaSvihNezaduzenihKnjiga())
            {
                listBoxSlobodno.Items.Add(k);
            }

            pređiNaČlanoveToolStripMenuItem.Visible = true;
            pređiNaKnjigeToolStripMenuItem.Visible = false;
        }

        private void pređiNaČlanoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostaviNaClanove();
        }

        private void pređiNaKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostaviNaKnjige();
        }

        private void expandujSveNodoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewZaduzenja.ExpandAll();
        }

        private void skupiSveNodoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewZaduzenja.CollapseAll();
        }
    }
}

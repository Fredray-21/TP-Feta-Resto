using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_FETA_RESTO
{
    public partial class frmPanier : Form
    {
        public frmPanier()
        {
            InitializeComponent();

            this.pnlPanier.Controls.Clear();
            int x = 10;
            int y = 10;
            List<Formule> PanierDistinct = new List<Formule>();
            foreach (Formule f in ORMmySQL.Panier)
            {
                if (PanierDistinct.Contains(f) != true)
                {
                    PanierDistinct.Add(f);
                }
            }

            foreach (Formule f in PanierDistinct)
            {
                CardPanier CardPanier = new CardPanier() { Location = new Point(x, y), TopLevel = false, TopMost = true };
                CardPanier.FormBorderStyle = FormBorderStyle.None;
                // ici les edit de label
                int multiplicateur = 0;
                foreach (Formule formule in ORMmySQL.Panier)
                {
                    if (formule.Equals(f))
                    {
                        multiplicateur++;
                    }
                }
                CardPanier.lblMultiplicateur.Text = "x"+multiplicateur.ToString();
                CardPanier.lblNOFORMULE.Text = f.GetIdFormule().ToString();
                this.pnlPanier.Controls.Add(CardPanier);
                CardPanier.Show();
                x = 10;
                y = y + 210;
            }
            CardPanier CardFin = new CardPanier() { Enabled = false, Visible = false, Location = new Point(x, y), BackColor = Color.FromArgb(50, 50, 50), Size = new Size(20, 5), TopLevel = false, TopMost = true };
            CardFin.FormBorderStyle = FormBorderStyle.None;
            this.pnlPanier.Controls.Add(CardFin);
            CardFin.Show();
        }
    }
}

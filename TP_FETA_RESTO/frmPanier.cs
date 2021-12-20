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
            List<Formule> Panier = ORMmySQL.Panier;

            foreach (Formule f in Panier)
            {
                CardPanier CardPanier = new CardPanier() { Location = new Point(x, y), TopLevel = false, TopMost = true };
                CardPanier.FormBorderStyle = FormBorderStyle.None;
                // ici les edit de label
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

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
    public partial class CardPanier : Form
    {
        public CardPanier()
        {
            InitializeComponent();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            int IdFormule = Convert.ToInt32(lblNOFORMULE.Text.Split("°")[1]);
            foreach (Formule f in ORMmySQL.Panier)
            {

                if (f.GetIdFormule().Equals(IdFormule))
                {
                    ORMmySQL.Panier.Remove(f);
                    break;
                }
            }

            Compte c = ORMmySQL.CurrentUser;
            Acceuil MajAcceuil = new Acceuil();
            MajAcceuil.lblUserName.Text = c.GetNom() + " " + c.GetPrenom();
            MajAcceuil.lblType.Text = "Type : " + c.GetTypeCompte();
            MajAcceuil.lblType.Visible = true;
            MajAcceuil.btnConnexion.Text = "Mon Compte";

            if (c.GetTypeCompte() == "ADM" || c.GetTypeCompte() == "GES")
            {
                MajAcceuil.pnlAdmin.Visible = true;
            }
            if (c != null)
            {
                MajAcceuil.btnPanier.Visible = true;
                MajAcceuil.btnMesReservation.Visible = true;
            }
            MajAcceuil.Show();
            ((Acceuil)Application.OpenForms["frm" + (ORMmySQL._counterForm - 2).ToString()]).Hide(); // cache le formulaire d'avant

            MessageBox.Show("Une formule N°" + IdFormule.ToString() + " à bien été retiré du panier");

        }
    }
}

// MAJ à jour  -->  seulement du form et pas du full acceuil


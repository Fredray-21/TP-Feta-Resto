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
    public partial class CardFormules : Form
    {
        public CardFormules()
        {
            InitializeComponent();
            Compte c = ORMmySQL.CurrentUser;
            if (c != null)
            {
                btnReserveCard.Visible = true;
            }
        }

        private void btnReserveCard_Click(object sender, EventArgs e)
        {
            Compte c = ORMmySQL.CurrentUser;
            if (c == null)
            {
                MessageBox.Show($"Veuillez-vous connecter afin de réserver", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string[] TabTextBTN = btnReserveCard.Text.Split('°');
                int idFormule = Int32.Parse(TabTextBTN[1]);
                Formule f = ORMmySQL.GetFormule(idFormule);
                if (f != null)
                {
                    ORMmySQL.Panier.Add(f);
                    MessageBox.Show($"La Formule N°{idFormule} a été ajouté au Panier", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnGestionDelFormule_Click(object sender, EventArgs e)
        {
            string[] TabTextBTN = btnReserveCard.Text.Split('°');
            int idFormule = Int32.Parse(TabTextBTN[1]);
            if (idFormule != -1)
            {
                DialogResult dialogResult = MessageBox.Show($"Etes vous sur de vouloir supprimé la Formule N°{idFormule} ", "Voulez-vous vraiment Supprimé la Formule", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (ORMmySQL.DeleteFormule(idFormule))
                    {
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
                        }

                        MajAcceuil.Show();
                        ((Acceuil)Application.OpenForms["frm" + (ORMmySQL._counterForm - 2).ToString()]).Hide(); 

                        MessageBox.Show($"La Formule N°{idFormule} a bien été Supprimé", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"La Formule N°{idFormule} n'a pas été Supprimé", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
    }
}

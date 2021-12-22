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
    public partial class frmEditCompte : Form
    {
        public frmEditCompte()
        {
            InitializeComponent();
            MAJvalueTxtB();
        }

        public void MAJvalueTxtB()
        {
            Compte c = ORMmySQL.CurrentUser;
            if (c != null)
            {
                txtbNom.Text = c.GetNom();
                txtBprenom.Text = c.GetPrenom();
                txtBmail.Text = c.GetAdressMail();
                txtBtel.Text = c.GetnoTel();
            }
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            btnModifier.Visible = false;
            btnValiderEdit.Visible = true;
            btnAnnulerEdit.Visible = true;
            btnValiderEdit.Location = new System.Drawing.Point(598, 402); 
            btnAnnulerEdit.Location = new System.Drawing.Point(392, 402);


            txtbNom.Enabled = true;
            txtBprenom.Enabled = true;
            txtBmail.Enabled = true;
            txtBtel.Enabled = true;
        }

        private void btnAnnulerEdit_Click(object sender, EventArgs e)
        {
            btnModifier.Visible = true;
            btnValiderEdit.Visible = false;
            btnAnnulerEdit.Visible = false;

            txtbNom.Enabled = false;
            txtBprenom.Enabled = false;
            txtBmail.Enabled = false;
            txtBtel.Enabled = false;
            MAJvalueTxtB();
        }

        private void btnValiderEdit_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtbNom.Text))
            {
                MessageBox.Show("Veuiller rentré un Nom Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtBprenom.Text))
            {
                MessageBox.Show("Veuiller rentré un Prénom Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtBmail.Text))
            {
                MessageBox.Show("Veuiller rentré un Email Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtBtel.Text))
            {
                MessageBox.Show("Veuiller rentré un Numéro de Téléphone Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                ORMmySQL.UpdateCompte(txtbNom.Text, txtBprenom.Text, txtBmail.Text, txtBtel.Text);
                ORMmySQL.CurrentUser = ORMmySQL.ConnexionCompte(txtBmail.Text, ORMmySQL.CurrentUser.GetMotDePasse());

                Acceuil MajAcceuil = new Acceuil();
                MajAcceuil.lblUserName.Text = ORMmySQL.CurrentUser.GetNom() + " " + ORMmySQL.CurrentUser.GetPrenom();
                MajAcceuil.lblType.Text = "Type : " + ORMmySQL.CurrentUser.GetTypeCompte();
                MajAcceuil.lblType.Visible = true;
                MajAcceuil.btnConnexion.Text = "Mon Compte";
                if (ORMmySQL.CurrentUser.GetTypeCompte() == "ADM" || ORMmySQL.CurrentUser.GetTypeCompte() == "GES")
                {
                    MajAcceuil.pnlAdmin.Visible = true;
                }
                MajAcceuil.Show();
                ((Acceuil)Application.OpenForms["frm" + (ORMmySQL._counterForm - 2).ToString()]).Close(); // Supprime le formulaire d'avant
                MessageBox.Show("Les modification ont bien été effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}

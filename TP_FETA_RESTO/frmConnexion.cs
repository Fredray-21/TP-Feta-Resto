using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_FETA_RESTO
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        public void ClearText()
        {
            lblMessage.Text = "";
            txtBlogin.Text = "";
            txtBpassword.Text = "";
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtBlogin.Text))
            {
                MessageBox.Show("Veuiller rentré une Email Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtBpassword.Text))
            {
                MessageBox.Show("Veuiller rentré un Mot de passe Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Compte c = ORMmySQL.ConnexionCompte(txtBlogin.Text, txtBpassword.Text);
                if (c == null)
                {
                    MessageBox.Show("Adresse mail et/ou Mot de passe Invalide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ClearText();
                    ORMmySQL.CurrentUser = c;
                    Acceuil MajAcceuil = new Acceuil();
                    MajAcceuil.lblUserName.Text = c.GetNom() + " " + c.GetPrenom();
                    MajAcceuil.lblType.Text = "Type : " + c.GetTypeCompte();
                    MajAcceuil.lblType.Visible = true;
                    MajAcceuil.btnConnexion.Text = "Mon Compte";
                    if (c.GetTypeCompte() == "ADM" || c.GetTypeCompte() == "GES")
                    {
                        MajAcceuil.pnlAdmin.Visible = true;
                    }
                    if(c != null)
                    {
                        MajAcceuil.btnPanier.Visible = true;
                    }
                    MajAcceuil.Show();
                    ((Acceuil)Application.OpenForms["frm" + (ORMmySQL._counterForm - 2).ToString()]).Hide(); // cache le formulaire d'avant
                }

            }
        }
    }
}

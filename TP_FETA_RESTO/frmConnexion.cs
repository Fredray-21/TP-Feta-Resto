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

            Compte c = ORMmySQL.ConnexionCompte(txtBlogin.Text, txtBpassword.Text);
            if(c != null)
            {
                ClearText();
                ORMmySQL.User = c;
                Acceuil frm2 = new Acceuil();
                frm2.lblUserName.Text = c.GetNom() + " " + c.GetPrenom();
                frm2.lblType.Text = "Type : "+ c.GetTypeCompte();
                frm2.lblType.Visible = true;
                if(c.GetTypeCompte() == "ADM")
                {
                    frm2.pnlAdmin.Visible = true;
                }
                frm2.ShowDialog();
            }
            else
            {
                lblMessage.Text = "Adresse mail et/ou Mot de passe Invalide";
                lblMessage.ForeColor = Color.Red;
            }
        }
    }
}

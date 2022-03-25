using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace TP_FETA_RESTO
{
    public partial class Acceuil : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);

        public Acceuil()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            ORMmySQL.ConnexionDB()
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            pnlNav.Height = btnFormules.Height;
            pnlNav.Top = btnFormules.Top;
            pnlNav.Left = btnFormules.Left;
            pnlNavGestion.Visible = false;
            pnlNav.Visible = true;

            lblTitle.Text = "Les Formules";
            this.pnlFormLoader.Controls.Clear();
            frmFormules frmFormules = new frmFormules() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFormules.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmFormules);
            frmFormules.Show();

            ((Acceuil)Application.OpenForms["Acceuil"]).Name = "frm" + ORMmySQL._counterForm.ToString();
            ORMmySQL._counterForm++;

            if (ORMmySQL.CurrentUser != null)
            {
                btnDeconnexion.Visible = true;
            }
        }

        private void btnFormules_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFormules.Height;
            pnlNav.Top = btnFormules.Top;
            pnlNav.Left = btnFormules.Left;
            pnlNavGestion.Visible = false;
            pnlNav.Visible = true;

            lblTitle.Text = "Les Formules";
            this.pnlFormLoader.Controls.Clear();
            frmFormules frmFormules = new frmFormules() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFormules.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmFormules);
            frmFormules.Show();

        }
        private void btnMesReservation_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMesReservation.Height;
            pnlNav.Top = btnMesReservation.Top;
            pnlNav.Left = btnMesReservation.Left;
            pnlNavGestion.Visible = false;
            pnlNav.Visible = true;

            lblTitle.Text = "Mes Réservations";
            this.pnlFormLoader.Controls.Clear();
            frmMesReservation frmMesReservation = new frmMesReservation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmMesReservation.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmMesReservation);
            frmMesReservation.Show();
        }


        private void btnConnexion_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnConnexion.Height;
            pnlNav.Top = btnConnexion.Top;
            pnlNav.Left = btnConnexion.Left;
            pnlNavGestion.Visible = false;
            pnlNav.Visible = true;

            lblTitle.Text = "Connexion";
            if (ORMmySQL.CurrentUser != null)
            {
                this.pnlFormLoader.Controls.Clear();
                frmEditCompte frmEditCompte = new frmEditCompte() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmEditCompte.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(frmEditCompte);
                frmEditCompte.Show();
            }
            else
            {
                this.pnlFormLoader.Controls.Clear();
                frmConnexion frmConnexion = new frmConnexion() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmConnexion.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(frmConnexion);
                frmConnexion.Show();
            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            String message = "";
            Compte c = ORMmySQL.CurrentUser;
            if (c != null)
            {
                message = "Etes vous sur de vouloir Quitter et Supprimer votre panier";
            }
            else
            {
                message = "Etes vous sur de vouloir Quitter";

            }
            DialogResult dialogResult = MessageBox.Show(message, "Voulez-vous vraiment Quitter?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sur de vouloir vous Déconnecter et Supprimer votre panier", "Voulez-vous vraiment vous Déconnecter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                ORMmySQL.CurrentUser = null;
                ORMmySQL.Panier.Clear();
                Acceuil MajAcceuil = new Acceuil();
                MajAcceuil.Show();
                ((Acceuil)Application.OpenForms["frm" + (ORMmySQL._counterForm - 2).ToString()]).Close(); // close le formulaire d'avant
            }

        }

        private void btnPanier_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPanier.Height;
            pnlNav.Top = btnPanier.Top;
            pnlNav.Left = btnPanier.Left;
            pnlNavGestion.Visible = false;
            pnlNav.Visible = true;

            lblTitle.Text = "Mon Panier";
            this.pnlFormLoader.Controls.Clear();
            frmPanier frmPanier = new frmPanier() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPanier.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmPanier);
            frmPanier.Show();
        }

        private void btnGestionAddFormule_Click(object sender, EventArgs e)
        {
            pnlNavGestion.Height = btnGestionAddFormule.Height;
            pnlNavGestion.Top = btnGestionAddFormule.Top;
            pnlNavGestion.Left = btnGestionAddFormule.Left;
            pnlNavGestion.Visible = true;
            pnlNav.Visible = false;

            lblTitle.Text = "Création de Formules";
            this.pnlFormLoader.Controls.Clear();
            frmGestionAddFormule frmGestionAddFormule = new frmGestionAddFormule() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmGestionAddFormule.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmGestionAddFormule);
            frmGestionAddFormule.Show();
        }

        private void btnGestionAddArticle_Click(object sender, EventArgs e)
        {
            pnlNavGestion.Height = btnGestionAddArticle.Height;
            pnlNavGestion.Top = btnGestionAddArticle.Top;
            pnlNavGestion.Left = btnGestionAddArticle.Left;
            pnlNavGestion.Visible = true;
            pnlNav.Visible = false;

            lblTitle.Text = "Création de Formules";
            this.pnlFormLoader.Controls.Clear();
            frmGestionAddArticle frmGestionAddArticle = new frmGestionAddArticle() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmGestionAddArticle.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmGestionAddArticle);
            frmGestionAddArticle.Show();
        }
    }
}

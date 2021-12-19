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
            ORMmySQL.ConnexionDB();

        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
           
            pnlNav.Height = btnFormules.Height;
            pnlNav.Top = btnFormules.Top;
            pnlNav.Left = btnFormules.Left;

            lblTitle.Text = "Les Formules";
            this.pnlFormLoader.Controls.Clear();
            frmFormules frmFormules = new frmFormules() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFormules.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmFormules);
            frmFormules.Show();

            ((Acceuil)Application.OpenForms["Acceuil"]).Name = "frm"+ORMmySQL._counterForm.ToString();
            ORMmySQL._counterForm++;

            if(ORMmySQL.CurrentUser != null)
            {
                btnDeconnexion.Visible = true;
            }
        }

        private void btnFormules_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFormules.Height;
            pnlNav.Top = btnFormules.Top;
            pnlNav.Left = btnFormules.Left;

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

            lblTitle.Text = "Connexion";
            if(ORMmySQL.CurrentUser != null)
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
            Application.Exit();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            ORMmySQL.CurrentUser = null;
            Acceuil MajAcceuil = new Acceuil();
            MajAcceuil.Show();
            ((Acceuil)Application.OpenForms["frm" + (ORMmySQL._counterForm - 2).ToString()]).Close(); // close le formulaire d'avant
        }

    }


}

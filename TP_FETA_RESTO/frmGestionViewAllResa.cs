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
    public partial class frmGestionViewAllResa : Form
    {
        public frmGestionViewAllResa()
        {
            InitializeComponent();
            int x = 10;
            int y = 10;
            int Xlbl = 10;
            int Ylbl = 10;
            List<Reservation> listRESA = ORMmySQL.GetAllReservation();


            foreach (Reservation r in listRESA)
            {
                CardReservation CardReservation = new CardReservation() { Location = new Point(x, y), TopLevel = false, TopMost = true };
                CardReservation.FormBorderStyle = FormBorderStyle.None;
                CardReservation.lblDateResa.Text = r.GetDateResa().ToString("dd/MM/yyyy");
                CardReservation.lblMontantT.Text = r.GetMontant().ToString() + " €";
                CardReservation.lblAdresse.Text = r.GetAdressLivraison().ToString();

                foreach (Formule f in ORMmySQL.GetAllFormuleParResa(r))
                {
                    FontFamily family = new FontFamily("Microsoft Sans Serif");
                    Font font = new Font(family, 12, FontStyle.Bold);

                    Label lbl = new Label() { Location = new Point(Xlbl, Ylbl), Font = font, ForeColor = Color.White, AutoSize = true };
                    lbl.Text = $"- {f.GetNomFormule()} ({f.GetPrixFormule()}€)";

                    CardReservation.pnlListFormule.Controls.Add(lbl);
                    lbl.Show();
                    Ylbl = Ylbl + 30;
                }
                Ylbl = 10;
                this.pnlViewAllResa.Controls.Add(CardReservation);
                CardReservation.Show();
                y = y + 240;
            }

            CardReservation CardFin = new CardReservation() { Enabled = false, Visible = false, Location = new Point(x, y), BackColor = Color.FromArgb(50, 50, 50), Size = new Size(10, 5), TopLevel = false, TopMost = true };
            CardFin.FormBorderStyle = FormBorderStyle.None;
            this.pnlViewAllResa.Controls.Add(CardFin);
            CardFin.Show();

    }
    }
}

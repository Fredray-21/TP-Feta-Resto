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
    public partial class frmFormules : Form
    {
        public frmFormules()
        {
            InitializeComponent();

            this.pnlFormule.Controls.Clear();
            int x = 10;
            int y = 10;
            List<Formule> AllFormules = ORMmySQL.GetAllFormules();
            for (int i = 1; i <= AllFormules.Count; i++)
            {
                CardFormules CardFormules = new CardFormules() { Location = new Point(x, y), TopLevel = false, TopMost = true };
                CardFormules.FormBorderStyle = FormBorderStyle.None;
                CardFormules.lblNomFormule.Text = AllFormules[i - 1].GetNomFormule();
                CardFormules.lblPrixFormule.Text = AllFormules[i - 1].GetPrixFormule().ToString() + "€";
                Compte c = ORMmySQL.CurrentUser;
                if(c != null)
                {
                    CardFormules.btnReserveCard.Text = "Réserver N°" + AllFormules[i - 1].GetIdFormule().ToString();
                }
                else
                {
                    CardFormules.btnReserveCard.Visible = false;
                }
                this.pnlFormule.Controls.Add(CardFormules);
                CardFormules.Show();
                x = x + 360;
                if (i % 2 == 0)
                {
                    x = 10;
                    y = y + 210;
                }
            
            }
            if (AllFormules.Count % 2 != 0)
            {
                CardFormules CardFormules = new CardFormules() { Enabled = false, BackColor = Color.FromArgb(50, 50, 50), Location = new Point(x, y), TopLevel = false, TopMost = true };
                CardFormules.FormBorderStyle = FormBorderStyle.None;
                CardFormules.lblNomFormule.Text = "";
                CardFormules.lblPrixFormule.Text = "";
                CardFormules.btnReserveCard.Visible = false;
                this.pnlFormule.Controls.Add(CardFormules);
                CardFormules.Show();
                x = 10;
                y = y + 210;
            }
            CardFormules CardFin = new CardFormules() { Enabled = false, Visible = false, Location = new Point(x, y), BackColor = Color.FromArgb(50, 50, 50), Size = new Size(20, 5), TopLevel = false, TopMost = true };
            CardFin.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormule.Controls.Add(CardFin);
            CardFin.Show();
        }

    }
}


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
            if(c != null)
            {
                btnReserveCard.Visible = true;
            }
        }

        private void btnReserveCard_Click(object sender, EventArgs e)
        {
            string[] TabTextBTN = btnReserveCard.Text.Split('°');
            int idFormule = Int32.Parse(TabTextBTN[1]);
            Formule f = ORMmySQL.GetFormule(idFormule);
            if (f != null)
            {
                ORMmySQL.Panier.Add(f);
                MessageBox.Show($"La Formule N°{f.GetIdFormule()} a été ajouté au Panier", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

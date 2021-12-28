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
    public partial class frmGestionAddArticle : Form
    {
        public frmGestionAddArticle()
        {
            InitializeComponent();
            String[] TypeArticle = new String[] { "Entrée", "Plat", "Dessert", "Supplément", "Boisson", "Alcool" };
            listBTypeArticle.Items.AddRange(TypeArticle.ToArray());
        }

        public void ClearTxt()
        {
            listBTypeArticle.SelectedItem = null;
            txtBNomArticle.Text = "";
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            String type = (String)listBTypeArticle.SelectedItem;

            if (String.IsNullOrWhiteSpace(txtBNomArticle.Text))
            {
                MessageBox.Show("Veuiller rentré un Nom Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (type == null)
            {
                MessageBox.Show("Veuillez sélectionner un type valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                ORMmySQL.AjouterArticle(txtBNomArticle.Text, type);
                MessageBox.Show("L'Article à bien été ajouter", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTxt();
            }
        }
    }
}

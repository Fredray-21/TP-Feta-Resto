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
    public partial class frmPanier : Form
    {
        public frmPanier()
        {
            InitializeComponent();
            if (ORMmySQL.Panier.Count > 0)
            {
                pnlPrixTotal.Visible = true;
                txtBAdress.Visible = true;
                this.pnlPanier.Controls.Clear();
            }

            double Prix_Total = 0;
            foreach (Formule f in ORMmySQL.Panier)
            {
                Prix_Total += f.GetPrixFormule();
            }
            lblPrixTotal.Text = Prix_Total.ToString() + "€";
            int x = 10;
            int y = 10;
            List<Formule> PanierDistinct = new List<Formule>(); // ici panier Distinct
            foreach (Formule f in ORMmySQL.Panier)
            {
                if (PanierDistinct.Contains(f) != true)
                {
                    PanierDistinct.Add(f);
                }
            }

            foreach (Formule f in PanierDistinct)
            {
                CardPanier CardPanier = new CardPanier() { Location = new Point(x, y), TopLevel = false, TopMost = true };
                CardPanier.FormBorderStyle = FormBorderStyle.None;

                //Début multiplicateur
                int multiplicateur = 0;
                foreach (Formule formule in ORMmySQL.Panier)
                {
                    if (formule.Equals(f))
                    {
                        multiplicateur++;
                    }
                }
                CardPanier.lblMultiplicateur.Text = "x" + multiplicateur.ToString();
                //Fin multiplicateur

                CardPanier.lblNOFORMULE.Text = "N°" + f.GetIdFormule().ToString();
                CardPanier.lblTitle.Text = f.GetNomFormule();
                CardPanier.lblPrixUnitaire.Text = f.GetPrixFormule().ToString() + " €/u";

                List<Article> SesArticles = ORMmySQL.GetAllArticleParIdFormule(f.GetIdFormule());
                foreach (Article a in SesArticles)
                {
                    if (a.GetTypeArticle() == "Entrée")
                    {
                        CardPanier.lblEntree.Text = a.GetNomArticle();
                        CardPanier.lblEntree.Visible = true;
                    }
                    if (a.GetTypeArticle() == "Plat")
                    {
                        CardPanier.lblPlat.Text = a.GetNomArticle();
                        CardPanier.lblPlat.Visible = true;
                    }
                    if (a.GetTypeArticle() == "Dessert")
                    {
                        CardPanier.lblDessert.Text = a.GetNomArticle();
                        CardPanier.lblDessert.Visible = true;
                    }
                    if (a.GetTypeArticle() == "Supplément")
                    {
                        CardPanier.lblSupp.Text = a.GetNomArticle();
                        CardPanier.lblSupp.Visible = true;
                    }
                    if (a.GetTypeArticle() == "Boisson")
                    {
                        CardPanier.lblBoisson.Text = a.GetNomArticle();
                        CardPanier.lblBoisson.Visible = true;
                    }
                    if (a.GetTypeArticle() == "Alcool")
                    {
                        CardPanier.lblAlcool.Text = a.GetNomArticle();
                        CardPanier.lblAlcool.Visible = true;
                    }
                }
                byte[] img = ORMmySQL.GetPictureFormule(f.GetIdFormule());
                var ms = new MemoryStream(img);
                Image image = Image.FromStream(ms);
                CardPanier.PictureBox.Image = image;


                this.pnlPanier.Controls.Add(CardPanier);
                CardPanier.Show();
                x = 10;
                y = y + 230;
            }
            CardPanier CardFin = new CardPanier() { Enabled = false, Visible = false, Location = new Point(x, y), BackColor = Color.FromArgb(50, 50, 50), Size = new Size(20, 5), TopLevel = false, TopMost = true };
            CardFin.FormBorderStyle = FormBorderStyle.None;
            this.pnlPanier.Controls.Add(CardFin);
            CardFin.Show();
        }

        private void btnReservePanier_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBAdress.Text))
            {
                MessageBox.Show("Veuiller rentré une Adresse Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show($"Etes vous sur de vouloir réservé ce Panier", "Voulez-vous vraiment réservé le Panier", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    double prixTotal = 0;
                    foreach (Formule f in ORMmySQL.Panier)
                    {
                        prixTotal += f.GetPrixFormule();

                    }
                    if(ORMmySQL.AjouterReservation(prixTotal, txtBAdress.Text))
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
                            MajAcceuil.btnMesReservation.Visible = true;
                        }
                        MajAcceuil.Show();
                       ((Acceuil)Application.OpenForms["frm" + (ORMmySQL._counterForm - 2).ToString()]).Hide(); // cache le formulaire d'avant

                        ORMmySQL.Panier.Clear();

                        MessageBox.Show("La Reservation à bien été enregisté");

                    }

                }
            }
        }
    }
}

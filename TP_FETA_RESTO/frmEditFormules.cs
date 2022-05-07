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
    public partial class frmEditFormules : Form
    {
        private int idFormule;
        public frmEditFormules(int IdFormule)
        {
            InitializeComponent();
            this.idFormule = IdFormule;
            List<Article> LesAticles = ORMmySQL.GetAllArticles();
            comBoxentree.Items.Add(String.Empty);
            comBoxPlat.Items.Add(String.Empty);
            comBoxDessert.Items.Add(String.Empty);
            comBoxSupp.Items.Add(String.Empty);
            comBoxBoisson.Items.Add(String.Empty);
            comBoxAlcool.Items.Add(String.Empty);

            if (LesAticles != null)
            {
                foreach (Article a in LesAticles)
                {
                    if (a.GetTypeArticle() == "Entrée")
                    {
                        comBoxentree.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Plat")
                    {
                        comBoxPlat.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Dessert")
                    {
                        comBoxDessert.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Supplément")
                    {
                        comBoxSupp.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Boisson")
                    {
                        comBoxBoisson.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Alcool")
                    {
                        comBoxAlcool.Items.Add(a);
                    }
                    else
                    {
                    }
                }
            }

            Formule f = ORMmySQL.GetFormule(IdFormule);
            if (f == null) this.Close();
            else
            {
                txtBNomFormule.Text = f.GetNomFormule();
                txtPrixFormule.Text = f.GetPrixFormule().ToString();
                txtBDescFormule.Text = f.GetDescFormule();

                byte[] img = ORMmySQL.GetPictureFormule(f.GetIdFormule());
                var ms = new MemoryStream(img);
                Image image = Image.FromStream(ms);
                pictureBoxPhoto.Image = image;

                List<Article> articlesFormule = ORMmySQL.GetAllArticleParIdFormule(f.GetIdFormule());
                SelectInComBox(articlesFormule);

            }
        }


        private void SelectInComBox(List<Article> lesARTS)
        {
            ComboBox box = comBoxentree;
            foreach (Article article in lesARTS)
            {
                switch (article.GetTypeArticle())
                {
                    case "Entrée": box = comBoxentree; break;
                    case "Plat": box = comBoxPlat; break;
                    case "Dessert": box = comBoxDessert; break;
                    case "Supplément": box = comBoxSupp; break;
                    case "Boisson": box = comBoxBoisson; break;
                    case "Alcool": box = comBoxAlcool; break;
                }

                for (int i = 0; i < box.Items.Count; i++)
                {
                    if (box.Items[i].ToString() == article.GetNomArticle()) box.SelectedIndex = i;
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg; *.png;)|*.jpg; *.png;|JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                String PicLoc = dlg.FileName.ToString();
                if (PicLoc.Substring(PicLoc.Length - 4) != ".png" && PicLoc.Substring(PicLoc.Length - 4) != ".jpg")
                {
                    MessageBox.Show("Le Format est incorrect (.png ou .jpg)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pictureBoxPhoto.Image = Image.FromFile(PicLoc);
                }
            }
        }

        private void btnEDITFormule_Click(object sender, EventArgs e)
        {
            Article entree = null;
            Article plat = null;
            Article dessert = null;
            Article supplement = null;
            Article boisson = null;
            Article alcool = null;

            if (comBoxentree.SelectedItem is Article)
            {
                entree = (Article)comBoxentree.SelectedItem;

            }
            if (comBoxPlat.SelectedItem is Article)
            {
                plat = (Article)comBoxPlat.SelectedItem;
            }
            if (comBoxDessert.SelectedItem is Article)
            {
                dessert = (Article)comBoxDessert.SelectedItem;
            }
            if (comBoxSupp.SelectedItem is Article)
            {
                supplement = (Article)comBoxSupp.SelectedItem;
            }
            if (comBoxBoisson.SelectedItem is Article)
            {
                boisson = (Article)comBoxBoisson.SelectedItem;
            }
            if (comBoxAlcool.SelectedItem is Article)
            {
                alcool = (Article)comBoxAlcool.SelectedItem;
            }

            List<Article> LesArticleSelected = new List<Article>();
            if (entree != null)
            {
                LesArticleSelected.Add(entree);
            }
            if (plat != null)
            {
                LesArticleSelected.Add(plat);
            }
            if (dessert != null)
            {
                LesArticleSelected.Add(dessert);
            }
            if (supplement != null)
            {
                LesArticleSelected.Add(supplement);
            }
            if (boisson != null)
            {
                LesArticleSelected.Add(boisson);
            }
            if (alcool != null)
            {
                LesArticleSelected.Add(alcool);
            }

            bool ConvertOK = float.TryParse(txtPrixFormule.Text, out float PrixFormule);
            if (String.IsNullOrWhiteSpace(txtBNomFormule.Text))
            {
                MessageBox.Show("Veuiller rentré un Nom Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtPrixFormule.Text) || ConvertOK == false || PrixFormule == 0)
            {
                MessageBox.Show("Veuiller rentré un Prix Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (String.IsNullOrWhiteSpace(txtBDescFormule.Text))
            {
                MessageBox.Show("Veuiller rentré une Description Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (pictureBoxPhoto.Image == null)
            {
                MessageBox.Show("Veuiller choisir une photo Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if ((entree != null && plat != null) || (plat != null && dessert != null))
            {
                MemoryStream ms = new MemoryStream();
                pictureBoxPhoto.Image.Save(ms, pictureBoxPhoto.Image.RawFormat);
                byte[] img = ms.ToArray();


                if (ORMmySQL.UpdateFormule(LesArticleSelected, txtBNomFormule.Text, PrixFormule, txtBDescFormule.Text, img, this.idFormule))
                { 
                    MessageBox.Show("La formule à bien été Modifier", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La formule n'à pas été Modifier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuiller selectionner au moin (Entrée/plat) ou (Plat/dessert)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }

}

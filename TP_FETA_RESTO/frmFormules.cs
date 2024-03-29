﻿using System;
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
    public partial class frmFormules : Form
    {

        public frmFormules()
        {
            InitializeComponent();

            this.pnlFormule.Controls.Clear();
            int x = 10;
            int y = 10;
            List<Formule> AllFormules = ORMmySQL.GetAllFormules();
            Compte currentUser = ORMmySQL.CurrentUser;
            for (int i = 1; i <= AllFormules.Count; i++)
            {
                List<Article> SesArticles = ORMmySQL.GetAllArticleParIdFormule(AllFormules[i - 1].GetIdFormule());
                CardFormules CardFormules = new CardFormules() { Location = new Point(x, y), TopLevel = false, TopMost = true };
                CardFormules.FormBorderStyle = FormBorderStyle.None;
                CardFormules.lblNomFormule.Text = AllFormules[i - 1].GetNomFormule();
                CardFormules.lblPrixFormule.Text = AllFormules[i - 1].GetPrixFormule().ToString() + "€";

                if (currentUser != null && (currentUser.GetTypeCompte() == "GES" || currentUser.GetTypeCompte() == "ADM"))
                {
                    CardFormules.btnGestionDelFormule.Visible = true;
                    CardFormules.btnGestionEditFormule.Visible = true;
                }
                foreach (Article a in SesArticles)
                {
                    if (a.GetTypeArticle() == "Entrée")
                    {
                        CardFormules.lblEntree.Text = a.GetNomArticle();
                        CardFormules.lblEntree.Visible = true;
                    }
                    if (a.GetTypeArticle() == "Plat")
                    {
                        CardFormules.lblPlat.Text = a.GetNomArticle();
                        CardFormules.lblPlat.Visible = true;
                    }
                    if (a.GetTypeArticle() == "Dessert")
                    {
                        CardFormules.lblDessert.Text = a.GetNomArticle();
                        CardFormules.lblDessert.Visible = true;
                    }
                    if (a.GetTypeArticle() == "Supplément")
                    {
                        CardFormules.lblSupplement.Text = a.GetNomArticle();
                        CardFormules.lblSupplement.Visible = true;
                    }
                    if (a.GetTypeArticle() == "Boisson")
                    {
                        CardFormules.lblBoisson.Text = a.GetNomArticle();
                        CardFormules.lblBoisson.Visible = true;
                    }
                    if (a.GetTypeArticle() == "Alcool")
                    {
                        CardFormules.lblAlcool.Text = a.GetNomArticle();
                        CardFormules.lblAlcool.Visible = true;
                    }
                }

                CardFormules.btnReserveCard.Text = "Ajouter au Panier N°" + AllFormules[i - 1].GetIdFormule().ToString();

                //essayer d'afficher l'image
                byte[] img = ORMmySQL.GetPictureFormule(AllFormules[i - 1].GetIdFormule());
                var ms = new MemoryStream(img);
                Image image = Image.FromStream(ms);
                CardFormules.pictureBPhotoFormule.Image = image;
                CardFormules.lblDescription.Text = AllFormules[i - 1].GetDescFormule();

                this.pnlFormule.Controls.Add(CardFormules);
                CardFormules.Show();
                x = x + 485;
                if (i % 2 == 0)
                {
                    x = 10;
                    y = y + 439;
                }
            }

            if(AllFormules.Count % 2 != 0)
            {
                x = 10;
                y = y + 439;
            }

            CardFormules CardFin = new CardFormules() { Enabled = false, Visible = false, Location = new Point(x, y), BackColor = Color.FromArgb(50, 50, 50), Size = new Size(40, 5), TopLevel = false, TopMost = true };
            CardFin.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormule.Controls.Add(CardFin);
            CardFin.Show();
        }
    }
}


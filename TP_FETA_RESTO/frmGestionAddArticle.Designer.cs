namespace TP_FETA_RESTO
{
    partial class frmGestionAddArticle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBNomArticle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBTypeArticle = new System.Windows.Forms.ListBox();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnnulerEdit = new System.Windows.Forms.Button();
            this.lblTitleAddEdit = new System.Windows.Forms.Label();
            this.btnValidEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditArticle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteArticle = new System.Windows.Forms.Button();
            this.listBLesArticles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBNomArticle
            // 
            this.txtBNomArticle.Location = new System.Drawing.Point(192, 73);
            this.txtBNomArticle.Name = "txtBNomArticle";
            this.txtBNomArticle.Size = new System.Drawing.Size(217, 25);
            this.txtBNomArticle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de l\'Article :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Type de l\'Article :";
            // 
            // listBTypeArticle
            // 
            this.listBTypeArticle.FormattingEnabled = true;
            this.listBTypeArticle.ItemHeight = 17;
            this.listBTypeArticle.Location = new System.Drawing.Point(192, 136);
            this.listBTypeArticle.Name = "listBTypeArticle";
            this.listBTypeArticle.Size = new System.Drawing.Size(217, 106);
            this.listBTypeArticle.TabIndex = 2;
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddArticle.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAddArticle.Location = new System.Drawing.Point(192, 263);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(217, 33);
            this.btnAddArticle.TabIndex = 0;
            this.btnAddArticle.Text = "Ajouter l\'Article";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnAnnulerEdit);
            this.panel1.Controls.Add(this.lblTitleAddEdit);
            this.panel1.Controls.Add(this.txtBNomArticle);
            this.panel1.Controls.Add(this.btnValidEdit);
            this.panel1.Controls.Add(this.btnAddArticle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBTypeArticle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(40, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 333);
            this.panel1.TabIndex = 3;
            // 
            // btnAnnulerEdit
            // 
            this.btnAnnulerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnnulerEdit.ForeColor = System.Drawing.Color.Red;
            this.btnAnnulerEdit.Location = new System.Drawing.Point(45, 263);
            this.btnAnnulerEdit.Name = "btnAnnulerEdit";
            this.btnAnnulerEdit.Size = new System.Drawing.Size(141, 33);
            this.btnAnnulerEdit.TabIndex = 4;
            this.btnAnnulerEdit.Text = "Annuler";
            this.btnAnnulerEdit.UseVisualStyleBackColor = true;
            this.btnAnnulerEdit.Visible = false;
            this.btnAnnulerEdit.Click += new System.EventHandler(this.btnAnnulerEdit_Click);
            // 
            // lblTitleAddEdit
            // 
            this.lblTitleAddEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.82178F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleAddEdit.ForeColor = System.Drawing.Color.White;
            this.lblTitleAddEdit.Location = new System.Drawing.Point(0, 0);
            this.lblTitleAddEdit.Name = "lblTitleAddEdit";
            this.lblTitleAddEdit.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblTitleAddEdit.Size = new System.Drawing.Size(415, 47);
            this.lblTitleAddEdit.TabIndex = 3;
            this.lblTitleAddEdit.Text = "Ajouter un Article";
            this.lblTitleAddEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnValidEdit
            // 
            this.btnValidEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnValidEdit.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnValidEdit.Location = new System.Drawing.Point(192, 297);
            this.btnValidEdit.Name = "btnValidEdit";
            this.btnValidEdit.Size = new System.Drawing.Size(217, 33);
            this.btnValidEdit.TabIndex = 0;
            this.btnValidEdit.Text = "Valider Modification";
            this.btnValidEdit.UseVisualStyleBackColor = true;
            this.btnValidEdit.Visible = false;
            this.btnValidEdit.Click += new System.EventHandler(this.btnValidEdit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.btnEditArticle);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnDeleteArticle);
            this.panel2.Controls.Add(this.listBLesArticles);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(546, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 438);
            this.panel2.TabIndex = 3;
            // 
            // btnEditArticle
            // 
            this.btnEditArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditArticle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEditArticle.Location = new System.Drawing.Point(17, 378);
            this.btnEditArticle.Name = "btnEditArticle";
            this.btnEditArticle.Size = new System.Drawing.Size(141, 30);
            this.btnEditArticle.TabIndex = 4;
            this.btnEditArticle.Text = "Modifier";
            this.btnEditArticle.UseVisualStyleBackColor = true;
            this.btnEditArticle.Click += new System.EventHandler(this.btnEditArticle_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.82178F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(415, 47);
            this.label4.TabIndex = 3;
            this.label4.Text = "Supprimer un Article";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteArticle
            // 
            this.btnDeleteArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteArticle.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteArticle.Location = new System.Drawing.Point(168, 377);
            this.btnDeleteArticle.Name = "btnDeleteArticle";
            this.btnDeleteArticle.Size = new System.Drawing.Size(217, 33);
            this.btnDeleteArticle.TabIndex = 0;
            this.btnDeleteArticle.Text = "Supprimer l\'Article";
            this.btnDeleteArticle.UseVisualStyleBackColor = true;
            this.btnDeleteArticle.Click += new System.EventHandler(this.btnDeleteArticle_Click);
            // 
            // listBLesArticles
            // 
            this.listBLesArticles.FormattingEnabled = true;
            this.listBLesArticles.ItemHeight = 17;
            this.listBLesArticles.Location = new System.Drawing.Point(166, 70);
            this.listBLesArticles.Name = "listBLesArticles";
            this.listBLesArticles.Size = new System.Drawing.Size(217, 293);
            this.listBLesArticles.TabIndex = 2;
            this.listBLesArticles.SelectedIndexChanged += new System.EventHandler(this.listBLesArticles_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Les Articles:";
            // 
            // frmGestionAddArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1000, 656);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionAddArticle";
            this.Text = "frmGestionAddArticle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBNomArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBTypeArticle;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteArticle;
        private System.Windows.Forms.ListBox listBLesArticles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitleAddEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditArticle;
        private System.Windows.Forms.Button btnAnnulerEdit;
        private System.Windows.Forms.Button btnValidEdit;
    }
}
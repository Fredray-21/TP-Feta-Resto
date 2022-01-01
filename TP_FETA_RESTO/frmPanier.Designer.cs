namespace TP_FETA_RESTO
{
    partial class frmPanier
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
            this.pnlPanier = new System.Windows.Forms.Panel();
            this.btnReservePanier = new System.Windows.Forms.Button();
            this.lblPrixTotal = new System.Windows.Forms.Label();
            this.lblTitrePrixTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPanier
            // 
            this.pnlPanier.AutoScroll = true;
            this.pnlPanier.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPanier.Location = new System.Drawing.Point(0, 0);
            this.pnlPanier.Name = "pnlPanier";
            this.pnlPanier.Size = new System.Drawing.Size(751, 656);
            this.pnlPanier.TabIndex = 0;
            // 
            // btnReservePanier
            // 
            this.btnReservePanier.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReservePanier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservePanier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReservePanier.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnReservePanier.Location = new System.Drawing.Point(10, 150);
            this.btnReservePanier.Name = "btnReservePanier";
            this.btnReservePanier.Size = new System.Drawing.Size(199, 30);
            this.btnReservePanier.TabIndex = 5;
            this.btnReservePanier.Text = "Réserver ce Panier";
            this.btnReservePanier.UseVisualStyleBackColor = true;
            // 
            // lblPrixTotal
            // 
            this.lblPrixTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrixTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrixTotal.ForeColor = System.Drawing.Color.White;
            this.lblPrixTotal.Location = new System.Drawing.Point(10, 20);
            this.lblPrixTotal.Name = "lblPrixTotal";
            this.lblPrixTotal.Size = new System.Drawing.Size(199, 160);
            this.lblPrixTotal.TabIndex = 6;
            this.lblPrixTotal.Text = "100€";
            this.lblPrixTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitrePrixTotal
            // 
            this.lblTitrePrixTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitrePrixTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitrePrixTotal.ForeColor = System.Drawing.Color.White;
            this.lblTitrePrixTotal.Location = new System.Drawing.Point(10, 20);
            this.lblTitrePrixTotal.Name = "lblTitrePrixTotal";
            this.lblTitrePrixTotal.Size = new System.Drawing.Size(199, 33);
            this.lblTitrePrixTotal.TabIndex = 6;
            this.lblTitrePrixTotal.Text = "Prix Total";
            this.lblTitrePrixTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.lblTitrePrixTotal);
            this.panel1.Controls.Add(this.btnReservePanier);
            this.panel1.Controls.Add(this.lblPrixTotal);
            this.panel1.Location = new System.Drawing.Point(769, 444);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.panel1.Size = new System.Drawing.Size(219, 200);
            this.panel1.TabIndex = 7;
            // 
            // frmPanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1000, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPanier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPanier";
            this.Text = "frmPanier";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPanier;
        public System.Windows.Forms.Button btnReservePanier;
        private System.Windows.Forms.Label lblPrixTotal;
        private System.Windows.Forms.Label lblTitrePrixTotal;
        private System.Windows.Forms.Panel panel1;
    }
}
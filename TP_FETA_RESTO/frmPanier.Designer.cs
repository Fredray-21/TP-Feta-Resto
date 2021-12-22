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
            this.SuspendLayout();
            // 
            // pnlPanier
            // 
            this.pnlPanier.AutoScroll = true;
            this.pnlPanier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPanier.Location = new System.Drawing.Point(0, 0);
            this.pnlPanier.Name = "pnlPanier";
            this.pnlPanier.Size = new System.Drawing.Size(1000, 656);
            this.pnlPanier.TabIndex = 0;
            // 
            // frmPanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1000, 656);
            this.Controls.Add(this.pnlPanier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPanier";
            this.Text = "frmPanier";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPanier;
    }
}
namespace TP_FETA_RESTO
{
    partial class CardPanier
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
            this.lblNOFORMULE = new System.Windows.Forms.Label();
            this.lblMultiplicateur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNOFORMULE
            // 
            this.lblNOFORMULE.AutoSize = true;
            this.lblNOFORMULE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNOFORMULE.ForeColor = System.Drawing.Color.White;
            this.lblNOFORMULE.Location = new System.Drawing.Point(31, 20);
            this.lblNOFORMULE.Name = "lblNOFORMULE";
            this.lblNOFORMULE.Size = new System.Drawing.Size(38, 29);
            this.lblNOFORMULE.TabIndex = 0;
            this.lblNOFORMULE.Text = "ID";
            // 
            // lblMultiplicateur
            // 
            this.lblMultiplicateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.23762F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMultiplicateur.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMultiplicateur.Location = new System.Drawing.Point(566, 9);
            this.lblMultiplicateur.Name = "lblMultiplicateur";
            this.lblMultiplicateur.Size = new System.Drawing.Size(133, 54);
            this.lblMultiplicateur.TabIndex = 0;
            this.lblMultiplicateur.Text = "x 2";
            this.lblMultiplicateur.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CardPanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(711, 200);
            this.Controls.Add(this.lblMultiplicateur);
            this.Controls.Add(this.lblNOFORMULE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CardPanier";
            this.Text = "CardPanier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNOFORMULE;
        public System.Windows.Forms.Label lblMultiplicateur;
    }
}
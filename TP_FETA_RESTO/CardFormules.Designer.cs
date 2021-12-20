namespace TP_FETA_RESTO
{
    partial class CardFormules
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
            this.lblNomFormule = new System.Windows.Forms.Label();
            this.lblPrixFormule = new System.Windows.Forms.Label();
            this.btnReserveCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomFormule
            // 
            this.lblNomFormule.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNomFormule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomFormule.ForeColor = System.Drawing.Color.White;
            this.lblNomFormule.Location = new System.Drawing.Point(0, 0);
            this.lblNomFormule.Name = "lblNomFormule";
            this.lblNomFormule.Size = new System.Drawing.Size(350, 28);
            this.lblNomFormule.TabIndex = 0;
            this.lblNomFormule.Text = "NomFormule";
            this.lblNomFormule.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrixFormule
            // 
            this.lblPrixFormule.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrixFormule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrixFormule.ForeColor = System.Drawing.Color.White;
            this.lblPrixFormule.Location = new System.Drawing.Point(0, 28);
            this.lblPrixFormule.Name = "lblPrixFormule";
            this.lblPrixFormule.Size = new System.Drawing.Size(350, 28);
            this.lblPrixFormule.TabIndex = 1;
            this.lblPrixFormule.Text = "Prix €";
            this.lblPrixFormule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReserveCard
            // 
            this.btnReserveCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserveCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReserveCard.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnReserveCard.Location = new System.Drawing.Point(138, 158);
            this.btnReserveCard.Name = "btnReserveCard";
            this.btnReserveCard.Size = new System.Drawing.Size(200, 30);
            this.btnReserveCard.TabIndex = 5;
            this.btnReserveCard.Text = "Réserver";
            this.btnReserveCard.UseVisualStyleBackColor = true;
            this.btnReserveCard.Visible = false;
            this.btnReserveCard.Click += new System.EventHandler(this.btnReserveCard_Click);
            // 
            // CardFormules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.btnReserveCard);
            this.Controls.Add(this.lblPrixFormule);
            this.Controls.Add(this.lblNomFormule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CardFormules";
            this.Text = "CardFormules";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblNomFormule;
        public System.Windows.Forms.Label lblPrixFormule;
        public System.Windows.Forms.Button btnReserveCard;
    }
}
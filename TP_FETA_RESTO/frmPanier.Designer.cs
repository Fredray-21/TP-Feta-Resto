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
            this.listBpanier = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBpanier
            // 
            this.listBpanier.FormattingEnabled = true;
            this.listBpanier.ItemHeight = 17;
            this.listBpanier.Location = new System.Drawing.Point(184, 87);
            this.listBpanier.Name = "listBpanier";
            this.listBpanier.Size = new System.Drawing.Size(254, 225);
            this.listBpanier.TabIndex = 0;
            // 
            // frmPanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(751, 477);
            this.Controls.Add(this.listBpanier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPanier";
            this.Text = "frmPanier";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBpanier;
    }
}
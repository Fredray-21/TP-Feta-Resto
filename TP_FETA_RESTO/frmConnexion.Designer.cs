namespace TP_FETA_RESTO
{
    partial class frmConnexion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.txtBpassword = new System.Windows.Forms.TextBox();
            this.txtBlogin = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnSeConnecter);
            this.panel1.Controls.Add(this.txtBpassword);
            this.panel1.Controls.Add(this.txtBlogin);
            this.panel1.Location = new System.Drawing.Point(191, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 185);
            this.panel1.TabIndex = 0;
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeConnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeConnecter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(23)))), ((int)(((byte)(85)))));
            this.btnSeConnecter.Location = new System.Drawing.Point(90, 127);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(200, 30);
            this.btnSeConnecter.TabIndex = 1;
            this.btnSeConnecter.Text = "Se Connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = true;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // txtBpassword
            // 
            this.txtBpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBpassword.Location = new System.Drawing.Point(70, 82);
            this.txtBpassword.Name = "txtBpassword";
            this.txtBpassword.PlaceholderText = "Password";
            this.txtBpassword.Size = new System.Drawing.Size(240, 27);
            this.txtBpassword.TabIndex = 2;
            // 
            // txtBlogin
            // 
            this.txtBlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBlogin.Location = new System.Drawing.Point(70, 33);
            this.txtBlogin.Name = "txtBlogin";
            this.txtBlogin.PlaceholderText = "Adresse mail";
            this.txtBlogin.Size = new System.Drawing.Size(240, 27);
            this.txtBlogin.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 17.82178F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 35);
            this.lblMessage.TabIndex = 1;
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(751, 477);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConnexion";
            this.Text = "frmConnexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBpassword;
        private System.Windows.Forms.TextBox txtBlogin;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.Label lblMessage;
    }
}
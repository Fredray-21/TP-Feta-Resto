﻿namespace TP_FETA_RESTO
{
    partial class frmFormules
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
            this.pnlFormule = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlFormule
            // 
            this.pnlFormule.AutoScroll = true;
            this.pnlFormule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormule.Location = new System.Drawing.Point(0, 0);
            this.pnlFormule.Name = "pnlFormule";
            this.pnlFormule.Size = new System.Drawing.Size(1000, 656);
            this.pnlFormule.TabIndex = 0;
            // 
            // frmFormules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1000, 656);
            this.Controls.Add(this.pnlFormule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFormules";
            this.Text = "frmDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormule;
    }
}
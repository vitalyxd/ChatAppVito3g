﻿namespace ChatAppVito3g.Forme
{
    partial class PosaljiPoruku
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
            this.UpisiPoruku = new System.Windows.Forms.TextBox();
            this.PrikazPoruka = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Posalji = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UpisiPoruku
            // 
            this.UpisiPoruku.Location = new System.Drawing.Point(11, 402);
            this.UpisiPoruku.Name = "UpisiPoruku";
            this.UpisiPoruku.Size = new System.Drawing.Size(197, 20);
            this.UpisiPoruku.TabIndex = 0;
            // 
            // PrikazPoruka
            // 
            this.PrikazPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrikazPoruka.FormattingEnabled = true;
            this.PrikazPoruka.Location = new System.Drawing.Point(11, 90);
            this.PrikazPoruka.Name = "PrikazPoruka";
            this.PrikazPoruka.Size = new System.Drawing.Size(278, 303);
            this.PrikazPoruka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pošalji poruku";
            // 
            // Posalji
            // 
            this.Posalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Posalji.Location = new System.Drawing.Point(214, 399);
            this.Posalji.Name = "Posalji";
            this.Posalji.Size = new System.Drawing.Size(75, 23);
            this.Posalji.TabIndex = 3;
            this.Posalji.Text = "Pošalji";
            this.Posalji.UseVisualStyleBackColor = true;
            this.Posalji.Click += new System.EventHandler(this.Posalji_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 4;
            // 
            // PosaljiPoruku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(301, 443);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Posalji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrikazPoruka);
            this.Controls.Add(this.UpisiPoruku);
            this.Name = "PosaljiPoruku";
            this.Text = "PosaljiPoruku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UpisiPoruku;
        private System.Windows.Forms.ListBox PrikazPoruka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Posalji;
        private System.Windows.Forms.TextBox textBox1;
    }
}
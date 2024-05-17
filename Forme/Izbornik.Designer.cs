namespace ChatAppVito3g
{
    partial class Izbornik
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
            this.label1 = new System.Windows.Forms.Label();
            this.KreirajKorisnika = new System.Windows.Forms.Button();
            this.PrikazRazgovora = new System.Windows.Forms.Button();
            this.PosaljiPoruku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chat aplikacija";
            // 
            // KreirajKorisnika
            // 
            this.KreirajKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KreirajKorisnika.Location = new System.Drawing.Point(357, 130);
            this.KreirajKorisnika.Name = "KreirajKorisnika";
            this.KreirajKorisnika.Size = new System.Drawing.Size(95, 36);
            this.KreirajKorisnika.TabIndex = 1;
            this.KreirajKorisnika.Text = "Kreiraj korisnika";
            this.KreirajKorisnika.UseVisualStyleBackColor = true;
            this.KreirajKorisnika.Click += new System.EventHandler(this.KreirajKorisnika_Click);
            // 
            // PrikazRazgovora
            // 
            this.PrikazRazgovora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrikazRazgovora.Location = new System.Drawing.Point(357, 203);
            this.PrikazRazgovora.Name = "PrikazRazgovora";
            this.PrikazRazgovora.Size = new System.Drawing.Size(95, 35);
            this.PrikazRazgovora.TabIndex = 2;
            this.PrikazRazgovora.Text = "Prikaz razgovora";
            this.PrikazRazgovora.UseVisualStyleBackColor = true;
            this.PrikazRazgovora.Click += new System.EventHandler(this.PrikazRazgovora_Click);
            // 
            // PosaljiPoruku
            // 
            this.PosaljiPoruku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PosaljiPoruku.Location = new System.Drawing.Point(357, 287);
            this.PosaljiPoruku.Name = "PosaljiPoruku";
            this.PosaljiPoruku.Size = new System.Drawing.Size(95, 27);
            this.PosaljiPoruku.TabIndex = 3;
            this.PosaljiPoruku.Text = "Pošalji poruku";
            this.PosaljiPoruku.UseVisualStyleBackColor = true;
            this.PosaljiPoruku.Click += new System.EventHandler(this.PosaljiPoruku_Click);
            // 
            // Izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PosaljiPoruku);
            this.Controls.Add(this.PrikazRazgovora);
            this.Controls.Add(this.KreirajKorisnika);
            this.Controls.Add(this.label1);
            this.Name = "Izbornik";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KreirajKorisnika;
        private System.Windows.Forms.Button PrikazRazgovora;
        private System.Windows.Forms.Button PosaljiPoruku;
    }
}


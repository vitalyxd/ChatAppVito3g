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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Izbornik));
            this.label1 = new System.Windows.Forms.Label();
            this.KreirajKorisnika = new System.Windows.Forms.Button();
            this.PrikazRazgovora = new System.Windows.Forms.Button();
            this.PosaljiPoruku = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.UsernameTrenutnogKorisnika = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chat aplikacija";
            // 
            // KreirajKorisnika
            // 
            this.KreirajKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KreirajKorisnika.Location = new System.Drawing.Point(118, 108);
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
            this.PrikazRazgovora.Location = new System.Drawing.Point(118, 181);
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
            this.PosaljiPoruku.Location = new System.Drawing.Point(118, 265);
            this.PosaljiPoruku.Name = "PosaljiPoruku";
            this.PosaljiPoruku.Size = new System.Drawing.Size(95, 27);
            this.PosaljiPoruku.TabIndex = 3;
            this.PosaljiPoruku.Text = "Pošalji poruku";
            this.PosaljiPoruku.UseVisualStyleBackColor = true;
            this.PosaljiPoruku.Click += new System.EventHandler(this.PosaljiPoruku_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Logout.Location = new System.Drawing.Point(11, 364);
            this.Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(60, 23);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // UsernameTrenutnogKorisnika
            // 
            this.UsernameTrenutnogKorisnika.AutoSize = true;
            this.UsernameTrenutnogKorisnika.Location = new System.Drawing.Point(11, 350);
            this.UsernameTrenutnogKorisnika.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameTrenutnogKorisnika.Name = "UsernameTrenutnogKorisnika";
            this.UsernameTrenutnogKorisnika.Size = new System.Drawing.Size(35, 13);
            this.UsernameTrenutnogKorisnika.TabIndex = 5;
            this.UsernameTrenutnogKorisnika.Text = "label2";
            // 
            // Izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(333, 408);
            this.Controls.Add(this.UsernameTrenutnogKorisnika);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.PosaljiPoruku);
            this.Controls.Add(this.PrikazRazgovora);
            this.Controls.Add(this.KreirajKorisnika);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label UsernameTrenutnogKorisnika;
    }
}


namespace ChatAppVito3g.Forme
{
    partial class KreiranjeKorisnika
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
            this.UnosImena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KreirajKorisnika = new System.Windows.Forms.Button();
            this.PrikazKorisnika = new System.Windows.Forms.ListBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.UnosPrezimena = new System.Windows.Forms.TextBox();
            this.UnosGodRodj = new System.Windows.Forms.TextBox();
            this.UnosEmaila = new System.Windows.Forms.TextBox();
            this.UnosUsernamea = new System.Windows.Forms.TextBox();
            this.UnosPassworda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ObrisiKorisnika = new System.Windows.Forms.Button();
            this.UrediKorisnika = new System.Windows.Forms.Button();
            this.IzmjeniKorisnika = new System.Windows.Forms.Button();
            this.PovratakUIzbornik = new System.Windows.Forms.Button();
            this.PovratakULogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UnosImena
            // 
            this.UnosImena.Location = new System.Drawing.Point(29, 175);
            this.UnosImena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnosImena.Name = "UnosImena";
            this.UnosImena.Size = new System.Drawing.Size(132, 22);
            this.UnosImena.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kreiraj korisnika";
            // 
            // KreirajKorisnika
            // 
            this.KreirajKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KreirajKorisnika.Location = new System.Drawing.Point(29, 391);
            this.KreirajKorisnika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KreirajKorisnika.Name = "KreirajKorisnika";
            this.KreirajKorisnika.Size = new System.Drawing.Size(99, 28);
            this.KreirajKorisnika.TabIndex = 2;
            this.KreirajKorisnika.Text = "Kreiraj";
            this.KreirajKorisnika.UseVisualStyleBackColor = true;
            this.KreirajKorisnika.Click += new System.EventHandler(this.KreirajKorisnika_Click);
            // 
            // PrikazKorisnika
            // 
            this.PrikazKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrikazKorisnika.FormattingEnabled = true;
            this.PrikazKorisnika.ItemHeight = 17;
            this.PrikazKorisnika.Location = new System.Drawing.Point(492, 155);
            this.PrikazKorisnika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrikazKorisnika.Name = "PrikazKorisnika";
            this.PrikazKorisnika.Size = new System.Drawing.Size(443, 276);
            this.PrikazKorisnika.TabIndex = 3;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // UnosPrezimena
            // 
            this.UnosPrezimena.Location = new System.Drawing.Point(29, 251);
            this.UnosPrezimena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnosPrezimena.Name = "UnosPrezimena";
            this.UnosPrezimena.Size = new System.Drawing.Size(132, 22);
            this.UnosPrezimena.TabIndex = 4;
            // 
            // UnosGodRodj
            // 
            this.UnosGodRodj.Location = new System.Drawing.Point(29, 332);
            this.UnosGodRodj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnosGodRodj.Name = "UnosGodRodj";
            this.UnosGodRodj.Size = new System.Drawing.Size(132, 22);
            this.UnosGodRodj.TabIndex = 5;
            // 
            // UnosEmaila
            // 
            this.UnosEmaila.Location = new System.Drawing.Point(243, 175);
            this.UnosEmaila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnosEmaila.Name = "UnosEmaila";
            this.UnosEmaila.Size = new System.Drawing.Size(132, 22);
            this.UnosEmaila.TabIndex = 6;
            // 
            // UnosUsernamea
            // 
            this.UnosUsernamea.Location = new System.Drawing.Point(243, 251);
            this.UnosUsernamea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnosUsernamea.Name = "UnosUsernamea";
            this.UnosUsernamea.Size = new System.Drawing.Size(132, 22);
            this.UnosUsernamea.TabIndex = 7;
            // 
            // UnosPassworda
            // 
            this.UnosPassworda.Location = new System.Drawing.Point(243, 330);
            this.UnosPassworda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnosPassworda.Name = "UnosPassworda";
            this.UnosPassworda.PasswordChar = '*';
            this.UnosPassworda.Size = new System.Drawing.Size(132, 22);
            this.UnosPassworda.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(25, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Godina rođenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(239, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(239, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Korisničko ime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(239, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lozinka";
            // 
            // ObrisiKorisnika
            // 
            this.ObrisiKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ObrisiKorisnika.Location = new System.Drawing.Point(944, 171);
            this.ObrisiKorisnika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ObrisiKorisnika.Name = "ObrisiKorisnika";
            this.ObrisiKorisnika.Size = new System.Drawing.Size(99, 28);
            this.ObrisiKorisnika.TabIndex = 15;
            this.ObrisiKorisnika.Text = "Obriši";
            this.ObrisiKorisnika.UseVisualStyleBackColor = true;
            this.ObrisiKorisnika.Click += new System.EventHandler(this.ObrisiKorisnika_Click);
            // 
            // UrediKorisnika
            // 
            this.UrediKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UrediKorisnika.Location = new System.Drawing.Point(944, 391);
            this.UrediKorisnika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UrediKorisnika.Name = "UrediKorisnika";
            this.UrediKorisnika.Size = new System.Drawing.Size(99, 28);
            this.UrediKorisnika.TabIndex = 16;
            this.UrediKorisnika.Text = "Uredi";
            this.UrediKorisnika.UseVisualStyleBackColor = true;
            this.UrediKorisnika.Click += new System.EventHandler(this.UrediKorisnika_Click);
            // 
            // IzmjeniKorisnika
            // 
            this.IzmjeniKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IzmjeniKorisnika.Location = new System.Drawing.Point(243, 391);
            this.IzmjeniKorisnika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IzmjeniKorisnika.Name = "IzmjeniKorisnika";
            this.IzmjeniKorisnika.Size = new System.Drawing.Size(99, 28);
            this.IzmjeniKorisnika.TabIndex = 17;
            this.IzmjeniKorisnika.Text = "Izmjeni";
            this.IzmjeniKorisnika.UseVisualStyleBackColor = true;
            this.IzmjeniKorisnika.Click += new System.EventHandler(this.IzmjeniKorisnika_Click);
            // 
            // PovratakUIzbornik
            // 
            this.PovratakUIzbornik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PovratakUIzbornik.Location = new System.Drawing.Point(1000, 592);
            this.PovratakUIzbornik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PovratakUIzbornik.Name = "PovratakUIzbornik";
            this.PovratakUIzbornik.Size = new System.Drawing.Size(169, 28);
            this.PovratakUIzbornik.TabIndex = 18;
            this.PovratakUIzbornik.Text = "Povratak u izbornik";
            this.PovratakUIzbornik.UseVisualStyleBackColor = true;
            this.PovratakUIzbornik.Click += new System.EventHandler(this.PovratakUIzbornik_Click);
            // 
            // PovratakULogin
            // 
            this.PovratakULogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PovratakULogin.Location = new System.Drawing.Point(823, 592);
            this.PovratakULogin.Margin = new System.Windows.Forms.Padding(4);
            this.PovratakULogin.Name = "PovratakULogin";
            this.PovratakULogin.Size = new System.Drawing.Size(169, 28);
            this.PovratakULogin.TabIndex = 19;
            this.PovratakULogin.Text = "Povratak u login";
            this.PovratakULogin.UseVisualStyleBackColor = true;
            this.PovratakULogin.Click += new System.EventHandler(this.PovratakULogin_Click);
            // 
            // KreiranjeKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1185, 635);
            this.Controls.Add(this.PovratakULogin);
            this.Controls.Add(this.PovratakUIzbornik);
            this.Controls.Add(this.IzmjeniKorisnika);
            this.Controls.Add(this.UrediKorisnika);
            this.Controls.Add(this.ObrisiKorisnika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UnosPassworda);
            this.Controls.Add(this.UnosUsernamea);
            this.Controls.Add(this.UnosEmaila);
            this.Controls.Add(this.UnosGodRodj);
            this.Controls.Add(this.UnosPrezimena);
            this.Controls.Add(this.PrikazKorisnika);
            this.Controls.Add(this.KreirajKorisnika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnosImena);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KreiranjeKorisnika";
            this.Text = "KreiranjeKorisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UnosImena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KreirajKorisnika;
        private System.Windows.Forms.ListBox PrikazKorisnika;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox UnosPrezimena;
        private System.Windows.Forms.TextBox UnosGodRodj;
        private System.Windows.Forms.TextBox UnosEmaila;
        private System.Windows.Forms.TextBox UnosUsernamea;
        private System.Windows.Forms.TextBox UnosPassworda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ObrisiKorisnika;
        private System.Windows.Forms.Button UrediKorisnika;
        private System.Windows.Forms.Button IzmjeniKorisnika;
        private System.Windows.Forms.Button PovratakUIzbornik;
        private System.Windows.Forms.Button PovratakULogin;
    }
}
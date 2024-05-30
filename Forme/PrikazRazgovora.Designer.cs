namespace ChatAppVito3g.Forme
{
    partial class PrikazRazgovora
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
            this.RazgovoriListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OtvoriRazgovor = new System.Windows.Forms.Button();
            this.ObrisiRazgovor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RazgovoriListBox
            // 
            this.RazgovoriListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RazgovoriListBox.FormattingEnabled = true;
            this.RazgovoriListBox.Location = new System.Drawing.Point(10, 54);
            this.RazgovoriListBox.Name = "RazgovoriListBox";
            this.RazgovoriListBox.Size = new System.Drawing.Size(288, 303);
            this.RazgovoriListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prikaz razgovora";
            // 
            // OtvoriRazgovor
            // 
            this.OtvoriRazgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OtvoriRazgovor.Location = new System.Drawing.Point(10, 368);
            this.OtvoriRazgovor.Name = "OtvoriRazgovor";
            this.OtvoriRazgovor.Size = new System.Drawing.Size(112, 23);
            this.OtvoriRazgovor.TabIndex = 2;
            this.OtvoriRazgovor.Text = "Otvori razgovor";
            this.OtvoriRazgovor.UseVisualStyleBackColor = true;
            this.OtvoriRazgovor.Click += new System.EventHandler(this.OtvoriRazgovor_Click);
            // 
            // ObrisiRazgovor
            // 
            this.ObrisiRazgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ObrisiRazgovor.Location = new System.Drawing.Point(186, 368);
            this.ObrisiRazgovor.Name = "ObrisiRazgovor";
            this.ObrisiRazgovor.Size = new System.Drawing.Size(112, 23);
            this.ObrisiRazgovor.TabIndex = 3;
            this.ObrisiRazgovor.Text = "Obriši razgovor";
            this.ObrisiRazgovor.UseVisualStyleBackColor = true;
            this.ObrisiRazgovor.Click += new System.EventHandler(this.ObrisiRazgovor_Click);
            // 
            // PrikazRazgovora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(312, 403);
            this.Controls.Add(this.ObrisiRazgovor);
            this.Controls.Add(this.OtvoriRazgovor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RazgovoriListBox);
            this.Name = "PrikazRazgovora";
            this.Text = "PrikazRazgovora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RazgovoriListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OtvoriRazgovor;
        private System.Windows.Forms.Button ObrisiRazgovor;
    }
}
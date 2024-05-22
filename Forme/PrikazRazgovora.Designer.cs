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
            this.RazgovoriListBox.ItemHeight = 17;
            this.RazgovoriListBox.Location = new System.Drawing.Point(13, 67);
            this.RazgovoriListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RazgovoriListBox.Name = "RazgovoriListBox";
            this.RazgovoriListBox.Size = new System.Drawing.Size(383, 378);
            this.RazgovoriListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prikaz razgovora";
            // 
            // OtvoriRazgovor
            // 
            this.OtvoriRazgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OtvoriRazgovor.Location = new System.Drawing.Point(13, 453);
            this.OtvoriRazgovor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OtvoriRazgovor.Name = "OtvoriRazgovor";
            this.OtvoriRazgovor.Size = new System.Drawing.Size(149, 28);
            this.OtvoriRazgovor.TabIndex = 2;
            this.OtvoriRazgovor.Text = "Otvori razgovor";
            this.OtvoriRazgovor.UseVisualStyleBackColor = true;
            this.OtvoriRazgovor.Click += new System.EventHandler(this.OtvoriRazgovor_Click);
            // 
            // ObrisiRazgovor
            // 
            this.ObrisiRazgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ObrisiRazgovor.Location = new System.Drawing.Point(13, 489);
            this.ObrisiRazgovor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ObrisiRazgovor.Name = "ObrisiRazgovor";
            this.ObrisiRazgovor.Size = new System.Drawing.Size(149, 28);
            this.ObrisiRazgovor.TabIndex = 3;
            this.ObrisiRazgovor.Text = "Obriši razgovor";
            this.ObrisiRazgovor.UseVisualStyleBackColor = true;
            this.ObrisiRazgovor.Click += new System.EventHandler(this.ObrisiRazgovor_Click);
            // 
            // PrikazRazgovora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(416, 554);
            this.Controls.Add(this.ObrisiRazgovor);
            this.Controls.Add(this.OtvoriRazgovor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RazgovoriListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
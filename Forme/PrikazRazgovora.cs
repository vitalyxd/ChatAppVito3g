using ChatAppVito3g.Klase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChatAppVito3g.Forme
{
    public partial class PrikazRazgovora : Form
    {
        private List<Razgovor> razgovori = new List<Razgovor>();
        public static int BrojacRazgovora = 1;

        public PrikazRazgovora()
        {
            InitializeComponent();
        }

        public List<Razgovor> Razgovori => razgovori;

        public void DodajRazgovor(Razgovor razgovor)
        {
            razgovori.Add(razgovor);
            AzurirajListBox();
        }

        public void AzurirajListBox()
        {
            RazgovoriListBox.Items.Clear();
            foreach (var razgovor in razgovori)
            {
                RazgovoriListBox.Items.Add(razgovor.ToString());
            }
        }

        private void OtvoriRazgovor_Click(object sender, EventArgs e)
        {
            if (RazgovoriListBox.SelectedItem != null)
            {
                int indeks = RazgovoriListBox.SelectedIndex;
                Razgovor odabraniRazgovor = razgovori[indeks];

                // Otvori formu PosaljiPoruku s odabranim razgovorom
                PosaljiPoruku forma = new PosaljiPoruku(this, odabraniRazgovor);
                forma.Show();
            }
            else
            {
                MessageBox.Show("Molimo odaberite razgovor za otvaranje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObrisiRazgovor_Click(object sender, EventArgs e)
        {
            if (RazgovoriListBox.SelectedItem != null)
            {
                int indeks = RazgovoriListBox.SelectedIndex;
                razgovori.RemoveAt(indeks);
                AzurirajListBox();
            }
            else
            {
                MessageBox.Show("Molimo odaberite razgovor za brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

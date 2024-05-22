using ChatAppVito3g.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppVito3g.Forme
{
    public partial class PrikazRazgovora : Form
    {
        private List<Razgovor> razgovori = new List<Razgovor>();

        public PrikazRazgovora()
        {
            InitializeComponent();
        }

        public void DodajRazgovor(Razgovor razgovor)
        {
            razgovori.Add(razgovor);
            AzurirajListBox();
        }

        private void AzurirajListBox()
        {
            RazgovoriListBox.Items.Clear();
            for (int i = 0; i < razgovori.Count; i++)
            {
                RazgovoriListBox.Items.Add(razgovori[i].ToString());
            }
        }

        private void OtvoriRazgovor_Click(object sender, EventArgs e)
        {
            if (RazgovoriListBox.SelectedItem != null)
            {
                int indeks = RazgovoriListBox.SelectedIndex;
                Razgovor odabraniRazgovor = razgovori[indeks];
                string poruke = string.Join("\n", odabraniRazgovor.Poruke);
                MessageBox.Show($"Otvoren razgovor {indeks + 1}:\n{poruke}", "Otvori Razgovor", MessageBoxButtons.OK, MessageBoxIcon.Information); /* TOOO, treba napravit da se otvori ta forma 
                                                                                                                                                    * PosaljiPoruku.cs sa tim porukama */
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
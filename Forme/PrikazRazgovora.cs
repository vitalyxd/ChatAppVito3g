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
        private List<string> razgovori = new List<string>();

        public PrikazRazgovora()
        {
            InitializeComponent();
        }

        public void DodajRazgovor(string poruka)
        {
            razgovori.Add(poruka);
            AzurirajListBox();
        }

        private void AzurirajListBox()
        {
            RazgovoriListBox.Items.Clear();
            for (int i = 0; i < razgovori.Count; i++)
            {
                RazgovoriListBox.Items.Add("Razgovor " + (i + 1));
            }
        }

        private void OtvoriRazgovor_Click(object sender, EventArgs e)
        {
            if (RazgovoriListBox.SelectedItem != null)
            {
                int indeks = RazgovoriListBox.SelectedIndex;
                string odabraniRazgovor = razgovori[indeks];
                MessageBox.Show($"Otvoren razgovor {indeks + 1}:\n{odabraniRazgovor}", "Otvori Razgovor", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
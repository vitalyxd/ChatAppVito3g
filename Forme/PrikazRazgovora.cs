using ChatAppVito3g.Klase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChatAppVito3g.Forme
{
    public partial class PrikazRazgovora : Form
    {
        private string trenutniKorisnik;
        public static int BrojacRazgovora = 1;
        private PodatkovniKontekst podatkovniKontekst;

        public PrikazRazgovora(string trenutniKorisnik)
        {
            InitializeComponent();
            podatkovniKontekst = new PodatkovniKontekst();
            this.trenutniKorisnik = trenutniKorisnik;
            AzurirajListBox();
        }

        public void AzurirajListBox()
        {
            RazgovoriListBox.Items.Clear();
            var razgovori = DohvatiRazgovoreZaKorisnika(trenutniKorisnik);
            foreach (var razgovor in razgovori)
            {
                RazgovoriListBox.Items.Add(razgovor.ToString());
            }
        }

        private List<Razgovor> DohvatiRazgovoreZaKorisnika(string korisnik)
        {
            List<Razgovor> korisnikoviRazgovori = new List<Razgovor>();
            foreach (var razgovor in podatkovniKontekst.Razgovori)
            {
                if (razgovor.Posiljatelj == korisnik || razgovor.Primatelj == korisnik)
                {
                    korisnikoviRazgovori.Add(razgovor);
                }
            }
            return korisnikoviRazgovori;
        }

        private void OtvoriRazgovor_Click(object sender, EventArgs e)
        {
            if (RazgovoriListBox.SelectedItem != null)
            {
                int indeks = RazgovoriListBox.SelectedIndex;
                var razgovori = DohvatiRazgovoreZaKorisnika(trenutniKorisnik);
                Razgovor odabraniRazgovor = razgovori[indeks];

                if (odabraniRazgovor.JeDioRazgovora(trenutniKorisnik))
                {
                    PosaljiPoruku forma = new PosaljiPoruku(this, odabraniRazgovor, trenutniKorisnik);
                    forma.Show();
                }
                else
                {
                    MessageBox.Show("Nemate pristup ovom razgovoru.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                var razgovori = DohvatiRazgovoreZaKorisnika(trenutniKorisnik);
                Razgovor razgovorZaBrisanje = razgovori[indeks];
                podatkovniKontekst.Razgovori.Remove(razgovorZaBrisanje);
                AzurirajListBox();
                podatkovniKontekst.SpremiRazgovore();
            }
            else
            {
                MessageBox.Show("Molimo odaberite razgovor za brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DodajRazgovor(Razgovor razgovor)
        {
            podatkovniKontekst.DodajRazgovor(razgovor);
            AzurirajListBox();
        }

        private void PrikazRazgovora_FormClosing(object sender, FormClosingEventArgs e)
        {
            podatkovniKontekst.SpremiRazgovore();
        }
    }
}

using ChatAppVito3g.Klase;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ChatAppVito3g.Forme
{
    public partial class KreiranjeKorisnika : Form
    {
        private Korisnik odabraniKorisnik;
        private PodatkovniKontekst podatkovniKontekst;
        private string trenutniUsername;

        public KreiranjeKorisnika(string username)
        {
            InitializeComponent();
            podatkovniKontekst = new PodatkovniKontekst();
            trenutniUsername = username; // Pohrana trenutnog korisničkog imena
            UcitajKorisnike();
        }

        private void KreirajKorisnika_Click(object sender, EventArgs e)
        {
            // Prikupljanje unesenih podataka
            string ime = UnosImena.Text;
            string prezime = UnosPrezimena.Text;
            string godRodjText = UnosGodRodj.Text;
            string email = UnosEmaila.Text;
            string username = UnosUsernamea.Text;
            string password = UnosPassworda.Text;

            // Validacija unesenih podataka
            if (string.IsNullOrWhiteSpace(ime) ||
                string.IsNullOrWhiteSpace(prezime) ||
                string.IsNullOrWhiteSpace(godRodjText) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Molimo popunite sve podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pokušaj parsiranja datuma rođenja u formatu dd.MM.yyyy
            if (!DateTime.TryParseExact(godRodjText, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime godRodj) &&
                !DateTime.TryParseExact(godRodjText, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out godRodj))
            {
                MessageBox.Show("Datum rođenja mora biti u formatu dd.MM.yyyy.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kreiranje novog korisnika
            Korisnik noviKorisnik = new Korisnik(ime, prezime, godRodj, email, username, password);

            // Dodavanje korisnika u ListBox i podatkovni kontekst
            PrikazKorisnika.Items.Add(noviKorisnik);
            podatkovniKontekst.Korisnici.Add(noviKorisnik);

            // Čišćenje polja nakon dodavanja korisnika
            ClearTextBoxes();

            // Spremanje korisnika
            podatkovniKontekst.SpremiKorisnike();

            MessageBox.Show("Uspješno napravljen korisnik");
        }

        private void ObrisiKorisnika_Click(object sender, EventArgs e)
        {
            if (PrikazKorisnika.SelectedItem != null)
            {
                // Brisanje odabranog korisnika iz ListBox-a i podatkovnog konteksta
                Korisnik korisnikZaBrisanje = (Korisnik)PrikazKorisnika.SelectedItem;
                PrikazKorisnika.Items.Remove(korisnikZaBrisanje);
                podatkovniKontekst.Korisnici.Remove(korisnikZaBrisanje);

                // Spremanje promjena
                podatkovniKontekst.SpremiKorisnike();

                MessageBox.Show("Korisnik je uspješno obrisan");
            }
            else
            {
                MessageBox.Show("Molimo odaberite korisnika za brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UrediKorisnika_Click(object sender, EventArgs e)
        {
            if (PrikazKorisnika.SelectedItem != null)
            {
                // Dobivanje odabranog korisnika iz ListBox-a
                odabraniKorisnik = (Korisnik)PrikazKorisnika.SelectedItem;

                // Postavljanje podataka odabranog korisnika u TextBox-ove za uređivanje
                UnosImena.Text = odabraniKorisnik.Ime;
                UnosPrezimena.Text = odabraniKorisnik.Prezime;
                UnosGodRodj.Text = odabraniKorisnik.GodRodj.ToString("dd.MM.yyyy");
                UnosEmaila.Text = odabraniKorisnik.Email;
                UnosUsernamea.Text = odabraniKorisnik.Username;
                UnosPassworda.Text = odabraniKorisnik.Password;
            }
            else
            {
                MessageBox.Show("Molimo odaberite korisnika za uređivanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IzmjeniKorisnika_Click(object sender, EventArgs e)
        {
            if (odabraniKorisnik != null)
            {
                // Ažuriranje podataka odabranog korisnika
                odabraniKorisnik.Ime = UnosImena.Text;
                odabraniKorisnik.Prezime = UnosPrezimena.Text;
                // Validacija i ažuriranje datuma rođenja
                if (DateTime.TryParseExact(UnosGodRodj.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime godRodj))
                {
                    odabraniKorisnik.GodRodj = godRodj;
                }
                else
                {
                    MessageBox.Show("Neispravan format datuma rođenja. Format mora biti dd.MM.yyyy.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                odabraniKorisnik.Email = UnosEmaila.Text;
                odabraniKorisnik.Username = UnosUsernamea.Text;
                odabraniKorisnik.Password = UnosPassworda.Text;
                PrikazKorisnika.Items[PrikazKorisnika.SelectedIndex] = odabraniKorisnik;

                // Spremanje promjena
                podatkovniKontekst.SpremiKorisnike();

                // Oslobađanje odabranog korisnika i čišćenje TextBox-ova
                odabraniKorisnik = null;
                ClearTextBoxes();

                MessageBox.Show("Korisnik je uspješno izmijenjen.");
            }
            else
            {
                MessageBox.Show("Molimo odaberite korisnika za izmjenu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UcitajKorisnike()
        {
            // Učitaj korisnike iz podatkovnog konteksta u ListBox
            foreach (Korisnik korisnik in podatkovniKontekst.Korisnici)
            {
                PrikazKorisnika.Items.Add(korisnik);
            }
        }

        private void ClearTextBoxes()
        {
            UnosImena.Clear();
            UnosPrezimena.Clear();
            UnosGodRodj.Clear();
            UnosEmaila.Clear();
            UnosUsernamea.Clear();
            UnosPassworda.Clear();
        }

        private void PovratakUIzbornik_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(trenutniUsername))
            {
                Izbornik form = new Izbornik(trenutniUsername); // Prosljeđivanje trenutnog korisničkog imena
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Morate biti prijavljeni da biste pristupili izborniku.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PovratakULogin_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }
    }
}

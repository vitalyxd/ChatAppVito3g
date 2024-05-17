﻿using ChatAppVito3g.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppVito3g.Forme
{
    public partial class KreiranjeKorisnika : Form
    {
        private Korisnik odabraniKorisnik;
        public KreiranjeKorisnika()
        {
            InitializeComponent();
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

            // Dodavanje korisnika u ListBox
            PrikazKorisnika.Items.Add(noviKorisnik);

            // Čišćenje polja nakon dodavanja korisnika
            UnosImena.Clear();
            UnosPrezimena.Clear();
            UnosGodRodj.Clear();
            UnosEmaila.Clear();
            UnosUsernamea.Clear();
            UnosPassworda.Clear();

            MessageBox.Show("Uspješno napravljen korisnik");
        }
        private void ObrisiKorisnika_Click(object sender, EventArgs e)
        {
            if (PrikazKorisnika.SelectedItem != null)
            {
                // Brisanje odabranog korisnika iz ListBox-a
                PrikazKorisnika.Items.Remove(PrikazKorisnika.SelectedItem);
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

                // Oslobađanje odabranog korisnika i čišćenje TextBox-ova
                odabraniKorisnik = null;
                ClearTextBoxes();

                // Oslobađanje odabranog korisnika
                odabraniKorisnik = null;

                // Oslobađanje TextBox-ova
                ClearTextBoxes();

                MessageBox.Show("Korisnik je uspješno izmijenjen.");
            }
            else
            {
                MessageBox.Show("Molimo odaberite korisnika za izmjenu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
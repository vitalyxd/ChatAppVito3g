using ChatAppVito3g.Forme;
using System;
using System.Windows.Forms;

namespace ChatAppVito3g
{
    public partial class Izbornik : Form
    {
        private PrikazRazgovora prikazRazgovoraForm;
        private string trenutniUsername;

        public Izbornik(string username)
        {
            InitializeComponent();
            prikazRazgovoraForm = new PrikazRazgovora();
            trenutniUsername = username; // Pohrana trenutnog korisničkog imena
            UsernameTrenutnogKorisnika.Text = $"Prijavljeni ste kao: {trenutniUsername}"; // Prikaz korisničkog imena
        }

        private void KreirajKorisnika_Click(object sender, EventArgs e)
        {
            KreiranjeKorisnika form = new KreiranjeKorisnika(trenutniUsername); // Prosljeđivanje korisničkog imena
            form.Show();
        }

        private void PrikazRazgovora_Click(object sender, EventArgs e)
        {
            prikazRazgovoraForm.ShowDialog();
        }

        private void PosaljiPoruku_Click(object sender, EventArgs e)
        {
            PosaljiPoruku form = new PosaljiPoruku(prikazRazgovoraForm);
            form.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            // Implementacija odjave
            this.Close(); // Zatvaranje forme Izbornik
            var loginForm = new Login();
            loginForm.Show(); // Prikaz forme za prijavu
        }
    }
}

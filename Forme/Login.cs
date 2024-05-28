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
    public partial class Login : Form
    {
        private PodatkovniKontekst podatkovniKontekst;
        public Login()
        {
            InitializeComponent();
            podatkovniKontekst = new PodatkovniKontekst();
        }

        private void Ulogiraj_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text; 
            string password = textBox2.Text;
            var korisnik = podatkovniKontekst.Korisnici.FirstOrDefault(k => k.Username == username && k.Password == password);
            if (korisnik != null)
            {
                // Podaci su točni, omogućavamo prijavu
                MessageBox.Show("Uspješno ste prijavljeni!", "Prijava uspješna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Izbornik form = new Izbornik();
                form.ShowDialog();

                this.Hide();
            }
            else
            {
                // Neispravno korisničko ime ili lozinka
                MessageBox.Show("Neispravno korisničko ime ili lozinka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Registriraj_Click(object sender, EventArgs e)
        {
            KreiranjeKorisnika form = new KreiranjeKorisnika(); 
            form.Show();
            this.Hide();
        }
    }
}   

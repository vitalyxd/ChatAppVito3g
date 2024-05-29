using ChatAppVito3g.Klase;
using System;
using System.Windows.Forms;

namespace ChatAppVito3g.Forme
{
    public partial class PosaljiPoruku : Form
    {
        private PrikazRazgovora prikazRazgovoraForm;
        private Razgovor trenutniRazgovor;
        private PodatkovniKontekst podatkovniKontekst;

        // Konstruktor za novi razgovor
        public PosaljiPoruku(PrikazRazgovora form) : this(form, new Razgovor { Id = PrikazRazgovora.BrojacRazgovora++, Aktivan = true }) { }

        // Konstruktor za postojeći razgovor
        public PosaljiPoruku(PrikazRazgovora form, Razgovor razgovor)
        {
            InitializeComponent();
            prikazRazgovoraForm = form;
            trenutniRazgovor = razgovor;
            podatkovniKontekst = new PodatkovniKontekst(); // Inicijalizacija podatkovnog konteksta
            this.FormClosed += new FormClosedEventHandler(PosaljiPoruku_FormClosed);

            // Prikaz poruka u ListBoxu
            foreach (var poruka in trenutniRazgovor.Poruke)
            {
                PrikazPoruka.Items.Add(poruka);
            }

            // Dodavanje AutoComplete funkcionalnosti za textbox1 tj. unos primatelja
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = GetKorisniciAutoCompleteSource();
        }

        private AutoCompleteStringCollection GetKorisniciAutoCompleteSource()
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            foreach (var korisnik in podatkovniKontekst.Korisnici)
            {
                source.Add(korisnik.Username);
            }
            return source;
        }

        private void Posalji_Click(object sender, EventArgs e)
        {
            string poruka = UpisiPoruku.Text.Trim();

            if (!string.IsNullOrEmpty(poruka))
            {
                PrikazPoruka.Items.Add(poruka);
                trenutniRazgovor.DodajPoruku(poruka); // Dodaj poruku u trenutniRazgovor
                UpisiPoruku.Clear();
                prikazRazgovoraForm.AzurirajListBox(); // Ažuriraj prikaz razgovora
            }
            else
            {
                MessageBox.Show("Unesite poruku prije slanja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PosaljiPoruku_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ažuriraj razgovore samo ako je ovo novi razgovor
            if (!prikazRazgovoraForm.Razgovori.Contains(trenutniRazgovor))
            {
                prikazRazgovoraForm.DodajRazgovor(trenutniRazgovor);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Ovdje možete implementirati dodatnu logiku ako je potrebna
        }
    }
}

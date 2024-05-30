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
        private string trenutniKorisnik;

        // Konstruktor za novi razgovor
        public PosaljiPoruku(PrikazRazgovora form, string trenutniKorisnik)
        : this(form, new Razgovor { Id = PrikazRazgovora.BrojacRazgovora++, Aktivan = true }, trenutniKorisnik) { }

        // Konstruktor za postojeći razgovor
        public PosaljiPoruku(PrikazRazgovora form, Razgovor razgovor, string trenutniKorisnik)
        {
            InitializeComponent();
            prikazRazgovoraForm = form;
            trenutniRazgovor = razgovor;
            podatkovniKontekst = new PodatkovniKontekst();
            this.trenutniKorisnik = trenutniKorisnik;
            this.FormClosed += new FormClosedEventHandler(PosaljiPoruku_FormClosed);

            // Prikaz poruka u ListBoxu
            foreach (var poruka in trenutniRazgovor.Poruke)
            {
                PrikazPoruka.Items.Add(poruka.ToString());
            }

            // Dodavanje AutoComplete funkcionalnosti za textbox1 tj. unos primatelja
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = GetKorisniciAutoCompleteSource();

            // Postavi pošiljatelja
            if (trenutniRazgovor.Posiljatelj == null)
            {
                trenutniRazgovor.Posiljatelj = trenutniKorisnik;
            }
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
            string porukaText = UpisiPoruku.Text.Trim();
            string primatelj = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(porukaText) && !string.IsNullOrEmpty(primatelj))
            {
                if (trenutniRazgovor.Primatelj == null)
                {
                    trenutniRazgovor.Primatelj = primatelj;
                }

                var poruka = new Poruke
                {
                    Id = trenutniRazgovor.Poruke.Count + 1,
                    Posiljatelj = new Korisnik { Username = trenutniKorisnik },
                    Primatelj = new Korisnik { Username = primatelj },
                    Poruka = porukaText
                };

                trenutniRazgovor.DodajPoruku(poruka);
                PrikazPoruka.Items.Add(poruka.ToString());
                UpisiPoruku.Clear();
                prikazRazgovoraForm.AzurirajListBox();
                podatkovniKontekst.SpremiRazgovore(); // Dodaj ovu liniju
            }
            else
            {
                MessageBox.Show("Unesite poruku i primatelja prije slanja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PosaljiPoruku_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!GlobalnaPohrana.SviRazgovori.Contains(trenutniRazgovor))
            {
                GlobalnaPohrana.DodajRazgovor(trenutniRazgovor);
            }
            prikazRazgovoraForm.AzurirajListBox();
            podatkovniKontekst.SpremiRazgovore();
        }
    }
}

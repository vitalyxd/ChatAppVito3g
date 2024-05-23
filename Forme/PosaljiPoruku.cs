using ChatAppVito3g.Klase;
using System;
using System.Windows.Forms;

namespace ChatAppVito3g.Forme
{
    public partial class PosaljiPoruku : Form
    {
        private PrikazRazgovora prikazRazgovoraForm;
        private Razgovor trenutniRazgovor;

        // Konstruktor za novi razgovor
        public PosaljiPoruku(PrikazRazgovora form)
        {
            InitializeComponent();
            prikazRazgovoraForm = form;
            trenutniRazgovor = new Razgovor { Id = PrikazRazgovora.BrojacRazgovora++, Aktivan = true };
            this.FormClosed += new FormClosedEventHandler(PosaljiPoruku_FormClosed);
        }

        // Konstruktor za postojeći razgovor
        public PosaljiPoruku(PrikazRazgovora form, Razgovor razgovor)
        {
            InitializeComponent();
            prikazRazgovoraForm = form;
            trenutniRazgovor = razgovor;
            this.FormClosed += new FormClosedEventHandler(PosaljiPoruku_FormClosed);

            // Prikaz poruka u ListBoxu
            foreach (var poruka in trenutniRazgovor.Poruke)
            {
                PrikazPoruka.Items.Add(poruka);
            }
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
    }
}

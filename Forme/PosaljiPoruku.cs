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
    public partial class PosaljiPoruku : Form
    {
        private static int brojacRazgovora = 1;
        private PrikazRazgovora prikazRazgovoraForm;
        private Razgovor trenutniRazgovor;

        public PosaljiPoruku(PrikazRazgovora form)  
        {
            InitializeComponent();
            prikazRazgovoraForm = form;
            trenutniRazgovor = new Razgovor { Id = brojacRazgovora, Aktivan = true };
            this.FormClosed += new FormClosedEventHandler(PosaljiPoruku_FormClosed);
        }

        private void Posalji_Click(object sender, EventArgs e)
        {
            string poruka = UpisiPoruku.Text.Trim();

            if (!string.IsNullOrEmpty(poruka))
            {
                PrikazPoruka.Items.Add(poruka);
                UpisiPoruku.Clear();
            }
            else
            {
                MessageBox.Show("Unesite poruku prije slanja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PosaljiPoruku_FormClosed(object sender, FormClosedEventArgs e)
        {
            prikazRazgovoraForm.DodajRazgovor(trenutniRazgovor);
            brojacRazgovora++;
        }
    }
}
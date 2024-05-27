using ChatAppVito3g.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppVito3g
{
    public partial class Izbornik : Form
    {
        private PrikazRazgovora prikazRazgovoraForm;

        public Izbornik()
        {
            InitializeComponent();
            prikazRazgovoraForm = new PrikazRazgovora(); // Inicijalizacija instance forme PrikazRazgovora
        }

        private void KreirajKorisnika_Click(object sender, EventArgs e)
        {
            KreiranjeKorisnika form = new KreiranjeKorisnika();
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
    }
}
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

        public PosaljiPoruku(PrikazRazgovora form)
        {
            InitializeComponent();
            prikazRazgovoraForm = form;
        }

        private void Posalji_Click(object sender, EventArgs e)
        {
            string poruka = UpisiPoruku.Text.Trim();

            if (!string.IsNullOrEmpty(poruka))
            {
                string nazivRazgovora = "Razgovor " + brojacRazgovora;
                prikazRazgovoraForm.DodajRazgovor(nazivRazgovora + ": " + poruka);
                brojacRazgovora++;
                UpisiPoruku.Clear();
            }
            else
            {
                MessageBox.Show("Unesite poruku prije slanja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
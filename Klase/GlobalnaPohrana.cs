using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppVito3g.Klase
{
    public static class GlobalnaPohrana
    {
        public static List<Razgovor> SviRazgovori { get; set; } = new List<Razgovor>();

        public static void DodajRazgovor(Razgovor razgovor)
        {
            SviRazgovori.Add(razgovor);
        }

        public static List<Razgovor> DohvatiRazgovoreZaKorisnika(string korisnik)
        {
            return SviRazgovori.FindAll(r => r.JeDioRazgovora(korisnik));
        }
    }
}

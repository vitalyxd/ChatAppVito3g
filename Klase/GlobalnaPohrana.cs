using ChatAppVito3g.Klase;
using System.Collections.Generic;

namespace ChatAppVito3g
{
    public static class GlobalnaPohrana
    {
        private static PodatkovniKontekst podatkovniKontekst = new PodatkovniKontekst();
        public static List<Razgovor> SviRazgovori => podatkovniKontekst.Razgovori;

        public static void DodajRazgovor(Razgovor razgovor)
        {
            podatkovniKontekst.DodajRazgovor(razgovor);
        }

        public static List<Razgovor> DohvatiRazgovoreZaKorisnika(string korisnik)
        {
            List<Razgovor> korisnikoviRazgovori = new List<Razgovor>();
            foreach (var razgovor in SviRazgovori)
            {
                if (razgovor.Posiljatelj == korisnik || razgovor.Primatelj == korisnik)
                {
                    korisnikoviRazgovori.Add(razgovor);
                }
            }
            return korisnikoviRazgovori;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ChatAppVito3g.Klase
{
    public class PodatkovniKontekst
    {
        private List<Korisnik> korisnici;

        public List<Korisnik> Korisnici { get { return this.korisnici; } }

        private string datKorisnici = "korisnici.dat";

        public PodatkovniKontekst()
        {
            this.korisnici = UcitajKorisnike();
        }

        private List<Korisnik> UcitajKorisnike()
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            if (File.Exists(datKorisnici))
            {
                using (StreamReader sr = new StreamReader(datKorisnici))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        string[] polja = linija.Split('|');
                        Korisnik k = new Korisnik
                        {
                            Id = int.Parse(polja[0]),
                            Ime = polja[1],
                            Prezime = polja[2],
                            GodRodj = DateTime.ParseExact(polja[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                            Email = polja[4],
                            Username = polja[5],
                            Password = polja[6]
                        };
                        korisnici.Add(k);
                    }
                }
            }
            return korisnici;
        }

        public void SpremiKorisnike()
        {
            using (StreamWriter sw = new StreamWriter(datKorisnici))
            {
                foreach (Korisnik k in this.Korisnici)
                {
                    sw.WriteLine($"{k.Id}|{k.Ime}|{k.Prezime}|{k.GodRodj:dd.MM.yyyy}|{k.Email}|{k.Username}|{k.Password}");
                }
            }
        }
    }
}

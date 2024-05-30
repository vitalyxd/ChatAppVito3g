using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ChatAppVito3g.Klase
{
    public class PodatkovniKontekst
    {
        private List<Korisnik> korisnici;
        private List<Razgovor> razgovori;
        private string datKorisnici = "korisnici.dat";
        private string datRazgovori = "razgovori.dat";

        public List<Korisnik> Korisnici { get { return this.korisnici; } }
        public List<Razgovor> Razgovori { get { return this.razgovori; } }

        public PodatkovniKontekst()
        {
            this.korisnici = UcitajKorisnike();
            this.razgovori = UcitajRazgovore();
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

        private List<Razgovor> UcitajRazgovore()
        {
            List<Razgovor> razgovori = new List<Razgovor>();
            if (File.Exists(datRazgovori))
            {
                using (StreamReader sr = new StreamReader(datRazgovori))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        string[] polja = linija.Split('|');

                        Razgovor r = new Razgovor
                        {
                            Id = int.Parse(polja[0]),
                            Posiljatelj = polja[1],
                            Primatelj = polja[2],
                            Aktivan = bool.Parse(polja[3])
                        };

                        for (int i = 4; i < polja.Length; i += 4)
                        {
                            Poruke p = new Poruke
                            {
                                Id = int.Parse(polja[i]),
                                Posiljatelj = new Korisnik { Username = polja[i + 1] },
                                Primatelj = new Korisnik { Username = polja[i + 2] },
                                Poruka = polja[i + 3]
                            };
                            r.DodajPoruku(p);
                        }

                        razgovori.Add(r);
                    }
                }
            }
            return razgovori;
        }

        public void SpremiRazgovore()
        {
            using (StreamWriter sw = new StreamWriter(datRazgovori))
            {
                foreach (Razgovor r in this.razgovori)
                {
                    sw.Write($"{r.Id}|{r.Posiljatelj}|{r.Primatelj}|{r.Aktivan}");

                    foreach (Poruke p in r.Poruke)
                    {
                        sw.Write($"|{p.Id}|{p.Posiljatelj.Username}|{p.Primatelj.Username}|{p.Poruka}");
                    }
                    sw.WriteLine();
                }
            }
        }

        public void DodajRazgovor(Razgovor razgovor)
        {
            this.razgovori.Add(razgovor);
            SpremiRazgovore();
        }
    }
}

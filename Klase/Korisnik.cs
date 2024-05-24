using System;

namespace ChatAppVito3g.Klase
{
    public class Korisnik : IComparable
    {
        private static int idCounter = 1;
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime GodRodj { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Korisnik()
        {
            this.Id = idCounter++;
        }

        public Korisnik(string ime, string prezime, DateTime godRodj, string email, string korisnickoIme, string password) : this()
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.GodRodj = godRodj;
            this.Email = email;
            this.Username = korisnickoIme;
            this.Password = password;
        }

        public int CompareTo(object obj)
        {
            int rez = this.Id.CompareTo(((Korisnik)obj).Id);
            if (rez == 0) rez = this.Username.CompareTo(((Korisnik)obj).Username);
            if (rez == 0) rez = this.Email.CompareTo(((Korisnik)obj).Email);
            return rez;
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime} ({Username}) - {Email} - {GodRodj:dd.MM.yyyy}";
        }
    }
}

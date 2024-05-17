﻿using System;

namespace ChatAppVito3g.Klase
{
    public class Korisnik : IComparable
    {
        private int id;
        private string ime;
        private string prezime;
        private DateTime godRodj;
        private string email;
        private string username;
        private string password;

        // Konstruktor bez parametara
        public Korisnik() { }

        // Konstruktor s parametrima
        public Korisnik(string ime, string prezime, DateTime godRodj, string email, string korisnickoIme, string password)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godRodj = godRodj;
            this.email = email;
            this.username = korisnickoIme;
            this.password = password;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public DateTime GodRodj
        {
            get { return godRodj; }
            set { godRodj = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int CompareTo(object obj)
        {
            int rez = this.id.CompareTo(((Korisnik)obj).id);
            if (rez == 0) rez = this.username.CompareTo(((Korisnik)obj).username);
            if (rez == 0) rez = this.email.CompareTo(((Korisnik)obj).email);
            return rez;
        }

        public override string ToString()
        {
            return $"{ime} {prezime} ({username}) - {email} - {godRodj.ToString("dd.MM.yyyy")}";
        }
    }
}

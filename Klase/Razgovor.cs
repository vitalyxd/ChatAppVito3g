using System;
using System.Collections.Generic;

namespace ChatAppVito3g.Klase
{
    public class Razgovor : IComparable
    {
        private int id;
        private List<Poruke> poruke = new List<Poruke>();
        private bool aktivan;
        private string posiljatelj;
        private string primatelj;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public List<Poruke> Poruke
        {
            get { return poruke; }
            set { poruke = value; }
        }

        public bool Aktivan
        {
            get { return aktivan; }
            set { aktivan = value; }
        }

        public string Posiljatelj
        {
            get { return posiljatelj; }
            set { posiljatelj = value; }
        }

        public string Primatelj
        {
            get { return primatelj; }
            set { primatelj = value; }
        }

        public void DodajPoruku(Poruke poruka)
        {
            poruke.Add(poruka);
        }

        public bool JeDioRazgovora(string korisnik)
        {
            return korisnik == posiljatelj || korisnik == primatelj;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Razgovor otherRazgovor = obj as Razgovor;
            if (otherRazgovor != null)
                return this.id.CompareTo(otherRazgovor.id);
            else
                throw new ArgumentException("Object is not a Razgovor");
        }

        public override string ToString()
        {
            return $"Razgovor {Id}, Aktivan: {Aktivan}, Broj Poruka: {Poruke.Count}";
        }
    }
}

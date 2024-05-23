using System;
using System.Collections.Generic;

namespace ChatAppVito3g.Klase
{
    public class Razgovor : IComparable
    {
        private int id;
        private List<string> poruke = new List<string>();
        private bool aktivan;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public List<string> Poruke
        {
            get { return poruke; }
            set { poruke = value; }
        }

        public bool Aktivan
        {
            get { return aktivan; }
            set { aktivan = value; }
        }

        public void DodajPoruku(string poruka)
        {
            poruke.Add(poruka);
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

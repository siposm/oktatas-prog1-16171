using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaProject
{
    class Tulaj
    {
        string nev;
        DateTime szuletisdatum;
        bool nem;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        public DateTime Szuletisdatum
        {
            get { return szuletisdatum; }
            set { szuletisdatum = value; }
        }
        public bool Nem
        {
            get { return nem; }
            set { nem = value; }
        }

        public Tulaj(string nev, DateTime szuletisdatum, bool nem)
        {
            this.nev = nev;
            this.szuletisdatum = szuletisdatum;
            this.nem = nem;
        }

        public bool OrvosiVizsgalatEsedekes()
        {
            if ((DateTime.Today.Year - szuletisdatum.Year) > 56)
            {
                return true;
            }
            else
                return false;
        }
    }
}

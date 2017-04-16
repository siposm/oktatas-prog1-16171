using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaProject
{
    class Auto
    {
        string rendszam;
        string marka;
        string tipus;
        int forgalmbahelyezesEve;
        int loero;
        int suly;
        Tulaj tulajdonos;


        public string Rendszam
        {
            get { return rendszam; }
            //set { rendszam = value; }
        }
        public string Marka
        {
            get { return marka; }
        }
        public string Tipus
        {
            get { return tipus; }
        }
        public int ForgalmbahelyezesEve
        {
            get { return forgalmbahelyezesEve; }
            set { forgalmbahelyezesEve = value; }
        }
        public int Loero
        {
            get { return loero; }
        }
        public int Suly
        {
            get { return suly; }
        }
        public Tulaj Tulajdonos
        {
            get { return tulajdonos; }
            //set { tulajdonos = value; }
        }

        public Auto(string rendszam, string marka, string tipus, int forgalmbahelyezesEve, int loero, int suly)
        {
            this.rendszam = rendszam;
            this.marka = marka;
            this.tipus = tipus;
            this.forgalmbahelyezesEve = forgalmbahelyezesEve;
            this.loero = loero;
            this.suly = suly;
        }

        public Auto(string rendszam, string marka, string tipus, int forgalmbahelyezesEve, int loero, int suly, Tulaj tulajdonos)
        {
            this.rendszam = rendszam;
            this.marka = marka;
            this.tipus = tipus;
            this.forgalmbahelyezesEve = forgalmbahelyezesEve;
            this.loero = loero;
            this.suly = suly;
            this.tulajdonos = tulajdonos;
        }

        public void AdatokLekerdez()
        {
            Console.WriteLine("{0} > {1}, {2} - FH: {3} - LE: {4}" ,
                rendszam,
                marka,
                tipus,
                forgalmbahelyezesEve,
                loero
                );
        }

        public char Jelolo()
        {
            return marka.ToUpper()[0];
        }

        public int Vamolas()
        {
            double europaiSzabvanyErtek = 23.64;
            return (suly * loero) / (int)Math.Floor(loero / europaiSzabvanyErtek) * DateTime.Today.Year;
        }

        public void TulajdonosValtas(Tulaj ujtulajdonos)
        {
            this.tulajdonos = ujtulajdonos;
        }

        public bool SzervizEsedekes()
        {
            if ((DateTime.Today.Year - forgalmbahelyezesEve) > 5)
            {
                return true;
            }
            return false;
        }

        public void TeljesitmenyNoveles(int mertek)
        {
            loero += Math.Abs(mertek);
        }

        public bool RendszamModositas(string[] rendszamok, string ujRendszam)
        {
            int i = 0;
            while (i < rendszamok.Length && rendszamok[i] != ujRendszam)
            {
                i++;
            }

            if (i >= rendszamok.Length)
            {
                // nincs lefoglalva az új rendszám, cserélhetünk
                rendszam = ujRendszam;
                return true;
            }
            else
                return false;
        }
    }
}

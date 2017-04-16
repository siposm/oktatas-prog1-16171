using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaProject
{
    class AutoKezelo
    {
        public Auto[] Import()
        {
            StreamReader sr = new StreamReader("AUTOK.txt");
            Auto[] autok = new Auto[AutokSzama()];
            int index = 0;
            while (!sr.EndOfStream)
            {
                string sorAdat = sr.ReadLine();

                string[] autoAdatai = sorAdat.Split('>')[0].Split(':');
                string[] tulajAdati = sorAdat.Split('>')[1].Split('/');

                string rendszam = autoAdatai[0].Split('@')[1];
                string marka = autoAdatai[1].Split(',')[0];
                string tipus = autoAdatai[1].Split(',')[1];

                bool nem = false;
                if (tulajAdati[2] == "Nő")
                {
                    nem = true;
                }

               Tulaj tulaj = new Tulaj(
                   tulajAdati[0],
                   DateTime.Parse(tulajAdati[1]),
                   nem
                   );

               autok[index++] = new Auto(
                   rendszam,
                   marka,
                   tipus,
                   int.Parse(autoAdatai[2]),
                   int.Parse(autoAdatai[3]),
                   int.Parse(autoAdatai[4]),
                   tulaj
                   );
            }
            sr.Close();



            return autok;
        }
        
        private int AutokSzama()
        {
            int sorszam = 0;
            StreamReader sr = new StreamReader("AUTOK.txt");
            while (!sr.EndOfStream)
            {
                sorszam++;
                sr.ReadLine();
            }
            sr.Close();
            return sorszam;
        }

        public string[] RendszamokKinyerese(Auto[] autok)
        {
            string[] rendszamok = new string[autok.Length];
            for (int i = 0; i < rendszamok.Length; i++)
			{
                rendszamok[i] = autok[i].Rendszam;
			}
            return rendszamok;
        }

        public int AutokBehozatala(Auto[] autok)
        {
            int min = 0;
            for (int i = 1; i < autok.Length; i++)
            {
                if (autok[i].Vamolas() < autok[min].Vamolas())
                {
                    min = i;
                }
            }
            return min;
        }

        public void AutokTulajaiVezethetnek(Auto[] autok)
        {
            for (int i = 0; i < autok.Length; i++)
            {
                Console.WriteLine(autok[i].Tulajdonos.OrvosiVizsgalatEsedekes());
            }
        }
    }
}

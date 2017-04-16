using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaProject
{
    class ParkoloAlgoritmus
    {
        Auto[,] parkolo;

        public Auto[,] Parkolo
        {
            get { return parkolo; }
            set { parkolo = value; }
        }

        public ParkoloAlgoritmus()
        {
            parkolo = new Auto[10,20];
        }

        public void AutokParkirozasa(Auto[] autok)
        {
            StreamReader sr = new StreamReader("GPS.txt");
            int index = 0;
            while (!sr.EndOfStream)
            {
                string[] koordinatak = sr.ReadLine().Split('|');
                parkolo[
                    int.Parse(koordinatak[0]),
                    int.Parse(koordinatak[1])
                    ] = autok[index++];
            }
            sr.Close();
        }

        public void ParkoloMegjelenit()
        {
            for (int i = 0; i < parkolo.GetLength(0); i++)
            {
                for (int j = 0; j < parkolo.GetLength(1); j++)
                {
                    if (parkolo[i,j] != null)
                    {
                        Console.Write(parkolo[i,j].Jelolo());
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine("");
            }
        }

        public int UresParkolokSzama()
        {
            int db = 0;
            for (int i = 0; i < parkolo.GetLength(0); i++)
            {
                for (int j = 0; j < parkolo.GetLength(1); j++)
                {
                    if (parkolo[i,j] == null)
                    {
                        db++;
                    }
                }
            }
            return db;
        }

        public int[] FoglaltParkolokSzamaSoronkent()
        {
            int[] soronkentiDbSzamok = new int[parkolo.GetLength(0)];

            for (int i = 0; i < parkolo.GetLength(0); i++)
            {
                for (int j = 0; j < parkolo.GetLength(1); j++)
                {
                    if (parkolo[i, j] != null)
                    {
                        soronkentiDbSzamok[i] += 1;
                    }
                }
            }
            return soronkentiDbSzamok;
        }

        public void FoglaltParkolokExport(int[] autokSzamaSoronkent)
        {
            StreamWriter sw = new StreamWriter("autokSzamaExport.txt");
            for (int i = 0; i < autokSzamaSoronkent.Length; i++)
            {
                sw.WriteLine(autokSzamaSoronkent[i]);
            }
            sw.Close();
        }
    }
}

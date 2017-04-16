using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoKezelo ak = new AutoKezelo();
            Auto[] autok = ak.Import();

            ParkoloAlgoritmus pa = new ParkoloAlgoritmus();
            pa.AutokParkirozasa(autok);
            pa.ParkoloMegjelenit();



            // Rendszám módosítása - jó eset
            bool eredmeny = autok[0].RendszamModositas(ak.RendszamokKinyerese(autok), "AAA111");
            Console.WriteLine("rendszám módosítása, jó eset: " + eredmeny);

            // Rendszám módosítása - rossz eset
            eredmeny = autok[0].RendszamModositas(ak.RendszamokKinyerese(autok), "MES112");
            Console.WriteLine("rendszám módosítása, rossz eset: " + eredmeny);


            // Szervíz esedékesség tesztelése
            for (int i = 0; i < autok.Length; i++)
            {
                Console.WriteLine(autok[i].SzervizEsedekes());
            }

            // autók behozatala
            autok[ak.AutokBehozatala(autok)].AdatokLekerdez();

            // autó tulajok orvosi vizsgálata
            ak.AutokTulajaiVezethetnek(autok);

            
            int[] foglaltak = pa.FoglaltParkolokSzamaSoronkent();
            pa.FoglaltParkolokExport(foglaltak);
        }
    }
}

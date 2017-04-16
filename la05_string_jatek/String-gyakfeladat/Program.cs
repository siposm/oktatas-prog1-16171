using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_gyakfeladat
{
    class Program
    {


        static string NeptunGeneral()
        {

            Random r = new Random();
            char[] abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string neptunKod = "";

            for (int i = 0; i < 6; i++) // neptun kód karakterszáma
            {

                if (r.Next(0,2) == 0)
                {
                    // betű - abc-ből valamilyek karakter
                    neptunKod += abc[r.Next(0, abc.Length)]; // nem kell -1 !!!
                }
                else
                {
                    // szám - 0-9
                    neptunKod += r.Next(0, 10);
                }
            }

            return neptunKod;
            
        }

        static int BetuSzamlal(string bemenet)
        {
            int szamlalo = 0;
            for (int i = 0; i < bemenet.Length; i++)
            {
                if ( char.IsLetter(bemenet[i]) )
                {
                    szamlalo++;
                }
            }
            return szamlalo;
        }

        static string SpaceTorol(string bemenet)
        {
            string vissza = "";

            for (int i = 0; i < bemenet.Length; i++)
            {
                if (bemenet[i] != ' ')
                {
                    vissza += bemenet[i];
                }
            }

            return vissza;
        }

        static bool PalindromE(string eredetiSzoveg) // spacek gondot okozhatnak !!!
        {
            bool palindrom = true;

            string forditottSzoveg = "";

            // készítettünk egy fordított stringet
            for (int i = eredetiSzoveg.Length-1; i >= 0; i--)
            {
                forditottSzoveg += eredetiSzoveg[i];
            }

            // vizsgálat egyszerűen azonos helyen lévő karakterek összehasonlítása
            for (int i = 0; i < eredetiSzoveg.Length; i++)
            {
                if (eredetiSzoveg[i] != forditottSzoveg[i])
                {
                    palindrom = false;
                }
            }

            return palindrom;
        }


        static void Main(string[] args)
        {


             // 0. Írjon programot, amely előállít egy véletlen Neptun kódot!
             // A Neptun kódok 6 karakterből állnak. Minden karakter az angol ABC nagybetűje, illetve 0 és 9 közötti számjegy lehet.
            
            string nk = NeptunGeneral();
            Console.WriteLine(nk);


            // 1. Írjon programot, amely egy szöveges változóban megszámolja a betűket!

            int szam = BetuSzamlal(nk);
            Console.WriteLine("{0}-ben {1} db betű van.", nk, szam);


            // 2. Írjon programot, amely egy szövegből eltűnteti a szóközöket.

            string spacekNelkul = SpaceTorol("A szegedi egyetemen különleges méltányosságot kapott a hivatalvezető lánya.");
            Console.WriteLine(spacekNelkul);


            // 3. Írjon programot, amely egy szövegről megmondja, hogy palindrom-e.
            // Megjegyzés: ezt rekurzív programozási tétellel volna optimális megvalósítani.
            
            // space-k bezavarhatnak, ezért töröljük előtte őket
            bool elsoEset = PalindromE(SpaceTorol("indul a görög aludni"));
            bool masodikEset = PalindromE(SpaceTorol("alma"));
            Console.WriteLine(elsoEset);
            Console.WriteLine(masodikEset);
        }
    }
}

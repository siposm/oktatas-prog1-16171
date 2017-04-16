using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErtekAtadas
{

    class Szemely
    {
        public string nev;
        public string eletkor;
    }

    class Program
    {

        // NEM ÉRTÉK SZERINT
        static void NemErtekSzerint(int valtozo)
        {
            valtozo += 900;
        }

        static void NemErtekSzerint(int[] tomb)
        {
            tomb[0] += 300;
        }

        




        // ÉRTÉK SZERINT
        static void ErtekSzerint(ref int valtozo)
        {
            valtozo += 900;
            
            // innen persze működik
            //Console.WriteLine(valtozo);
        }


        static void ErtekSzerint(int[] tomb)
        {
            tomb[0] += 300;
        }






        static void Main(string[] args)
        {

            // ÉRTÉK ALAPJÁN 
            int a = 10;
            
            NemErtekSzerint(a);
            Console.WriteLine(a); // a értéke változatlan

            ErtekSzerint(ref a);
            Console.WriteLine(a); // a értéke megváltozott

            Console.WriteLine("-------------------");

            // REFERENCIA ALAPJÁN
            int[] tomb = { 1, 2, 3, 4, 555, 10 };

            NemErtekSzerint(tomb);
            Console.WriteLine(tomb[0]); // tomb[0] értéke változatlan

            ErtekSzerint(tomb);
            Console.WriteLine(tomb[0]); // tomb[0] értéke megváltozott

        }
    }
}

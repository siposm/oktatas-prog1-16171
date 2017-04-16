using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosarlabdaDobasSzimulalo
{
    class Program
    {

        static void DobasokGeneralasa(int[] dobasok)
        {
            Random r = new Random();
            for (int i = 0; i < dobasok.Length; i++)
            {
                dobasok[i] = r.Next(0, 101);
            }
        }

        static int LegnagyobbDobas(int[] dobasok)
        {

            int max = 0;
            for (int i = 1; i < dobasok.Length; i++)
            {
                if (dobasok[max] < dobasok[i])
                {
                    // van új max érték
                    max = i;
                }
            }


            return max;
        }


        static void Main(string[] args)
        {
            Console.Write("Dobások száma?: ");
            int dbSzam = int.Parse(Console.ReadLine());

            int[] dobasok = new int[dbSzam];

            DobasokGeneralasa(dobasok);

            int max = LegnagyobbDobas(dobasok);
            Console.WriteLine("Az első legnagyobb dobás a(z) {0}. helyen volt és az értéke {1}.", max+1, dobasok[max]);
            
        }
    }
}

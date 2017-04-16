using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh_A_B_csoport
{
    class Program
    {


        static void MatrixGeneral()
        {
            int sorSzamA = 15;
            int oszlopSzamA = 6;

            int sorSzamB = 5;
            int oszlopSzamB = 10;
            
            Random r = new Random();
            int[,] matrix = new int[sorSzamB,oszlopSzamB];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(0, 100);
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }


        static int SzamjegySzamol(string mondat)
        {
            int db = 0;
            for (int i = 0; i < mondat.Length; i++)
            {
                if ( char.IsDigit(mondat[i]) )
                {
                    db++;
                }
            }
            return db;
        }

        static int BetuSzamol(string mondat)
        {
            int db = 0;
            for (int i = 0; i < mondat.Length; i++)
            {
                if (char.IsLetter(mondat[i]))
                {
                    db++;
                }
            }
            return db;
        }


        static void Main(string[] args)
        {

            MatrixGeneral();

            string valami = "Indul a Görög 789 Aludni 99";

            int szdb = SzamjegySzamol(valami);
            int bdb = BetuSzamol(valami);

            Console.WriteLine("{0} db számjegy van",szdb);
            Console.WriteLine("{0} db betű van",bdb);



        }
    }
}

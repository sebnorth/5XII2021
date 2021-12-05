using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * s - ilość spacji
             * k - ilość krzyżyków
             * s+k = n
             */
            Console.WriteLine("Podaj rozmiar bok kwadratu: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++) // i - numer wiersza = k
            {

                int z;
                // ustaw n-k = n-i spacji
                for (z = 0; z < n-i; z++)
                {
                    Console.Write(" ");
                }

                // dostaw i krzyżyków
                for (z=0; z < i; z++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}

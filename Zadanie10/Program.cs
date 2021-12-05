using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar bok kwadratu: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) // piątemu wierszowi odpowiada i = 4
            {
                for (int j = 0; j <= i; j++) // pierwszej kolumnie odpowiada j = 0
                {
                    Console.Write("{0,4} ", (i+1)*(j+1));
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}

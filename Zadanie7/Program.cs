using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine("Liczba {0} jest dzielnikiem liczby {1}.", b, a);
            }
            else {

                Console.WriteLine("Liczba {0} jest NIE dzielnikiem liczby {1}.", b, a);
            }

            Console.Write("Dzielniki liczby {0}: ",a);
            for (int i = 1; i < a; i++)
            {
                if (a%i==0)
                {
                    Console.Write("{0}, ",i);
                }

            }
            Console.Write("{0}.", a);


            Console.ReadKey();
        }
    }
}

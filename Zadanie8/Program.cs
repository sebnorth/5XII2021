using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość zmiennej ile: ");
            int ile = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ile-1; i++)
            {
                Console.Write("{0}, ", 7*i);
            }

            Console.Write("{0}.", 7 * (ile-1));

            Console.ReadKey();
        }
    }
}

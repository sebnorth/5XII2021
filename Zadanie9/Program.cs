using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            // n - ilość kolejnych liczb nieparzystych
            // suma - suma n pierwszych liczb nieparzystych
            // wzór ogólny na liczbę nieparzystą: 2*numer + 1 albo 2*numer - 1
            Console.WriteLine("Podaj wartość n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int suma = 0;

            for (int i = 0; i < n-1; i++)
            {
                // 2*i+1 to będzie i-ta liczba nieparzysta
                Console.Write("{0} + ", 2*i+1);
                suma += (2 * i + 1);
            }
            Console.Write("{0} = ", 2 * (n-1) + 1);
            suma += (2 * (n-1) + 1);

            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}

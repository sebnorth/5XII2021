using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  wersja 1D
             *  uzytkownik podaje n
             *  program wypisuje bez odstępów n znaków "*"
             *  
             *  wersja 2D
             *  poprzedni kod obejmujemy w pętli zewnętrznej
             *  
             *  i - numer wiersza
             *  j - numer kolumny
             */

            Console.WriteLine("Podaj rozmiar bok kwadratu: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }


            Console.ReadKey();

        }
    }
}

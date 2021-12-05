using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dlug = 80;
            int dziennyZarobekJanka = 50;
            int dziennyZarobekKarola = 40;
            double aktualnieSplaconyDlug = 0;
            int dzien = 0;

            do
            {
                dzien++;
                aktualnieSplaconyDlug += (0.2 * dziennyZarobekKarola + 0.2 * dziennyZarobekJanka);
                Console.WriteLine("dzień nr: {0}, spłata łączna do tego dnia: {1}", dzien, aktualnieSplaconyDlug);
            } while (aktualnieSplaconyDlug < dlug);

            Console.ReadKey();
        }
    }
}

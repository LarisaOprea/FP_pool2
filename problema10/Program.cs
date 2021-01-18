using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema10
{
    class Program
    {
        static void Main(string[] args)
        {
            ///10.Se da o secventa de n numere. 
            ///Care este numarul maxim de numere consecutive egale din secventa. 
            int n, x, y, lc = 1, lmax = 1, i;
            Console.WriteLine("Introduceti numarul de elemente al secventei");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei");
            x = int.Parse(Console.ReadLine());

            for (i = 2; i <= n; i++)
            {
                y = int.Parse(Console.ReadLine());
                if (x == y)
                    lc++;
                else
                    lc = 1;
                if (lc > lmax)
                    lmax = lc;
                x = y;
            }
            Console.WriteLine("Numarul maxim de numere consecutive egale din secventa este {0}", lmax);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            ///5.Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. 
            ///Se considera ca primul element din secventa este pe pozitia 0.

            int n, x, nr = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n - 1; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == i) nr++;
            }
            Console.WriteLine(nr);

            Console.ReadKey();
        }
    }
}

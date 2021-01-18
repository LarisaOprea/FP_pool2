using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema12
{
    class Program
    {
        static void Main(string[] args)
        {
            ///12.Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
            ///Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.
            int n, a, b, nr = 0;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            if (a != 0) nr = 1;
            for (int i = 2; i <= n; i++)
            {
                b = int.Parse(Console.ReadLine());
                if ((a == 0) && (b != 0)) nr++;
                a = b;
            }
            Console.WriteLine(nr);

            Console.ReadKey();
        }
    }
}

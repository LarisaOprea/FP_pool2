using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///1.Se da o secventa de n numere. 
            ///Sa se determine cate din ele sunt pare. 
            int n, nrpare = 0, x;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) ;
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0) nrpare++;
            }
            Console.WriteLine("Sunt " + nrpare + " numere pare in secventa.");

            Console.ReadKey();

        }
    }
}

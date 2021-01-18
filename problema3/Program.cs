using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///3.Calculati suma si produsul numerelor de la 1 la n. 
            int n, suma = 0, prod = 1;
            n = int.Parse(Console.ReadLine());
            suma = n * (n + 1) / 2;

            for (int i = 1; i <= n; i++) 
            {
                prod = n * i;
            }
            Console.WriteLine("Suma este:" + suma + "");
            Console.WriteLine("Produsul este:" + prod + "");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema6
{
    class Program
    {
        static void Main(string[] args)
        {
            ///6.Se da o secventa de n numere. 
            ///Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
            int n, a, b;
            bool cresc = true;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a > b) cresc = false;
                a = b;
            }
            if (cresc == true) Console.WriteLine("Secventa este crescatoare.");
            else Console.WriteLine("Secventa nu este crescatoare");

            Console.ReadKey();
         }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            ///4.Se da o secventa de n numere. 
            ///Determinati pe ce pozitie se afla in secventa un numar a. 
            ///Se considera ca primul element din secventa este pe pozitia zero. 
            ///Daca numarul nu se afla in secventa raspunsul va fi -1. 

            int a, n, x, poz = -1;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (int i=0;i<=n-1;i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == a) poz = i;
            }
            Console.WriteLine(poz);

            Console.ReadKey();





        }
    }
}

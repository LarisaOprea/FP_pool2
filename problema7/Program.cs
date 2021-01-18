using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema7
{
    class Program
    {
        static void Main(string[] args)
        {
            ///7.Se da o secventa de n numere.
            ///Sa se determine cea mai mare si cea mai mica valoare din secventa. 
            int n, minim, maxim, x;
            n = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            minim = x;
            maxim = x;

            for (int i = 2; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x > maxim) maxim = x;
                if (x < minim) minim = x;
            }
            Console.WriteLine("Maximul este'maxim'");
            Console.WriteLine("Minimul este'minim'");

            Console.ReadKey();
        
        }
    }
}

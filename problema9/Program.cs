using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema9
{
    class Program
    {
        static void Main(string[] args)
        {
            ///9.Sa se determine daca o secventa de n numere este monotona.
            ///Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
            int n, a, b;

            bool cresc = true; bool descres = true;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a > b) cresc = false;
                if (a < b) descres = false;
                a = b;
            }
            if ((cresc = true) || (descres = true)) Console.WriteLine("Secventa este monotona");
            else Console.WriteLine("Secventa nu este monotona");

            Console.ReadLine();
        }
    }
}

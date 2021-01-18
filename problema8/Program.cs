using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema8
{
    class Program
    {
        static void Main(string[] args)
        {
            ///8.Determianti al n-lea numar din sirul lui Fibonacci. 
            ///Exemplu: 0, 1, 1, 2, 3, 5, 8 ...

            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            int firstNumber = 1, secondNumber = 1;
            int fn;

            for (int i = 2; i < n; i++)
            {
                fn = firstNumber + secondNumber;
                secondNumber = firstNumber;
                firstNumber = fn;
            }
            Console.WriteLine("Al {0}-lea termen din sirul fibonacci este {1} ", n, firstNumber);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema13
{
    class Program
    {
        static void Main(string[] args)
        {
            ///13.O <secventa crescatoare rotita> este o secventa de numere 
            ///care este in ordine crescatoare sau poate fi transformata 
            ///intr-o secventa in ordine crescatoare prin rotiri succesive 
            ///(rotire cu o pozitie spre stanga = toate elementele 
            ///se muta cu o pozitie spre stanga si primul element devine ultimul).
            ///Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
            int n, a = 0, b = 0;
            bool cresc = false, descr = false, raspuns = true;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a < b) cresc = true;
            else descr = true;
            a = b;
            if (cresc == true)
            {
                for (int i = 3; i <= n; i++)
                {
                    b = int.Parse(Console.ReadLine());
                    if ((a > b))
                    {
                        descr = true;
                    }
                    else if ((a < b) && (descr == true))
                    {
                        raspuns = false;
                    }
                    a = b;
                }
            }
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    b = int.Parse(Console.ReadLine());
                    if ((a < b))
                    {
                        cresc = true;
                    }
                    else if ((a > b) && (descr == false))
                    {
                        raspuns = false;
                    }
                    a = b;
                }
            }
            if (raspuns == true) Console.WriteLine("Secventa poate fi rotita");
            else Console.WriteLine("Secventa nu poate fi rotita");

            Console.ReadKey();
        }
    }
}

using System;
using System.Data.Common;

namespace uppgift6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Störst(6,6);
        }
        static void Störst(int tal1, int tal2)
        {
            if(tal1 > tal2)
            {
                Console.WriteLine("Den största talen är" + tal1 + ".");
            }
            else if(tal1 < tal2)
            {
                Console.WriteLine("Den största talen är" + tal2 + ".");
            }
            else if(tal1 == tal2)
            {
                Console.WriteLine("De är lika stora");
            }
        }
    }
}
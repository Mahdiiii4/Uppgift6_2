using System;
namespace uppgift6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ner var en nummer på var sin rad");
            int nummer = int.Parse(Console.ReadLine());
            int nummer2 = int.Parse(Console.ReadLine());
            int nummer3 = int.Parse(Console.ReadLine());
            tal(nummer, nummer2, nummer3);
        }
        static void tal(int tal1, int tal2, int tal3)
        {
            int summa = tal1 + tal2 + tal3;
            Console.WriteLine("Den summa är" + summa + ".");
        }
    }
}

using System;

namespace Praktika_OddAndEen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 98;
            CheckNumber Cnum = new CheckNumber();
            Console.WriteLine("Eded Tekdir?");
            Console.WriteLine(Cnum.isOdd(number));
            Console.WriteLine("Eded Cutdur?");
            Console.WriteLine(Cnum.isEven(number));
        }
    }
}

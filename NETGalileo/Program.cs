namespace NETGalileo
{
    using System;
    using Helpers;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Primes between 0 and 100 ---");

            for (int i = 0; i < 100; i++)
            {
                bool prime = PrimeHelper.IsPrime(i);
                if (prime)
                {
                    Console.Write("Prime: ");
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}

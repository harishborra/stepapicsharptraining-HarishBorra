using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("The number " + n + " is EVEN ");
            }
            else
            {
                Console.WriteLine("The number " + n + " is ODD ");
            }
        }
    }
}

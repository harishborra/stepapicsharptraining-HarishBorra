using System;

namespace FibnocciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number upto which we need the series :");
            int n = int.Parse(Console.ReadLine());
            int i, f1 = 0, f2 = 1,f3;
            Console.Write(f1+" ");
            Console.Write(f2+" ");
            for (i = 2; i < n; i++)
            {
                f3 = f1 + f2;
                Console.Write(f3+" ");
                f1 = f2;
                f2 = f3;
            }
        }
    }
}

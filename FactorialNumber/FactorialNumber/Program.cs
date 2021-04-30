using System;

namespace FactorialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FINDING THE FACTORIAL OF NUMBER");
            Console.WriteLine("Enter the Number:");
            int n = int.Parse(Console.ReadLine());
            int f = 1,temp=n;
            for(int i = 1; i < n; i++)
            {
                f = f * temp;
                temp--;
            }
            Console.WriteLine("The Factorial of " + n + " is " + f);
            Console.ReadLine();
        }
    }
}

using System;

namespace ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of Array :");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the numbers in the array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Entered Array Elements are");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s += arr[i];
            }
            Console.WriteLine("The Sum of Array Elements is : "+ s);
            Console.ReadLine();
        }
    }
}

using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Generating Armstrong Numbers With in Given Range****");
            Console.WriteLine("Enter UpperLimit and LowerLimit");
            int l = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = l + 1; i < r; i++)
            {
                int temp = i,rem,s=0;
                while (temp > 0)
                {
                    rem = temp % 10;
                    s += rem * rem * rem;
                    temp = temp / 10;
                    
                }
                if (s == i)
                {
                    if (count == 0)
                    {
                        Console.WriteLine("The Armstrong Numbers With in Given Range are : ");
                    }
                    Console.WriteLine(i);
                    count += 1;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("There are no Armstrong Numbers within that given range");
            }
            Console.WriteLine("**********DONE************");
        }
    }
}

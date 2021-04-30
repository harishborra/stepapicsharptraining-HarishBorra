using System;


namespace FirstProject
{
    class ExplicitConDemo
    {
        public ExplicitConDemo()
        {
            Console.WriteLine("Constructor is Called");
        }
        public static void Main()
        {
            ExplicitConDemo obj = new ExplicitConDemo();

            Console.ReadLine();
        }
    }
}

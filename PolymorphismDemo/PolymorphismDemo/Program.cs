using System;

namespace PolymorphismDemo
{
    
    class Program
    {
        public class Shape
        {
            public virtual void draw()
            {
                Console.WriteLine("Started drawing..");
            }
        }
        public class Rectangle : Shape
        {
            public override void draw()
            {
                Console.WriteLine("Inside the Rectangle and the rectangle is drawn.");
            }

        }
        public class Circle : Shape
        {
            public override void draw()
            {
                Console.WriteLine("Inside the Circle and drawing of circle is done");
            }

        }
        public class TestPolymorphismDemo
        {
            public static void Main()
            {
                Shape s = new Shape();
                s.draw();
                s = new Rectangle();
                s.draw();
                s = new Circle();
                s.draw();
                Console.ReadLine();

            }
        }
    }
}

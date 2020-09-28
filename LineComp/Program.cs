using System;

namespace LineComp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Line 1 coordinates point 1 (x,y)");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Line 1 coordinates point 2  (x,y)");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            double d1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Line 2 coordinates point 1 (x,y)");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Line 2 coordinates point 2  (x,y)");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            double d2 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            if (d1==d2)
            {
                Console.WriteLine("The lengths of two lines are equal");
            }
            else if(d1>d2)
            {
                Console.WriteLine("Line 1 is greater");
            }
            else
            {
                Console.WriteLine("Line 2 is greater");
            }

        }
    }
}

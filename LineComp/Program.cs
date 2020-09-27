using System;

namespace LineComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates point 1 (x,y)");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinates point 2  (x,y)");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2));
        }
    }
}

using System;

namespace LineComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line 1 coordinates point 1 (x,y)");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Line 1 coordinates point 2  (x,y)");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Line 2 coordinates point 1 (x,y)");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Line 2 coordinates point 2  (x,y)");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());
            if (Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2).CompareTo(Math.Sqrt((x3 - x4)^ 2 + (y3 - y4)^ 2))==0)
            {
                Console.WriteLine("The lengths of two lines are equal");
            }
            else if(Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2).CompareTo(Math.Sqrt((x3 - x4) ^ 2 + (y3 - y4) ^ 2))< 0)
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

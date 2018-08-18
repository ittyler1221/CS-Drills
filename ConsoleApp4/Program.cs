using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type a Number Then Press Enter");
            string Number = Console.ReadLine();
            double Number1 = Convert.ToDouble(Number);
            Console.WriteLine("Your Number Multiplied By 50 = ");
            Console.WriteLine(Number1 * 50);
            Console.WriteLine("Hit Enter");
            Console.ReadLine();
            Console.WriteLine("Your Number Plus 25 = ");
            Console.WriteLine(Number1 + 25);
            Console.WriteLine("Hit Enter");
            Console.ReadLine();
            Console.WriteLine("Your Number Divided By 12.5");
            Console.WriteLine(Number1 / 12.5);
            Console.WriteLine("Hit Enter");
            Console.ReadLine();
            Console.WriteLine("Is Your Number Greater Than 50");
            Console.WriteLine(Number1 > 50);
            Boolean check = Number1 > 50;
            Console.WriteLine("Hit Enter");
            Console.ReadLine();
            Console.WriteLine("Your Numbers Remainder When Divided By 7");
            Console.WriteLine("Hit Enter");
            Console.WriteLine(Number1 % 7);
            Console.ReadLine();
        }
    }
}

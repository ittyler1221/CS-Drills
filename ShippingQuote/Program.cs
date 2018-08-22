using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Enter Package Weight");
            int package = Convert.ToInt16(Console.ReadLine());
            if (package > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Enter Package Width.");
                int Width = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Package Height.");
                int Height = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Package Length.");
                int Length = Convert.ToInt16(Console.ReadLine());
                if (Width + Height + Length > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                } else
                {
                    int total = (Length + Width + Height) * package / 100;
                    Console.WriteLine("Your Estimated total for shipping this package is: $" + total);
                    Console.ReadLine();
                }
            }
        } 
    }
}

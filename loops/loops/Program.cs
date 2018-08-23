using System;

namespace loops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many cats do you have?");
            int cats = Convert.ToInt16(Console.ReadLine());
            while (cats > 1)
            {
                Console.WriteLine("You have to many cats");
                Console.WriteLine("Get rid Of some. How many cats do you have now?");
                cats = Convert.ToInt16(Console.ReadLine());
                {
                    if (cats == 1)
                        Console.WriteLine("You have enough cats stop it.");
                    Console.ReadLine();
                }
            }
            {
                Console.WriteLine("How many letters are there in the Alphabet");
                int letters = Convert.ToInt32(Console.ReadLine());
                do
                {
                    if (letters == 26)
                    {
                        Console.WriteLine("Good Job.");
                        Console.ReadLine();
                        break;
                    } else
                    {
                        Console.WriteLine("Keep Trying.");
                        letters = Convert.ToInt32(Console.ReadLine());
                    }
                }
                while (letters != 1);
            }
        }
    }
}

using System;


namespace Boolean_Logic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What Is Your Age?");
            string Age = Console.ReadLine();
            int Age1 = Convert.ToInt16(Age);
            Console.WriteLine("Have You Ever Had A DUI? Answer true Or false");
            string DUI = Console.ReadLine();
            Boolean DUI1 = Convert.ToBoolean(DUI);
            Console.WriteLine("How Many Speeding Tickets Do You Have?");
            string Tickets = Console.ReadLine();
            int Tickets1 = Convert.ToInt16(Tickets);
            Console.WriteLine("Qualified");
            Boolean check = (Age1 > 15 && DUI1 == false && Tickets1 < 4);
            Console.WriteLine(check);
            Console.ReadLine();

        }
    }
}

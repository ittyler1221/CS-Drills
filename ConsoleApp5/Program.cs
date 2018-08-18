using System;


namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparsion Program");
            Console.WriteLine("Person1");
            Console.WriteLine("Hourly Rate?");
            string Rate = Console.ReadLine();
            Double Hourly = Convert.ToDouble(Rate);
            Console.WriteLine("Hours worked per week?");
            string Hours = Console.ReadLine();
            int Hours1 = Convert.ToInt16(Hours);
            Console.WriteLine("Person2");
            Console.WriteLine("Hourly Rate?");
            string Rate2 = Console.ReadLine();
            Double Hourly2 = Convert.ToDouble(Rate2);
            Console.WriteLine("Hours worked per week?");
            string HoursWeekly = Console.ReadLine();
            int Hours2 = Convert.ToInt16(HoursWeekly);
            Console.WriteLine("Weekly Salary of Person1 =");
            Console.WriteLine(Hourly * Hours1);
            Console.ReadLine();
            Console.WriteLine("Weekly Salary of Person2 =");
            Console.WriteLine(Hourly2 * Hours2);
            Console.ReadLine();
            Console.WriteLine("Does Person1 Make More Than Person2?");
            Boolean check = (Hourly * Hours1) > (Hourly2 * Hours2);
            Console.WriteLine(check);
            Console.ReadLine();
        }
    }
}

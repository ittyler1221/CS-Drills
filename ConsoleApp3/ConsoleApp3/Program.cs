using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What Course Are You On?");
            string Course = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string Page = Console.ReadLine();
            Int16 pageNumber = Convert.ToInt16(Page);
            Console.WriteLine("Do you need any help? Please answer true or false");
            string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specfics");
            string positve = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hour's did you study today?");
            string Hours = Console.ReadLine();
            Int16 hoursStudied = Convert.ToInt16(Hours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
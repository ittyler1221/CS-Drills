using System;
using System.Collections.Generic;


namespace ListsAndArrays
{
    class Program
    {
        static void Main()
        {
            string[] animatedArray = { "Family Guy", "American Dad", "The Simpsons", "South Park" };
            Console.WriteLine("Select an index between 0 and 3");
            int index = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(animatedArray[index]);
            Console.ReadLine();

            int[] numberArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Select an index between 0 and 4");
            index = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(numberArray[index]);
            Console.ReadLine();

            Console.WriteLine("Select an index greater than 4");
            index = Convert.ToInt16(Console.ReadLine());
            if (index > 4)
            Console.WriteLine("No such index exists");
            Console.ReadLine();


            List<string> stringList = new List<string>();
            stringList.Add("Hello1");
            stringList.Add("Hello2");
            stringList.Add("Hello3");
            stringList.Add("Hello4");
            stringList.Add("Hello5");
            Console.WriteLine("Select An index between 0 and 4");
            index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[index]);
            Console.ReadLine();
        }
    }
}

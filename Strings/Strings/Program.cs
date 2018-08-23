using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            String s1 = "Food";
            String s2 = "Is";
            String s3 = "Good";
            String Food = s1 + " " + s2 + " " + s3;
            Console.WriteLine(Food);
            Console.ReadLine();
            Food = Food.ToUpper();
            Console.WriteLine(Food);
            Console.ReadLine();
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("This is the first sentence. ");
                sb.Append("This is the second sentence. ");
                sb.Append("This is the third sentence.");
                sb.Append("This is the fourth sentence.");
                sb.Append("This is the fifth sentence and thus this is a paragraph. ");
                Console.WriteLine(sb);
                Console.ReadLine();


            }
        }
    }
}

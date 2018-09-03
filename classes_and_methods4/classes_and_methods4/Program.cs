using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_methods4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 addition = new Class1();

            Console.WriteLine("Enter a number");
            int anumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You can enter another number if you want");
            string anumber2 = Console.ReadLine();

            if (anumber2 == "")
            {
                int entered1 = addition.Enter(anumber1);
                Console.WriteLine(anumber1 + " + 0 = " + entered1);
                Console.ReadLine();
            }
            else
            {
                int num2 = Convert.ToInt32(anumber2);
                int entered2 = addition.Enter(anumber1, num2);
                Console.WriteLine(anumber1 + " + " + anumber2 + " = " + entered2);
                Console.ReadLine();
            }
        }
    }
}

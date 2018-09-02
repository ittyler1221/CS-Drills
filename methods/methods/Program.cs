using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int Enter = Convert.ToInt16(Console.ReadLine());

            methods.class1.Hello1(Enter);

            methods.class1.Hello2(Enter);

            methods.class1.Hello3(Enter);
        }
    }
}

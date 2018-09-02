using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 addition = new Class1();
            int enters = addition.Main2(12);
            Console.WriteLine(enters);
            Console.ReadLine();

            Class1 division = new Class1();
            decimal enters2 = division.Main2(.15m);
            Console.WriteLine(enters2);
            Console.ReadLine();

            Class1 subtraction = new Class1();
            int entered = 0;
            int enters3 = subtraction.Main2(entered - 10);
            Console.WriteLine(enters3);
            Console.ReadLine();
        }
    }
}

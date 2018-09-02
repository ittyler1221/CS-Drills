using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class class1
    {
       public static void Hello1 (int Enter)
        {
            Console.WriteLine("Your Number Entered Multiplied By 4 = " + (Enter * 4));
        }
        public static void Hello2 (int Enter)
        {
            Console.WriteLine("Your Number Subtracted By 4 = " + (Enter - 4));
        }
        public static void Hello3 (int Enter)
        {
            Console.WriteLine("Your Number Divided By 4 = " + (Enter / 4));
            Console.ReadLine();
        }
    }
}

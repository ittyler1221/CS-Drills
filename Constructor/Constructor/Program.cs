using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const int twenty = 20;
            object Tyler = null;
            var name = Tyler;

            Person pers = new Person("Tyler", "Helm");
            pers.PrintName();
            Console.ReadLine();
        }
    }
}
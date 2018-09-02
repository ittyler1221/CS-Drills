using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_methods3
{
    class Class1
    {
        public int Main2(int Enter1)
        {
            int entered = (Enter1 + 50);
            return entered;
        }

        public decimal Main2(decimal Enter1)
        {
            decimal entered = Enter1 / 5;
            return entered;
        }
        public int Main2(string Enter1)
        {
            int entered = Convert.ToInt32(Enter1);
            entered = entered - 10;
            return entered;
        }
    }
}

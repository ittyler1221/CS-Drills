using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_handling
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<int> intList = new List<int>();
                intList.Add(10);
                intList.Add(110);
                intList.Add(200);
                intList.Add(13);
                intList.Add(44);
                intList.Add(150);
                intList.Add(50);
                intList.Add(170);
                intList.Add(110);
                intList.Add(105);
                intList.Add(200);
                Console.WriteLine("Enter a number to divide the number's in this list by");
                int divide = Convert.ToInt16(Console.ReadLine());
                foreach (int num in intList)
                {
                    Console.WriteLine(num / divide);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please Dont divide by zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a number");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
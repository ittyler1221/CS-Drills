using System;

namespace Constructor
{
    class Person
    {
        public Person()
        {      
            Person pers = new Person();
        }
        public string first;
        public string last;

        public Person(string f1):this(f1,"-")
        {
         
        }

        public Person(string f1, string f2) 
        {
            first = f1;
            last = f2;
        }


        public void PrintName()
        {
            Console.WriteLine(first + " " + last);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Bird
    {
        public void show1()
        {
            Console.WriteLine("This is a Peacock");
        }
    }
    class Peacock : Bird
    {
        public void show2()
        {
            Console.WriteLine("It is our National Bird");
        }
    }
}

    

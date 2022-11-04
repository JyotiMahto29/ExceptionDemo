using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class StaticPolymorphism
    {
        
            public void Print(string firstname, string lastname)
            {
                Console.WriteLine("First Name is: " + firstname + Environment.NewLine + "Last Name is: " + lastname);
            }
            public void Print(string city)
            {
                Console.WriteLine("City is: " + city);
            }
            public void Print(int mobilenumber, string emailId)
            {
                Console.WriteLine("Mobile Number is: " + mobilenumber + Environment.NewLine + "Email Id is : " + emailId);
            }
        
    }
    
}


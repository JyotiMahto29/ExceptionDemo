using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Encapsulation
    {
            public long AccountNumber;
            public string Name;
            public int Balance;
            public void GetBalance()
            {
                Console.WriteLine("Public..");
            }
            private void WithdrawAmount()
            {
                Console.WriteLine("Private..");
            }
            internal void Deposit()
            {
                Console.WriteLine("Internal..");
            }
        
    }
}

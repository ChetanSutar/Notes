using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Bank
    {
        internal int Balance = 5000;
        abstract public void Credit(int amt);
        abstract public void Debit(int amt);
        abstract public void Login(int pincode);
        abstract public void CheckBalance();

        void BankInfo()
        {
            Console.WriteLine("SBI");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Customer
    {

        public static void Main (string[] args)
        {
            Bank bank = new BankImplimentation ();

            bank.Credit(99);
            bank.CheckBalance();
        }

    }
}

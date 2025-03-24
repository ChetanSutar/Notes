using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankImplimentation : Bank
    {
        public override void CheckBalance()
        {
           Console.WriteLine($"Balance={Balance}");
        }

        public override void Credit(int amt)
        {
            Balance += amt;
        }

        public override void Debit(int amt)
        {
           Balance -= amt;
        }

        public override void Login(int pincode)
        {
            if (pincode == 000)
            {
               
                this.CheckBalance();
            }
            else {
                Console.WriteLine("Invalid Pin");
            }
        }
    }
}

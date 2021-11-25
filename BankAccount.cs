using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceRelationshipExample
{
    public class Bank_Account
    {
        public string AccountNo { set; get; }
        public string CustomerName { set; get; }
        public double Balance { set; get; }
        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposited";
        }
        public virtual string Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            
                Balance -= amount;
                return "withdrawn";

            }
   }
}

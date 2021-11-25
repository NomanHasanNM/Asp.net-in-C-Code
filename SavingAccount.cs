using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceRelationshipExample
{
   public class SavingAccount : Bank_Account
    {
        public double InterestAmount { set; get; }

        public override string Withdraw(double amount)
        {
            if( Balance -amount >= 0)
            {
                return base.Withdraw(amount);
            }
            {
                return "Insuffcient Balance";
            }
        }
        
            
        
    }
}

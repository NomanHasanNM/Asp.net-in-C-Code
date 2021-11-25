using System;

namespace InheritanceRelationshipExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount chk3 = new CheckingAccount();
            chk3.CustomerName = "Nomanb";
            chk3.AccountNo = "449";
            chk3.Deposit(40000);
            string m = chk3.Withdraw(560000);
                
                 
            //Method Overridding 

            SavingAccount sv1 = new SavingAccount();
            double depoAmount = 5000;
            sv1.Deposit(depoAmount);
            double withdrawAmount = 700;
            sv1.Withdraw(withdrawAmount);
            Bank_Account b1 = new CheckingAccount();
            b1.Withdraw(1);
            Bank_Account b2 = new SavingAccount();
            b2.Withdraw(3);




            //SavingAccount av1 = new SavingAccount();
            //double depoAmount  = 5000;
            //av1.Deposit(depoAmount);
            //double withdrawAmount = 7000;
            //av1.Withdraw(withdrawAmount);

            // upcasting and downcasting here :-
            // 
            //CheckingAccount chk1 = new CheckingAccount();
            //chk1.AccountNo = "2344353";
            //chk1.CustomerName = "Noman";
            //chk1.ServiceCharge = 900;
            //Bank_Account b1 = chk1;
            //CheckingAccount chk3 = (CheckingAccount) b1;
            //double val = chk3.ServiceCharge;
          



                 

            




            //CheckingAccount chk1 = new CheckingAccount();
            //chk1.CustomerName = "noman";
            //chk1.AccountNo = "chk_1";
            //chk1.ServiceCharge = 6799;
            //chk1.Deposit(200);
            // chk1.Withdraw(50);
            //double Balance = chk1.Balance;

            //SavingAccount sv1 = new SavingAccount();
            //sv1.AccountNo = "dfjjn-";
            //sv1.CustomerName = "ador";
            //sv1.Deposit(5000);
            //sv1.Withdraw(600);




        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bankonton
{
    class SavingAccount : IAccount
    {
        public string Name { get;  set; }

        public double Balance { get; private set; }

        public SavingAccount() { }
        public SavingAccount(double initailBalance) 
        {
            if (initailBalance <= 0) throw new System.Exception("Amount too small");

            Balance = initailBalance;  
        }

        public string Accountinfo()
        {
            return $"Account name{Name}, Balance{Balance}";
        }

        public double Desposit(double amount)
        {
            if(amount<= 0) throw new System.Exception("Amount too small");
            Balance += amount;
            return Balance;
        }

        public double Withdraw(double amount)
        {
            if (amount <= 0) throw new System.Exception("Amount too small");
            if (amount > Balance) throw new System.Exception("No credit for you!");

            Balance += amount;
            return Balance;

        }
    }
}

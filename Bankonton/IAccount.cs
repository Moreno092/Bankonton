using System;
using System.Collections.Generic;
using System.Text;

namespace Bankonton
{
    interface IAccount
    {
        string Name { get; set; }
        double Balance { get; }
        string Accountinfo();
        double Withdraw(double amount);
        double Desposit(double amount);


    }
}

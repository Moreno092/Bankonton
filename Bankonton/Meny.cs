using System;
using System.Collections.Generic;
using System.Text;

namespace Bankonton
{
    class Meny 
    {
        public static Bankonton.SavingAccount account = new Bankonton.SavingAccount();


        public void MenyChoice()
        {
            Console.WriteLine("Tryck 1 om du vill sätta in pengar");
            Console.WriteLine("Tryck 2 om du vill ta ut pengar");
            Console.WriteLine("Tryck 3 om du vill se din balans ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    account.Desposit(0);
                    break;

                case "2":
                    account.Withdraw(0);
                    break;

                case "3":
                    account.Accountinfo();
                    break;

                    
                    
            }
        }

        
    }
}

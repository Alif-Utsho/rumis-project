using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Utsho", 2000.00, "ka32/2", "187", "Dhaka", "Bangladesh");
            Account acc2 = new Account("Mamnun", 5000, "ka32/2", "187", "Dhaka", "Bangladesh");
            //acc1.showAccountInfo();
            acc1.Deposit(5000);
            //acc1.showAccountInfo();
            //acc1.Withdraw(2000);
            //acc1.showAccountInfo();

            Bank bank = new Bank("Dhaka Bank");
            //bank.AddAccount(acc1);
            bank.AddAccount(acc2);
            bank.Transaction(acc1.TransactioType);
            //bank.AccountList();
        }
    }
}

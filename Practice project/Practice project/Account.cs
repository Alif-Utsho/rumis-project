using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_project
{
    class Account : Address
    {
        enum transactionTypeEnum
        {
            Deposit, Withdraw, Transfer
        }
        private int transactionType;

        public int TransactioType
        {
            get { return transactionType; }
            set { transactionType = value; }
        }


        Random random = new Random();
        private int accountNumber;

        public int AccountNumber
        {
            get { return accountNumber; }
        }

        private string accountName;

        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }

        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account() { }

        public Account(string accountName, double balance, string roadNo, string houseNo, string city, string country)
            : base(roadNo, houseNo, city, country)
        {
            this.accountNumber = random.Next();
            this.accountName = accountName;
            this.balance = balance;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
            transactionType = (int) transactionTypeEnum.Withdraw;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            transactionType = (int)transactionTypeEnum.Deposit;
        }

        public void Transfer(Account account, double amount)
        {

        }

        public void showAccountInfo()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Name: " + accountName);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine(GetAddress());
        }

    }
}

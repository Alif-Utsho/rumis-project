using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_project
{
    class Bank
    {
        private string bankName;

        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }

        Account[] accounts;
        private int accountCount;

        public Bank()
        {
            accounts = new Account[100];
        }

        public Bank(string bankName)
        {
            this.bankName = bankName;
            accounts = new Account[100];
        }

        public void AddAccount(Account account)
        {
            accounts[accountCount++] = account;
        }

        public void AccountList()
        {
            for (int i = 0; i < accountCount; i++)
            {
                accounts[i].showAccountInfo();
            }
        }

        public void DeleteAccount(int accountNumber)
        {
            for(int i=0; i<accountCount; i++)
            {
                if (accounts[i].AccountNumber == accountNumber)
                {
                    //need to delete accounts[i] ;
                }
            }
        }

        public void Transaction(int transactionType, params int[] transactionDetails) 
        {
            if (transactionType == 0)
            {
                Console.WriteLine("Deposited");
            }
            else if (transactionType == 1)
            {
                Console.WriteLine("Withdrawn");
            }
        }

        public void PrintAccountDetails()
        {
            Console.WriteLine("Bank Name: " + bankName);
        }

    }
}

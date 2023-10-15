using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahamDavidBankOOP
{
    internal class BankAccount
    {
        public string ownerName { get; set; }
        public decimal balance { get; set; }
        public string accountNumber { get; set; }
        public string accountType { get; set; }
        public DateTime accountOpeningDate { get; set; }
        public bool isAcountActive { get; set; }

        public BankAccount(string ownerName, decimal balance, string accountNumber, string accountType, DateTime accountOpeningDate, bool isAcountActive)
        {
            this.ownerName = ownerName;
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.accountOpeningDate = accountOpeningDate;
            this.isAcountActive = isAcountActive;
        }

        public void printAccountInfo()
        {
            Console.WriteLine($"Name: {ownerName} \n" +
                              $"Balance: {balance} Ft \n" +
                              $"Account Number: {accountNumber} \n" +
                              $"Account Type: {accountType} \n" +
                              $"Account Created: {accountOpeningDate} \n" +
                              $"Account Active: {isAcountActive} \n");
        }

        public void closeAccount()
        {
            if (isAcountActive == true)
            {
                isAcountActive = false;
            }
            else { Console.WriteLine("Account is already closed"); }
        }

        public void TransferFundsTo(BankAccount destinationAccount, decimal amount)
        {
            destinationAccount.balance += amount;
            balance -= amount;
        }

        public void UpdateAccountType(string newAccountType)
        {
            accountType = newAccountType;
        }
    }
}


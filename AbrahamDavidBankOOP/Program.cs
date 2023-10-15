using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahamDavidBankOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer bela = new Customer("Kovács Béla", 23, "Budapest", "kutya@csiga.hu", "+36305556662");
            BankAccount belaacc = new BankAccount(bela.customerName, 32000, "123324435345", "Premium", DateTime.Now, true);
            BankAccount belaneacc = new BankAccount("csiga", 35000, "123424435345", "Premium", DateTime.Now, true);


            bela.PlaceOrder("Premium life insurance for my dead hamster.", 12);
            bela.RequestSupport("Help me for God Sake.");
            bela.SendFeedBack("No help whatsoever.");
            belaacc.printAccountInfo();
            belaneacc.TransferFundsTo(belaacc, 300);
            belaneacc.printAccountInfo();
            belaacc.printAccountInfo();
            belaacc.UpdateAccountType("broke");
            belaacc.printAccountInfo();
            Console.ReadKey();
        }
    }
}

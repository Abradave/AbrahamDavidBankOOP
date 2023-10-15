using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahamDavidBankOOP
{
    internal class Customer
    {
        public string customerName { get; set; }
        public int customerAge { get; set; }
        public string customerAddress { get; set; }
        public string customerEmail { get; set; }
        public string customerPhoneNumber { get; set; }

        public Customer(string customerName, int customerAge, string customerAddress, string customerEmail, string customerPhoneNumber)
        {
            this.customerName = customerName;
            this.customerAge = customerAge;
            this.customerAddress = customerAddress;
            this.customerEmail = customerEmail;
            this.customerPhoneNumber = customerPhoneNumber;
        }

        public void printCustomerInfo()
        {
            Console.WriteLine($"Name: {customerName} \n" +
                              $"Age: {customerAge} \n" +
                              $"Address: {customerAddress} \n" +
                              $"Email: {customerEmail} \n" +
                              $"Phone Number: {customerPhoneNumber} \n");
        }

        public void updateCustomerInfo(string newName, int newAge, string newAdress, string newEmail, string newPhoneNumber)
        {
            customerName = newName;
            customerAge = newAge;
            customerAddress = newAdress;
            customerEmail = newEmail;
            customerPhoneNumber = newPhoneNumber;
        }

        public void PlaceOrder(string product, int quantity)
        {
            Console.WriteLine($"{customerName} ordered: {quantity} {product}. \n");
        }

        public void RequestSupport(string supportRequest)
        {
            Console.WriteLine($"{customerName} your request: {supportRequest}  has been noted ({DateTime.Now}).\n");
        }

        public void SendFeedBack(string feedback)
        {
            Console.WriteLine($"{customerName} your feedback has been registered \n" +
                $"Your feedback: {feedback} \n");
        }

    }
}


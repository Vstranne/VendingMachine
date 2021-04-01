using System;

namespace AwesomeVendingMachine
{
    class Program
    {
        public static Customer person = new Customer(500);
        public static BankAccount bankAccount = new BankAccount();
        
        static void Main(string[] args)
        {
            var vendingMachine = new VendingMachine();
            vendingMachine.Welcome();
            
        }
    }
}
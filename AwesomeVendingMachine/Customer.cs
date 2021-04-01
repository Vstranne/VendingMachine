using System;

namespace AwesomeVendingMachine
{
    public class Customer
    {
        public int wallet;

        public Customer(int money)
        {
            this.wallet = money;
        }

        public static void Rob(Customer customer)
        {
            customer.wallet += 50000;
        }

        public void BuyItem(string item, int price, Customer customer)
        {
            if (price > customer.wallet)
            {
                Console.WriteLine("Not enough cash (press ENTER)");
            }
            else
            {
                customer.wallet -= price;
                Console.WriteLine($"Success! Enjoy the {item} (press ENTER)");
            }
            
        }

        public void WithDraw(int balance, Customer customer)
        {
            if (balance >= 100)
            {
                customer.wallet += 100;
            }
        }

        public void Deposit(int amount, Customer customer)
        {
            if (amount <= customer.wallet)
            {
                customer.wallet -= amount;
            }
            
        }
            
            
    }
}
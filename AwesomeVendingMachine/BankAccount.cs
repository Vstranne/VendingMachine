using System;

namespace AwesomeVendingMachine
{
    public class BankAccount
    {
        private int balance = 500;

        /*public BankAccount(int balance)
        {
            this.balance = balance;
        }
        */
        
        public void WithDraw(BankAccount bankAccount)
        {
            if (bankAccount.balance >= 100)
            {
                Console.WriteLine("Success! Press enter");
                bankAccount.balance -= 100;
            }
            else
            {
                Console.WriteLine(
                    $"You tried to withdraw {100} but only have {bankAccount.balance} in your bank account, perhaps try and rob us :):):) (press ENTER)");
            }
        }
        public int Balance()
        {
            return balance;
        }
        public void Deposit(int amount, int wallet)
        {
            if (amount > wallet)
            {
                Console.WriteLine($"You tried to deposit {amount}, but it looks like you only have {wallet}");
            }
            else
            {
                Console.WriteLine("Success! (press ENTER)");
                balance += amount;
            }
            
        }
        
    }
}
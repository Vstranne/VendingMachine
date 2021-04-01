using System;
using System.Security.Principal;

namespace AwesomeVendingMachine
{
    public class VendingMachine
    {
        public void Welcome()
        {
            //var person = new Customer(50);
            Console.Clear();
            Console.WriteLine("Welcome to awesome omega Vending Machinezor!");
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1: Buy something to drink");
            Console.WriteLine("2: Go rob the bank");
            Console.WriteLine("3: The cops are coming, RUUUN(exit program)");
            Console.WriteLine();
            Console.WriteLine($"Dollahz in your pocket {Program.person.wallet}");
            Console.WriteLine();
            Console.WriteLine("Type in the corresponding number for what you wanna do!");
            
            while (true)
            {
                var choice = Console.ReadLine();
                
                if (int.TryParse(choice, out var number) && number >= 1 && number <= 3)
                {
                    switch (choice)
                    {
                        case "1":
                            Buy();
                            break;
                        case "2":
                            Bank();
                            break;
                        case "3":
                            Console.WriteLine("SEEE YA");
                            break;
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
        }

        
        
        public void Buy()
        {
            string[,] wares = new string[,]
            {
                {"Potato Juice", "10"}, 
                {"Zombie Soda ", "80"}, 
                {"Champagne   ", "5000"}
            };
            Console.Clear();
            Console.WriteLine("We only offer 3 different beverages, deal with it...");
            Console.WriteLine();
            for (var x = 0; x < wares.GetLength(0); x++)
            {
                Console.Write($"{x + 1}:  ");
                for (var y = 0; y < wares.GetLength(1); y++)
                {
                    if (y == 1)
                    {
                        Console.Write($"${wares[x, y]}");
                    }
                    else
                    {
                        Console.Write($"{wares[x, y]}           "); 
                    }
                    
                }

                Console.WriteLine();
            }

            Console.WriteLine("4:  I changed my mind, send me back!");
            Console.WriteLine();
            Console.WriteLine($"Dollahz in your pocket {Program.person.wallet}");
            Console.WriteLine();
            Console.WriteLine("Enter the number you want to order and press ENTER");
            while (true)
            {
                var choice = Console.ReadLine();
                
                if (int.TryParse(choice, out var number) && number >= 1 && number <= 4)
                {
                    switch (choice)
                    {
                        case "1":
                            int.TryParse(wares[0, 1], out var price1);
                            Program.person.BuyItem(wares[0,0], price1, Program.person);
                            Console.ReadLine();
                            Buy();
                            break;
                        case "2":
                            int.TryParse(wares[1, 1], out var price2);
                            Program.person.BuyItem(wares[1,0], price2, Program.person);
                            Console.ReadLine();
                            Buy();
                            break;
                        case "3":
                            int.TryParse(wares[2, 1], out var price3);
                            Program.person.BuyItem(wares[2, 0], price3, Program.person);
                            Console.ReadLine();
                            Buy();
                            break;
                        case "4":
                            Welcome();
                            break;
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }


        }
        
        public void RunProgram()
        {
            Console.Clear();
            Console.WriteLine("please work");
        }

        public void Bank()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO SWISHBANK!");
            Console.WriteLine();
            Console.WriteLine($"Current balance: {Program.bankAccount.Balance()}");
            Console.WriteLine("1: Deposit");
            Console.WriteLine("2: Withdraw $100");
            Console.WriteLine("3: ROB THE BANK(you better run afterwards)");
            Console.WriteLine("4: Go back to the vending machine");
            Console.WriteLine();
            Console.WriteLine($"Dollahz in your pocket {Program.person.wallet}");
            Console.WriteLine("What do you want to do?");

            while (true)
            {
                var choice = Console.ReadLine();

                if (int.TryParse(choice, out var number) && number >= 1 && number <= 4)
                {
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("How much?");
                            var deposit = Console.ReadLine();
                            int.TryParse(deposit, out var amount);
                            Program.bankAccount.Deposit(amount, Program.person.wallet);
                            Program.person.Deposit(amount, Program.person);
                            Console.ReadLine();
                            Bank();
                            break;
                        case "2":
                            Program.person.WithDraw(Program.bankAccount.Balance(), Program.person);
                            Program.bankAccount.WithDraw(Program.bankAccount);
                            Console.ReadLine();
                            Bank();
                            
                            break;
                        case "3":
                            Customer.Rob(Program.person);
                            Console.WriteLine(
                                "You just yoinked 50k $$$ (press ENTER to swing by the vending machine before the cops spots you");
                            Console.ReadLine();
                            Welcome();
                            break;
                        case "4":
                            Welcome();
                            break;
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
        }
    }
}
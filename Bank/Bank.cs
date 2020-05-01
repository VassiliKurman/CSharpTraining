using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection;

namespace Bank
{
    /**
     * This is a C# language features learning space.
     */
    class Bank
    {
        private string Title
        {
            get;
            set;
        }
        private List<BankAccount> Accounts
        {
            get;
        }

        Bank(String title)
        {
            this.Title = title;
            Accounts = new List<BankAccount>();
        }

        static void mainMenuProcessing(Bank bank)
        {
            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("*** Main menu ***");
                Console.WriteLine("Please type one of the following options:");
                Console.WriteLine("    1 - Create account");
                Console.WriteLine("    2 - Deposit/Withdraw from existing account");
                Console.WriteLine("    3 - View account balance");
                Console.WriteLine("    0 - Exit");

                string input = string.Empty;
                while(String.IsNullOrEmpty(input))
                {
                    input = Console.ReadLine();
                }
                switch (input)
                {
                    case "1":
                        CreateAccount(bank);
                        break;
                    case "2":
                        MakeTransaction(bank);
                        break;
                    case "3":
                        ViewBalance(bank);
                        break;
                    case "0":
                        exit = true;
                        break;
                }
            }
        }

        static void CreateAccount(Bank bank)
        {
            while (true)
            {
                Console.WriteLine("*** Create Account menu ***");
                // Requesting for customer name
                Console.WriteLine("Please type your full name and press \"Enter\":");
                string name = string.Empty;
                while (String.IsNullOrEmpty(name))
                {
                    name = Console.ReadLine();

                }
                // Requesting initial deposit
                Console.WriteLine("Please type initial ammount to deposit and press \"Enter\":");

                string input = string.Empty;
                decimal deposit = Decimal.Zero;
                while (String.IsNullOrEmpty(input))
                {
                    input = Console.ReadLine();
                    if(Decimal.TryParse(input, out deposit))
                    {
                        break;
                    }

                }

                var account = new BankAccount(name, deposit);
                bank.Accounts.Add(account);

                // Requesting initial deposit
                Console.WriteLine($"Your account number is: {account.Number}");
                Console.WriteLine("Press \"Enter\" key to return to main menu!");
                Console.ReadLine();
                return;
            }
        }

        static void MakeTransaction(Bank bank)
        {
            while (true)
            {
                Console.WriteLine("*** Transaction menu ***");

                Console.WriteLine("Please type your account number and press \"Enter\":");
                long accountNumber = 0;
                string input = string.Empty;
                while (String.IsNullOrEmpty(input))
                {
                    input = Console.ReadLine();
                    if(long.TryParse(input, out accountNumber))
                    {
                        // TODO if account found
                        break;
                    }
                    accountNumber = 0;
                    input = string.Empty;
                }
                Console.WriteLine("Please type amount you want deposit or negative amount to withdraw, and press \"Enter\":");
                // TODO make transaction

                // Exit current menu
                Console.WriteLine("Please press \"Enter\" to exit.");
                Console.ReadLine();
            }
        }
        static void ViewBalance(Bank bank)
        {
            // TODO
        }

        static void Main(string[] args)
        {
            Bank bank;
            if(args.Length > 0) {
                bank = new Bank(args[0]);
            } else {
                bank = new Bank("Test Bank Ltd.");
            }

            mainMenuProcessing(bank);
        }
    }
}
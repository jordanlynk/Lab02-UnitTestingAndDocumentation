using System;

namespace ATM
{
    public class Program
    {
        public static decimal Balance = 0;
        public static void Main(string[] args)
        {
            UserInterface();
        }

        public static void UserInterface()
        {
            string userChoice = "";
            string userYesOrNo = "";
            string anotherTransaction = "Would you care to make another transaction (y/n)?";
            string forSureValidType = "Sorry, you have to enter in a positive and valid decimal number";
            while (userChoice != "4" && userYesOrNo != "n")
            {
                Console.WriteLine("Please Select A Transaction below..");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. View Balance");
                Console.WriteLine("4. Exit");

                userChoice = Console.ReadLine();

                if (userChoice = "1")
                {
                    Console.WriteLine("How much of your loot would you like to deposit today?");
                    string amountInput= Console.ReadLine();
                    decimal amount = Convert.ToDecimal(amountInput);

                    if (amount > 0)
                    {
                        Deposit(amount);
                        Console.WriteLine($"Thank you for your business. Depositting your cash money.. ${amount}");
                        Console.WriteLine(moreTransactions);
                    }
                    else
                    {
                        Console.WriteLine(forSureValidType);
                    }
                }
            }
            if (userChoice == "2")
            {
                Console.WriteLine("How much would you like to withdraw from your bank today?");
                string amountInput = Console.ReadLine();
                decimal amount = Convert.ToDecimal(amountInput);

                if (Balance - amount < 0)
                {
                    Console.WriteLine($"Sorry to say, you do not have enough money in your account, your balance is currently: ${Balance}");
                }

                else if (amount > 0 && Balance - amount > 0)
                {
                    Withdraw(amount);
                    Console.WriteLine($"Thank you! Withdrawing in progress.. ${amount}");
                    Console.WriteLine(anotherTransaction);
                }

                else
                {
                    Console.WriteLine(forSureValidType);
                }
            }
            if (userChoice = "3")
            {
                Console.WriteLine($"Total balance is: ${Balance}");
                Console.WriteLine(anotherTransaction);
            }
        }

    }
    public static decimal ViewBalance(decimal currentBalance)
    {
        decimal balance = Balance;
        return balance;
    }
    public static decimal Deposit(decimal amount)
    {
        decimal newBalance = Balance + amount;
        Balance = newBalance;
        return newBalance;
    }

    public static decimal Withdraw (decimal amount)
    {
        decimal newBalance = Balance - amount;
        Balance = newBalance;
        return newBalance;
    }
}

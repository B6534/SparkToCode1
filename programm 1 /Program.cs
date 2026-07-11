using System;
using System.Collections.Generic;

namespace BankingSystemApp
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. <your 1st custom service - choose a name>");
                Console.WriteLine("7. <your 2nd custom service - choose a name>");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        // TODO: call your first custom service function here
                        break;
                    case 7:
                        // TODO: call your second custom service function here
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }

        // ===================== HELPER FUNCTION =====================

        static int FindAccountIndex(string accNum)
        {
            for (int i = 0; i < accountNumbers.Count; i++)
            {
                if (accountNumbers[i] == accNum)
                {
                    return i;
                }

                return -1;
            }

            throw new InvalidOperationException();
        }

        // ===================== SERVICE FUNCTIONS =====================

        static void AddAccount()
        {
            // TODO: implement (Section 3)
        }

        static void DepositMoney()
        {
            ////TODO: implement (Section 3)  
        }

        static void WithdrawMoney()
        {
            // //TODO: implement (Section 3)
        }

        static void ShowBalance()
        {
            // TODO: implement (Section 3)
        }

        static void TransferAmount()
        {
            // TODO: implement (Section 3)
        }

        // TODO: two custom service functions for options 6 and 7
    }
}
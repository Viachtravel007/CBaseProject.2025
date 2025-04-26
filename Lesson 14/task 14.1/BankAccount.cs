using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DefaultProject.Lesson_14.task_14._1
{
    public class Account
    {
        public string Name { get; }
        private double balance;

        public Account(string name, double initialBalance)
        {
            Name = name;
            balance = initialBalance >= 0 ? initialBalance : 0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public bool Withdrawal(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public double Balance => balance;
    }

    class BankAccount
    {
        private static Account[] accounts = new Account[9];

        public static void Demonstrator()
        {
            while (true)
            {
                Console.WriteLine("1. Create account");
                Console.WriteLine("2. Look balance");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdrawal");
                Console.WriteLine("5. Transfer");
                Console.WriteLine("6. Exit");
                Console.Write("Choose: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateAccount();
                        break;
                    case "2":
                        ShowBalance();
                        break;
                    case "3":
                        Deposit();
                        break;
                    case "4":
                        Withdrawal();
                        break;
                    case "5":
                        Transfer();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void Transfer()
        {
            Console.WriteLine("Transfer funds between accounts");

            Console.WriteLine("Source account:");
            int srcInd = GetSlotIndex();
            if (srcInd < 0) return;
            var srcAcc = accounts[srcInd];
            if (srcAcc == null)
            {
                Console.WriteLine($"No account in slot {srcInd + 1}.");
                return;
            }

            Console.WriteLine("Destination account:");
            int dstInd = GetSlotIndex();
            if (dstInd < 0) return;
            var dstAcc = accounts[dstInd];
            if (dstAcc == null)
            {
                Console.WriteLine($"No account in slot {dstInd + 1}.");
                return;
            }

            if (srcInd == dstInd)
            {
                Console.WriteLine("Cannot transfer to the same account");
                return;
            }

            Console.Write("Enter amount to transfer: ");
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid amount");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be positive");
                return;
            }

            if (srcAcc.Withdrawal(amount))
            {
                dstAcc.Deposit(amount);
                Console.WriteLine("Transfer successful");
            }
            else
            {
                Console.WriteLine("Transfer failed, invalid amount");
            }
        }

        private static int GetSlotIndex()
        {
            Console.Write("Enter slot number (1-9): ");
            if (int.TryParse(Console.ReadLine(), out int slot) && slot >= 1 && slot <= 9)
            {
                return slot - 1;
            }
            Console.WriteLine("Invalid slot number");
            return -1;
        }

        private static void CreateAccount()
        {
            int ind = GetSlotIndex();
            if (ind < 0) return;

            Console.Write("Enter account name: ");
            string name = Console.ReadLine();
            Console.Write("Enter initial balance: ");
            if (!double.TryParse(Console.ReadLine(), out double initial))
            {
                Console.WriteLine("Invalid amount");
                return;
            }

            accounts[ind] = new Account(name, initial);
            Console.WriteLine($"Account created in slot {ind + 1}");
        }

        private static void ShowBalance()
        {
            int ind = GetSlotIndex();
            if (ind < 0) return;

            var acc = accounts[ind];
            if (acc != null)
                Console.WriteLine($"Balance of '{acc.Name}' (slot {ind + 1}): {acc.Balance}");
            else
                Console.WriteLine($"No account in slot {ind + 1}.");
        }

        private static void Deposit()
        {
            int ind = GetSlotIndex();
            if (ind < 0) return;

            var acc = accounts[ind];
            if (acc == null)
            {
                Console.WriteLine($"No account in slot {ind + 1}");
                return;
            }

            Console.Write("Enter amount to deposit: ");
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid amount");
                return;
            }

            acc.Deposit(amount);
            Console.WriteLine("Deposit successful");
        }

        private static void Withdrawal()
        {
            int ind = GetSlotIndex();
            if (ind < 0) return;

            var acc = accounts[ind];
            if (acc == null)
            {
                Console.WriteLine($"No account in slot {ind + 1}.");
                return;
            }

            Console.Write("Enter amount to withdraw: ");
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid amount");
                return;
            }

            if (acc.Withdrawal(amount))
                Console.WriteLine("Withdrawal successful");
            else
                Console.WriteLine("Withdrawal failed, invalid amount");
        }
    }
}
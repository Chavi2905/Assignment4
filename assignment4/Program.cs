using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    public class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative");
            }
            balance = initialBalance;
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative");
                }
                balance = value;
            }
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit amount cannot be negative");
            }
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Withdrawal amount cannot be negative");
            }

            if (amount > balance)
            {
                throw new ArgumentException("Insufficient balance");
            }

            balance -= amount;
        }

        public override string ToString()
        {
            return $"Balance: ${balance:F2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter initial balance: ");
            double initialBalance;
            if (!double.TryParse(Console.ReadLine(), out initialBalance))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            try
            {
                BankAccount account = new BankAccount(initialBalance);
                Console.WriteLine($"Account created with initial balance: {account}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    



}

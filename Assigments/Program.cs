using Assigments.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigments
{
    internal class Program
    {
        //Scenario 3: Bank Account Management System

        static decimal balance = 10000;
        static void Main(string[] args)
        {

            //    int choice;

            //    do
            //    {
            //        Console.WriteLine("1. Check Balance");
            //        Console.WriteLine("2. Deposit Money");
            //        Console.WriteLine("3. Transfer Money");
            //        Console.WriteLine("4. Exit");
            //        Console.Write("Enter your choice: ");
            //        choice = Convert.ToInt32(Console.ReadLine());

            //        switch (choice)
            //        {
            //            case 1:
            //                CheckBalance();
            //                break;

            //            case 2:
            //                Deposit();
            //                break;
            //            case 3:
            //                Transfer();
            //                break;
            //            case 4:
            //                Console.WriteLine("Thank you for using the application. Goodbye!");
            //                break;
            //            default:
            //                Console.WriteLine("Invalid choice. Please try again.");
            //                break;

            //        }
            //    }
            //    while (choice != 4);
            //}
            //static void CheckBalance()
            //{
            //    Console.WriteLine($"Your current balance is: {balance:C}");

            //}
            //static void Deposit()
            //{
            //    Console.Write("Enter the amount to deposit: ");
            //    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

            //    if (depositAmount > 0)
            //    {
            //        balance += depositAmount;
            //        Console.WriteLine($"Successfully deposited {depositAmount:C}. New balance: {balance:C}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
            //    }
            //}

            //static void Transfer()
            //{
            //    Console.Write("Enter the amount to transfer: ");
            //    decimal transferAmount = Convert.ToDecimal(Console.ReadLine());

            //    if (transferAmount > 0 && transferAmount <= balance)
            //    {
            //        balance -= transferAmount;
            //        Console.WriteLine($"Successfully transferred {transferAmount:C}. New balance: {balance:C}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid transfer amount. Please ensure it is positive and does not exceed the balance.");
            //    }
            //3 end

            //Scenario 1: Library Management System

            Books book = new Books("C# Programming","John Doe",12345);
            Console.WriteLine(book.pages);
            Console.WriteLine(book.title);
            Console.WriteLine(book.author);

            Console.ReadLine();

        }
        
    }
}

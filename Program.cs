using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Expense> expenses = new List<Expense>();

        bool running = true;

        while (running)
        { // Display menu options
            Console.WriteLine("\nPersonal Expense Tracker");
            Console.WriteLine();
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View Expenses");
            Console.WriteLine("3. View Total Expenses");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice) // Handle user input
            {
                case "1":
                    Console.Write("Add Expense selected. Enter description: ");
                    string description = Console.ReadLine() ?? string.Empty;
                    Console.Write("Enter amount: ");
                    decimal amount;
                    while (!decimal.TryParse(Console.ReadLine(), out amount))
                    {
                        Console.Write("Invalid amount. Please enter a valid decimal number: ");
                    }
                    Console.Write("Enter category: ");
                    string category = Console.ReadLine() ?? string.Empty;
                    expenses.Add(new Expense(description, amount, category));
                    Console.WriteLine("Expense added successfully.");
                    break;
                case "2":
                    Console.WriteLine("View Expenses selected. Listing all expenses:");
                    foreach (var expense in expenses)
                    {
                        Console.WriteLine($"- {expense.Description} ({expense.Category}): ${expense.Amount:F2}");
                    }
                    break;
                case "3":
                    Console.WriteLine("View Total Expenses selected. Calculating total:");
                    decimal total = 0;
                    foreach (var expense in expenses)
                    {
                        total += expense.Amount;
                    }
                    Console.WriteLine($"Total expenses: ${total:F2}");
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
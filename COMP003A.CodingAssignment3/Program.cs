// Author: Riley Benson
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Budget management application demonstrating control flow.

namespace COMP003A.CodingAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double expenseAmount = 0;
            string expenseName = "None";

            Console.WriteLine("Welcome to the Budget Management Tool!\n");
            Console.Write("Enter your monthly income: ");
            double monthlyIncome = double.Parse(Console.ReadLine());
            while (true)
            {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add an Expense");
            Console.WriteLine("2. View Expenses and Budget");
            Console.WriteLine("3. Remove an Expense");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.Write("Enter the expense name: ");
                expenseName = (Console.ReadLine());
                Console.Write("Enter the expense amount: ");
                expenseAmount = double.Parse(Console.ReadLine());
                Console.WriteLine("Expense added successfully!");
                    break;
                case 2: Console.WriteLine("\nExpenses:");
                Console.WriteLine($"- {expenseName}: {expenseAmount}");
                Console.Write($"Total Expenses: {expenseAmount}");

                Console.Write("");

                    break;
                case 3: Console.Write("");
                    break;
                case 4: Console.Write("");
                Console.WriteLine("Goodbye!");
                    return;
            }
            }
            Console.WriteLine("\n\nExpenses:");
            Console.WriteLine("- Rent: $");
            Console.WriteLine("Total Expenses: $");
            Console.WriteLine("Remaining Budget: $");
        }
    }
}
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
            double expense1 = 0;
            double expense2 = 0;
            double expense3 = 0;
            double expense4 = 0;
            double expense5 = 0;
            string expense1name = "";
            string expense2name = "";
            string expense3name = "";
            string expense4name = "";
            string expense5name = "";

            Console.WriteLine("Welcome to the Budget Management Tool!\n");
            double monthlyIncome = 0;
            while (true)
            {
                Console.Write("Enter your monthly income: ");
                try
                {
                    monthlyIncome = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is an invalid input. Please enter a valid number for your monthly income.");
                }
            }
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add an Expense");
                Console.WriteLine("2. View Expenses and Budget");
                Console.WriteLine("3. Remove an Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is an invalid input. Please enter a number between 1 and 4.");
                    continue;
                }
                switch (choice)
                {
                    case 1: // Add an expense
                        Console.Write("Enter the expense name: ");
                        string expenseName = Console.ReadLine();
                        while (true)
                        {
                            Console.Write("Enter the expense amount: ");
                            try
                            {
                                expenseAmount = double.Parse(Console.ReadLine());
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("That is an invalid input. Please enter a valid number for the expense amount.");
                            }
                        }
                        if (expense1name == "")
                        {
                            expense1name = expenseName;
                            expense1 = expenseAmount;
                        }
                        else if (expense2name == "")
                        {
                            expense2name = expenseName;
                            expense2 = expenseAmount;
                        }
                        else if (expense3name == "")
                        {
                            expense3name = expenseName;
                            expense3 = expenseAmount;
                        }
                        else if (expense4name == "")
                        {
                            expense4name = expenseName;
                            expense4 = expenseAmount;
                        }
                        else if (expense5name == "")
                        {
                            expense5name = expenseName;
                            expense5 = expenseAmount;
                        }
                        else
                        {
                            Console.WriteLine("You have hit the max number of expenses the program can handle.");
                        }
                        Console.WriteLine("Expense added successfully!");
                        break;
                    case 2: // View Expenses and Budget
                        Console.WriteLine("\nExpenses:");
                        Console.WriteLine($"- {expense1name}: ${expense1.ToString("F2")}");
                        Console.WriteLine($"- {expense2name}: ${expense2.ToString("F2")}");
                        Console.WriteLine($"- {expense3name}: ${expense3.ToString("F2")}");
                        Console.WriteLine($"- {expense4name}: ${expense4.ToString("F2")}");
                        Console.WriteLine($"- {expense5name}: ${expense5.ToString("F2")}");
                        double totalExpenses = expense1 + expense2 + expense3 + expense4 + expense5;
                        Console.WriteLine($"Total Expenses: ${totalExpenses.ToString("F2")}");
                        Console.WriteLine($"Remaining Budget: ${(monthlyIncome - totalExpenses).ToString("F2")}");
                        break;
                    case 3: // Remove an Expense
                        Console.Write("Enter the name of the expense you want to remove: ");
                        string inputtedText = Console.ReadLine();
                        if (inputtedText == expense1name)
                        {
                            expense1 = 0;
                            expense1name = "";
                        }
                        else if (inputtedText == expense2name)
                        {
                            expense2 = 0;
                            expense2name = "";
                        }
                        else if (inputtedText == expense3name)
                        {
                            expense3 = 0;
                            expense3name = "";
                        }
                        else if (inputtedText == expense4name)
                        {
                            expense4 = 0;
                            expense4name = "";
                        }
                        else if (inputtedText == expense5name)
                        {
                            expense5 = 0;
                            expense5name = "";
                        }
                        else
                        {
                            Console.WriteLine("That expense doesn't exist.");
                        }
                        break;
                    case 4: // Exit
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("This is an invalid input. Numbers between 1 and 4 are accepted.");
                        break;
                }
            }
        }
    }
}
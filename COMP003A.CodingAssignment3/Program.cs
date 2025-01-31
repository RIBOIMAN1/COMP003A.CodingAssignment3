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
                    case 1:
                        Console.Write("Enter the expense name: ");
                        string expenseName = Console.ReadLine();
                        Console.Write("Enter the expense amount: ");
                        expenseAmount = double.Parse(Console.ReadLine());
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
                    case 2:
                        Console.WriteLine("\nExpenses:");
                        Console.WriteLine($"- {expense1name}: {expense1}");
                        Console.WriteLine($"Total Expenses: {expense1 + expense2 + expense3 + expense4 + expense5}");
                        Console.WriteLine($"Remaining Budget: ${monthlyIncome - (expense1 + expense2 + expense3 + expense4 + expense5)}");
                        break;
                    case 3:
                        Console.Write("Enter the name of the expense you want to remove: ");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        return;
                }
            }
        }
    }
}
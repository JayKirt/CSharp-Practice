using System; // allows classes from the system namespace
// can anything else instead of System be used?

namespace SimpleCalculator // used to declare a scope that contains related objects - this is a container
// how / when would we access this namespace later?      
{
    class Program // basically an object?
    {
        static void Main (string []args) // the Main method
        {
            
            Console.WriteLine ("Simple Calculator"); // write to console
            Console.WriteLine ("---------------"); // write to console
            Console.WriteLine("Select an operation:");
Console.    WriteLine("1. Addition");
Console.    WriteLine("2. Subtraction");
Console.    WriteLine("3. Multiplication");
Console.    WriteLine("4. Division");
Console.    Write("Enter your choice (1/2/3/4): ");

string choiceString = Console.ReadLine();
int choice;
if (!int.TryParse(choiceString, out choice) || choice <1 || choice > 4 )
{
    Console.WriteLine ("Invalid choice, Please select a valid option.")
    return;
}
    Console.Write("Enter the first number: ");
    string num1String = Console.ReadLine();
        if (!double.TryParse(num1String, out double num1))
{   
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

    Console.Write("Enter the second number: ");
    string num2String = Console.ReadLine();
        if (!double.TryParse(num2String, out double num2))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}
double result = 0.0;

switch (choice)
{
    case 1:
        result = num1 + num2;
        break;
    case 2:
        result = num1 - num2;
        break;
    case 3:
        result = num1 * num2;
        break;
    case 4:
        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return;
        }
        result = num1 / num2;
        break;
}
        Console.WriteLine($"Result: {result}");
        }
    }
    
}
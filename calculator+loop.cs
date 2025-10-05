using System;

bool keepRunning = true;

while (keepRunning)
{
    double num1, num2;
    char op;
    double result = 0;
    bool validOperation = true;

    // Get first number
    Console.Write("Enter first number: ");
    while (!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.Write("Invalid input. Enter a valid number: ");
    }

    // Get second number
    Console.Write("Enter second number: ");
    while (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.Write("Invalid input. Enter a valid number: ");
    }

    // Get operator
    Console.Write("Enter operator (+, -, *, /): ");
    string input = Console.ReadLine();
    op = input.Length > 0 ? input[0] : '\0';

    // Perform operation
    switch (op)
    {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
        case '/':
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                validOperation = false;
            }
            else
            {
                result = num1 / num2;
            }
            break;
        default:
            Console.WriteLine("Invalid operator.");
            validOperation = false;
            break;
    }

    // Show result
    if (validOperation)
    {
        Console.WriteLine($"Result: {num1} {op} {num2} = {result:F2}");
    }

    // Ask to continue
    Console.Write("Do you want to continue? (y/n): ");
    string again = Console.ReadLine();
    if (again.ToLower() != "y")
    {
        keepRunning = false;
    }
}

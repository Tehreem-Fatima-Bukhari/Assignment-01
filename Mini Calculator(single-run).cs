using System;

double num1;

Console.Write("Enter first number: ");
while (!double.TryParse(Console.ReadLine(), out num1))
{
    Console.Write("Invalid input. Enter a valid number: ");
}
double num2;

Console.Write("Enter second number: ");
while (!double.TryParse(Console.ReadLine(), out num2))
{
    Console.Write("Invalid input. Enter a valid number: ");
}
Console.WriteLine("Choose an operation: +  -  *  /");
Console.Write("Enter operator: ");
string?input = Console.ReadLine();
char op = input.Length > 0 ? input[0] : '\0';

double result = 0;
bool valid = true;

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
            valid = false;
        }
        else
        {
            result = num1 / num2;
        }
        break;
    default:
        Console.WriteLine("Invalid operator.");
        valid = false;
        break;
}

if (valid)
{
    Console.WriteLine($"Result: {num1} {op} {num2} = {result:F2}");
}
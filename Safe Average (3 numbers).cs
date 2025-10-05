using System;

double n1, n2, n3;

Console.Write("Enter n1: ");
while (!double.TryParse(Console.ReadLine(), out n1))
{
    Console.Write("Invalid input. Enter a valid number for n1: ");
}

Console.Write("Enter n2: ");
while (!double.TryParse(Console.ReadLine(), out n2))
{
    Console.Write("Invalid input. Enter a valid number for n2: ");
}

Console.Write("Enter n3: ");
while (!double.TryParse(Console.ReadLine(), out n3))
{
    Console.Write("Invalid input. Enter a valid number for n3: ");
}

double average = (n1 + n2 + n3) / 3;
Console.WriteLine($"The average is: {average:F3}");

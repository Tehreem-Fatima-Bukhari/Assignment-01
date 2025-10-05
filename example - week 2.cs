using System;

Console.Write("Enter text: ");
  string? input = Console.ReadLine();

{
    string trimmed = input.Trim();
    Console.WriteLine($"trimmed: {trimmed}");
    Console.WriteLine($"UPPER: {trimmed.ToUpperInvariant()}");
    Console.WriteLine($"lower: {trimmed.ToLowerInvariant()}");
}
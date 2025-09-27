using System;

class Program
{
    static void Main()
    {
        int n;
        while (true)
        {
            Console.Write("How many readings? ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                break;
            Console.WriteLine(" Enter a number > 0.");
        }

        int[] temps = new int[n];

        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"Enter reading #{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out temps[i]))
                    break;
                Console.WriteLine(" Invalid input. Please enter an integer.");
            }
        }

        Console.WriteLine("\nYou entered the following readings:");
        foreach (int temp in temps)
        {
            Console.WriteLine(temp);
        }
    }
}
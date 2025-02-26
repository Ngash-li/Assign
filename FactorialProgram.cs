using System;
using System.Diagnostics;

class Program
{
    // Function to calculate factorial
    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    static void Main()
    {
        // Input number
        Console.Write("Enter a number to calculate factorial: ");
        int num = int.Parse(Console.ReadLine());

        // Create a stopwatch instance to measure runtime
        Stopwatch stopwatch = new Stopwatch();
        
        // Start measuring time
        stopwatch.Start();
        
        // Calculate factorial
        long result = Factorial(num);
        
        // Stop measuring time
        stopwatch.Stop();
        
        // Output the result and runtime
        Console.WriteLine($"Factorial of {num} is: {result}");
        Console.WriteLine($"Time taken to calculate factorial: {stopwatch.Elapsed.TotalSeconds} seconds");
    }
}

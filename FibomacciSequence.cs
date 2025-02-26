using System;
using System.Diagnostics;

class Program
{
    // Function to calculate nth Fibonacci number
    static long Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        // Input number for Fibonacci sequence
        Console.Write("Enter the number to find the Fibonacci sequence up to: ");
        int num = int.Parse(Console.ReadLine());

        // Create a stopwatch instance to measure runtime
        Stopwatch stopwatch = new Stopwatch();
        
        // Start measuring time
        stopwatch.Start();
        
        // Output the Fibonacci sequence
        Console.WriteLine("Fibonacci Sequence:");
        for (int i = 0; i < num; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
        
        // Stop measuring time
        stopwatch.Stop();
        
        // Output runtime
        Console.WriteLine("\nTime taken to calculate Fibonacci sequence: " + stopwatch.Elapsed.TotalSeconds + " seconds");
    }
}

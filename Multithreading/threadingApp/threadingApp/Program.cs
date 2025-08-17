using System;
using System.Threading;
using System.Threading.Tasks;
namespace threadingApp
{   // This is a simple console application demonstrating threading in C#
    // It uses both classic Thread and Task for parallel execution
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main thread starting...");

        // Start classic threads
        Thread thread1 = new Thread(DoWork1);
        Thread thread2 = new Thread(DoWork2);

        thread1.Start();
        thread2.Start();

        // Using Task (modern approach)
        Task.Run(() => DoWork3());

        Console.WriteLine("Main thread is free to do other work...");

        // Wait before exiting
        thread1.Join();
        thread2.Join();

        Console.WriteLine("All threads completed. Press any key to exit.");
        Console.ReadKey();
    }

    static void DoWork1()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"[Thread 1] Working... step {i}");
            Thread.Sleep(500); // Simulate work
        }
    }

    static void DoWork2()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"[Thread 2] Processing... step {i}");
            Thread.Sleep(700); // Simulate work
        }
    }

    static void DoWork3()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"[Task Thread] Calculating... step {i}");
            Thread.Sleep(600); // Simulate work
        }
    }
}
   
}

using System;

namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Project started");
        
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name);
    }
}
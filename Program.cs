using System;

namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Project has started");
        
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name);
        
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Error: Name cannot be empty");
        }
        
        double average = StatisticsHelper.CalculateAverage(numbers);
        Console.WriteLine("Average value is: " + average);
        
        double max = StatisticsHelper.CalculateMax(numbers);
        Console.WriteLine("Maximum value is: " + max);

        double min = StatisticsHelper.CalculateMin(numbers);
        Console.WriteLine("Minimum value is: " + min);

        Console.WriteLine("This is a different message from main branch")
    }
}
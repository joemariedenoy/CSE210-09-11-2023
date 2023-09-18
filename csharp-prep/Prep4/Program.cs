using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        
        List<int> numbers = new List<int>();
        
        int askUserNumber = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (askUserNumber != 0)
        {
            Console.Write("Enter a number: ");
            
            string userResponse = Console.ReadLine();
            askUserNumber = int.Parse(userResponse);
            
            if (askUserNumber != 0)
            {
                numbers.Add(askUserNumber);
            }
        }

        // 1. Compute the sum, or total, of the numbers in the list.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // 2. Compute the average of the numbers in the list.
        int count = numbers.Count;

        float average = ((float)sum) / count;
        Console.WriteLine($"The average is: {average}");


        // 3. Find the maximum, or largest, number in the list.        
        int largestNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");

        // find the smallest number
        int smallestNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number < smallestNumber)
            {
                smallestNumber = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
    }
}
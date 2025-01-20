using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers;
        numbers = new List<int>();
        // has the user input a list of number until they type 0
        int number = 1;
        do
        {
            Console.Write("Enter number: ");
            string user_input = Console.ReadLine();
            number = int.Parse(user_input);
            if (number != 0)
                {
                    numbers.Add(number);
                }
                        
        } while (number != 0);
        // finds sum by iterating through all numbers in the list 
        int sum = 0;
        foreach (int i in numbers)
            {
               sum += i; 
            }
        // finds the average 
        double average = 0;
        average = (double)sum / numbers.Count;
        
        // find the largest number in the list
        int largest = int.MinValue;
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        
        // returns the sum, average and largest number
        Console.WriteLine($"The Sum is: {sum}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}
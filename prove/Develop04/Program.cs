using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            Console.Write("Menu Options:\n1. Start Breathing Activity\n2. Start Reflecting Activity\n3. Start Listing Activity\n4. Quit\nSelect a choice from the Menu: ");
            string choice = Console.ReadLine();

            if (choice.Contains("1") || choice.Contains("Breath"))
            {
                Breathing breathing = new Breathing("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing", 0);

                breathing.Run();
            }
            else if (choice.Contains("2") || choice.Contains("Reflect"))
            {
                Reflecting reflecting = new Reflecting("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflecting", 0);

                reflecting.Run();
            }
            else if (choice.Contains("3") || choice.Contains("List"))
            {
                Listing listing = new Listing("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing", 0);

                listing.Run();
            }
            else if (choice.Contains("4") || choice.Contains("Quit"))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
                Thread.Sleep(2000);
            }
        }
        Console.WriteLine("Goodbye!");

    }
}
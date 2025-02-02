using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create Entry");
            Console.WriteLine("2. Load Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. View Journal");
            Console.WriteLine("5. Delete Journal");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter your journal entry: ");
                    string prompt = new Prompt().GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string text = Console.ReadLine();
                    journal.AddEntry(text, prompt);
                    break;
                case "2":
                    journal.LoadFromFile();
                    Console.WriteLine("Journal loaded.");
                    break;
                case "3":
                    journal.SaveToFile();
                    Console.WriteLine("Journal saved.");
                    break;
                case "4":
                    journal.DisplayAll();
                    break;
                case "5":
                    journal.DeleteJournalFile();
                    Console.WriteLine("Journal deleted.");
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
           }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = null;
        while(true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create Fraction");
            Console.WriteLine("2. View Fraction");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the numerator: ");
                    int top = int.Parse(Console.ReadLine());
                    Console.Write("Enter the denominator: ");
                    int bottom = int.Parse(Console.ReadLine());
                    fraction = new Fraction(top, bottom);
                    break;
                case "2":
                    if (fraction != null)
                    {
                        Console.WriteLine($"Fraction: {fraction.GetFractionString()}");
                        Console.WriteLine($"Decimal value: {fraction.GetDecimalValue()}");
                    }
                    else
                    {
                        Console.WriteLine("No fraction created yet.");
                    }
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
        }
    }
    }
}
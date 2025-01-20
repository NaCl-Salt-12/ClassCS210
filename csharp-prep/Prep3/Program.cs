using System;

class Program
{
    static void Main(string[] args)
    {
        string again = "y";
        while (again == "y")
        {

            Random randomGenerator = new Random();
            int rnd_number = randomGenerator.Next(1,100);

            Console.WriteLine("Guess the magic number");
            int attempts = 0;
            int guess = 0;
            do
            {
                Console.Write("What is your guess: ");
                string response = Console.ReadLine();
                guess = int.Parse(response);

                if(guess > rnd_number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < rnd_number)
                {
                    Console.WriteLine("Higher");
                }
                attempts += 1;
            } while (guess != rnd_number);
            
            Console.WriteLine("You guessed correctly");
            Console.WriteLine($"You guessed the magic number in {attempts} trys");
            Console.WriteLine("Play again? (y/n)");
            again = Console.ReadLine();
        }
    }
}
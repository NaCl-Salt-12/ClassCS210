using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squarednumber = SquareNumber(userNumber);
        DisplayResult(userName,squarednumber);
        static void DisplayWelcome()
        {
            // welcomes the user
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            // asks for the users name 
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            // ask for the users favorite number and returns it 
            Console.WriteLine("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        }
        static int SquareNumber(int userNumber)
        {
            // takes the given number and squares it 
            int numberSquare = userNumber*userNumber;
            return numberSquare;
        }
        static void DisplayResult(string userName, int numberSquare)
        {
            // prints the users name and the number
            Console.WriteLine($"{userName}, the square of your number is {numberSquare}");
        }
    }
}
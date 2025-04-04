using System;

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message to introduce the user to the application
        Console.WriteLine("Welcome to Eternal Quest Program!");
        Console.WriteLine("Track your goals and achievements and level up as you accomplish them.");
        
        // Create a new instance of the UserInterface class to handle user interactions
        UserInterface ui = new UserInterface();
        
        // Start the main application loop by calling the Run method
        // This will display the menu and handle all user input until the user chooses to exit
        ui.Run();

        // Display a farewell message when the user exits the program
        Console.WriteLine("Thank you for using Eternal Quest Program!");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses for each event
        Address lectureAddress = new Address("123 University St", "College Town", "CA", "90210", "USA");
        Address receptionAddress = new Address("456 Celebration Ave", "Wedding City", "NY", "10001", "USA");
        Address outdoorAddress = new Address("789 Park Road", "Nature Valley", "CO", "80302", "USA");

        // Create a lecture event
        Lecture lecture = new Lecture(
            "Advanced C# Programming", 
            "Learn advanced techniques in C# programming from an industry expert.", 
            new DateOnly(2023, 11, 15), 
            "6:00 PM", 
            lectureAddress, 
            "Lecture", 
            "Dr. Jane Smith", 
            150);

        // Create a reception event
        Reception reception = new Reception(
            "Johnson Wedding Reception", 
            "Join us to celebrate the marriage of Sarah and Michael Johnson.", 
            new DateOnly(2023, 12, 10), 
            "7:30 PM", 
            receptionAddress, 
            "Reception", 
            "rsvp@johnsonwedding.com");

        // Create an outdoor event
        Outdoor outdoor = new Outdoor(
            "Community Summer Picnic", 
            "Annual community gathering with food, games, and activities for all ages.", 
            new DateOnly(2023, 7, 4), 
            "12:00 PM", 
            outdoorAddress, 
            "Outdoor", 
            "Sunny with a high of 75°F");

        // Display information for each event
        Console.WriteLine("LECTURE EVENT");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandard());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture.GetDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lecture.GetShort());

        Console.WriteLine("\n\nRECEPTION EVENT");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandard());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(reception.GetDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(reception.GetShort());

        Console.WriteLine("\n\nOUTDOOR EVENT");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoor.GetStandard());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(outdoor.GetDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoor.GetShort());
    }
}
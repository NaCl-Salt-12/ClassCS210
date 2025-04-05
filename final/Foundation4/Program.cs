using System;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        List<Activity> activities = new List<Activity>
        {
            new Running("2023-11-03", 30, 3.0),
            new Cycling("2023-11-04", 45, 15.0),
            new Swimming("2023-11-05", 60, 20.0)
        };

        // Display summary for each activity
        Console.WriteLine("Exercise Activity Tracking:");
        Console.WriteLine("-------------------------");

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
            Console.WriteLine("-------------------------");
        }
    }
}
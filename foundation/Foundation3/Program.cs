using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate instances of each activity type
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),  // 3 miles run
            new Cycling(new DateTime(2022, 11, 4), 45, 4.8), // 15 mph cycling
            new Swimming(new DateTime(2022, 11, 5), 40, 30)   // 30 laps swimming
        };

        // Iterate through each activity and print the summary
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
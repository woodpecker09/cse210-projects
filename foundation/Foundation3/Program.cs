using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new();
        Running running = new Running("03 Nov 2022", 30, 3.0);
        activities.Add(running);
        Cycling cycling = new Cycling("03 Nov 2022", 30, 6.0);
        activities.Add(cycling);
        Swimming swimming = new Swimming("03 Nov 2022", 30, 20);
        activities.Add(swimming);
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
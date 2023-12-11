using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running (new DateTime(2023, 12, 04), 30, 3.0),
            new Cycling (new DateTime(2023, 12, 04), 30, 9.7),
            new Swimming(new DateTime(2022, 12, 04), 30, 3)
        };
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
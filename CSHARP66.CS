using System;
using System.Linq;

class ActivitySelection
{
    static void Main()
    {
        int[] start = { 1, 3, 0, 5, 8, 5 };
        int[] finish = { 2, 4, 6, 7, 9, 9 };

        var activities = start
            .Select((s, i) => new { Start = s, Finish = finish[i] })
            .OrderBy(a => a.Finish)
            .ToList();

        int lastFinish = -1;

        foreach (var act in activities)
        {
            if (act.Start >= lastFinish)
            {
                Console.WriteLine(act.Start + " - " + act.Finish);
                lastFinish = act.Finish;
            }
        }
    }
}
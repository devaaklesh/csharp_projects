using System;
using System.Linq;

class JobScheduling
{
    class Job { public string Id; public int Deadline; public int Profit; }

    static void Main()
    {
        Job[] jobs = {
            new Job{Id="A",Deadline=2,Profit=100},
            new Job{Id="B",Deadline=1,Profit=19},
            new Job{Id="C",Deadline=2,Profit=27},
            new Job{Id="D",Deadline=1,Profit=25},
            new Job{Id="E",Deadline=3,Profit=15}
        };

        var sorted = jobs.OrderByDescending(j => j.Profit).ToArray();
        int maxDeadline = sorted.Max(j => j.Deadline);
        string[] result = new string[maxDeadline];

        foreach (var job in sorted)
        {
            for (int j = job.Deadline - 1; j >= 0; j--)
                if (result[j] == null)
                {
                    result[j] = job.Id;
                    break;
                }
        }

        foreach (var r in result)
            if (r != null)
                Console.WriteLine(r);
    }
}
using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Job job1 = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            Job job2 = new Job("Web Developer", "LaunchCode", "St. Louis", "Front-end developer", "JavaScript");
            Job job3 = new Job("Ice cream tester", "", "Home", "UX", "Tasting ability");

            List<Job> jobs = new List<Job>();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);

            foreach (Job job in jobs)
            {
                Console.WriteLine(job);
            }
            
        }
    }
}

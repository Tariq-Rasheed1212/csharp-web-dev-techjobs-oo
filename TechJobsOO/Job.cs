using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        
        private static int nextId = 1;
        public string Value { get; set; }

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
            {
            Id = nextId;
            nextId++;
            }

        // TODO: Generate Equals() and GetHashCode() methods.

        public Job(string name, string employerName, string employerLocation, string jobType, string jobCoreCompetency) : this()
            {

            Name = name;
            EmployerName = new Employer(employerName);
            EmployerLocation = new Location(employerLocation);
            JobType = new PositionType(jobType);
            JobCoreCompetency = new CoreCompetency(jobCoreCompetency);
            }

        public override bool Equals(object obj)
            {
            return obj is Job job &&
                   Id == job.Id;
            }

        public override int GetHashCode()
            {
            return HashCode.Combine(Id);
            }
        public override string ToString()
            {
            return "\nID: " + Id +
                   $"\nName: {ValueChecker(Name)}" +
                   $"\nEmployer: {ValueChecker(EmployerName.Value)}" +
                   $"\nLocation: {ValueChecker(EmployerLocation.Value)}" +
                   $"\nPosition Type: {ValueChecker(JobType.Value)}" +
                   $"\nCore Competency: {ValueChecker(JobCoreCompetency.Value)}" +
                   "\n";
            }

        private string ValueChecker( string item)
            {
             if (item == "")
                {
                return "Data not available";
                }
            else
                {
                return item;
                }
                
            }
        }
}

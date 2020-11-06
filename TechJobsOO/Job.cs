using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }
        public object id { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency)
        : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.


        

        public override string ToString()
        {
            if (IsNotValidJob())
                return "OOPS! This job does not seem to exist.";
            string toString = new string("\nID: " + Id);
            toString += "\nName: " + GetCorrectLabel(Name);
            toString += "\nEmployer: " + GetCorrectLabel(EmployerName.Value);
            toString += "\nLocation: " + GetCorrectLabel(EmployerLocation.Value);
            toString += "\nPosition Type: " + GetCorrectLabel(JobType.Value);
            toString += "\nCore Competency: " + GetCorrectLabel(JobCoreCompetency.Value + "\n");

            return toString;
        }


        private string GetCorrectLabel(string label)
        {
            return (String.IsNullOrEmpty(label)) ? "Data not available" : label;
        }

        private Boolean IsNotValidJob()
        {
            return String.IsNullOrEmpty(Name) && EmployerName == null && JobType == null && JobCoreCompetency == null && EmployerLocation == null;
        }
    }

}

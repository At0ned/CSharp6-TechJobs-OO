using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Reflection.Metadata;
namespace TechJobsOOAutoGraded6
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


            public Job()
            {
                Id = nextId;
                nextId++;
            }

            public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
            {
                Name = name;
                EmployerName = employerName;
                EmployerLocation = employerLocation;
                JobType = jobType;
                JobCoreCompetency = jobCoreCompetency;
            }



        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  
        public override bool Equals(object? obj)
        {
            return obj is Job job &&
            Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
    public override string ToString() 
    { 
        string empty = "Data not available";

        return Environment.NewLine + 
        "ID: " + Id + Environment.NewLine +
        "Name: " + ((Name.Length != 0) ? Name : empty) + Environment.NewLine +
        "Employer: " + ((EmployerName.ToString().Length != 0) ? EmployerName : empty) + Environment.NewLine +
        "Location: " + ((EmployerLocation.ToString().Length != 0) ? EmployerLocation : empty) + Environment.NewLine +
        "Position Type: " + ((JobType.ToString().Length != 0) ? JobType : empty) + Environment.NewLine +
        "Core Competency: " + ((JobCoreCompetency.ToString().Length != 0) ? JobCoreCompetency : empty) + Environment.NewLine;
    }



    }
}


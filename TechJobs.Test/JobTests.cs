
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        //initalize your testing objects here
        //Testing objects
    Job job1 = new Job();

    Job job2 = new Job();

    Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

    Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
    Job job5 = new Job("", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

    


        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.ToString());
            Assert.AreEqual("Desert", job3.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job3.JobType.ToString());
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsTrue(!Equals(job3, job4));
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
       
        Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
        Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));

        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
        Assert.IsTrue(job4.ToString().Contains("ID: " + job4.Id));
        Assert.IsTrue(job4.ToString().Contains("Name: " + job4.Name));
        Assert.IsTrue(job4.ToString().Contains("Employer: " + job4.EmployerName));
        Assert.IsTrue(job4.ToString().Contains("Location: " + job4.EmployerLocation));
        Assert.IsTrue(job4.ToString().Contains("Position Type: " + job4.JobType));
        Assert.IsTrue(job4.ToString().Contains("Core Competency: " + job4.JobCoreCompetency));
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
        Assert.IsTrue(job5.ToString().Contains("Data not available"));
        // Assert.AreEqual(job5.ToString(), 3);
        }
    }
}


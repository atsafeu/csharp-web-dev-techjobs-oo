using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job1.Id != job2.Id);
            Assert.IsFalse(job1.Id == job2.Id);
            int difference = job1.Id- job2.Id;
            Assert.AreEqual(-1, difference);

        }

        [TestMethod]
        public void TestSettingJobIdDifference1()
        {
            Job job1 = new Job();
            Job job2 = new Job();
   
            int difference = job1.Id - job2.Id;
            Assert.AreEqual(-1, difference);
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer employer = new Employer("ACME");
            Location jobLocation = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency competency = new CoreCompetency("Persistence");

            Job job = new Job("Product tester", employer, jobLocation, jobType, competency);

            Assert.AreEqual(job.Name, "Product tester");
            Assert.AreEqual(job.EmployerName.Value, "ACME");
            Assert.AreEqual(job.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job.JobType.Value, "Quality control");
            Assert.AreEqual(job.JobCoreCompetency.Value, "Persistence");


        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer employer = new Employer("Employer");
            Location locationName = new Location("Location");
            PositionType position = new PositionType("Location");
            CoreCompetency myCompetency = new CoreCompetency("Competency");
            Job job1 = new Job("Name", employer, locationName, position, myCompetency);
            Job job2 = new Job("Name", employer, locationName, position, myCompetency);
            PositionType position2 = new PositionType("Location");
     
           Assert.IsTrue(position.Equals(position));
        }

        [TestMethod]
        public void TestJobFielsForEquality()
        { 
      
            Employer employer = new Employer("Employer");
            Employer employer1 = new Employer("Employer");
           
            Assert.IsTrue(employer.Equals(employer));

        }


            [TestMethod]
        public void TestToStringToPassTheFirstTest()
        {
            Employer employer = new Employer("Employer");
            Location locationName = new Location();
            PositionType position = new PositionType("Position Type");
            CoreCompetency myCompetency = new CoreCompetency("Competency");
            Job job = new Job("Name 1", employer, locationName, position, myCompetency);

            string expected = new string("\nID: " + job.Id);
            expected += "\nName: " + job.Name;
            expected += "\nEmployer: " + job.EmployerName.Value;
            expected += "\nLocation: Data not available";
            expected += "\nPosition Type: " + job.JobType.Value;
            expected += "\nCore Competency: " + job.JobCoreCompetency.Value + "\n";

            Assert.AreEqual(expected, job.ToString());
        }

        [TestMethod]
        public void TestToStringToFinishTheTDD()
        {
            Job job = new Job();

            string expected = "OOPS! This job does not seem to exist.";
            Assert.AreEqual(expected, job.ToString());
        }


    }
}

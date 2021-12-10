using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
    {
    [TestClass]
    public class JobTests
        {
        Job job_id;
        Job second_job_id;
        [TestInitialize]
        public void CreateJobObject() 
            {
             job_id = new Job();
             second_job_id = new Job();
            }
        [TestMethod]
        public void TestSettingJobId()
            {

            // could insert 2 & 3 
            Assert.IsTrue(job_id.Id != second_job_id.Id && (job_id.Id + 1) == second_job_id.Id);
            }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
            {
            Job company_test_info = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            
            Assert.AreEqual("Product tester", company_test_info.Name);
            Assert.AreEqual("ACME", company_test_info.EmployerName.Value);
            Assert.AreEqual("Desert", company_test_info.EmployerLocation.Value);
            Assert.AreEqual("Quality control", company_test_info.JobType.Value);
            Assert.AreEqual("Persistence", company_test_info.JobCoreCompetency.Value);
            }
        
        [TestMethod]
        public void TestJobsForEquality()
            {
            Job test_identical_values = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            Job test_identical_values2 = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");

            Assert.IsFalse(test_identical_values.Equals(test_identical_values2));
            }

        [TestMethod]

        public void TestForCustomToString()
            {
            Job custom_string = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            Assert.AreEqual("\nID: " + custom_string.Id +
                   "\nName: " + custom_string.Name +
                   "\nEmployer: " + custom_string.EmployerName.Value +
                   "\nLocation: " + custom_string.EmployerLocation.Value +
                   "\nPosition Type: " + custom_string.JobType.Value +
                   "\nCore Competency: " + custom_string.JobCoreCompetency.Value +
                   "\n", custom_string.ToString());

            Job custom_string2 = new Job("Product tester", "ACME", "", "", "Persistence");
            Assert.AreEqual("\nID: " + custom_string2.Id +
                   "\nName: " + custom_string2.Name +
                   "\nEmployer: " + custom_string2.EmployerName.Value +
                   "\nLocation: Data not available" +
                   "\nPosition Type: Data not available"  +
                   "\nCore Competency: " + custom_string2.JobCoreCompetency.Value +
                   "\n", custom_string2.ToString());
            }
        }
    }

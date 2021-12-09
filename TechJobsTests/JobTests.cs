using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
    {
    [TestClass]
    public class JobTests
        {
        [TestMethod]
        public void TestSettingJobId()
            {
            Job job_id = new Job();
            Job second_job_id = new Job();
            // could insert 2 & 3 
            Assert.AreEqual(1, job_id.Id);
            Assert.AreEqual(2, second_job_id.Id);
            }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
            {
            Job company_test_info = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            Assert.AreEqual(1, company_test_info.Id);
            Assert.AreEqual("Product tester", company_test_info.Name);
            Assert.AreEqual("ACME", company_test_info.EmployerName.Value);
            Assert.AreEqual("Desert", company_test_info.EmployerLocation.Value);
            Assert.AreEqual("Quality control", company_test_info.JobType.Value);
            Assert.AreEqual("Persistence", company_test_info.JobCoreCompetency.Value);
            }
        
        [TestMethod]
        public void TestJobsForEquality()
            {
            Job identical_values = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            Job identical_values2 = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");

            Assert.IsFalse(identical_values.Equals(identical_values2));
            }
        }
    }

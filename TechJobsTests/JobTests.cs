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
            Assert.AreEqual(1, job_id.Id);
            Assert.AreEqual(2, second_job_id.Id);
            }
        }
    }

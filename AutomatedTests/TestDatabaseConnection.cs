using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomatedTests
{
    [TestClass]
    public class TestDatabaseConnection
    {
        /// <summary>
        /// Test that basicRequest() returns an integer.
        /// </summary>
        /*
        [TestMethod]
        public void TestBasicRequestNumber()
        {
            string sqlQuery = "SELECT Applicant_info_ID FROM Applicant WHERE Applicant_ID = 1";
            string reply = HappyTech.DatabaseConnection.basicRequest(sqlQuery, true);
            Assert.AreEqual(reply, "4");
        }

        /// <summary>
        /// Test that basicRequest() returns a string.
        /// </summary>
        [TestMethod]
        public void TestBasicRequestString()
        {
            string sqlQuery = "SELECT Applicant_fName FROM Applicant_Information WHERE Applicant_lName = 'Malone'";
            string reply = HappyTech.DatabaseConnection.basicRequest(sqlQuery, false);
            Assert.AreEqual(reply, "Post");
        }*/
    }
}

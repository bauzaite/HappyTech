
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    public class Tests
    {
        [TestMethod]
        public void TestBasicRequestNumber()
        {
            string sqlQuery = "SELECT Applicant_info_ID FROM Applicant WHERE Applicant_Id = 1";
            string reply = HappyTech.DatabaseConnection.basicRequest(sqlQuery, true);
            Assert.AreEqual(reply, "4");
        }

        [TestMethod]
        public void TestBasicRequestString()
        {
            string sqlQuery = "SELECT templateCategory FROM templates WHERE Id = 3";
            string reply = HappyTech.DatabaseConnection.basicRequest(sqlQuery, false);
            Assert.AreEqual(reply, "CV Presentation");
        }
    }
}
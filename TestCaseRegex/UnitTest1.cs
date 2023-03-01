using RegexProblems;

namespace TestCaseRegex
{
    [TestClass]
    public class UnitTest1
    {

        RegexProgram regexTestCase = new RegexProgram();


        [TestMethod]
        public void TestForFirstName()
        {
            string firstName = regexTestCase.ValidateFirstName("Tanvi");
            Assert.AreEqual(firstName, "Tanvi");
        }
        [TestMethod]
        public void TestForLastName()
        {
            string LastName = regexTestCase.ValidateLastName("Shinde");
            Assert.AreEqual(LastName, "Shinde");
        }
        [TestMethod]
        public void TestForGmail()
        {
            string LastName = regexTestCase.ValidateEmail("tanvi.shinde@gmail.co.in\"");
            Assert.AreEqual(LastName, "tanvi.shinde@gmail.co.in\"");
        }
       
    }
}

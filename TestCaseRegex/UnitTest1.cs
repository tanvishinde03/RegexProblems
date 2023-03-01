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
       
       
       
    }
}

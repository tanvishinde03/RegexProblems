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
        [TestMethod]
        public void TestForPhoneNumber()
        {
            string LastName = regexTestCase.ValidatePhoneNumber("91 8007622250");
            Assert.AreEqual(LastName, "91 8007622250");
        }
        [TestMethod]
        public void TestForPassword()
        {
            string LastName = regexTestCase.ValidatePassword("Password");
            Assert.AreEqual(LastName, "Password");
        }
        [TestMethod]
       
        public void TestForStringPassword()
        {
            string LastName = regexTestCase.ValidateStringPassword("Tanvi123");
            Assert.AreEqual(LastName, "Tanvi123");
        }
        [TestMethod]
        public void TestForNumericPassword()
        {
            string LastName = regexTestCase.ValidateNumericPassword("tanU003");
            Assert.AreEqual(LastName, "tanU003");
        }
       
    }
}

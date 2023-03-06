using RegexProblems;

namespace TestCaseRegex
{
    [TestClass]
    public class UnitTest1
    {

        RegexProgram regexTestCase = new RegexProgram(null);


        [TestMethod]
        public void Given_Empty_FirstName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string result = regexTestCase.ValidateFirstName("Tanvi");
            }
            catch (UserRegistratinException obj)
            {
                Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
            }
        }

        [TestMethod]
        public void Given_Empty_LastName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string result = regexTestCase.ValidateFirstName("Shinde");
            }
            catch (UserRegistratinException obj)
            {
                Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_MAIL_ID_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string result = regexTestCase.ValidateFirstName("tanvi.shinde@gmail.co.in");
            }
            catch (UserRegistratinException obj)
            {
                Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_PHONENUMBER_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string result = regexTestCase.ValidateFirstName("91 8007622250");
            }
            catch (UserRegistratinException obj)
            {
                Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_PASSWORD_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string result = regexTestCase.ValidateFirstName("password");
            }
            catch (UserRegistratinException obj)
            {
                Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_PASSWORDRULE2_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string result = regexTestCase.ValidateFirstName("Tanvi123");
            }
            catch (UserRegistratinException obj)
            {
                Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_PASSWORDRULE3_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string result = regexTestCase.ValidateFirstName("tanU003");
            }
            catch (UserRegistratinException obj)
            {
                Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
            }
        }
    }
}
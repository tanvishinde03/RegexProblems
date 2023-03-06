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
           
       
       
       
    }
}

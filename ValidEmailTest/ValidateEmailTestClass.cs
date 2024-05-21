
using RobertsEmailValidatorProject;
namespace ValidEmailTest
{
    [TestClass]
    public class ValidateEmailTestClass
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void NotNullEmailTest ()
        {
            TestContext.WriteLine("Currently in Test: " + TestContext.TestName);
            string _email = TestContext.Properties["param1"].ToString();
            bool result = ValidEmails.NotNullEmail(_email);
            Assert.IsTrue(result);
           
        }
    }
}
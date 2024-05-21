
using RobertsEmailValidatorProject;
namespace ValidEmailTest
{
    [TestClass]
    public class ValidateEmailTestClass
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void NotNullEmailTest()
        {
            TestContext.WriteLine("Currently in Test: " + TestContext.TestName);
            string _email = TestContext.Properties["goodEmail"].ToString();
            bool result = ValidEmails.NotNullEmail(_email);
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void NullEmailTest()
        {
            TestContext.WriteLine("Currently in Test: " + TestContext.TestName);
            string _email = TestContext.Properties["nullEmail"].ToString();
            bool badResult = ValidEmails.NotNullEmail(_email);
            Assert.IsTrue(badResult);

        }
        [TestMethod]
        public void ContainsAtTest()
        {
            TestContext.WriteLine("Currently in Test: " + TestContext.TestName);
            string _email = TestContext.Properties["goodEmail"].ToString();
            bool Result = ValidEmails.ContainsAtSymbol(_email);
            Assert.IsTrue(Result);

        }
        [TestMethod]
        public void NoAtTest()
        {
            TestContext.WriteLine("Currently in Test: " + TestContext.TestName);
            string _email = TestContext.Properties["badAtEmail"].ToString();
            bool badResult = ValidEmails.ContainsAtSymbol(_email);
            Assert.IsTrue(badResult);

        }
        [TestMethod]
        public void lDBeforeAtTest()
        {
            TestContext.WriteLine("Currently in Test: " + TestContext.TestName);
            string _email = TestContext.Properties["goodEmail"].ToString();
            bool Result = ValidEmails.ContainsAtSymbol(_email);
            Assert.IsTrue(Result);

        }
        [TestMethod]
        public void noLDBeforeAtTest()
        {
            TestContext.WriteLine("Currently in Test: " + TestContext.TestName);
            string _email = TestContext.Properties["badBeforeAtEmail"].ToString();
            bool badResult = ValidEmails.ContainsAtSymbol(_email);
            Assert.IsTrue(badResult);

        }
        [TestMethod]
        public void LDAfterAtTest()
        {
            TestContext.WriteLine("Currently in Test: " + TestContext.TestName);
            string _email = TestContext.Properties["goodEmail"].ToString();
            bool Result = ValidEmails.ContainsAtSymbol(_email);
            Assert.IsTrue(Result);

        }
        [TestMethod]
        public void noLDAfterAtTest()
        {
            TestContext.WriteLine("Currently in Test: " + TestContext.TestName);
            string _email = TestContext.Properties["badAfterAtEmail"].ToString();
            bool badResult = ValidEmails.ContainsAtSymbol(_email);
            Assert.IsTrue(badResult);

        }
        [TestMethod]
        public void goodDotTest()
        {
            TestContext.WriteLine("Currently in Test: " + TestContext.TestName);
            string _email = TestContext.Properties["goodEmail"].ToString();
            bool Result = ValidEmails.ContainsAtSymbol(_email);
            Assert.IsTrue(Result);

        }
        [TestMethod]
        public void badDotBeforeAtTest()
        {
            TestContext.WriteLine("Currently in Test: " + TestContext.TestName);
            string _email = TestContext.Properties["badDotBeforeAtEmail"].ToString();
            bool badResult = ValidEmails.ContainsAtSymbol(_email);
            Assert.IsTrue(badResult);

        }
        [TestMethod]
        public void noDotAfterAtTest()
        {
            TestContext.WriteLine("Currently in Test: " + TestContext.TestName);
            string _email = TestContext.Properties["MissingDotAfterAtEmail"].ToString();
            bool badResult = ValidEmails.ContainsAtSymbol(_email);
            Assert.IsTrue(badResult);

        }

    }
}
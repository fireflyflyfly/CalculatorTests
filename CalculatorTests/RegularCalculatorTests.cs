using Calculator;
using NUnit.Framework;

namespace Tests
{
    [TestFixture(Description = "Test suite for regular calculator features")]
    public class RegularCalculatorTests
    {
        [SetUp] public void Initialize()
        {
        }

        [TearDown] public void CleanUp()
        {
        }

        public RegularCalculator calc = new RegularCalculator();


        // Calculator tests
        [TestCase(4, 2, 2), Description("test"), Order(1), MaxTime(1), Repeat(2), Retry(2)]
        [TestCase(12, 6, 6)]
        [TestCase(-2, 1, -3)]
        [TestCase(102.5, 2.5, 100)]
        public void TestAddition(double target, double variable1, double variable2)
        {
            Assert.AreEqual(target, calc.Addition(variable1, variable2));
        }

        [Test(Description = "Verifies the work of calculator SUBSTRACTION feature"), Order(4)]
        public void TestSubstraction()
        {
            Assert.AreEqual(-1, calc.Subsctraction(1, 2));
        }

        [TestCase(135, 2, ExpectedResult = 67.5), Order(5)]
        public double TestDivision(int a, int b)
        {
            return calc.Division(a, b);
        }

        [Test(Description = "Verifies the work of calculator MULTIPLICATION feature", ExpectedResult = 4), Order(6)]
        public double TestMultiplication()
        {
            return calc.Multiplictation(2, 2);
        }


        //STRING TESTS

        [Test(Description = "Testing some funny string comparisions, this one fails on purpose"), Order(7)]
        [Ignore("For a reason")]
        public void VerifyStringIsEmpty()
        {
            string testString = "This is the most clever test ever";
            Assert.IsEmpty(testString);
        }

        [Test(Description = "Check if one string contains the other"), Order(8)]
        public void CheckIfStringsContainEachOther()
        {
            string a = "This is a fun test";
            string b = "test";
            Assert.That(a.Contains(b));
        }

        [Test(Description = "Check if strings start with a certain letter"), Order(9)]
        public void CheckIfStringStartsWith()
        {
            string a = "This is a fun test";
            string b = "test";
            Assert.That(a.ToLower().StartsWith("t") && b.ToLower().StartsWith("t"));
        }

        //ALWAYS PASS
        [Test(Description = "This one is meant to pass"), Order(11)]
        public void PassItAll()
        {
            Assert.Pass();
        }

        //ALWAYS FAIL
        [Test(Description = "This one is meant to fail"), Order(12)]
        public void FailItAll()
        {
            Assert.Fail();
        }
    }
}

using NUnit.Framework;
using Calculator;

namespace Tests
{
    public class Tests
    {
        [TestFixture]
        public class CalculatorTests
        {

            // Calculator tests
            [Test(Description = "Verifies the work of calculator ADDITION feature"), Order(1)]
            public void TestAddition()
            {
                RegularCalculator calc = new RegularCalculator();
                calc = new RegularCalculator();
                Assert.AreEqual(3, calc.Addition(1, 2));
            }

            [Test(Description = "Verifies the work of calculator SUBSTRACTION feature"), Order(2)]
            public void TestSubstraction()
            {
                RegularCalculator calc = new RegularCalculator();
                Assert.AreEqual(-1, calc.Subsctraction(1, 2));
            }

            //    public static TestCaseData[] TestCaseData = {
            //    new TestCaseData(135),
            //    new TestCaseData(2)
            //};
            [TestCase(135, 2, ExpectedResult = 67.5), Order(3)]
            public double TestDivision(int a, int b)
            {
                RegularCalculator calc = new RegularCalculator();
                return calc.Division(a, b);
            }

            [Test(Description = "Verifies the work of calculator MULTIPLICATION feature", ExpectedResult = 4), Order(4)]
            public double TestMultiplication()
            {
                RegularCalculator calc = new RegularCalculator();
                return calc.Multiplictation(2, 2);
            }


            //Other tests

            [Test(Description = "Testing some funny string comparisions, this one fails on purpose"), Order(5)]
            public void VerifyConsoleInput()
            {
                string testString = "This is the most clever test ever";
                Assert.IsEmpty(testString);
            }
        }
    }
}
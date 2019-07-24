using System;
using NUnit.Framework;
using Calculator;
namespace Tests
{
    [TestFixture (Description = "Test suite for scientific calculator features")]
    public class ScientificCalculatorTests
    {
        ScientificCalculator calc = new ScientificCalculator();


        [Test(ExpectedResult = 4, Description = "MathPOW method verification"), Order(1)]
        public double VerifyPow()
        {
            return calc.MathPowFunc(2, 2);
        }

        [Test(ExpectedResult = 5, Description = "GetPerscent method verification"), Order(2)]
        public double VerifyGetPercent()
        {
            return calc.GetPercent(5, 100);
        }

        [Test(Description = ""), Order(3)]
        public void VerifyGetArraySum()
        {
            double[] doubleArray = { 1, 2, 3 };
            //Assert.AreEqual(6, calc.GetArraySum(doubleArray));
            Assert.That(6, Is.EqualTo(calc.GetArraySum(doubleArray)), message: "Test output did not match an expected result.");
        }

        [Test(Description = "GetMaxArrayValue method verification"), Order(4)]
        public void VerifyGetMaxArrayValue()
        {
            double[] doubleArray = { 2, 2, 3, 5, 18, 0, 33, 1.6, 33.3 };
            //Assert.AreEqual(33.3, calc.GetArraySum(doubleArray));
            Assert.That(33.3, Is.EqualTo(calc.GetMaxArrayValue(doubleArray)));
        }

        [Test(Description = "GetMaxArrayValue method verification"), Order(5)]
        public void VerifyGetMinArrayValue()
        {
            double[] doubleArray = { 2, 2, 3, 5, 18, 0, 33, 1.6, 33.3 };
            //Assert.AreEqual(0, calc.GetMinArrayValue(doubleArray));
            Assert.That(0, Is.LessThanOrEqualTo(calc.GetMinArrayValue(doubleArray)));
        }
    }
}

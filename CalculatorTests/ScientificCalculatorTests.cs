using System;
using NUnit.Framework;
using Calculator;
namespace Tests
{
    [TestFixture]
    public class ScientificCalculatorTests
    {

        [Test(Description = "MathPOW method verification"), Order(1)]
        public void VerifyPow()
        {
            ScientificCalculator calc = new ScientificCalculator();
            Assert.AreEqual(4, calc.MathPowFunc(2, 2));
        }

        [Test(Description = "GetPerscent method verification"), Order(2)]
        public void VerifyGetPercent()
        {
            ScientificCalculator calc = new ScientificCalculator();
            Assert.AreEqual(5, calc.GetPercent(5, 100));
        }

        [Test(Description = ""), Order(3)]
        public void VerifyGetArraySum()
        {
            double[] doubleArray = { 1, 2, 3 };
            ScientificCalculator calc = new ScientificCalculator();
            Assert.AreEqual(6, calc.GetArraySum(doubleArray));
        }

        [Test(Description = "GetMaxArrayValue method verification"), Order(4)]
        public void VerifyGetMaxArrayValue()
        {
            double[] doubleArray = { 2, 2, 3, 5, 18, 0, 33, 1.6, 33.3 };
            ScientificCalculator calc = new ScientificCalculator();
            Assert.AreEqual(33.3, calc.GetMaxArrayValue(doubleArray));
        }

        [Test(Description = "GetMaxArrayValue method verification"), Order(5)]
        public void VerifyGetMinArrayValue()
        {
            double[] doubleArray = { 2, 2, 3, 5, 18, 0, 33, 1.6, 33.3 };
            ScientificCalculator calc = new ScientificCalculator();
            Assert.AreEqual(33.3, calc.GetMinArrayValue(doubleArray));
        }
    }
}

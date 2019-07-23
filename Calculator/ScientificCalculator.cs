using System;
using System.Linq;
namespace Calculator
{
    public class ScientificCalculator : RegularCalculator
    {
        public double MathPowFunc(double basis, double exponent)
        {
            return Math.Pow(basis, exponent);
        }

        public double GetPercent(double a, double b)
        {
            return Math.Round(a / b * 100);
        }

        public double GetArraySum(double[] doubleArray)
        {
            double total = 0;
            foreach (double number in doubleArray)
            {
                total += number;
            }
            return total;
        }

        public double GetMaxArrayValue(double[] doubleArray)
        {
            double max = doubleArray.Max();
            return max;
        }

        public double GetMinArrayValue(double[] doubleArray)
        {
            double min = doubleArray.Min();
            return min;
        }
    }
}

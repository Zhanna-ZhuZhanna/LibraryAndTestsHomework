using NUnit.Framework;
using HomeWorksLibrary;
namespace NUnitTestForHomeworks
{
    public class VariablesTests
    {
        [TestCase(5, 10, 25)]
        [TestCase(10, 5, -15)]
        [TestCase(1, -1, -3)]
        [TestCase(5, 10, 25)]
        [TestCase(8, 2, (-7.333333333333333))]
        public void TestSolveExpressionOfFirstExcersize(double a, double b, double expected)
        {
            double actual = Variables.SolveExpressionOfFirstExcersize(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5)]
        [TestCase(-7, -7)]
        public void NegativeTestSolveExpressionOfFirstExcersize(int a, int b)
        {
            try
            {
                double actual = Variables.SolveExpressionOfFirstExcersize(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(112, 10, 2)]
        [TestCase(5, 5, 0)]
        [TestCase(-4, 1, 0)]
        [TestCase(-4, 3, -1)]
        [TestCase(1, 3, 1)]
        public void TestGetModulo(int divident, int divider, int expected)
        {
            int actual = Variables.GetModulo(divident, divider);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(5, 0)]
        [TestCase(-7, 0)]
        public void NegativeTestGetModulo(int divident, int divider)
        {
            try
            {
                int actual = Variables.GetModulo(divident, divider);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(112, 10, 11)]
        [TestCase(5, 5, 1)]
        [TestCase(-4, 1, -4)]
        [TestCase(-4, 3, -1)]
        [TestCase(1, 3, 0)]
        public void TestGetTheWholePartOfDivision(int divident, int divider, int expected)
        {
            int actual = Variables.GetTheWholePartOfDivision(divident, divider);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(5, 0)]
        [TestCase(-7, 0)]
        public void NegativeGetTheWholePartOfDivision(int divident, int divider)
        {
            try
            {
                int actual = Variables.GetModulo(divident, divider);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(1, 2, 3, 1)]
        [TestCase(5, 10, 20, 2)]
        [TestCase(1, 1, 1, 0)]
        [TestCase(2, -3, -1, 1)]
        [TestCase(1, 3, 0, -3)]
        public void TestSolveTheLinearEquation(double a, double b, double c, double expected)
        {
            double actual = Variables.SolveTheLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual, 0.01);
        }
        [TestCase(0, 5, 0)]
        [TestCase(0, -7, 1)]
        public void NegativeTestSolveTheLinearEquation(double a, double b, double c)
        {
            try
            {
                double actual = Variables.SolveTheLinearEquation(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(-1, -1, 1, 1, new double[] {1, 0})]
        [TestCase(-2, 0, 0, 1, new double[] { 0.5, 1 })]
        public void TestGetCoefficientsOfLinearEquationFromPoints(double x1, double y1, double x2, double y2, double[] expected)
        {
            double[] actual = Variables.GetCoefficientsOfLinearEquationFromPoints(x1, y1, x2, y2);
            for(int i=0; i<actual.Length;i++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.01);
            }
         
        }
        [TestCase(0, 5, 0, 0)]
        [TestCase(1, -7, 1, 8)]
        public void NegativeTestGetCoefficientsOfLinearEquationFromPoints(double x1, double y1, double x2, double y2)
        {
            try
            {
                double[] actual = Variables.GetCoefficientsOfLinearEquationFromPoints(x1, y1, x2, y2);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }

}
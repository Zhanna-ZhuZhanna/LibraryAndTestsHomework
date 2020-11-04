using NUnit.Framework;
using HomeWorksLibrary;

namespace NUnitTestForHomeworks
{
    class CyclesTests
    {
        [TestCase(5, 2, 25)]
        [TestCase(2, 10, 1024)]
        [TestCase(3, 0, 1)]
        public void TestGetPow(int power, int grade, int expected)
        {
            int actual = Cycles.GetPow(power, grade);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(3, -5)]
        public void NegativeTestGetPow(int power, int grade)
        {
            try
            {
                int actual = Cycles.GetPow(power, grade);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(1000, new int[] {1000 })]
        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(400, new int[] { 400, 800 })]
        public void TestGetValuesDividingByVariable(int a, int[] expected)
        {
            int[] actual = Cycles.GetValuesDividingByVariable(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void NegativeTestGetValuesDividingByVariable(int a)
        {
            try
            {
                int[] actual = Cycles.GetValuesDividingByVariable(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(5,1)]
        [TestCase(12,6)]
        public void TestGetMaxDivider(int a, int expected)
        {
            int actual = Cycles.GetMaxDivider(a);
            Assert.AreEqual(expected, actual);
        }
       
        [TestCase(4,1)]
        [TestCase(17,4)]
        [TestCase(100,9)]
        public void TestGetAmountOfSquaresLessThanVariable(int a, int expected)
        {
            int actual = Cycles.GetAmountOfSquaresLessThanVariable(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        [TestCase(-5)]
        public void NegativeTestGetAmountOfSquaresLessThanVariable(int a)
        {
            try
            {
                int actual = Cycles.GetAmountOfSquaresLessThanVariable(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(4, 4,0)]
        [TestCase(-8, 8, 0)]
        [TestCase(9, 1, 7)]
        public void TestGetTheSumOfValuesAliquotToSevenFromTheSection(int a, int b, int expected)
        {
            int actual = Cycles.GetTheSumOfValuesAliquotToSevenFromTheSection(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(7, 13)]
        [TestCase(2, 1)]
        [TestCase(1, 1)]
        [TestCase(10, 55)]
        public void TestGetTheFibonacciValueFromItsIndex(int n, int expected)
        {
            int actual = Cycles.GetTheFibonacciValueFromItsIndex(n);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        [TestCase(-5)]
        public void NegativeTestGetTheFibonacciValueFromItsIndex(int n)
        {
            try
            {
                int actual = Cycles.GetTheFibonacciValueFromItsIndex(n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(11,44,11)]
        [TestCase(30, 15, 15)]
        [TestCase(15,15,15)]
        public void TestGetTheMaxDividerByEuclidAlgorithm(int a, int b, int expected)
        {
            int actual = Cycles.GetTheMaxDividerByEuclidAlgorithm(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-11,12)]
        [TestCase(11,-12)]
        public void NegativeTestGetTheMaxDividerByEuclidAlgorithm(int a, int b)
        {
            try
            {
                int actual = Cycles.GetTheMaxDividerByEuclidAlgorithm(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(-8,-2)]
        [TestCase(1,1)]
        [TestCase(27,3)]
        public void TestGetTheCubeRootByHalfDivisionMethod(int n, double expected)
        {
            double actual = Cycles.GetTheCubeRootByHalfDivisionMethod(n);
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestCase(181899, 4)]
        [TestCase(999,3)]
        [TestCase(-1001, 2)]
        public void TestGetTheAmountofOddDigits(int n, int expected)
        {
            int actual = Cycles.GetTheAmountofOddDigits(n);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1000, 1)]
        [TestCase(1987, 7891)]
        public void TestGetThePalindromOfTheNumber(int n, int expected)
        {
            int actual = Cycles.GetThePalindromOfTheNumber(n);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-10)]
        [TestCase(-505)]
        public void NegativeTestGetThePalindromOfTheNumber(int n)
        {
            try
            {
                int actual = Cycles.GetThePalindromOfTheNumber(n);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(6, 3)]
        [TestCase(5, 2)]
        public void TestGetTheAmountOfNumbersWhereTheSumOfEvenNumbersGraterThanSumOfOdds(int n, int expected)
        {
            int actual = Cycles.GetTheAmountOfNumbersWhereTheSumOfEvensGraterThanSumOfOdds(n);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(55,-55, "да")]
        [TestCase(55, 505, "да")]
        [TestCase(55, 44, "нет")]
        [TestCase(55, -44, "нет")]
        public void TestDecideIfThereAreTheSameDigitsInTwoNumbers(int a, int b, string expected)
        {
            string actual = Cycles.DecideIfThereAreTheSameDigitsInTwoNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}

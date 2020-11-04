using NUnit.Framework;
using HomeWorksLibrary;

namespace NUnitTestForHomeworks
{
    class ClausesTests
    {
        [TestCase(5, 10, -5)]
        [TestCase(10, 5, 15)]
        [TestCase(2, 2, 4)]
        public void TestCompareVariablesAndDecideWhatToDo(int a, int b, int expected)
        {
            int actual = Clauses.CompareVariablesAndDecideWhatToDo(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(5, 10, "Первая четверть")]
        [TestCase(-10, 5, "Вторая четверть")]
        [TestCase(2, -2, "Четвертая четверть")]
        [TestCase(-5, -10, "Третья четверть")]
        [TestCase(0, 5, "Х находится в нуле")]
        [TestCase(-2, 0, "Y находится в нуле")]
        [TestCase(0, 0, "Начало координат")]
        public void TestFindTheQuarter(double x, double y, string expected)
        {
            string actual = Clauses.FindTheQuarter(x,y);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(5, 10, 12, new int[] { 5,10,12})]
        [TestCase(7, 1, 12, new int[] { 1, 7, 12 })]
        [TestCase(5, 10, 1, new int[] { 1, 5, 10 })]
        [TestCase(15, 10, 12, new int[] { 10, 12, 15 })]
        [TestCase(5, 1, 5, new int[] { 1, 5, 5 })]
        [TestCase(5, 1, -3, new int[] { -3, 1, 5 })]
        [TestCase(5, 0, 1, new int[] { 0, 1, 5 })]
        public void TestSortThreeVariablesInIncreaseOrder(int a, int b, int c, int[] expected)
        {
            int[] actual = Clauses.SortThreeVariablesInIncreaseOrder(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase( 12, "двенадцать")]
        [TestCase(44, "сорок четыре")]
        [TestCase(19, "девятнадцать")]
        [TestCase(90, "девяносто")]
        public void TestGetTheNameForUsersValue(int a, string expected)
        {
            string actual = Clauses.GetTheNameForUsersValue(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(5)]
        [TestCase(100)]
        public void NegativeGetTheNameForUsersValue(int a)
        {
            try
            {
                string actual = Clauses.GetTheNameForUsersValue(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(16, 0, 0, new double[] { 0.0, 0.0 })]
        [TestCase(0, 2, 0, new double[] { 0.0})]
        [TestCase(4, 2, 0, new double[] { 0.0, -0.5 })]
        [TestCase(16, 0, -1, new double[] { 0.25, -0.25 })]
        [TestCase(0, 2, 2, new double[] { -1.0 })]
        [TestCase(1, 6, -7, new double[] { 1.0, -7.0 })]
        [TestCase(2, 4, 2, new double[] { -1.0 })]

        public void TestSolveSquareEquation(double a, double b, double c, double[] expected)
        {
            double[] actual = Clauses.SolveSquareEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 0, 0)]
        [TestCase(-1, 0, -1)]
        [TestCase(1, 0, 1)]
        [TestCase(0, 0, 2)]
        [TestCase(4, 4, 4)]
        public void NegativeTestSolveSquareEquation(double a, double b, double c)
        {
            try
            {
                double[] actual = Clauses.SolveSquareEquation(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}

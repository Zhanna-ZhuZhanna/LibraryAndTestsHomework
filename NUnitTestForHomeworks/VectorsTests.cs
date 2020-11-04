using NUnit.Framework;
using HomeWorksLibrary;

namespace NUnitTestForHomeworks
{
    class VectorsTests
    {
        [TestCase(4, new int[] {2, 3,-5,4 }, -5)]
        [TestCase(3, new int[] { 2, 3, 4 }, 2)]
        [TestCase(5, new int[] { 2, 3, 5, 4, 0 }, 0)]
        public void TestGetMinElementOfArray(int n, int[] array, int expected)
        {
            int actual = Vectors.GetMinElementOfArray(n, array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(4, new int[] { 2, 3, -5, 4 }, 4)]
        [TestCase(3, new int[] { 2, 3, 4 }, 4)]
        [TestCase(5, new int[] { 2, 3, 5, 4, 0 }, 5)]
        public void TestGetMaxElementOfArray(int n, int[] array, int expected)
        {
            int actual = Vectors.GetMaxElementOfArray(n, array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(4, new int[] { 2, 3, -5, 4 }, 2)]
        [TestCase(3, new int[] { 2, 3, 4 }, 0)]
        [TestCase(5, new int[] { 2, 3, 5, 4, 0 }, 4)]
        public void TestGetIndexOfMinElementOfArray(int n, int[] array, int expected)
        {
            int actual = Vectors.GetIndexOfMinElementOfArray(n, array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(4, new int[] { 2, 3, -5, 4 }, 3)]
        [TestCase(3, new int[] { 2, 3, 4 }, 2)]
        [TestCase(5, new int[] { 2, 3, 5, 4, 0 }, 2)]
        public void TestGetIndexOfMaxElementOfArray(int n, int[] array, int expected)
        {
            int actual = Vectors.GetIndexOfMaxElementOfArray(n, array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(4, new int[] { 2, 3, -5, 4 }, 7)]
        [TestCase(3, new int[] { 2, 3, 4 }, 3)]
        [TestCase(5, new int[] { 2, 3, 5, -7, 0 }, -4)]
        public void TestGetTheSumOfElementsAtOddIndexes(int n, int[] array, int expected)
        {
            int actual = Vectors.GetTheSumOfElementsAtOddIndexes(n, array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, new int[] {1,2,3,4 }, new int[] { 4,3,2,1})]
        [TestCase(4, new int[] { -4, -3, -2, -1 }, new int[] { -1, -2, -3, -4 })]
        public void TestReverseTheArray(int n, int[] array, int[] expected)
        {
            int[] actual = Vectors.ReverseTheArray(n, array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(4, new int[] { 2, 3, -5, 4 }, 2)]
        [TestCase(3, new int[] { 2, 3, 4 }, 1)]
        [TestCase(5, new int[] { 2, 3, 5, -7, 0 }, 3)]
        [TestCase(3, new int[] { 2, 6, 4 }, 0)]
        public void TestFindAmountOfOddElemennts(int n, int[] array, int expected)
        {
            int actual = Vectors.FindAmountOfOddElemennts(n, array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(4, new int[] { 1, 2, 3, 4 }, new int[] {3, 4, 1, 2 })]
        [TestCase(5, new int[] { -4, -3, 0,-2, -1 }, new int[] { -2, -1, 0, -4, -3 })]
        public void TestGetTheReverseOfArrayFromTheCenter(int n, int[] array, int[] expected)
        {
            int[] actual = Vectors.GetTheReverseOfArrayFromTheCenter(n, array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(4, new int[] { 3, 4, 1, 2 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(5, new int[] { -4, -3, 0, -2, -1 }, new int[] { -4, -3, -2, -1, 0 })]
        public void TestSortTheArrayFromSmallestToLargestValueByBubbleSort(int n, int[] array, int[] expected)
        {
            int[] actual = Vectors.SortTheArrayFromSmallestToLargestValueByBubbleSort(n, array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(4, new int[] { 3, 4, 1, 2 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(5, new int[] { -4, -3, 0, -2, -1 }, new int[] { 0, -1, -2, -3, -4 })]
        public void TestSortTheArrayFromLargestToSmallestValueByInputSort(int n, int[] array, int[] expected)
        {
            int[] actual = Vectors.SortTheArrayFromLargestToSmallestValueByInputSort(n, array);
            Assert.AreEqual(expected, actual);
        }
    }
}

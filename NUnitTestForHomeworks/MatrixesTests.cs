using NUnit.Framework;
using HomeWorksLibrary;

namespace NUnitTestForHomeworks
{
    class MatrixesTests
    {
        [TestCase(1, 1)]
        [TestCase(2, -5)]
        [TestCase(3, -9)]
        public void TestFindTheMinElementOfMatrix(int mockValue, int expected)
        {
            int[,] a = GetMatrixMock(mockValue);
            int actual = Matrixes.FindTheMinElementOfMatrix(a.GetLength(0), a.GetLength(1), a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 9)]
        [TestCase(3, 0)]
        public void TestFindTheMaxElementOfMatrix(int mockValue, int expected)
        {
            int[,] a = GetMatrixMock(mockValue);
            int actual = Matrixes.FindTheMaxElementOfMatrix(a.GetLength(0), a.GetLength(1), a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] {2,0})]
        [TestCase(2, new int[] { 0, 1 })]
        [TestCase(3, new int[] { 2, 0 })]
        public void TestFindTheIndexesOfMaxElementOfMatrix(int mockValue, int[] expected)
        {
            int[,] a = GetMatrixMock(mockValue);
            int[] actual = Matrixes.FindTheIndexesOfMaxElementOfMatrix(a.GetLength(0), a.GetLength(1), a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 0, 2 })]
        [TestCase(2, new int[] { 1, 1 })]
        [TestCase(3, new int[] { 1, 0 })]
        public void TestFindTheIndexesOfMinElementOfMatrix(int mockValue, int[] expected)
        {
            int[,] a = GetMatrixMock(mockValue);
            int[] actual = Matrixes.FindTheIndexesOfMinElementOfMatrix(a.GetLength(0), a.GetLength(1), a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void TestTransponateTheMatrix(int mockValue)
        {
            int[,] a = GetMatrixMock(mockValue);
            int[,] expected = GetExpectedMock(mockValue);
            int[,] actual = Matrixes.TransponateTheMatrix(a.GetLength(0), a.GetLength(1), a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,1)]
        [TestCase(2,3)]
        [TestCase(3,3)]
        public void TestGetTheAmontOfNumbersThatGraterItsNeighbours(int mockValue, int expected)
        {
            int[,] a = GetMatrixMock(mockValue);
            
            int actual = Matrixes.GetTheAmontOfNumbersThatGraterItsNeighbours(a.GetLength(0), a.GetLength(1), a);
            Assert.AreEqual(expected, actual);
        }

        public int[,] GetMatrixMock(int n)
        {
            switch(n)
            {
                case 1:
                    return new int[,]
                    {
                        {3,2,1 },
                        {4,5,6 },
                        {9,8,7 }
                    };
                case 2:
                    return new int[,]
                    {
                        {1,9,0 },
                        {8,-5,9 }
                    };
                case 3:
                    return new int[,]
                   {
                        {-1,-8 },
                        {-9,-5},
                        {0,-9 }
                   };
                default:
                    throw new System.Exception("Something went wrong.... =(\n");
            }
        }
        public int[,] GetExpectedMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                        {3,4,9 },
                        {2,5,8 },
                        {1,6,7 }
                    };
                case 2:
                    return new int[,]
                    {
                        {1,8 },
                        {9,-5},
                        {0,9 }
                    };
                case 3:
                    return new int[,]
                    {
                        {-1,-9,0 },
                        {-8,-5,-9 }
                    };
                default:
                    throw new System.Exception("Something went wrong.... =(\n");
            }
        }

    }
}

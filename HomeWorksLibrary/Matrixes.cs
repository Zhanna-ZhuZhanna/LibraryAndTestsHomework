using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorksLibrary
{
    public static class Matrixes
    {
        public static int[,] CreateTheMatrix()
        {
            int n = 0;
             int m=0;
           
       
            Console.WriteLine("Введите количество строк матрицы: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0) throw new Exception("The number of rows has to be grater than zero!");
            Console.WriteLine("Введите количество столбцов матрицы: ");
            m = Convert.ToInt32(Console.ReadLine());
            if (m <= 0) throw new Exception("The number of columns has to be grater than zero!");
            int[,] matrix = new int[n, m];
            return matrix;
        }
        public static int[,] GenerateMatrixValues(int n, int m, int a, int b)
        {
            Random r = new Random();
            if (n <= 0) throw new Exception("The amount of rows have to be grater than zero!");
            if (m <= 0) throw new Exception("The amount of columns have to be grater than zero!");
            int[,] array = new int[n, m];
            if (a == 0 && b != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = r.Next(b);
                    }
                }
            }
            else if (b == 0 && a != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = r.Next(a);
                    }
                }
            }
            else if (a == b && a != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = r.Next(b);
                    }
                }
            }
            else if (a < b)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = r.Next(a, b);
                    }
                }
            }
            else if (a == b && a == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = r.Next();
                    }

                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = r.Next(b, a);
                    }
                }
            }
            return array;
        }
        public static void PrintTheMatrix(int n, int m, int[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
        public static int FindTheMinElementOfMatrix(int n, int m, int[,] matrix)
        {
            int min = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            return min;
        }
        public static int FindTheMaxElementOfMatrix(int n, int m, int[,] matrix)
        {
            int max = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }
        public static int[] FindTheIndexesOfMaxElementOfMatrix(int n, int m, int[,] matrix)
        {
            int max = matrix[0, 0];
            int[] idx = new int[] { 0, 0 };

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        idx[0] = i;
                        idx[1] = j;
                    }
                }
            }
            return idx;
        }
        public static int[] FindTheIndexesOfMinElementOfMatrix(int n, int m, int[,] matrix)
        {
            int min = matrix[0, 0];
            int[] idx = new int[] { 0, 0 };

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        idx[0] = i;
                        idx[1] = j;
                    }
                }
            }
            return idx;
        }
        public static int[,] TransponateTheMatrix(int n, int m, int[,] matrix)
        {
            int[,] matrix2 = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                        matrix2[i, j] = matrix[j, i];
                }
            }
            return matrix2;
        }
        public static int GetTheAmontOfNumbersThatGraterItsNeighbours(int n, int m, int[,] matrix)
        {
            int[,] res = new int[n + 2, m + 2];
            for (int i = 0; i < n + 2; i++)
            {
                for (int j = 0; j < m + 2; j++)
                {
                    if (i == 0 || j == 0 || i == n + 1 || j == m + 1) res[i, j] = -2147483648;
                    else
                    {
                        res[i, j] = matrix[i-1, j-1];
                    }
                }
            }
            int amount = 0;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < m + 1; j++)
                {
                    if (res[i, j] > res[i - 1, j] && res[i, j] > res[i, j + 1] && res[i, j] > res[i + 1, j] && res[i, j] > res[i, j - 1])
                    {
                        amount++;
                    }
                }
            }
            return amount;
        }
    }
}

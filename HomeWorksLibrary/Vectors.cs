using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorksLibrary
{
   public static class Vectors
    {
        public static int[] GenerateArrayValues (int n, int a, int b)
        {
            Random r = new Random();
            if (n <= 0) throw new Exception("The Length of array have to be grater than zero!");
            int[] array = new int[n];
            if(a==0 && b!=0)
            {
                for(int i=0;i<n;i++)
                {
                    array[i] = r.Next(b);
                }
            }
            else if(b==0 && a!=0)
            {
                for (int i = 0; i < n; i++)
                {
                    array[i] = r.Next(a);
                }
            }
            else if (a==b && a!=0)
            {
                for (int i = 0; i < n; i++)
                {
                    array[i] = r.Next(b);
                }
            }
            else if (a<b)
            {
                for (int i = 0; i < n; i++)
                {
                    array[i] = r.Next(a,b);
                }
            }
            else if(a==b && a==0)
            {
                for (int i = 0; i < n; i++)
                {
                    array[i] = r.Next();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    array[i] = r.Next(b,a);
                }
            }
            return array;
        }
        public static void PrintTheArray(int n, int[] array)
        {
            for(int i=0;i<n;i++)
            {
                Console.Write(array[i] + "\t");
            }
        }
        public static int GetMinElementOfArray (int n, int[] array)
        {
            int min = array[0];
           
            for (int i = 1; i < n; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        public static int GetMaxElementOfArray(int n, int[] array)
        {
            int max = array[0];

            for (int i = 1; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public static int GetIndexOfMinElementOfArray(int n, int[] array)
        {
            int min = array[0];
            int idx = 0;

            for (int i = 1; i < n; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    idx = i;
                }
            }
            return idx;
        }
        public static int GetIndexOfMaxElementOfArray(int n, int[] array)
        {
            int max = array[0];
            int idx = 0;
            for (int i = 1; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    idx = i;
                }
            }
            return idx;
        }
        public static int GetTheSumOfElementsAtOddIndexes(int n, int[] array)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0) sum += array[i];
            }
            return sum;
        }
        public static int[] ReverseTheArray(int n, int[] array)
        {
            int[] array2 = new int[n];
            for(int i=0;i<n;i++)
            {
                array2[i] = array[n - i - 1];
            }
            return array2;
        }
        public static int FindAmountOfOddElemennts(int n, int[] array)
        {
            int amount = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 != 0) amount++;
            }
            return amount;
        }
        public static int[] GetTheReverseOfArrayFromTheCenter(int n, int[] array)
        {
            int[] array2 = new int[n];
            if (n % 2 == 0)
            {
                for (int i = n / 2; i < n; i++)
                {
                    array2[i-(n / 2)] = array[i];
                }
                for (int i = 0; i < n / 2; i++)
                {
                    array2[(n / 2) + i] = array[i];
                }

            }
            else
            {
                for (int i = (n / 2) + 1; i < n; i++)
                {
                    array2[i-(n / 2) - 1] = array[i];
                }
                array2[n / 2] = array[n / 2];
                for (int i = 0; i < n / 2; i++)
                {
                    array2[(n / 2) + 1 + i] = array[i];
                }
            }
            return array2;
        }
        public static int[] SortTheArrayFromSmallestToLargestValueByBubbleSort(int n, int[] array)
        {
            int[] array2 = new int[n];
            Array.Copy(array, array2, n);
            int start = 0;
            for (int i = 0; i < n; i++)
            {
                start = i;
                for (int j = start; j < n; j++)
                {
                    if (array2[j] < array2[i])
                    {
                        int cur = array2[i];
                        array2[i] = array2[j];
                        array2[j] = cur;

                    }
                }

            }
            return array2;
        }
        public static int[] SortTheArrayFromLargestToSmallestValueByInputSort(int n, int[] array)
        {
            int[] array2 = new int[n];
            Array.Copy(array, array2, n);
            for (int i = 1; i < n; i++)
            {
                int cur = array2[i];
                for (int j = 0; j < i; j++)
                {
                    if (cur > array2[j])
                    {
                        array2[i] = array2[j];

                        array2[j] = cur;
                        cur = array2[i];
                    }
                }
            }
            return array2;
        }
    }
}

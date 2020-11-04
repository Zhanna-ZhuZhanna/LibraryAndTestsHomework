using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorksLibrary
{
   public static class Cycles
    {
        public static int GetPow( int power, int grade)
        {
            if (grade < 0) throw new Exception("The grade value should be grater than zero!");
            else if (grade == 0) return 1;
            else
            {
                int c = power;
                for (int i=0; i<grade-1; i++)
                {
                    c *= power;
                }
                return c;
            }
        }
        public static int[] GetValuesDividingByVariable(int a)
        {
            if (a == 0) throw new Exception("The variable A can't be equal to zero!");
            int[] vars = new int[1000/a];
            for(int i=0; i<vars.Length;i++)
            {
                vars[i] = a;
                a += a;
            }
            return vars;
        }

        public static int GetMaxDivider(int a)
        {
            int k = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0) k = i;
            }
            return k;
        }

        public static int GetAmountOfSquaresLessThanVariable(int a)
        {
            if (a <= 0) throw new Exception("The variable's value should be positive!");
            int k = 0;
            for (int i = 1; i < Math.Sqrt(a); i++)
            {
                if (i * i < a) k++;
            }
            return k;
        }

        public static int GetTheSumOfValuesAliquotToSevenFromTheSection(int a, int b)
        {
            int k = 0;
            if (a<=b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0) k += i;
                }
            }
            else
            {
                for (int i = b; i < a; i++)
                {
                    if (i % 7 == 0) k += i;
                }
            }
            return k;
        }
        public static int GetTheFibonacciValueFromItsIndex(int n)
        {
            if (n <= 0) throw new Exception("The number of the value should be grater than zero!");
            int b = 1;
            int c = 1;
            int d = 0;
            if (n == 1 || n == 2) return 1;
            else
            {
                for (int i = 2; i < n; i++)
                {
                    d = b + c;
                    c = b;
                    b = d;
                }
                return d;
            }
        }
        public static int GetTheMaxDividerByEuclidAlgorithm(int a, int b)
        {
            int c;
            if (a <= 0) throw new Exception("The value of variable A should be grater than zero");
            if (b <= 0) throw new Exception("The value of variable A should be grater than zero");
            if (b == a) return b;
            else if(a>b)
            {
                while (b != 0)
                {
                    c = b;
                    b = a % b;
                    a = c;
                }
                return a;
            }
            else
            {
                while (a != 0)
                {
                    c = a;
                    a = b % a;

                    b = c;
                }
                return b;
            }
        }
        public static double GetTheCubeRootByHalfDivisionMethod( int n)
        {
            double b = n;
           
            double eps = 0.001;
            if (n < 0.0)
            {
                double a=1.0;
                double x = (a + b) / 2.0;
                while (Math.Abs((x * x * x) - n) > eps)
                {
                    if ((x * x * x) - n < 0)
                    {
                        b = x;
                        x = (a + x) / 2.0;
                    }
                    else
                    {
                        a = x;
                        x = (b + x) / 2.0;
                    }
                }
                return x;
            }
            else if (n > 0)
            {
                double a=-1.0;
                double x = (a + b) / 2.0;
                while (Math.Abs((x * x * x) - n) > eps)
                {
                    if ((x * x * x) - n > 0)
                    {
                        b = x;
                        x = (a + x) / 2.0;
                    }
                    else
                    {
                        a = x;
                        x = (b + x) / 2.0;
                    }
                }
                return x;
            }
            else return 0.0;
        }
        public static int GetTheAmountofOddDigits(int n)
        {
            int k = 0;
            while(n!=0)
            {
                if ((n % 2 == 1)|| (n%2==-1)) k++;
                n = n / 10;
            }
            return k;
        }
        public static int GetThePalindromOfTheNumber(int n)
        {
            if (n < 0) throw new Exception("The value can't be less than zero!");
            string s = "";
            while(n!=0)
            {
                s += (n % 10);
                n = n / 10;
            }
            return Convert.ToInt32(s);
        }
        public static int GetTheAmountOfNumbersWhereTheSumOfEvensGraterThanSumOfOdds(int n)
        {
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                int even = 0;
                int odd = 0;
                int j = i;
                while (j != 0)
                {
                    if ((j % 10) % 2 == 0)
                    {
                        even += j % 10;
                    }
                    else odd += j % 10;
                    j = j / 10;
                }
                if (even > odd) k++;
            }
            return k;
        }

        public static string DecideIfThereAreTheSameDigitsInTwoNumbers(int a, int b)
        {
            bool check = false;
            while (!check)
            {
                for (int i = 0; i < a.ToString().Length; i++)
                {
                    for (int j = 0; j < b.ToString().Length; j++)
                    {
                        if (a.ToString()[i] == b.ToString()[j]) check = true;
                    }
                }
                break;
            }
            if (check) return "да";
            else return "нет";
        }
    }
}

using System;

namespace HomeWorksLibrary
{
    public static class Variables
    {
        public static int GetIntVariable(string varName)
        {
            Console.WriteLine($"Введите {varName}:");
            try
            {
                int variable = Convert.ToInt32(Console.ReadLine());
                return variable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
                return 1000000000;
            }
        }
        public static double SolveExpressionOfFirstExcersize(double a, double b)
        {
                if (b == a) throw new Exception("Variables A and B can't be equal");
                return (5.0 * a + b * b) / (b - a);
        }

        public static int GetModulo(int divident, int divider)
        {
                if (divider == 0) throw new Exception("The divider can't be equal to zero");
                return divident % divider;
        }

        public static int GetTheWholePartOfDivision(int divident, int divider)
        {
            if (divider == 0) throw new Exception("The divider can't be equal to zero");
            return divident / divider;
        }
        public static double SolveTheLinearEquation(double a, double b, double c)
        {
                if (a == 0.0) throw new Exception("A can't be equal to zero");
                return (c - b) / a;
        }
        public static double[] GetCoefficientsOfLinearEquationFromPoints(double x1, double y1, double x2, double y2)
        {
           
                if (x1 == x2) throw new Exception("The X-coordinates can't be the same!");
                double[] arr = new double[2];
                arr[0] = (y2 - y1) / (x2 - x1);
                arr[1] = y1 - x1 * (y2 - y1) / (x2 - x1);
                return arr;
        }
        public static void SwapVariables(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}

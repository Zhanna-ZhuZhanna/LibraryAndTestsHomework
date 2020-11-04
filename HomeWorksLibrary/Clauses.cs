using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorksLibrary
{
   public static class Clauses
    {
        public static int CompareVariablesAndDecideWhatToDo(int a, int b)
        {
            if (a > b) return a + b;
            else if (a < b)
            {
                return a - b;
            }
            else return a * b;
        }
        public static string FindTheQuarter(double x, double y)
        {
            if (y > 0.0 && x > 0.0) return ("Первая четверть");
            else if (y > 0.0 && x < 0.0) return ("Вторая четверть");
            else if (y < 0.0 && x < 0.0) return ("Третья четверть");
            else if (y < 0.0 && x > 0.0) return ("Четвертая четверть");
            else if (x == 0.0 && y != 0.0) return ("Х находится в нуле");
            else if (y == 0.0 && x != 0.0) return ("Y находится в нуле");
            else return ("Начало координат");
        }

        public static int[] SortThreeVariablesInIncreaseOrder(int a, int b, int c)
        {
            int[] vars = new int[3];
            if (a <= b && a <= c)
            {
                if (b <= c)
                {
                    vars[0] = a;
                    vars[1] = b;
                    vars[2] = c;
                }
                else
                {
                    vars[0] = a;
                    vars[1] = c;
                    vars[2] = b;
                }
            }
            else if (b < a && b <= c)
            {
                if (a <= c)
                {
                    vars[0] = b;
                    vars[1] = a;
                    vars[2] = c;
                }
                else
                {
                    vars[0] = b;
                    vars[1] = c;
                    vars[2] = a;
                }
            }
            else if (a <= b)
            {
                vars[0] = c;
                vars[1] = a;
                vars[2] = b;
            }
            else
            {
                vars[0] = c;
                vars[1] = b;
                vars[2] = a;
            }
            return vars;
        }
        public static double[] SolveSquareEquation(double a, double b, double c)
        {
            double[] solution = new double[0];
           
                double d = b * b - 4.0 * a * c;
                if (c == 0)
                {
                    if (a == 0.0 && b != 0.0)
                    {
                        solution = new double[1];
                        solution[0] = 0.0;
                    }
                    else if (a != 0.0 && b == 0.0)
                    {
                        solution = new double[2];
                        solution[0] = 0.0;
                        solution[1] = 0.0;
                    }
                    else if (a == 0.0 && b == 0.0)
                    {
                        throw new Exception("The equation has endless amount of solutions!");
                    }
                    else
                    {
                        solution = new double[2];
                        solution[0] = 0.0;
                        solution[1] = (0.0 - b) / a;
                    }
                }
                else
                {
                    if (a == 0.0 && b != 0.0)
                    {
                        solution = new double[1];
                        solution[0] = (0.0 - c) / b;
                    }
                    else if (a != 0.0 && b == 0.0)
                    {
                        if (((0.0 - c) / a) < 0.0) throw new Exception("The expression (-C)/A should be positive!");
                        else
                        {
                            solution = new double[2];
                            solution[0] = Math.Sqrt((0.0 - c) / a);
                            solution[1] = 0.0 - Math.Sqrt((0.0 - c) / a);
                        }
                       
                    }
                    else if (a == 0.0 && b == 0.0)
                    {
                        throw new Exception("The equation has no solutions!");
                    }
                    else
                    {
                        if (d>0.0)
                        {
                           
                            solution = new double[2];
                            solution[0] = (0.0 - b + Math.Sqrt(d)) / (2.0 * a);
                            solution[1] = (0.0 - b - Math.Sqrt(d)) / (2.0 * a);
                        }
                        else if (d==0.0)
                        {
                            solution = new double[1];
                            solution[0] = (0.0 - b )/ (2.0 * a);
                        }
                        else throw new Exception("The equation has no real solutions!");

                    }
                }

                return solution;
        }

        public static string GetTheNameForUsersValue (int a)
        {
            string varName=" ";
            if (a < 10 || a > 99) throw new Exception("The variable's value have to be grater than 9 and smaller than 100!");
            else
            {
                switch (a / 10)
                {
                    case 1:
                        switch (a % 10)
                        {
                            case 0:
                                varName = "десять";
                                break;
                            case 1:
                                varName = "одиннадцать";
                                break;
                            case 2:
                                varName = "двенадцать";
                                break;
                            case 3:
                                varName = "тринадцать";
                                break;
                            case 4:
                                varName = "четырнадцать";
                                break;
                            case 5:
                                varName = "пятнадцать";
                                break;
                            case 6:
                                varName = "шестнадцать";
                                break;
                            case 7:
                                varName = "семнадцать";
                                break;
                            case 8:
                                varName = "восемнадцать";
                                break;
                            case 9:
                                varName = "девятнадцать";
                                break;
                        }
                        break;
                    case 2:
                        varName = "двадцать";
                        break;
                    case 3:
                        varName = "тридцать";
                        break;
                    case 4:
                        varName = "сорок";
                        break;
                    case 5:
                        varName = "пятьдесят";
                        break;
                    case 6:
                        varName = "шестьдесят";
                        break;
                    case 7:
                        varName = "семьдесят";
                        break;
                    case 8:
                        varName = "восемьдесят";
                        break;
                    case 9:
                        varName = "девяносто";
                        break;

                }
                if (a / 10 != 1)
                {
                    switch (a % 10)
                    {
                        case 0:

                            break;
                        case 1:
                            varName += " один";
                            break;
                        case 2:
                            varName += " два";
                            break;
                        case 3:
                            varName += " три";
                            break;
                        case 4:
                            varName += " четыре";
                            break;
                        case 5:
                            varName += " пять";
                            break;
                        case 6:
                            varName += " шесть";
                            break;
                        case 7:
                            varName += " семь";
                            break;
                        case 8:
                            varName += " восемь";
                            break;
                        case 9:
                            varName += " девять";
                            break;
                    }
                }
                return varName;
            }
        }
    }
}

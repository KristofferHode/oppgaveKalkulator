using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.VisualBasic;

namespace oppgaveKalkulator;

class Program
{   //overloads
    //Pluss regnestykke
    static double add(double a, double b) => a + b;
    static double add(double a, double b, double c) => a + b + c;
    static double add(double a, double b, double c, double d) => a + b + c + d;

    //Minus regnestykke
    static double subtract(double a, double b) => a - b;
    static double subtract(double a, double b, double c) => a - b - c;
    static double subtract(double a, double b, double c, double d) => a - b - c - d;

    //Gangestykke
    static double multiply(double a, double b) => a * b;
    static double multiply(double a, double b, double c) => a * b * c;
    static double multiply(double a, double b, double c, double d) => a * b * c * d;

    //deleStykke
    static double divide(double a, double b, double c, double d)
    {
        if (b == 0 || c == 0 || d == 0) throw new DivideByZeroException("Cant divide by zero");
        return a / b / c / d;
    }
    static double divide(double a, double b, double c)
    {
        if (b == 0 || c == 0) throw new DivideByZeroException("Cant divide by zero");
        return a / b / c;
    }
        static double divide(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Cant divide by zero");
        return a / b;
    }


    class Kalkulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to- add: 1, subtract: 2, multiply: 3 or divide: 4");
            string? inputI = Console.ReadLine();

            Console.WriteLine("How many numbers are we Mathing today? Please choose between 2 and 4");
            int antall = int.Parse(Console.ReadLine());
            if (antall < 2 || antall > 4)
            {
                Console.WriteLine("Please choose between the numbers 4 and 2");
                return;
            }

            double[] tall = new double[antall];
            for (int i = 0; i < antall; i++)
            {
                Console.WriteLine($"input your number {i + 1};");
                while (!double.TryParse(Console.ReadLine(), out tall[i]))
                {
                    Console.WriteLine("invalid input, try again");
                }
            }
            double result = 0;
            switch (inputI)
            {
                case "1":
                    result = antall switch
                    {
                        2 => add(tall[0], tall[1]),
                        3 => add(tall[0], tall[1], tall[2]),
                        4 => add(tall[0], tall[1], tall[2], tall[3]),
                        _ => 0
                    };
                    break;
                case "2":
                    result = antall switch
                    {
                        2 => subtract(tall[0], tall[1]),
                        3 => subtract(tall[0], tall[1], tall[2]),
                        4 => subtract(tall[0], tall[1], tall[2], tall[3]),
                        _ => 0
                    };
                    break;
                case "3":
                    result = antall switch
                    {
                        2 => multiply(tall[0], tall[1]),
                        3 => multiply(tall[0], tall[1], tall[2]),
                        4 => multiply(tall[0], tall[1], tall[2], tall[3]),
                        _ => 0
                    };
                    break;
                case "4":
                    result = antall switch
                    {
                        2 => divide(tall[0], tall[1]),
                        3 => divide(tall[0], tall[1], tall[2]),
                        4 => divide(tall[0], tall[1], tall[2], tall[3]),
                        _ => 0
                    };
                    break;

                default:
                    Console.WriteLine("Illegal operation");
                    return;
            }

            Console.WriteLine($"\nYour Result: {result}");
        }
    }
}

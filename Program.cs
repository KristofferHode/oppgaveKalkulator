using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.VisualBasic;

namespace oppgaveKalkulator;

class Program
{
    static double sum(double a, double b, double c, double d)
    {
        return a + b + c + d;
    }

    static double sum(double a, double b, double c)
    {
        return a + b + c;
    }
    static double sum(double a, double b)
    {
        return a + b;
    }

    static int sum(int a, int b, int c, int d)
    {
        return a - b + c - d;
    }


    class Kalkulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your first value");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input your second value");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input your third value");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input your fourth value");
            double d = Convert.ToDouble(Console.ReadLine());

            int a_int = (int)a;

            int b_int = (int)b;

            int c_int = (int)c;

            int d_int = (int)d;

            Console.WriteLine(sum(a, b, c, d));
            Console.WriteLine(sum(a, b, c));
            Console.WriteLine(sum(a, b));
            Console.WriteLine(sum(a_int, b_int, c_int, d_int));
        }
    }
}
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.VisualBasic;

namespace oppgaveKalkulator;

class Program
{//overloads
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
            Console.WriteLine("Would you like to- add:1, subtract:2, multiply:3 or divide:4?");
            double inputI = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many numbers are we Mathing today? Two: 1, Three: 2, Four: 3");
            double inputII = Convert.ToDouble(Console.ReadLine());

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

            if (inputI == 1)
            {
                double sum = a + b;
                Console.WriteLine("Result = " + sum);
            }

            if (inputI == 2)
            {
                double sum = a - b;
                Console.WriteLine("Result = " + sum);
            }

            if (inputI == 3)
            {
                double sum = a * b;
                Console.WriteLine("result = " + sum);
            }

            if (inputI == 4)
            {
                if (b == 0)
                    Console.WriteLine("Cant divide by zero");
            }
            else
            {
                double sum = a / b;
                Console.WriteLine("Result = " + sum);
            }

            if (inputII == 1)
            {
                Console.WriteLine("You are mathing two numbers" + sum(a, b));
            }
            if (inputII == 2)
            {
                Console.WriteLine("You are mathing three numbers" + sum(a, b, c));
            }
            if (inputII == 3)
            {
                Console.WriteLine ("You are mathing four numbers" + sum(a, b, c, d));
            }

            
            //Console.WriteLine(sum(a, b, c, d));
            //Console.WriteLine(sum(a, b, c));
            //Console.WriteLine(sum(a, b));
            //Console.WriteLine(sum(a_int, b_int, c_int, d_int));
        }
    }
}
using System;

namespace Assignment8ex2
{
    // Custom delegate declaration
    public delegate void SmallerDelegate(double a, double b);

    public class MathSolutions
    {
        public double GetSum(double x, double y)
        {
            return x + y;
        }

        public double GetProduct(double a, double b)
        {
            return a * b;
        }

        // Static method to compare and print smaller number
        public static void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }

        // Func delegate for GetSum method
        public static double Add(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            // Create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);

            // Using Action delegate to call GetSmaller method
            Action<double, double> smallerAction = new Action<double, double>(GetSmaller);
            smallerAction(num1, num2);

            // Using Func delegate to call GetSum method
            Func<double, double, double> sumFunc = new Func<double, double, double>(Add);
            Console.WriteLine($" {num1} + {num2} = {sumFunc(num1, num2)}");

            // Using custom delegate to call GetProduct method
            SmallerDelegate smallerDelegate = new SmallerDelegate(GetSmaller);
            smallerDelegate(num1, num2);
        }
    }
}

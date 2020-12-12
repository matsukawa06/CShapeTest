using System;

namespace CShapeTest
{
    public class NumberTest
    {
        public NumberTest() { }

        // int型
        public void NumberInteger()
        {
            Console.WriteLine("ここからinteger型");
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

        }

        // double型
        public void NumberDouble()
        {
            Console.WriteLine("ここからdouble型");
            double a = 19;
            double b = 23;
            double c = 8;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

        // decimal型
        public void NumberDecimal()
        {
            Console.WriteLine("ここからdecimal型");
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }

        // 課題
        public void Kadai()
        {
            double hankei = 2.5;
            double anser = hankei * hankei * Math.PI;
            Console.WriteLine(anser);
        }
    }
}

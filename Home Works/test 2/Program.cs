using System;

namespace test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            a = (a * (Math.PI)) / 180;
            Console.WriteLine(Math.Cos(a));
            
        }
    }
}

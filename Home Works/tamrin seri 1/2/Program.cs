using System;

namespace _2
{
    class Program
    {
        static void setare(int number)
        {
            int i, j, fasele;
            fasele = number - 1;
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= fasele; i++)
                    Console.Write(" ");
                fasele--;
                for (i = 1; i <= j; i++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            fasele = 1;
            for (j = 1; j <= number - 1; j++)
            {
                for (i = 1; i <= fasele; i++)
                    Console.Write(" ");
                fasele++;
                for (i = 1; i <= (number - j); i++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            setare(number);
        }
    }
}

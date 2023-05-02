using System;

namespace _6
{
    class Program
    {
        static void Square(ref int[] array)
        {
            for (int i = 0; i < 10; i++)
            {
                array[i] = array[i] * array[i];
            }
        }
        static void Sum(out int number, int[] array)
        {
            number = 0;
            for (int i = 0; i < 10; i++)
            {
                number =  number + array[i];
            }
            Console.WriteLine(number);
        }
        static void Main(string[] args)
        {
            int w = 0;
            int[] array = new int [10];
            Random generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = generator.Next();
            }
            Square(ref array);
            Sum(out w , array);
        }
    }
}

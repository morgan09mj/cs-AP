using System;

namespace _7
{
    class Program
    {
        static double miyangin(double [] ary , double n , ref double w , int i)
        {
            if(i < n)
            {
                w = w + (ary[i] / n);
                i++;
                return miyangin( ary ,  n , ref  w ,  i);
            }
            else
                return 0;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] ins = input.Split(' ');
            double [] array = new double[n];
            for(int i1 = 0 ; i1 < n ; i1++)
            {
                array[i1] = int.Parse(ins[i1]);
            }
            int i = 0;
            double w = 0;
            miyangin(array , n, ref w , i);
            Console.WriteLine(Math.Round(w , 2));
        }
    }
}

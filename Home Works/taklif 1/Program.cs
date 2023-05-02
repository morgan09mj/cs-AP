using System;

namespace _1
{
    class Program
    {
        static void MaxNum(int n1 , int [] array1)
        {
            int h ;
            h = -23234;
            for(int i = 0 ; i < n1 ; i++)
            {
                for(int j = 0 ; j < n1 ; j++)
                {
                    if(array1 [i] >= array1 [j])
                    {
                    h = 1;        
                    }
                    else
                    {
                        j = n1;
                        h = -1;
                    }
                }
                if(h == 1)
                {
                Console.WriteLine(array1 [i]); 
                }
            }
        }
        static void Main(string[] args)
        {
            int t;
            int [] array = new int [1000000];
            int n = int.Parse(Console.ReadLine());
            for (int i = 0 ; i < n ; i++)
            {
                t = int.Parse(Console.ReadLine());
                array[i] = t;
            }
            MaxNum(n , array);
        }
    }
}

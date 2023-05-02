using System;

namespace emtehan_1
{
    class Program
    {
        static void ary(int[] aryy)
        {
            int[] mesal = new int[100];
            int w = 0;
            for(int j = 0 ; j < 100 ; j++)
            {
                for(int i = 0 ; i < 100 ; i++)
                {
                    if(string .CompareOrdinal(aryy[w], aryy[i+1]))
                        mesal[j] = aryy[w];

                    else
                    {
                        mesal[j] = aryy[i+1];
                        w++;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n = 100;
            char m;
            int[] array = new int[n];
            for(int i = 0 ; i < n ; i++)
            {
                m = char.Parse(Console.ReadLine());
                array[i] = m;
            }
            ary(array);
        }
    }
}

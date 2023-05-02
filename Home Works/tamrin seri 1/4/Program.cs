using System;

namespace _4
{
    class Program
    {
        static void me(char [] array , int n , ref double mohem , int m , double p_mored_nazar)
        {
            if(m < n)
            {
                int rg = 0;
                for(; m < n && rg != 1; m++)
                {
                    if(array[m] == 'P')
                    {
                        rg = 1;
                    }
                    if(array[m] == 'H')
                    {
                        p_mored_nazar = p_mored_nazar + 1;
                    }
                }
                int rt;
                rt = 0;
                if(p_mored_nazar % 2 == 0)
                {
                    mohem = mohem + 1;
                    rt = 1;
                }
                double p_mored_nazar1 = p_mored_nazar;
                double er;
                double qw = 0;
                for(int i = 2 ; i < p_mored_nazar + 2 ; p_mored_nazar = p_mored_nazar1)
                {
                    p_mored_nazar = p_mored_nazar - i;
                    if(p_mored_nazar <= 1)
                    {
                        i = 10000000;
                    }
                    i = i * 2;
                    er = p_mored_nazar;
                }
                for(int j = 0 ; j < p_mored_nazar ; j = j+2)
                {
                    qw = qw + 1;
                }
                if(rt == 0)
                {
                    mohem = mohem + 1;
                }
                m++;
                me(array , n , ref  mohem ,  m ,  p_mored_nazar);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string ph = Console.ReadLine();
            char[] php = new char [ph.Length];
           for(int i = 0 ; i < n ; i++)
            {
                php[i] = ph[i];
            }
            string t = Console.ReadLine();
            string[] ins = t.Split(' ');
            int[] ts = new int [2];
            ts[0] = int.Parse(ins[0]);
            ts[1] = int.Parse(ins[1]);
            int w1 = ts[0];
            int w2 = ts[1];
            int w3 = 0;
            if(w1 > w2)
            {
                w3 = w1;
                w1 = w2;
                w2 = w3;
            }
            for(int j = 0 ; j < w1 ; j++)
            {
                php[j] = 'a';
            }
            for(int k = n-1 ; k >= w2 ; k--)
            {
                php[k] = 'a';
            }
            double p_mored_nazar = 0;
            double mohem = 0;
            int m = 0;
            me(php , n , ref mohem , m , p_mored_nazar);
            Console.WriteLine(mohem);
        }
    }
}

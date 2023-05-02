using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] ins = input.Split(' ');
            int[] abk = new int[3];
            abk[0] = int.Parse(ins[0]);
            abk[1] = int.Parse(ins[1]);
            abk[2] = int.Parse(ins[2]);
            double marahel = 0;
            double k = abk[0];
            double a = abk[1];
            double b = abk [2];

            if(a > b)
            {
                double e = a;
                a = b;
                b = e;
            }

            double marahel2 = b - a;

            for(int w = 1 ; a % k != 0; w++)
            {
                if((a-w) % k == 0)
                {
                    a = a - w;
                }
                if((a+w) % k == 0)
                {
                    a = a + w;
                }
                marahel = marahel + 1;
            }
            
            for(int w = 1 ; b % k != 0; w++)
            {
                if((b-w) % k == 0)
                {
                    b = b - w;
                }
                if((b+w) % k == 0)
                {
                    b = b + w;
                }
                marahel = marahel + 1;
            }

            if(b < 0)
            {
                b = -b;
            }

            for( ; b - k >= a ; b = b - k)
            {
                marahel = marahel + 1;
            }

            if(abk[1] == abk[2])
            {
                marahel = 0;
            }

            if(abk[1] % k == 0 && abk[2] % k == 0)
            {
                marahel = abk[2] - abk[1];
            }

            if(marahel2 < marahel)
            {
                marahel = marahel2;
            }

            Console.WriteLine(marahel);
        }
    }
}

using System;

namespace _1
{
    class Program
    {
        static void AvamelAval(int n)
        {
            int w1 = 0 , w2 = 0;
            while (n % 2 == 0) 
            {
                if(w1 == 0)
                {
                    Console.Write(2 + " ");  
                }
                n = n / 2;
                w1 = 1; 
            } 
            for(int i = 3 ; i <= Math.Sqrt(n) ; i = i + 2)
            {
                while (n % i == 0) 
                {
                    if(w2 == 0)
                    {
                        Console.Write(i + " ");
                    }  
                    n /= i;
                    w2 = 1; 
                }
                w2 = 0; 
            }
            if(n > 2)
            {
                Console.WriteLine(n);
            }
        }
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            AvamelAval(p);
        }
    }
}

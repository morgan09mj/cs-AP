using System;

namespace emtehan
{
    class Program
    {
        public string Reverse(string i)
        {
            char[] chars = i.ToCharArray();
            Array.Reverse(chars);
            return new String(chars);
        }
        static void Main(string[] args)
        {
            int s2 = 0;
            string n , s1 = "" ;      
            for( ; s2 < 500; s2++)
            {
                n = Console.ReadLine();
                s1 = s1 + n;
                s1 = s1 + " ";
            }
            Program.reverse(s1);
        }
    }
}

using System;
using System.Collections.Generic;
namespace taklif_6
{
    class LimitedCollection<T> where T : IComparable
    {
        int max;
        int min;
        public LimitedCollection(int ma , int mi)
        {
            max = ma;
            min = mi;
        }
        public void insert(int a)
        {
            if(min < a && a < max)
            {

            }
            else
            Console.WriteLine("vorudi dar mahdude nist");
        }
        public void remove()

        {

        }
        public void itemsAccepted()
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            LimitedCollection<string> c = new LimitedCollection<string>(a , b);

        }
    }
}

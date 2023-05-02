using System;

namespace soal4
{
    class circle
    {
        public double i;
        public double j;
        public double r;
        public circle (double i1 , double j1 , double r1)
        {
            i = i1;
            j = j1;
            if(r1 >= 0)
            {
                r = r1;
            }
            else
            {
                r = 0;
            }
        }
        public void print()
        {
            Console.WriteLine("i :" + i + ", j :" + j + ", shoa :" + r);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            circle c1 = new circle(0, 0, 10);
            circle c2 = new circle(5 , 3 , 6);
            circle c3 = new circle(0, 0, 0);
            c3.i = c1.i + c2.i;
            c3.j = c1.j + c2.j;
            c3.r = c1.r + c2.r;
            c3.print();

            c3.i = c1.i - c2.i;
            c3.j = c1.j - c2.j;
            if((c1.r - c2.r) >= 0)
            {
                c3.r = c1.r - c2.r;
            }
            else
            {
                c3.r = 0;
            }
            c3.print();

            c3.i = c1.i * c3.i;
            c3.j = c1.j * c3.j;
            c3.r = c1.r * c3.r;
            c3.print();
        }
    }
}

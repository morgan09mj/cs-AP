using System;

namespace soal_4
{
    class Twocomplex
    {
        int a;
        int b;
        int c;
        int d;

        public void start()
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
        }
        public void add()
        {
            int i = a + c;
            int j = b + d;
            Console.WriteLine("(" + i + "," + j + ")");
        }
        public void sub()
        {
            int i = a - c;
            int j = b - d;
            Console.WriteLine("(" + i + "," + j + ")");
        }
        public void mul()
        {
            int i1 = a * c;
            int i2 = b * d;
            int i = i1 - i2;
            int j1 = a * d;
            int j2 = b * c;
            int j = j1 + j2;
            Console.WriteLine("(" + i + "," + j + ")");
        }
        public void div()
        {
            int i1 = (a * c) + (b * d);
            int i2 = (c * c) + (d * d);
            double i = i1 / i2;
            int j1 = (b * c) - (a * d);
            double j = j1 / i2;
            Console.WriteLine("(" + i + "," + j + ")");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Twocomplex o1 = new Twocomplex();
            o1.start();
            Console.WriteLine("shomare mored nazar ra vared konid");
            Console.WriteLine("shomare 1 = Add");
            Console.WriteLine("shomare 2 = Subtract");
            Console.WriteLine("shomare 3 = Multiply");
            Console.WriteLine("shomare 4 = Division");
            Console.WriteLine("shomare 5 = changeNumbers");
            Console.WriteLine("shomare 0 = exit");
            for(int i = 0 ; i == 0 ;)
            {
                int shomare = int.Parse(Console.ReadLine());
                if(shomare == 1)
                {
                    o1.add();
                }
                if(shomare == 2)
                {
                    o1.sub();
                }
                if(shomare == 3)
                {
                    o1.mul();
                }
                if(shomare == 4)
                {
                    o1.div();
                }
                if(shomare == 5)
                {
                    o1.start();
                }
                if(shomare == 0)
                {
                    i = 1;
                }
            }
        }
    }
}

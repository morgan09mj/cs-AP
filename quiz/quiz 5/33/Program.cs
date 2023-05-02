using System;

namespace _33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
        class Circle
    {
        double tool;
        double arz;
        double r;
        public Circle(double tool,
        double arz,
        double r)
        {
            this.tool = tool;
            this.arz = arz;
            this.r = r;
        }
        public static Circle operator +(Circle c1,Circle c2)
        {
            Circle a = new Circle(c1.tool + c2.tool,c1.arz + c2.arz,c1.r + c2.r);
            return a;
        }
        public static Circle operator -(Circle c1, Circle c2)
        {
            Circle a = new Circle(c1.tool - c2.tool, c1.arz - c2.arz, c1.r - c2.r);
            return a;
        }
        public static Circle operator *(Circle c1, Circle c2)
        {
            Circle a = new Circle(c1.tool * c2.tool, c1.arz * c2.arz, c1.r * c2.r);
            return a;
        }
        public static bool operator ==(Circle c1, Circle c2)
        {
            if(c1.tool == c2.tool && c1.arz==c2.arz && c1.r == c2.r)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
        public static bool operator !=(Circle c1, Circle c2)
        {
            if (c1.tool == c2.tool && c1.arz == c2.arz && c1.r == c2.r)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Print()
        {
            Console.WriteLine("tool:" + tool + "arz:" + arz + "shoaa:" + r);
        }
    }
}

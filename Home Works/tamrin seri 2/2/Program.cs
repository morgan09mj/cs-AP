using System;
using System.IO;
using System.Text;

namespace _2
{
    class Circle
    {
        private double R;
        private double o1;
        private double o2;
        public Circle(double r , double o3 , double o4)
        {
            R = r;
            o1 = o3;
            o2 = o4;
        }
        public double P()
        {
            double p = 2 * System.Math.PI * R;
            Console.WriteLine(p);
            return p;
        }
        public double S()
        {
            double s = System.Math.PI * R * R;
            Console.WriteLine(s);
            return s;
        } 
        public double fasele_markaz_dayere_ta_mabda_mokhtasat()
        {
            double i1 = (o1) * (o1);
            double j1 = (o2) * (o2);
            double ij = i1 + j1;
            double a = System.Math.Sqrt(ij);
            return a;
        }
        public static double fasele_nogte_az_mabda_mokhtasat(double i , double j)
        {
            double i1 = (i) * (i);
            double j1 = (j) * (j);
            double ij = i1 + j1;
            double a = System.Math.Sqrt(ij);
            return a;
        }
        public void fasele_az_markaz_dayere(double i , double j)
        {
            double i1 = (o1 - i) * (o1 - i);
            double j1 = (o2 - j) * (o2 - j);
            double ij = i1 + j1;
            double a = System.Math.Sqrt(ij);
            Console.WriteLine(a);
        }
        public void kharej_dakhel_ru(double i , double j)
        {
            double i1 = (o1 - i) * (o1 - i);
            double j1 = (o2 - j) * (o2 - j);
            double ij = i1 + j1;
            double a = System.Math.Sqrt(ij);
            if(a < R)
            {
                Console.WriteLine("nogte dakhel dayere garar darad");
            }
            if(a == R)
            {
                Console.WriteLine("nogte ruye dayere garar darad");
            }
            if(a > R)
            {
                Console.WriteLine("nogte kharej dayere garar darad");
            }
        }
        public Circle copy()
        {
            return new Circle(R,o1,o2);
            // double r = (2 * R) - 3;
            // if(r == 0)
            // {
            //     r = 1;
            // }
            // if(r < 0)
            // {
            //     r = -r;
            // }
            // double j = o2 + 1;
            // double i = o1 - 2;
            // //Circle c3 = new Circle(r , i , j);
            // c2 = new Circle(r , i , j);
            // return c2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int tedad_dayereha = int.Parse(Console.ReadLine());
            double[] P = new double[tedad_dayereha * 2];
            double[] S = new double[tedad_dayereha * 2];
            double[] fasele_markaz_dayere_ta_mabda_mokhtasat = new double[tedad_dayereha * 2];
            
            for(int u = 0 ; u < tedad_dayereha ; u++)
            {
                double r = double.Parse(Console.ReadLine());
                for(; r <= 0 ; )
                {
                    r = double.Parse(Console.ReadLine());
                }
                double i = double.Parse(Console.ReadLine());
                double j = double.Parse(Console.ReadLine());
                Circle c = new Circle(r , i  ,j);
                Console.WriteLine("about c");
                c.P();
                double p1 = c.P();
                c.S();
                double s1 = c.S();
                Console.WriteLine("etelaat nogte mored nazar ra vared konid");
                double i1 = double.Parse(Console.ReadLine());
                double j1 = double.Parse(Console.ReadLine());
                c.fasele_az_markaz_dayere(i1 , j1);
                c.kharej_dakhel_ru(i1 , j1);
                Console.WriteLine("about copy c");
                Circle c1 = new Circle(r , i , j);
                c1.copy();
                c1.P();
                double p2 = c1.P();
                c1.S();
                double s2 = c1.S();
                Console.WriteLine("etelaat nogte mored nazar ra vared konid");
                double i2 = double.Parse(Console.ReadLine());
                double j2 = double.Parse(Console.ReadLine());
                c1.fasele_az_markaz_dayere(i2 , j2);
                c1.kharej_dakhel_ru(i2 , j2);
                double f1 = c.fasele_markaz_dayere_ta_mabda_mokhtasat();
                double f2 = c1.fasele_markaz_dayere_ta_mabda_mokhtasat();
                int w = 0;
                P[w] = p1;
                P[w+1] = p2;
                S[w] = s1;
                S[w+1] = s2;
                fasele_markaz_dayere_ta_mabda_mokhtasat[w] = f1;
                fasele_markaz_dayere_ta_mabda_mokhtasat[w+1] = f2;
                w = w + 2;
            }
            for(int t1 = 0 ; t1 < P.Length ; t1++)
            {
                Console.WriteLine(P[t1]);
            }
            for(int t1 = 0 ; t1 < S.Length ; t1++)
            {
                Console.WriteLine(S[t1]);
            }
            for(int t1 = 0 ; t1 < fasele_markaz_dayere_ta_mabda_mokhtasat.Length ; t1++)
            {
                Console.WriteLine(fasele_markaz_dayere_ta_mabda_mokhtasat[t1]);
                
            }
            File.CreateText(@"D:\university2\AP\c#\takalif\tamrin seri 2\2\circle.txt" );
            // File.WriteAllText(@"D:\university2\AP\c#\takalif\tamrin seri 2\2\circle.txt");
        }
    }
}
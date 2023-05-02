using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Point
    {
        public double i;
        public double j;
        public Point (double ii , double jj)
        {
            i = ii;
            j = jj;
        }
        public void print()
        {
            Console.WriteLine("i = " + i + ", j =" + j);
        }
        public double NumberShape ()
        {
            double ID;
            ID = i + j;
            return ID;
        }
        public virtual void ShowAll()
        {
            Console.WriteLine("i = " + i + ", j =" + j);
        }
    }

    class Circle : Point
    {
        public double r;
        public Circle (double rr , double ii , double jj) : base (ii , jj)
        {
            r = rr;
            //i = ii;
            //j = jj;
        }
        public void S ()
        {
            double s = r * r * System.Math.PI;
            Console.WriteLine("S = " + s);
        }
        public void P ()
        {
            double p = 2 * r * System.Math.PI;
            Console.WriteLine("P = " + p);
        }
        public void print()
        {
            Console.WriteLine("i = " + i + ", j =" + j + "R = " + r);
        }
        
        public double NumberShape ()
        {
            double ID;
            ID = i + j + r;
            return ID;
        }
        public override void ShowAll()
        {
            Console.WriteLine("i = " + i + ", j =" + j + "R = " + r);
            double s = r * r * System.Math.PI;
            double p = 2 * r * System.Math.PI;
            Console.WriteLine("S = " + s);
            Console.WriteLine("P = " + p);
        }
    }

    class Cylinder : Circle
    {
        public double h;
        public Cylinder (double hh , double rr , double ii , double jj) : base (rr , ii , jj)
        {
            h = hh;
            //r = rr;
            //i = ii;
            //j = jj;
        }
        public void SS ()
        {
            double s = r * r * System.Math.PI * h;
            Console.WriteLine("S = " + s);
        }
        public void print()
        {
            Console.WriteLine("i = " + i + ", j =" + j + "Z = " + h/2 + "R = " + r + "h = " + h);
        }

        public double NumberShape ()
        {
            double ID;
            ID = i + j + r + h;
            return ID;
        }
        public override void ShowAll()
        {
            Console.WriteLine("i = " + i + ", j =" + j + "Z = " + h/2 + "R = " + r + "h = " + h);
            double s = 2 * r * r * Math.PI + 2 * Math.PI * r * h;
            Console.WriteLine("S = " + s);
            double v = r * r * Math.PI * h;
            Console.WriteLine("V = " + v);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i == -1; i++)
            {              
                Console.WriteLine("shomare class mored nazar ra vared konid");
                Console.WriteLine("point = 1");
                Console.WriteLine("Circle = 2");
                Console.WriteLine("Cylinder = 3");
                Console.WriteLine("Show All = 4");
                Console.WriteLine("Exit = 5");
                int shomare = int.Parse(Console.ReadLine());
                Point[] mohem = new Point[10000];
                if(shomare == 1)
                {
                    Console.WriteLine("i ra vared konid");
                    double i1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("j ra vared konid");
                    double j1 = int.Parse(Console.ReadLine());
                    Point p = new Point (i1 , j1);
                    p.print();
                    p.NumberShape();
                    mohem[i] = p;
                }

                if(shomare == 2)
                {
                    Console.WriteLine("i ra vared konid");
                    double i1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("j ra vared konid");
                    double j1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("r ra vared konid");
                    double r1 = int.Parse(Console.ReadLine());
                    Circle c = new Circle (i1 , j1 , r1);
                    c.S();
                    c.P();
                    c.print();
                    c.NumberShape();
                    mohem[i] = c;
                }

                if(shomare == 3)
                {
                    Console.WriteLine("i ra vared konid");
                    double i1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("j ra vared konid");
                    double j1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("r ra vared konid");
                    double r1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("h ra vared konid");
                    double h1 = int.Parse(Console.ReadLine());
                    Cylinder cy = new Cylinder (i1 , j1 , r1 , h1);
                    cy.SS();
                    cy.print();
                    cy.NumberShape();
                    mohem[i] = cy;
                }

                
                if(shomare == 4)
                {
                    for (int x = 0; x < i; x++)
                    {
                        Console.WriteLine(mohem[x].GetType());
                        mohem[x].ShowAll();
                        Console.WriteLine();
                    }
                }

                if (shomare == 5)
                {
                    i = -1;
                }
            }
        }
    }
}

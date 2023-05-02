using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    interface Iprintable
    {
        public string print();
    }

    class mohem<T>
    {
        public static void genFun<T>(T w1) where T : Iprintable , IEnumerable
        {
            string w2 = w1.ToString();
            int tul = w2.Length;
            w1.print();
            int s1;
            Random s2 = new Random();
            s1 = s2.Next(1000, 9999);
            StreamWriter Writer = new StreamWriter(@"D:\university\AP\c#\emtehan_payan_term\3\OUTXXXX.txt");
            Writer.Write(w2);
            Writer.Write(w1);
        }
    }

    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

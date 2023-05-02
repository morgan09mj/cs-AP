using System;
using System.IO;

namespace _55
{
    class Program
    {
        static void Main(string[] args)
        {
            int stars = 0, Horuf_seddar = 0, lines = 0, numbers = 0;
            string path = "test1.txt";
            if (!File.Exists(path))
            {
                throw new Exception("There is no text file named 'test1.txt'!");
            }
            String text = File.ReadAllText(path);
            numbers = text.Split('1', '2', '3', '4', '5', '6', '7', '8', '9','0').Length-1;
            Horuf_seddar = text.Split('a','A','e','E','I','i','o','O','U','u').Length-1;
            stars = text.Split(' ').Length-1;
            lines = text.Split('\n').Length;
            StreamWriter Writer = new StreamWriter(@"D:\university\AP\c#\takalif\tamrin seri 3\4\test2.txt");
            Writer.Write(text.Replace(' ', '*'));
            Writer.Close();
            Console.WriteLine("Lines : {0}",lines);
            Console.WriteLine("Stars : {0}",stars);
            Console.WriteLine("Numbers : {0}",numbers);
            Console.WriteLine("Horuf seddar : {0}",Horuf_seddar);
        }
    }
}

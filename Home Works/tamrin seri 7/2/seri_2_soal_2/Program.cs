using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace seri_2_soal_2
{
    interface IPersonality
    {
        string Name { get; set; }
        int Point { get; set; }
        string Personality();
    }
    public class Bear : IPersonality
    {
        public string Name { get; set; }
        public int Point { get; set; }

        public Bear(string n, int p)
        {
            Name = n;
            Point = p;
        }
        public string Personality()
        {
            return "Pooh is yellow bear.\n" +
            "He loves honey.\n" +
            Name + " rate is " + Point;
        }

    }

    public class pig : IPersonality
    {
        public string Name { get; set; }
        public int Point { get; set; }

        public pig(string n, int p)
        {
            Name = n;
            Point = p;
        }

        public string Personality()
        {
            return "Pig is pink bear.\n" +
            "Funny and a little timid.\n" +
            Name + " rate is " + Point;
        }
    }

    class Tiger : IPersonality
    {
        public string Name { get; set; }
        public int Point { get; set; }

        public Tiger(string n, int p)
        {
            Name = n;
            Point = p;
        }

        public string Personality()
        {
            return "The tiger is always smiling.\n" +
            Name + " rate is " + Point;
        }
    }

    class Kangaroo : IPersonality
    {
        public string Name { get; set; }
        public int Point { get; set; }

        public Kangaroo(string n, int p)
        {
            Name = n;
            Point = p;
        }

        public string Personality()
        {
            return "Funny kangaroo kid who is friends with tiger.\n" +
            Name + " rate is " + Point;
        }
    }

    class Donkey : IPersonality
    {
        public string Name { get; set; }
        public int Point { get; set; }

        public Donkey(string n, int p)
        {
            Name = n;
            Point = p;
        }

        public string Personality()
        {
            return "A tired donkey.\n" +
            "He always growls.\n" +
            Name + " rate is " + Point;
        }
    }

    class Friend <T> where T : IPersonality
    {
        public T field1;
        //public T field2;
        public Friend(T s1)
        {
            field1 = s1;
        }

        public string per()
        {
            return field1.Personality();
        }

        public static implicit operator Friend<T>(T s1)
        {
            return new Friend<T>(s1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Friend<Bear> B = new Bear ("Pooh" , 5);
            Friend<pig> P = new pig("Piglet", 4);
            Friend<Tiger> T = new Tiger("Tigger", 3);
            Friend<Kangaroo> K = new Kangaroo("Roo", 2);
            Friend<Donkey> D = new Donkey("Eeyore", 1);
            Console.WriteLine(B.per());
            Console.WriteLine();
            Console.WriteLine(P.per());
            Console.WriteLine();
            Console.WriteLine(T.per());
            Console.WriteLine();
            Console.WriteLine(K.per());
            Console.WriteLine();
            Console.WriteLine(D.per());
            Console.WriteLine();
        }
    }
}

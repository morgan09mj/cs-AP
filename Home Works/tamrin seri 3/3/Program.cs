using System;

namespace _3
{
    class Estudiante
    {
        string first_name;
        string last_name;
        int ID;
        int clock = 6;
        tip tipo;

        public Estudiante(string fi , string la , int id , int cl , tip ti)
        {
            for (; cl > 8 ;)
            {
                cl = int.Parse(Console.ReadLine());
            }
            for (; 95000000 < id && id < 99000000 ;)
            {
                id = int.Parse(Console.ReadLine());
            }
            first_name = fi;
            last_name = la;
            ID = id;
            clock = cl;
            tipo = ti;
        }
        public void score()
        {
            int scoree;
            if(tipo == tip.Normal)
            {
                if(clock <= 3)
                {
                    scoree = 0;
                }
                if (clock >= 4 && clock <= 6)
                {
                    scoree = 6;
                }
                if (clock > 6 && clock <= 8)
                {
                    scoree = 8;
                }
            }
            if(tipo == tip.TA)
            {
                if(clock <= 3)
                {
                    scoree = 0;
                }
                if (clock >= 4 && clock <= 6)
                {
                    scoree = 9;
                }
                if (clock > 6 && clock <= 8)
                {
                    scoree = 12;
                }
            }
            if(tipo == tip.Rebel)
            {
                if(clock <= 3)
                {
                    scoree = 0;
                }
                if (clock >= 4 && clock <= 6)
                {
                    scoree = 3;
                }
                if (clock > 6 && clock <= 8)
                {
                    scoree = 4;
                }
            }
        }
    }
    enum tip
    {
        Normal,
        TA,
        Rebel
    }
    class Program
    {
        static void Main(string[] args)
        {
            int tedad = int.Parse(Console.ReadLine());
            for (int i = 1; i <= tedad; i++)
            {
                string first_name1 = Console.ReadLine();
                string last_name1 = Console.ReadLine();
                int ID1 = int.Parse(Console.ReadLine());
                int clock1 = int.Parse(Console.ReadLine());
                tip tip1 = Console.ReadLine(Enum);
            }
        }
    }
}

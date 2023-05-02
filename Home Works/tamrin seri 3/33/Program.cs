using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _33
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
                Console.WriteLine("hourse vared shode eshtebah ast , lotfan dobare hours ra vared konid");
                cl = int.Parse(Console.ReadLine());
            }
            for (; 95000000 < id && id < 99000000 ;)
            {
                Console.WriteLine("ID vared shode eshtebah ast , lotfan dobare ID ra vared konid");
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
            int scoree = 0;
            if(tipo == tip.Normal)
            {
                if(clock <= 3)
                {
                    scoree = 0;
                    Console.WriteLine(first_name + " " + last_name + " :" + scoree);
                }
                if (clock >= 4 && clock <= 6)
                {
                    scoree = 6;
                    Console.WriteLine(first_name + " " + last_name + " :" + scoree);
                }
                if (clock > 6 && clock <= 8)
                {
                    scoree = 8;
                    Console.WriteLine(first_name + " " + last_name + " :" + scoree);
                }
            }
            if(tipo == tip.TA)
            {
                if(clock <= 3)
                {
                    scoree = 0;
                    Console.WriteLine(first_name + " " + last_name + " :" + scoree);
                }
                if (clock >= 4 && clock <= 6)
                {
                    scoree = 9;
                    Console.WriteLine(first_name + " " + last_name + " :" + scoree);
                }
                if (clock > 6 && clock <= 8)
                {
                    scoree = 12;
                    Console.WriteLine(first_name + " " + last_name + " :" + scoree);
                }
            }
            if(tipo == tip.Rebel)
            {
                if(clock <= 3)
                {
                    scoree = 0;
                    Console.WriteLine(first_name + " " + last_name + " :" + scoree);
                }
                if (clock >= 4 && clock <= 6)
                {
                    scoree = 3;
                    Console.WriteLine(first_name + " " + last_name + " :" + scoree);
                }
                if (clock > 6 && clock <= 8)
                {
                    scoree = 4;
                    Console.WriteLine(first_name + " " + last_name + " :" + scoree);
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
            Console.WriteLine("Enter number of people:");
            int tedad = int.Parse(Console.ReadLine());
            for (int i = 1; i <= tedad; i++)
            {
                Console.WriteLine("Enter first name");
                string first_name1 = Console.ReadLine();
                Console.WriteLine("Enter last name");
                string last_name1 = Console.ReadLine();
                Console.WriteLine("Enter ID");
                int ID1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter hours");
                int hours1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter group of person");
                Console.WriteLine("Normal or TA or Rebel");
                tip personn = (tip)Enum.Parse(typeof(tip) , Console.ReadLine());
                Estudiante c = new Estudiante(first_name1 , last_name1 , ID1 , hours1 , personn);
                c.score();
            }
        }
    }
}
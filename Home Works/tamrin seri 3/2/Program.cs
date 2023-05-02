using System;
using System.IO;

namespace _2
{
    class Care
    {
        int ID;
        name name;
        public string location;
        public string food;
        public int number;
        public double[] schedule = new double[3];

        public Care(int i , name na , string lo , string fo , int nu , double[] sch)
        {
            ID = i;
            name = na;
            location = lo;
            food = fo;
            number = nu;
            for (int i1 = 0; i1 < 3; i1++)
            {
                schedule[i1] = sch[i1];
            }
        }
        public void SetSchedule(int id)
        {
            if(id == 9633 || id == 9644 || id == 9655 || id == 9666)
            {
                Random generator = new Random();
                schedule[0] = generator.Next(6 , 23);
                schedule[1] = generator.Next(2 , 5);
                schedule[2] = generator.Next(2 , 5);
            }
            if(id == 9600 || id == 9611 || id == 9622)
            {

            }
        }

        public void SaveToFile()
        {
            File.CreateText("D:\\university\\AP\\c#\\takalif\\9600.Txt");
            File.CreateText("D:\\university\\AP\\c#\\takalif\\9611.Txt");
            File.CreateText("D:\\university\\AP\\c#\\takalif\\9622.Txt");
            File.CreateText("D:\\university\\AP\\c#\\takalif\\9633.Txt");
            File.CreateText("D:\\university\\AP\\c#\\takalif\\9644.Txt");
            File.CreateText("D:\\university\\AP\\c#\\takalif\\9655.Txt");
            File.CreateText("D:\\university\\AP\\c#\\takalif\\9666.Txt");
            TextWriter t0 = new StreamWriter("D:\\university\\AP\\c#\\takalif\\9600.Txt");
            t0.WriteLine("ID : " + ID);
            t0.WriteLine("location : " + location);
            t0.WriteLine("food : " + food);
            t0.WriteLine("schedule : " + schedule[0] + "_" + schedule[1] + "_" + schedule[2]);
            t0.WriteLine("number = " + number);
            TextWriter t1 = new StreamWriter("D:\\university\\AP\\c#\\takalif\\9611.Txt");
            t1.WriteLine("ID : " + ID);
            t1.WriteLine("location : " + location);
            t1.WriteLine("food : " + food);
            t1.WriteLine("schedule : " + schedule[0] + "_" + schedule[1] + "_" + schedule[2]);
            t1.WriteLine("number = " + number);
            TextWriter t2 = new StreamWriter("D:\\university\\AP\\c#\\takalif\\9622.Txt");
            t2.WriteLine("ID : " + ID);
            t2.WriteLine("location : " + location);
            t2.WriteLine("food : " + food);
            t2.WriteLine("schedule : " + schedule[0] + "_" + schedule[1] + "_" + schedule[2]);
            t2.WriteLine("number = " + number);
            TextWriter t3 = new StreamWriter("D:\\university\\AP\\c#\\takalif\\9633.Txt");
            t3.WriteLine("ID : " + ID);
            t3.WriteLine("location : " + location);
            t3.WriteLine("food : " + food);
            t3.WriteLine("schedule : " + schedule[0] + "_" + schedule[1] + "_" + schedule[2]);
            t3.WriteLine("number = " + number);
            TextWriter t4 = new StreamWriter("D:\\university\\AP\\c#\\takalif\\9644.Txt");
            t4.WriteLine("ID : " + ID);
            t4.WriteLine("location : " + location);
            t4.WriteLine("food : " + food);
            t4.WriteLine("schedule : " + schedule[0] + "_" + schedule[1] + "_" + schedule[2]);
            t4.WriteLine("number = " + number);
            TextWriter t5 = new StreamWriter("D:\\university\\AP\\c#\\takalif\\9655.Txt");
            t5.WriteLine("ID : " + ID);
            t5.WriteLine("location : " + location);
            t5.WriteLine("food : " + food);
            t5.WriteLine("schedule : " + schedule[0] + "_" + schedule[1] + "_" + schedule[2]);
            t5.WriteLine("number = " + number);
            TextWriter t6 = new StreamWriter("D:\\university\\AP\\c#\\takalif\\9666.Txt");
            t6.WriteLine("ID : " + ID);
            t6.WriteLine("location : " + location);
            t6.WriteLine("food : " + food);
            t6.WriteLine("schedule : " + schedule[0] + "_" + schedule[1] + "_" + schedule[2]);
            t6.WriteLine("number = " + number);
        }
        public void AllInfo(Care[] arry)
        {
            File.CreateText("D:\\university\\AP\\c#\\takalif\\animal.Txt");
            TextWriter t = new StreamWriter("D:\\university\\AP\\c#\\takalif\\animal.Txt");
            for (int i = 0; i < 1000; i++)
            {
                t.WriteLine(arry[i]);
            }
        }
    }

    enum name
    {
        Lion = 9600,
        Tiger = 9611,
        Bear = 9622,
        Monkey = 9633,
        Elephant = 9644,
        Giraffe = 9655,
        Owl = 9666
    }
    class Program
    {
        static void Main(string[] args)
        {
            Care[] array = new Care[]();
            Console.WriteLine("Enter number of animals to save");
            int tedad_animals = int.Parse(Console.ReadLine());
            for (int i = 0; i < tedad_animals; i++)
            {
                Console.WriteLine("Enter the code");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the location");
                string location = Console.ReadLine();
                Console.WriteLine("Enter the food");
                string food = Console.ReadLine();
                Console.WriteLine("Enter the schedule");
                double[] schedule = new double[3];
                for (int ii = 0; ii < 3; ii++)
                {
                    schedule[ii] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the number");
                int number = int.Parse(Console.ReadLine());
                Care animals = new Care (id , name , location , food , number , schedule);
                animals.SaveToFile();
                animals.SetSchedule(id);
                array[i] = animals;
                animals.AllInfo(array);
            }
        }
    }
}

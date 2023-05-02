using System;

namespace javab
{
    class Person
    {
        public string first_name;
        public string last_name;
        public int age;
        public Person(string fn , string ln , int a)
        {
            first_name = fn;
            last_name = ln;
            age = a;
        }
        public void information()
        {
            Console.WriteLine(first_name + last_name + age);
        }
    }
    class Student : Person
    {
        public string school;
        public Student(string sc ,string fn , string ln , int a) : base (fn , ln , a)
        {
            school = sc;
            first_name = fn;
            last_name = ln;
            age = a;
        }
    }
    class Teacher : Person
    {
        public string name_dars;
        public Teacher(string na ,string fn , string ln , int a) : base (fn , ln , a)
        {
            name_dars = na;
            first_name = fn;
            last_name = ln;
            age = a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string first_name1 = Console.ReadLine();
            string last_name1 = Console.ReadLine();
            int age1 =int.Parse(Console.ReadLine());
            string first_name2 = Console.ReadLine();
            string last_name2 = Console.ReadLine();
            int age2 =int.Parse(Console.ReadLine());
            string school1 = Console.ReadLine();
            string name_darse1 = Console.ReadLine();
            Student s = new Student(school1 , first_name1 , last_name1 , age1);
            Teacher t = new Teacher(name_darse1 , first_name2 , last_name2 , age2);
            s.information();
            t.information();
            static void Check(object obj)
            {
                if(obj is Student)
                {
                    Console.WriteLine("Student");
                }
                if(obj is Teacher)
                {
                    Console.WriteLine("Teacher");
                }
            }
            Check(s);
            Check(t);
        }
    }
}

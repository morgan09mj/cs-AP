using System;
using System.IO

namespace taklif_3
{
    class Student
    {
        private string[] name = new string [2];
        private int Number;
        public Student(string[] namee , int num)
        {
            name[0] = namee[0];
            name[1] = namee[1];
            Number = num;
        } 
            public Student Clone()
            {
            Student rw;
            rw = new Student(name , Number);
            return rw;
            }
            public Student badClone ()
            {
                Student rw;
            rw = new Student(name , Number);
            return this;
            }
            public Student stdInfo ()
            {
                string[] a = new string [3];
                a[0] = name[0];
                a[1] = name[1];
                a[2] = Number.ToString();
                foreach(string n in a)
                {
                    Console.WriteLine(n);
                }
                return stdInfo();
            }
            public Student changeInfo (char c , int n)
            {
                string namoo = name[0];
                namoo.Remove(0);
                namoo.PadLeft('c');
                name[0] = namoo;
                Number = Number + n;
                return changeInfo(c , Number);
        }
    }
    class Program
    {
        static void studentInfo(params Student[] abc)
        {
            foreach(Student st in abc)
            {
                st.stdInfo();
            }
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string[] name = new string [2];
            name[0] = a;
            name[1] = b;
            int n = int.Parse(Console.ReadLine());
            Student s1;
            s1 = new Student(name , n);
            Student s2;
            s2 = new Student(name , n);
            Student s3;
            s3 = new Student(name , n);
            studentInfo(s1 , s2 , s3);
            Student s4;
            s4 = new Student(name , n);
            s4.Clone();
            int r = 10;
            int y = 34;
            s1.changeInfo('c' , r);
            studentInfo(s1 , s4);
            Student s5;
            s5 = new Student(name , n);
            s5 = s2.badClone();
            s2.changeInfo('w' , y);
            studentInfo(s2 , s5);
        }
    }
}


class strimwriterg
{
    class sadegh
    {
    strimwriterg w;
    w = new strimwriterg("taklif 3.txt");
    }
}
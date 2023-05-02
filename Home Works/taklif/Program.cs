using System;
using System.IO;
using System.Collections.Generic;

namespace Exam
{
    class Person
    {
        readonly public string firstName, lastName;
        readonly public int age, payment, workHours;
        static public int count;
        static public Person[] workers;

        public Person(string firstName, string lastName, int age, int payment = 300, int workHours = 6)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.payment = payment;
            this.workHours = workHours;
        }
        public Person()
        {
            this.firstName = "Hasna";
            this.lastName = "Hasani";
            this.age = 18;
            this.payment = 300;
            this.workHours = 6;
        }

        public int PayOfYear()
        {
            return payment * workHours * 289;
        }
        public int HoursOfYear()
        {
            return workHours * 289;
        }
        static public int CountObject()
        {
            int numberOfObjects = 0;

            for (int i = 0; i < workers.Length; i++)
                if (workers[i] != null)
                    numberOfObjects++;
                else
                    break;

            return numberOfObjects;
        }
        static public List<Person> NameExist(string name)
        {
            var people = new List<Person>();
            for (int i = 0; i < CountObject(); i++)
                if (Equals(workers[i].firstName, name))
                    people.Add(workers[i]);

            return people;
        }
        static public void PrintInfo()
        {
            StreamWriter Writer = new StreamWriter("text.txt", true);

            for (int i = 0; i < CountObject(); i++)
            {
                Console.WriteLine($"first name: {workers[i].firstName}, last name: {workers[i].lastName}" +
                      $", age: {workers[i].age}, payment: {workers[i].payment}, daily workhours: {workers[i].workHours}" +
                      $", annually work hours: {workers[i].HoursOfYear()}, annually salary: {workers[i].PayOfYear()}");

                Writer.WriteLine($"first name: {workers[i].firstName}, last name: {workers[i].lastName}" +
                      $", age: {workers[i].age}, payment: {workers[i].payment}, daily workhours: {workers[i].workHours}" +
                      $", annually work hours: {workers[i].HoursOfYear()}, annually salary: {workers[i].PayOfYear()}");
            }
            Writer.Close();
        }
        public Person DeepCopy()
        {
            return new Person(new string(firstName), new string(lastName), age);
        }
        public Person ShallowCopy()
        {
            Console.WriteLine("Enter first name of son of worker:");
            string newFirst = Console.ReadLine();
            Console.WriteLine("Enter the age of son of worker:");
            int age = Convert.ToInt32(Console.ReadLine());
            while (age < 0)
            {
                Console.WriteLine("Enter the age of son of worker:");
                age = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the age of son of worker:");
            int payment = Convert.ToInt32(Console.ReadLine());
            while(payment < 0)
            {
                Console.WriteLine("Enter the age of son of worker:");
                age = Convert.ToInt32(Console.ReadLine());
            }
            return new Person(newFirst, lastName, age, 300, 6);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many people are you going to add?");
            Person.count = Convert.ToInt32(Console.ReadLine());
            string[] input;

            Person.workers = new Person[Person.count + 2];

            int age;
            for (int i = 0; i < Person.count; i++)
            {
                Console.WriteLine("Please enter Full name:");
                input = Console.ReadLine().Split();
                Console.WriteLine("Enter age");
                age = Convert.ToInt32(Console.ReadLine());
                while (age < 0)
                    age = Convert.ToInt32(Console.ReadLine());

                Person.workers[i] = new Person(input[0], input[1], age);
            }

            Person.PrintInfo();

            Person.workers[Person.count] = Person.workers[0].DeepCopy();
            Person.workers[Person.count + 1] = Person.workers[0].ShallowCopy();

            Console.WriteLine("After adding copies:");
            Person.PrintInfo();
        }
    }
}
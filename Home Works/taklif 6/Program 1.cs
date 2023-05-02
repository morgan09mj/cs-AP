using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faaliat_kelasi_2
{
    class LimitedCollection<T> where T : IComparable<T>
    {
        T lowerBound, upperBound;
        public List<T> genericList = new List<T>();

        public int AcceptedNumber
        {
            get { return genericList.Count(); }
        }
        public LimitedCollection(T lowerBound, T upperBound)
        {
            this.lowerBound = lowerBound;
            this.upperBound = upperBound;
        }
        public void Insret(T item)
        {
            if (item.CompareTo(lowerBound) >= 0 && item.CompareTo(upperBound) <= 0)
            {
                genericList.Add(item);
            }
            else
                Console.WriteLine($"item {item} is out of range");
        }
        public T Remove()
        {
            T MyItem;
            if (genericList.Count == 0)
            {
                throw new Exception("List is Empty!!");
            }
            MyItem = genericList.Min();
            genericList.Remove(MyItem);
            return MyItem;
        }
        public void itemsAccepted()
        {
            Console.Write($"{genericList.Count()} ietm(s) accepted: ");
            foreach (var item in genericList)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lower bound and upper bound with space:");
            string[] bounds = Console.ReadLine().Split();
            LimitedCollection<string> strObj = new LimitedCollection<string>(bounds[0], bounds[1]);
            Console.WriteLine("................");



            Console.WriteLine("Enter inputs with space:");
            string[] input = Console.ReadLine().Split();
            foreach (var item in input)
            {
                strObj.Insret(item);
            }
            Console.WriteLine("................");



            Console.WriteLine($"number of accepted : {strObj.AcceptedNumber}");
            Console.WriteLine("................");



            strObj.itemsAccepted();
            Console.WriteLine("................");


            try
            {
                Console.WriteLine(strObj.Remove());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("................");


            //   <<<<<<int>>>>>
            string[] boundsInt;
            int min, max;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter lower bound and upper bound with space:");
                    boundsInt = Console.ReadLine().Split();
                    min = int.Parse(boundsInt[0]);
                    max = int.Parse(boundsInt[1]);
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid input type!");
                }
            }
            LimitedCollection<int> intObj = new LimitedCollection<int>(min, max);
            Console.WriteLine("................");



            int[] numbers;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter inputs with space:");
                    input = Console.ReadLine().Split();
                    numbers = Array.ConvertAll(input, item => int.Parse(item));
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid input type!");
                }
            }
            foreach (var item in numbers)
            {
                intObj.Insret(item);
            }
            Console.WriteLine("................");



            Console.WriteLine($"number of accepted : {intObj.AcceptedNumber}");
            Console.WriteLine("................");

            intObj.itemsAccepted();
            Console.WriteLine("................");

            try
            {
                Console.WriteLine(intObj.Remove());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("................");

        }
    }
}


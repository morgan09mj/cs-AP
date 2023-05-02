using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faaliat_kelasi_2
{
    class LimitedCollection<T> : IEnumerable<T>
    where T : IComparable<T>
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
        public IEnumerable<T> Reverse
        {
            get
            {
                for (int i = genericList.Count - 1; i >= 0; i--)
                {
                    yield return genericList[i];
                }
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var a in genericList)
            {
                yield return a;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
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

            foreach (var w in strObj.genericList)
            {
                Console.WriteLine(w + " "); 
            }

            foreach (var q in strObj.Reverse)
            {
                Console.WriteLine(q + " ");
            }

            try
            {
                Console.WriteLine(strObj.Remove());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("................");


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

            foreach (var w in strObj.genericList)
            {
                Console.WriteLine(w + " "); 
            }

            foreach (var q in strObj.Reverse)
            {
                Console.WriteLine(q + " ");
            }
            
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
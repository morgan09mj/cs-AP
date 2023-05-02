using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_stack
{
    class stack<T>
    {
        public List<T> c = new List<T>();
        public void push(T id)
        {
            c.Add(id);
        }
        public T pop()
        {
            T Item;
            if (c.Count == 0)
            {
                throw new Exception("List is Empty");
            }
            Item = c.Last();
            c.Remove(Item);
            return Item;
        }
        public T peek()
        {
            T Item;
            if (c.Count == 0)
            {
                throw new Exception("List is Empty");
            }
            Item = c.Last();
            return Item;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            foreach (var item in input);
            stack<int> intObj = new stack<int>();
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
                intObj.push(item);
            }
            try
            {
                Console.WriteLine(intObj.pop());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine(intObj.peek());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

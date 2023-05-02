using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class mohem<T> where T : IComparable<T>
    {
        public List<T> GenCol = new List<T>();

        public T add1(T MyItem1, T MyItem2)
        {

            if (GenCol.Count == 0)
            {
                throw new Exception("List is Empty!!");
            }
            string w1 = MyItem1.ToString();
            string w2 = MyItem2.ToString();
            int s1 = Convert.ToInt32(w1);
            int s2 = Convert.ToInt32(w2);
            if (s1 > s2)
            {
                GenCol.Add(MyItem2);
                return MyItem1;
            }
            else
            {
                GenCol.Add(MyItem1);
                return MyItem2;
            }
        }

        public IEnumerable<T> tartib
        {
            get
            {
                for (int i = 0; i < GenCol.Count; i++)
                    for(int j = 0; j < GenCol.Count; j++)
                    {
                        yield return GenCol[i];
                    }
            }
        }

        public T Remove()
        {
            T MyItem;
            if (GenCol.Count == 0)
            {
                throw new Exception("List is Empty!!");
            }
            MyItem = GenCol.Max();
            GenCol.Remove(MyItem);
            return MyItem;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

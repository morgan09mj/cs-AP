using System;

namespace _1
{
    class Conference
    {
        string name_h , name_s;
        int Capacity;
        public Participant[] ary;
        public Conference(string na1 , string na2 , int n)
        {
            name_h = na1;
            name_s = na2;
            Capacity = n;
        }

        public Conference(string na1 , string na2 , int n , Participant[] array)
        {
            name_h = na1;
            name_s = na2;
            Capacity = n;
            for(int i = 0 ; i < n ; i++)
            {
                ary[i] = array[i];
            }
        }

        public void ddParticipant(int n0)
        {
            if(n0 > Capacity)
            {
                Console.WriteLine("input is not valid");
            }
            
        }
    }

    class Participant
    {
        string first_name , last_name;
        int ID;
        private static int countObject=0;
        int Price;
        public Participant(int id)
        {
            countObject++;
            ID = id;
        }

        public Participant(string a , string b , int id)
        {
            first_name = a;
            last_name = b;
            ID = id;
            countObject++;
        }
        static int CalculatePrice(ref int i)
        {

            return i + 1000;
        }
        static public int CountParticipants()
        {

            // int w = 0;
            return countObject;
            // for (int i = 0; i < arrya.Length; i++)
            // {
            //     if(arrya[i]!=null)
            //     {
            //         w++;
            //     }
            //     else
            //     {
            //         break;
            //     }
            // }
            // return l + w;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int c = int.Parse(Console.ReadLine());
        int[] array = new int [c];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        string firt = Console.ReadLine();
        string last = Console.ReadLine();
        int id = int.Parse(Console.ReadLine());
        int price = int.Parse(Console.ReadLine());
        }
    }
}

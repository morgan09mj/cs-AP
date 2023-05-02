using System;

namespace _5
{
    interface IDrive
    {
        string UseFor();
    }
    class Vehicle
    {
        public string car_name;
        public int tedad_charkh;
        public Vehicle(string name , int tedad)
        {
            car_name = name;
            tedad_charkh = tedad;
        }
    }
    class car : Vehicle , IDrive
    {
        public noe_khodro s;
        public car(noe_khodro ss , string na , int te) : base (na , te)
        {
            car_name = na;
            tedad_charkh = te;
            s = ss;
        }
        public string UseFor()
        {
            return "safar";
        }
    }
    
    enum noe_khodro
    {
        Hatchback,
        Sedan,
        SUV,
        Coupe
    }
    class Truck : Vehicle , IDrive
    {
        Boolean haveTrailer;
        public Truck(Boolean ha , string nam , int ted) : base(nam , ted)
        {
            haveTrailer = ha;
            car_name = nam;
            tedad_charkh = ted;
        }
        public string UseFor()
        {
            return "haml bar";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string car_name1 = Console.ReadLine();
            int tedad_charkh1 = int.Parse(Console.ReadLine());
            noe_khodro s1 = noe_khodro.Hatchback;
            string car_name2 = Console.ReadLine();
            int tedad_charkh2 = int.Parse(Console.ReadLine());
            Boolean haveTrailer2 = Boolean.Parse(Console.ReadLine());
            car c = new car(s1 , car_name1 , tedad_charkh1);
            Truck t = new Truck(haveTrailer2 , car_name2 , tedad_charkh2);
            IDrive []aaa = new IDrive [2];
            aaa[0] = c;
            aaa[1] = t;
            aaa[0].UseFor();
            aaa[1].UseFor();
        }
    }
}

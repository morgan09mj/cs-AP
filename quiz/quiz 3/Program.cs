using System;

namespace quiz_3
{
    class Account
    {
        private int instance = 0;
        private int ID;
        protected int shomare_hesab;
        protected string shomare_cart;
        public double mojudi;
        public Account (double moj)
        {
            for( ;moj < 0;)
            {
                instance = instance +1;
                ID = new Random().Next(0 , 1000000000);
                moj = double.Parse(Console.ReadLine());
                shomare_hesab = new Random().Next(0,100000000);
                shomare_cart = new string(new Random().Next(0,10000) + " " + new Random().Next(0,10000) + " " + new Random().Next(0,10000) + " " + new Random().Next(0,10000));
            }
            mojudi = moj;
        }
        
        
        Random generator = new Random();
        
        public void variz()
        {
            Console.WriteLine ("not implemented ");
        }
        
        public void bardasht()
        {
            Console.WriteLine ("not implemented ");
        }
        public void mohasebe_sud()
        {
            Console.WriteLine ("not implemented ");
        }
        public void log()
        {
            Console.WriteLine ("not implemented ");
        }

    }
    class juniorAcc : Account
    {
        double max = 100000;
        double min = 0;
        double sude_mahane = (7/100);
        double mahdudiat_bardasht = (5/10);
        public juniorAcc(double moj) : base (moj)
        {
            mojudi = moj;
        }
        public override void variz()
        {
            if(min > mojudi || mojudi < max)
            {
            Console.WriteLine ("not implemented ");
            }
            
        }
        public override void bardasht(double bardash)
        {
            if(min > mojudi || mojudi < max)
            {
            Console.WriteLine ("not implemented ");
            }
            if(bardash >= mahdudiat_bardasht * mojudi)
            {
            Console.WriteLine ("not implemented ");
            }
        } 
        public override void log()
        {
            string a = max.ToString();
            string b = min.ToString();
            string c = sude_mahane.ToString();
            string d = mahdudiat_bardasht.ToString();
            Console.WriteLine(a + " " + b + " " + c + " " + d);
        }
        public override void mohasebe_sud(int tedad_mah)
        {
            double a = tedad_mah * sude_mahane * mojudi;
            mojudi = mojudi + a;
            Console.WriteLine(mojudi);
        }
        public void jayeze()
        {
            int ab = new Random().Next(0 , 20);
            mojudi = ab + mojudi;
            Console.WriteLine(mojudi);
        }
    }

    class longTimeAcc : Account
    {
        double min = 0;
        double sude_mahan = (15/100);
        public longTimeAcc(double moj) : base(moj)
        {
            mojudi = moj;
        }
        public override void variz()
        {
            if(min > mojudi)
            {
            Console.WriteLine ("not implemented ");
            }
        }

        public override void log()
        {
            string b = min.ToString();
            string c = sude_mahan.ToString();

            Console.WriteLine(b + " " + c );
        }
        public override void bardasht(double bardash)
        {
            if(min > mojudi)
            {
            Console.WriteLine ("not implemented ");
            }
            mojudi = mojudi - bardash;
        } 
        public override void mohasebe_sud(int tedad_mah)
        {
            double a = tedad_mah * sude_mahan * mojudi;
            mojudi = mojudi + a;
            Console.WriteLine(mojudi);
        }
        public void block()
        {

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

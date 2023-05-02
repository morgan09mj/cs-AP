using System;

namespace quiz_3
{
    class Account
    {
        private int instance;
        private int ID;
        public int shomare_hesab;
        private int shomare_cart;
        private double mojudi;
        public Account (double moj)
        {
            for( ;moj < 0;)
            {
                moj = double.Parse(Console.ReadLine());
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
    class juniorAcc 
    {
        double max;
        double min;
        double sude_mahane;
        double mahdudiat_mardasht;

    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Account
    {
        string name;
        int ID;
        int shomare_hesab;
        double mojudi_hesab;

        public Account(string n , int id , int sho , double mo)
        {
            name = n;
            ID = id;
            int w;
            if (sho > 9999)
            {
                w = sho % 10000;
                shomare_hesab = w;
            }
            else
            {
                shomare_hesab = sho;
            }
            if (mo < 0)
            {
                throw new Exception("mojudi nemitavanad manfi bashad");
            }
            else
            {
                mojudi_hesab = mo;
            }
        }

        public Account(string n, int id)
        {
            name = n;
            ID = id;
            Random sho = new Random();
            shomare_hesab = sho.Next(1000, 9999);
            mojudi_hesab = 0;
        }
    }

     class Babyaccount : Account
    {
        double ezafe_sagf_bardasht;
        int age;
        public Babyaccount(double ez, int ag, string n, int id, double mo) : base(n, id, 1, mo)
        {
            if (ez < 0)
            {
                throw new Exception("sagf bardasht nemitavanad manfi bashad");
            }
            else
            {
                ezafe_sagf_bardasht = ez;
            }
            if(ag < 1 || ag > 18)
            {
                throw new Exception("sen galat ast");
            }
            else
            {
                age = ag;
            }            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

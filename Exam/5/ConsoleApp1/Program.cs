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
        public string name;
        public int ID;
        public int shomare_hesab;
        public double mojudi;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Account> infos = new List<Account>();
            var question1 = infos.Where(x => x.ID).ToList();
            Console.WriteLine("Question1:\n");
            foreach (var i in question1)
            {
                Console.WriteLine(i);
            }

            var question2 = infos.Where(x => x.shomare_hesab && x.shomare_hesab % 100 == 00).ToList();
            Console.WriteLine("Question1:\n");
            foreach (var i in question2)
            {
                Console.WriteLine(i);
            }

            var question3 = infos.Where(x => x => x.mojudi == infos.Max(y => y.mojudi).ToList();
            Console.WriteLine("Question1:\n");
            foreach (var i in question3)
            {
                Console.WriteLine(i);
            }

        }
    }
}

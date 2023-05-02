using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public static class extansion
    {

        public static int countZeros(this int number , int pow)
        {
            int tedad = 0;
            string w = number.ToString();
            for (int i = 1; i < w.Length; i++)
            {
                if (w[i] == 0)
                {
                    tedad = tedad + 1;
                }
            }
            if (w[0] == 0)
            {
                tedad = 0;
            }
            return tedad;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ragam mored nazar ra vared konid :");
            int ragam = int.Parse(Console.ReadLine());
            Console.WriteLine("Tedad ragam ha sefr :");
            var pow = ragam.countZeros(ragam);
            Console.WriteLine(pow);
        }


    }
}

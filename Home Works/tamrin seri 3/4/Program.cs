using System;
using System.IO;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("name file ro vared konid");
            string filee = Console.ReadLine();
            
            string content = Convert.ToBase64String(File.ReadAllBytes(filee));
            File.WriteAllBytes(filee, Convert.FromBase64String(content));
            Console.WriteLine(content.Replace(' ' , '*'));
            char s = '*';
            int count = 0;
            foreach(char item in filee)
            {
                if(item == s)
                {
                    count++;
                }
            }
            Console.WriteLine("stars :" + count);
        }
    }
}

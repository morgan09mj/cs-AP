using System;

namespace tamrin_2
{
    class book
    {
        int esm , geymat , tedad;
        public book (int esm1 , int geymat1 , int tedad1)
        {
            esm = esm1;
            geymat = geymat1;
            tedad = tedad1;
        }
        public book (int esm2 , int geymat2)
        {
            esm = esm2;
            geymat = geymat2;
            Random tedad2 = new Random();
            int num=tedad2.Next(Convert.ToInt32(), Convert.ToInt32(TextBox2.Text)); 
            tedad = num;
        }
        public void printInfo()
        {
            Console.Write("\nName = {0} and Price = {1} and Number = {2}" , esm , geymat , tedad);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int e = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            book c1;
            c1 = new book(e , g , t);
            book c2;
            c2 = new book(e , g);
            c1.printInfo();
            c2.printInfo();

        }
    }
}

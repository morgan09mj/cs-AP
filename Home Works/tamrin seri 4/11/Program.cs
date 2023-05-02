using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11
{
    class Program
    {
        static void introduction()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Please choose \n ADD for adding a book \n LIST for showing list of the books that we have in our bookstore" +
                " \n SEARCH for searching the book that you want based on the ID of the book \n" +
                "SORT for sorting list of the books \n DELETE for deleting the book from the list \n EXIT for exiting from the program");
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Bookstore z = new Bookstore("x", "z", 10000, 10, "y");
            List<Bookstore> book = new List<Bookstore>();
            string ord = "";
            do
            {
                introduction();
                try
                {
                    ord = Console.ReadLine();
                    try
                    {
                        if (ord.ToUpper() == "ADD")
                        {
                            Bookstore.Add(book, z);
                        }

                        else if (ord.ToUpper() == "LIST")
                        {
                            Bookstore.List(book);
                        }

                        else if (ord.ToUpper() == "SEARCH")
                        {
                            Console.WriteLine("please input the ID of the book you want .");
                            int x = int.Parse(Console.ReadLine());
                            Bookstore.Search(book, x);
                        }

                        else if (ord.ToUpper() == "SORT")
                        {
                            Bookstore.Sort(book);
                        }

                        else if (ord.ToUpper() == "DELETE")
                        {
                            Console.WriteLine("please input the ID of the book you want to delete .");
                            int x = int.Parse(Console.ReadLine());
                            Bookstore.Delete(book, x);
                        }

                        else if (ord.ToUpper() == "EXIT")
                        {
                            System.Environment.Exit(0);
                        }

                        else
                        {
                            throw new Exception("Not include in our list");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                    }
                }
                catch(FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }

            } while (ord.ToUpper() != "EXIT");

            Console.ReadKey();      
        }
    }
    struct Bookstore
    {
        public string name, writer, publisher;
        public int price, id;
        private char? flag;
        static public List<int> idCheck;

        public Bookstore(string name, string writer, int id, int price, string publisher)
        {
            this.name = name;
            this.writer = writer;
            this.id = id;
            this.price = price;
            this.publisher = publisher;
            flag =null;
            idCheck = new List<int>();
        }

        public void inputs()
        {
            Console.WriteLine("Please enter information of the book \n");
            Console.WriteLine("Please enter name of the book");
            name = Console.ReadLine();
            Console.WriteLine("Please enter writer of the book");
            writer = Console.ReadLine();
            ID_Price();
            Console.WriteLine("Please enter publication of the book");
            publisher = Console.ReadLine();
        }

        public void ID_Price()
        {
            bool valid = false;
            Console.WriteLine("Please enter ID of the book");

            while (!valid)
            {
                try
                {

                    id = int.Parse(Console.ReadLine());
                    if (!idCheck.Contains(id))
                    {
                        idCheck.Add(id);
                        valid = true;
                    }
                    else
                    {
                        throw new Exception("This id has been already existed");
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }
            }


            Console.WriteLine("Please enter price of the book");
            try
            {
                price = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }
    
        static public void Add(List<Bookstore> book,Bookstore x)
        {
            x.inputs();
            book.Add(x);
        }

        static public void List(List<Bookstore> book)
        {
            for (int i = 0; i < book.Count; i++)
            {
                if (book[i].flag != '*')
                {
                    Console.WriteLine($"book \n name:{book[i].name} \n writer:{book[i].writer} \n ID:{book[i].id}" +
                        $"\n price:{book[i].price} \n publication:{book[i].publisher} \n");
                }
            }
        }

        static public void Search(List<Bookstore> book,int id)
        {
            if (idCheck.Contains(id))
            {
                int i = idCheck.IndexOf(id);
                if (book[i].flag != '*')
                {
                    Console.WriteLine($"book \n name:{book[i].name} \n writer:{book[i].writer}" +
                        $"\n price:{book[i].price} \n publication:{book[i].publisher} \n");
                }
                else
                {
                    Console.WriteLine("this book has been deleted from the list");
                }

            }

            else
            {
                Console.WriteLine("this id hasn't inputted yet");
            }
        }

        static public void Sort(List<Bookstore> book)
        {
            Console.WriteLine("please select the way you want to sort the list \n 1/name 2/id \t just type name/id.");
            string sortkind = Console.ReadLine();
            if (sortkind == "name")
            {
                string[] SortName = new string[book.Count];
                for (int i = 0; i < book.Count; i++)
                {
                    if (book[i].flag != '*')
                        SortName[i] = book[i].name;
                }
                Array.Sort(SortName);
                foreach (var x in SortName)
                {
                    if (x != null)
                    {
                        Console.WriteLine(x);
                    }
                }
            }

            else if (sortkind == "id")
            {
                int[] SortID = new int[book.Count];
                for (int i = 0; i < book.Count; i++)
                {
                    if (book[i].flag != '*')
                        SortID[i] = book[i].id;
                }
                Array.Sort(SortID);
                foreach (var x in SortID)
                {
                    if (x != 0)
                    {
                        Console.WriteLine(x);
                    }
                }
            }
        }

        static public void Delete(List<Bookstore> book,int id)
        {
            if (idCheck.Contains(id))
            {
                int i = idCheck.IndexOf(id);
                Bookstore x = book[i];
                x.flag = '*';
                book[i] = x;
            }

            else
            {
                Console.WriteLine("this id hasn't inputted yet");
            }
        }
    }
}

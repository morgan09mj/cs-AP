using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1
{
    enum searchingWords 
    { 
    IT = 21, 
    IOT = 45 , 
    AI = 36 , 
    WEB = 83, 
    IMAGEPROCESSING = 27 , 
    DATABASE = 55,
    EXIT
    }
    class Search
    {
        public int IT;
        public int IOT;
        public int AI;
        public int Web;
        public int Database;
        public int ImageProcessing;
        public Search()
        {
            IT = 0;
            IOT = 0;
            AI = 0;
            Database = 0;
            Web = 0;
            ImageProcessing = 0;
        }
    }
    class Program
    {
        static public bool Pas(string pas)
        {
            string path = @"D:\university\AP\c#\takalif\tamrin seri 3\Password.txt";
            String text;
            int i = 5;
            if (!File.Exists(path))
            {
                StreamWriter Writer = new StreamWriter("Password.txt");
                Writer.Write("Hello@P");
                Writer.Close();
                text = File.ReadAllText(path);
                try
                {
                    if (pas != text)
                    {
                        throw new Exception("The password is wrong!");
                    }
                }
                catch(Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                    return false;
                }
            }
            else
            {
                text = File.ReadAllText(path);
                if (pas != text)
                {
                    try
                    {
                        if (pas != text)
                        {
                            throw new Exception("The password is wrong!");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(e.Message);
                        Console.ResetColor();
                        return false;
                    }
                }
            }
            return true;
        }
        //method baraye avaz kardan password
        static public void ChangePas(string pas)
        {
            string path = @"D:\university\AP\c#\takalif\tamrin seri 3\Password.txt";
            String text;
            text = File.ReadAllText(path);
            string newPas, newPasRep;
            int i = 5;
            try
            {
                if (Pas(pas))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("What is the new password?");
                    Console.ResetColor();
                    newPas = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Please write the new password again :");
                    Console.ResetColor();
                    newPasRep = Console.ReadLine();
                    for (i = 0; !newPas.Equals(newPasRep) && i < 3; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Your password and confirmation password do not match.");
                        Console.WriteLine("Please write the new password again :");
                        Console.ResetColor();
                        newPasRep = Console.ReadLine();
                    }
                    if (i == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new Exception("Your password and confirmation password do not match for three times.Try it later!");
                    }
                    else
                    {
                        File.WriteAllText(path, string.Empty);
                        StreamWriter writer = new StreamWriter("password.txt");
                        writer.Write(newPas);
                        writer.Close();
                    }
                }
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }

        }
        static void Main(string[] args)
        {
            Search words = new Search();
            string input;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("(If you want to exit the program enter stop)");
            Console.ResetColor();
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Admin or User?");
                Console.ResetColor();
                input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "admin":
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("What is the password?");
                            Console.ResetColor();
                            string pass = Console.ReadLine();
                            if (Pas(pass))
                            {

                                //neshan dadan list
                                do
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Count || ChangePassword || Exit");
                                    Console.WriteLine("What's the order?");
                                    Console.ResetColor();
                                    input = Console.ReadLine();
                                    switch (input.ToLower())
                                    {
                                        case "count":
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Code - Name - Number of search");
                                                Console.WriteLine("{0} - Web - {1}" + (int)searchingWords.WEB, words.Web);
                                                Console.WriteLine("{0} - IOT - {1}" + (int)searchingWords.IOT, words.IOT);
                                                Console.WriteLine("{0} - IT - {1}" + (int)searchingWords.IT, words.IT);
                                                Console.WriteLine("{0} - AI - {1}" + (int)searchingWords.AI, words.AI);
                                                Console.WriteLine("{0} - ImageProcessing - {1}" + (int)searchingWords.IMAGEPROCESSING, words.ImageProcessing);
                                                Console.WriteLine("{0} - Database - {1}" + (int)searchingWords.DATABASE, words.Database);
                                                Console.ResetColor();
                                                break;
                                            }
                                        case "changepassword":
                                            {
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.WriteLine("What is the password?");
                                                Console.ResetColor();
                                                input = Console.ReadLine();
                                                ChangePas(input);
                                                break;
                                            }
                                        case "exit":
                                            {
                                                break;
                                            }
                                        default:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("The input is incorrect!");
                                                Console.ResetColor();
                                                break;
                                            }
                                    }
                                }
                                while (input.ToLower() != "exit");
                            }
                            break;
                        }
                    case "user":
                        {
                            int i = 0;
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("If you want to exit the program write exit!");
                                Console.Write("search : ");
                                Console.ResetColor();
                                try
                                {
                                    var searchWord = (searchingWords)Enum.Parse(typeof(searchingWords), Console.ReadLine().ToUpper());
                                    switch (searchWord)
                                    {
                                        case searchingWords.WEB:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                words.Web++;
                                                Console.WriteLine("A website (also written as web site) is a collection of web pages and related content that is identified by a common domain name and published on at least one web server. Notable examples are wikipedia.org, google.com, and amazon.com.");
                                                Console.ResetColor();
                                                break;
                                            }
                                        case searchingWords.IOT:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                words.IOT++;
                                                Console.WriteLine("The Internet of things (IoT) describes the network of physical objects—a.k.a. things—that are embedded with sensors, software, and other technologies for the purpose of connecting and exchanging data with other devices and systems over the Internet.");
                                                Console.ResetColor();
                                                break;
                                            }
                                        case searchingWords.AI:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                words.AI++;
                                                Console.WriteLine("Artificial intelligence (AI) is a wide-ranging branch of computer science concerned with building smart machines capable of performing tasks that typically require human intelligence. AI is an interdisciplinary science with multiple approaches, but advancements in machine learning and deep learning are creating a paradigm shift in virtually every sector of the tech industry.");
                                                Console.ResetColor();
                                                break;
                                            }
                                        case searchingWords.IT:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Information technology is the study, design, development, implementation, " +
                                                    " support or management of computer-based information systems—particularly software applications and computer hardware.");
                                                words.IT++;
                                                Console.ResetColor();
                                                break;
                                            }
                                        case searchingWords.DATABASE:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                words.Database++;
                                                Console.WriteLine("A database is an organized collection of data, generally stored and accessed electronically from a computer system.");
                                                Console.ResetColor();
                                                break;
                                            }
                                        case searchingWords.IMAGEPROCESSING:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                words.ImageProcessing++;
                                                Console.WriteLine("In image processing, the input is a low-quality image, and the output is an image with improved quality.");
                                                Console.ResetColor();
                                                break;
                                            }
                                        case searchingWords.EXIT:
                                            {
                                                i = 1;
                                                break;
                                            }
                                    }
                                }
                                catch
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("It will added soon!");
                                    Console.ResetColor();
                                }
                            }
                            while (i==0);
                            break;
                        }
                    case "stop":
                        {
                            break;
                        }
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("The input is incorrect!");
                            Console.ResetColor();
                            break;
                        }
                }
            } while (input.ToLower() != "stop");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _1
{
    enum InputKind { admin, user }
    enum UserKind { student, teacher, customer }
    enum MediaKinds { book, video, magazine}
    enum LibraryKinds { add,del,search,show,change,exit}
    enum UserOpsKinds { select, edit, buy, chance , exit}
    class User
    {
        public FileInfo UserFile = new FileInfo(@"D:\university\AP\c#\takalif\tamrin seri 6\user.txt");
        public int BuysNumber=0;
    }
    class Seller
    {
    
        string Emaill;
        string PassWord;
        public Seller(string em , string pas)
        {
            Emaill = em;
            PassWord = pas;
        }
        public void email_chek()
        {
                for (int i = 0; i == 0; )
                {
                    Regex reg = new Regex(@"^[a-zA-Z].*@[a-zA-Z]+\.com$");
                    if(reg.IsMatch(Emaill))
                    {
                        i = 1;
                    }
                    else
                    {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The email is wrong!");
                    Console.WriteLine("what's your email?");
                    Console.ResetColor();
                    Emaill = Console.ReadLine();
                    }
                }
        }

        static public bool Pas(string pas)
        {
            string path = @"D:\university\AP\c#\takalif\tamrin seri 6\Password.txt";
            String text;
            if (!File.Exists(path))
            {
                StreamWriter Writer = new StreamWriter("Password.txt");
                Writer.Write("MyShop1234$");
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


    class Students  : User
    {
        string user_name;
        int ID;

        public Students(string us , int id)
        {
            user_name = us;
            ID = id;
        }
        public void vorudi()
        {
            Console.WriteLine("Please Enter your name");
            user_name = Console.ReadLine();

            string a = ID.ToString();
            for (int i = 0; i == 0; )
                {
                    Regex rege = new Regex(@"^9[0-9]+");
                    if(rege.IsMatch(a))
                    {
                        i = 1;
                    }
                    else
                    {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The ID is wrong!");
                    Console.WriteLine("what's your ID?");
                    Console.ResetColor();
                    a = Console.ReadLine();
                    }
                }
            using (StreamWriter sw = UserFile.AppendText())
            {
                sw.WriteLine("This is Teacher .");
                sw.WriteLine($"Name :" + user_name);
                sw.WriteLine($"Teaching Place :" + ID);
            }
        }


        public void Save_information()
        {
            string Info = @"D:\university\AP\c#\takalif\tamrin seri 6\CustomersInfo.txt";
            String text = File.ReadAllText(Info);
            StreamWriter Writer = new StreamWriter(@"D:\university\AP\c#\takalif\tamrin seri 6\CustomersInfo.txt");
            Writer.WriteLine(user_name);
            Writer.WriteLine(ID);
            Writer.Close();
        }
    }


    class Teacher : User
    {
        string user_name;
        string mahal_tadris;
        public Teacher(string us , string mah)
        {
            user_name = us;
            mahal_tadris = mah;
        }
        public void vorudi()
        {
            Console.WriteLine("Please Enter your name");
            user_name = Console.ReadLine();
            Console.WriteLine("Please Enter name of the institute/school/university you work");
            mahal_tadris = Console.ReadLine();
        }

        public void SaveToFile()
        {
            using (StreamWriter sw = UserFile.AppendText())
            {
                sw.WriteLine("This is Teacher .");
                sw.WriteLine($"Name :" + user_name);
                sw.WriteLine($"Teaching Place :" + mahal_tadris);
            }
        }
    }


    class Customer : User
    {
        string user_name;
        string Code_Meli;
        public void vorudi()
        {
            Console.WriteLine("Please Enter your name");
            user_name = Console.ReadLine();
            Console.WriteLine("Please Enter name of the institute/school/university you work");
            Code_Meli = Console.ReadLine();
        }

        public void SaveToFile()
        {
            using (StreamWriter sw = UserFile.AppendText())
            {
                sw.WriteLine("This is Teacher .");
                sw.WriteLine($"Name :" + user_name);
                sw.WriteLine($"Teaching Place :" + Code_Meli);
            }
        }
    }


    class Media
    {
        public string Product_Name;
        public double geymat_bedun_maliat;
        public string shenase_kala;

        public Media (string pr , double ge , string she)
        {
            Product_Name = pr;
            geymat_bedun_maliat = ge;
            shenase_kala = she;
        }
    }

    class Books : Media
    {
        string Author;
        string Book_Publisher;
        public Books (string au , string bo , string pr , double ge , string she) : base(pr , ge , she)
        {
            Author = au;
            Book_Publisher = bo;
            Product_Name = pr;
            geymat_bedun_maliat = ge;
            shenase_kala = she;
        }

        public void maliat_bar_arzesh_afzude1()
        {
            double w1 = (geymat_bedun_maliat/10) + geymat_bedun_maliat;
            Console.WriteLine("geymat ketab ba mohasebe maliat bar arzesh afzude = " + w1);
        }
    }


    class Videos : Media
    {
        double time_video;
        int tedad_CD;
        public Videos (double ti , int te , string pr , double ge , string she) : base(pr , ge , she)
        {
            time_video = ti;
            tedad_CD = te;
            Product_Name = pr;
            geymat_bedun_maliat = ge;
            shenase_kala = she;
        }

        public void maliat_bar_arzesh_afzude2()
        {
            int x = 0;
            x = (tedad_CD * 3)/100;
            double w2;
            w2 = geymat_bedun_maliat + (geymat_bedun_maliat * x);
            double y = 0;
            y = time_video/60;
            y = (y*5)/100;
            double w3;
            w3 = geymat_bedun_maliat + (geymat_bedun_maliat * y);
            double w4 = w3 + w2;
            Console.WriteLine("geymat video ba mohasebe maliat bar arzesh afzude = " + w4);
        }
    }

    class Magazines : Media
    {
        string nasher_majale;
        int tedad_safahat;

        public Magazines (string nas , int te , string pr , double ge , string she) : base(pr , ge , she)
        {
            nasher_majale = nas;
            tedad_safahat = te;
            Product_Name = pr;
            geymat_bedun_maliat = ge;
            shenase_kala = she;
        }


        public void maliat_bar_arzesh_afzude3()
        {
            if (tedad_safahat >= 1 && tedad_safahat <= 20)
            {
                double w5 = geymat_bedun_maliat + (geymat_bedun_maliat * (2/100));
                Console.WriteLine("geymat ketab ba mohasebe maliat bar arzesh afzude = " + w5);
            }
            if (tedad_safahat >= 21 && tedad_safahat <= 50)
            {
                double w5 = geymat_bedun_maliat + (geymat_bedun_maliat * (3/100));
                Console.WriteLine("geymat ketab ba mohasebe maliat bar arzesh afzude = " + w5);
            }
            if (tedad_safahat >= 51)
            {
                double w5 = geymat_bedun_maliat + (geymat_bedun_maliat * (5/100));
                Console.WriteLine("geymat ketab ba mohasebe maliat bar arzesh afzude = " + w5);
            }
        }
    }


    class Library
    {
        public string Product_Name1;
        public double geymat_bedun_maliat1;
        public string shenase_kala1;
        string Author1;
        string Book_Publisher1;
        double time_video1;
        int tedad_CD1;
        string nasher_majale1;
        int tedad_safahat1;


        Media c;
        Books B;
        Videos V;
        Magazines M;


        public void AddMedia ()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Add Books or Video or Magazines");
            Console.WriteLine("Books = 1 & Video = 2 & Magazines = 3");
            Console.ResetColor();
            int typee = int.Parse(Console.ReadLine());
            if(typee == 1)
            {
                Author1 = Console.ReadLine();
                Book_Publisher1 = Console.ReadLine();
                Product_Name1 = Console.ReadLine();
                geymat_bedun_maliat1 = double.Parse(Console.ReadLine());
                shenase_kala1 = Console.ReadLine();
                B = new Books (Author1 , Book_Publisher1 , Product_Name1 , geymat_bedun_maliat1 , shenase_kala1);

                string Info = @"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia1.txt";
                String text = File.ReadAllText(Info);
                StreamWriter Writer = new StreamWriter(@"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia1.txt");
                Writer.WriteLine(geymat_bedun_maliat1);
                Writer.WriteLine(shenase_kala1);
                Writer.WriteLine(Author1);
                Writer.WriteLine(Book_Publisher1);
                Writer.WriteLine(Product_Name1);
                Writer.Close();
            }

            if(typee == 2)
            {
                Product_Name1 = Console.ReadLine();
                geymat_bedun_maliat1 = double.Parse(Console.ReadLine());
                shenase_kala1 = Console.ReadLine();
                time_video1 = double.Parse(Console.ReadLine());
                tedad_CD1 = int.Parse(Console.ReadLine());
                V = new Videos (time_video1 , tedad_CD1 , Product_Name1 , geymat_bedun_maliat1 , shenase_kala1);
                
                string Info = @"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia2.txt";
                String text = File.ReadAllText(Info);
                StreamWriter Writer = new StreamWriter(@"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia2.txt");
                Writer.WriteLine(geymat_bedun_maliat1);
                Writer.WriteLine(shenase_kala1);
                Writer.WriteLine(time_video1);
                Writer.WriteLine(tedad_CD1);
                Writer.WriteLine(Product_Name1);
                Writer.Close();
            }

            if(typee == 3)
            {
                Product_Name1 = Console.ReadLine();
                geymat_bedun_maliat1 = double.Parse(Console.ReadLine());
                shenase_kala1 = Console.ReadLine();
                nasher_majale1 = Console.ReadLine();
                tedad_safahat1 = int.Parse(Console.ReadLine());
                M = new Magazines (nasher_majale1 , tedad_safahat1 , Product_Name1 , geymat_bedun_maliat1 , shenase_kala1);
                
                string Info = @"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia3.txt";
                String text = File.ReadAllText(Info);
                StreamWriter Writer = new StreamWriter(@"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia3.txt");
                Writer.WriteLine(geymat_bedun_maliat1);
                Writer.WriteLine(shenase_kala1);
                Writer.WriteLine(nasher_majale1);
                Writer.WriteLine(tedad_safahat1);
                Writer.WriteLine(Product_Name1);
                Writer.Close();
            }
        }

        public void DeleteMedia()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Delete Books or Video or Magazines");
            Console.WriteLine("Books = 1 & Video = 2 & Magazines = 3");
            Console.ResetColor();
            int delet = int.Parse(Console.ReadLine());
            if(delet == 1)
            {
                string Info = @"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia1.txt";
                String text = File.ReadAllText(Info);
                StreamWriter Writer = new StreamWriter(@"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia1.txt");
                Writer.WriteLine(" ");
                Writer.Close();
            }
            
            if(delet == 2)
            {
                string Info = @"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia2.txt";
                String text = File.ReadAllText(Info);
                StreamWriter Writer = new StreamWriter(@"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia2.txt");
                Writer.WriteLine(" ");
                Writer.Close();
            }

            if(delet == 3)
            {
                string Info = @"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia3.txt";
                String text = File.ReadAllText(Info);
                StreamWriter Writer = new StreamWriter(@"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia3.txt");
                Writer.WriteLine(" ");
                Writer.Close();
            }
        }

        public void SearchMedia()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Search Books or Video or Magazines");
            Console.WriteLine("Books = 1 & Video = 2 & Magazines = 3");
            Console.ResetColor();
            int searche = int.Parse(Console.ReadLine());
            if(searche == 1)
            {
                string Info = @"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia1.txt";
                String text = File.ReadAllText(Info);
                Console.WriteLine(text);
            }
            
            if(searche == 2)
            {
                string Info = @"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia2.txt";
                String text = File.ReadAllText(Info);
                Console.WriteLine(text);
            }

            if(searche == 3)
            {
                string Info = @"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia3.txt";
                String text = File.ReadAllText(Info);
                Console.WriteLine(text);
            }
        }
    }

    class sabad_kharid
    {
        string Product_Name;
        public void namayesh_kalaha()
        {
            string Info = @"D:\university\AP\c#\takalif\tamrin seri 6\AddMedia\AddMedia1.txt";
            String text = File.ReadAllText(Info);
            Console.WriteLine(text);
        }
    }

    class program
    {
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
                            Console.WriteLine("what's your email?");
                            Console.ResetColor();
                            string email = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("What is the password?");
                            Console.ResetColor();
                            string pass = Console.ReadLine();
                            Seller s = new Seller(email , pass);
                            int number = 0;
                            if (Pas(pass))
                            {
                                s.email_chek();
                                //neshan dadan list
                                for(;number != 6 ;)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("ADD or DELETE or SEARCH or SHOWCUSTOMERS or CHANGEPASS or EXIT");
                                    Console.WriteLine("ADD = 1 & DELETE = 2 & SEARCH = 3 & SHOWCUSTOMERS = 4 & CHANGEPASS = 5 & EXIT = 6");
                                    Console.WriteLine("What's the order?");
                                    Console.ResetColor();
                                    number = int.Parse(Console.ReadLine());
                                    Library L = new Library();
                                    if(number == 1)
                                    {
                                        L.AddMedia();
                                    }
                                    if(number == 2)
                                    {
                                        L.DeleteMedia();
                                    }
                                    if(number == 3)
                                    {
                                        L.SearchMedia();
                                    }
                                    if(number == 4)
                                    {
                                        string Info = @"D:\university\AP\c#\takalif\tamrin seri 6\customer\CustomersInfo.txt";
                                        String text1 = File.ReadAllText(Info);
                                        Console.WriteLine(text1);
                                    }
                                    if(number == 5)
                                    {
                                        
                                    }
                                }
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
                                Console.WriteLine("(Students and Collegian) = 1 or (Teachers and Professors) = 2 or normal People = 3");
                                Console.ResetColor();
                                int user_0 = int.Parse(Console.ReadLine());
                                if (user_0 == 1)
                                {
                                    Console.WriteLine("ID va user name ra vared konid");
                                    string user_name1 = Console.ReadLine();
                                    int ID1 = int.Parse(Console.ReadLine());
                                    Students s1 = new Students (user_name1 , ID1);
                                    s1.vorudi();
                                    s1.Save_information();

                                    //dar akhar 20% takhfif
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("SELECT or EDIT or BUY or CHANCE or EXIT");
                                    Console.WriteLine("SELECT = 1 & EDIT = 2 & BUY = 3 & CHANCE = 4 & EXIT = 5");
                                    Console.ResetColor();
                                    int product1 = int.Parse(Console.ReadLine());
                                    if(product1 == 1)
                                    {
                                        sabad_kharid sa = new sabad_kharid();
                                        sa.namayesh_kalaha();
                                    }
                                }

                                if (user_0 == 2)
                                {
                                    string user_name2 = Console.ReadLine();
                                    string mahal_tadris2 = Console.ReadLine();
                                    Teacher s2 = new Teacher (user_name2 , mahal_tadris2);
                                    s2.vorudi();
                                    s2.SaveToFile();

                                    //15% takhfif bara kharid bishtar az 3 kala
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("SELECT or EDIT or BUY or CHANCE or EXIT");
                                    Console.WriteLine("SELECT = 1 & EDIT = 2 & BUY = 3 & CHANCE = 4 & EXIT = 5");
                                    Console.ResetColor();
                                    int product1 = int.Parse(Console.ReadLine());
                                    if(product1 == 1)
                                    {
                                        sabad_kharid sa = new sabad_kharid();
                                        sa.namayesh_kalaha();
                                    }
                                }

                                if(user_0 == 3)
                                {
                                    string user_name3 = Console.ReadLine();
                                    int Code_Meli3 = int.Parse(Console.ReadLine());
                                    Customer s3 = new Customer ();
                                    s3.vorudi();
                                    s3.SaveToFile();

                                    //5% takhfif bara kharid bishtar az 5 kala
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("SELECT or EDIT or BUY or CHANCE or EXIT");
                                    Console.WriteLine("SELECT = 1 & EDIT = 2 & BUY = 3 & CHANCE = 4 & EXIT = 5");
                                    Console.ResetColor();
                                    int product1 = int.Parse(Console.ReadLine());
                                    if(product1 == 1)
                                    {
                                        sabad_kharid sa = new sabad_kharid();
                                        sa.namayesh_kalaha();
                                    }
                                }
                            }
                            while (i==0);
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
            } while (input.ToLower() != "EXIT");
        }
    }
}
}

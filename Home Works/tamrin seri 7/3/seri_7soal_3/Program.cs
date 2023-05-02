using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seri_7soal_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines(@"D:\university\AP\c#\takalif\tamrin seri 7\3\zip\CSVParser\CSVParser\CSVParser\IMDB-Movie-Data.csv")
                .Skip(1)
                .Select(line => new IMDBData(line));

            // If necessary, you can use more than one extension method to calculate these answers.
            //Console.WriteLine($"Question 1: {data.ExtensionMethodPlaceHolder()}");
            //Console.WriteLine($"Question 2: {data.ExtensionMethodPlaceHolder()}");
            //Console.WriteLine($"Question 3: {data.ExtensionMethodPlaceHolder()}");
            //Console.WriteLine($"Question 4: {data.ExtensionMethodPlaceHolder()}");
            //Console.WriteLine($"Question 5: {data.ExtensionMethodPlaceHolder()}");
            //Console.WriteLine($"Question 6: {data.ExtensionMethodPlaceHolder()}");
            //Console.WriteLine($"Question 7: {data.ExtensionMethodPlaceHolder()}");
            //Console.WriteLine($"Question 8: {data.ExtensionMethodPlaceHolder()}");
            //Console.WriteLine($"Question 9: {data.ExtensionMethodPlaceHolder()}");
            //Console.WriteLine($"Question 10: {data.ExtensionMethodPlaceHolder()}");


            Console.WriteLine("Question 1 :");
            Console.WriteLine("");
            data.Q1();
            Console.WriteLine("");

            Console.WriteLine("Question 2 :");
            Console.WriteLine("");
            data.Q2();
            Console.WriteLine("");

            Console.WriteLine("Question 3 :");
            Console.WriteLine("");
            Console.WriteLine("Title :" + data.Q3().Title); Console.WriteLine("Genre :" + data.Q3().Genre);
            Console.WriteLine("Director :" + data.Q3().Director);
            Console.WriteLine("Actors :" + data.Q3().Actor1 + "," + data.Q3().Actor2 + "," + data.Q3().Actor3 + "," + data.Q3().Actor4);
            Console.WriteLine("Year :" + data.Q3().Year); Console.WriteLine("Runtime :" + data.Q3().Runtime);
            Console.WriteLine("Rating :" + data.Q3().Rating); Console.WriteLine("Votes :" + data.Q3().Votes);
            Console.WriteLine("Revenue :" + data.Q3().Revenue); Console.WriteLine("Metascore :" + data.Q3().Metascore);
            Console.WriteLine("");

            Console.WriteLine("Question 4 :");
            Console.WriteLine("");
            data.Q4();
            Console.WriteLine("");

            Console.WriteLine("Question 5 :");
            Console.WriteLine("");
            data.Q5();
            Console.WriteLine("");

            Console.WriteLine("Question 6 :");
            Console.WriteLine("");
            data.Q6();
            Console.WriteLine("");

            Console.WriteLine("Question 7 :");
            Console.WriteLine("");
            data.Q7();
            Console.WriteLine("");

            Console.WriteLine("Question 8 :");
            Console.WriteLine("");
            data.Q8();
            Console.WriteLine("");

            Console.WriteLine("Question 9 :");
            Console.WriteLine("");
            data.Q9();
            Console.WriteLine("");

            Console.WriteLine("Question 10 :");
            Console.WriteLine("");
            data.Q10();
            Console.WriteLine("");
        }
    }


    public static class Extensions
    {
        public static Nullable<int> ParseIntOrNull(this string str)
            => !string.IsNullOrEmpty(str) ? int.Parse(str) as Nullable<int> : null;
        public static string ParseStringOrNull(this string str)
            => !string.IsNullOrEmpty(str) ? str : null;

        //For example
        public static IMDBData GetHighestMetascore(this IEnumerable<IMDBData> data)
            => data.OrderByDescending(x => x.Metascore).First();

        /// <summary>
        /// you must modify the name of this method and its 
        /// implementation to fit your need and create more methods like this
        public static IMDBData ExtensionMethodPlaceHolder(this IEnumerable<IMDBData> data)
            => data.First();

        public static void Q1(this IEnumerable<IMDBData> data)
        {
            var qu1 = data.Where(x => x.Runtime < 100).Select(y => y.Genre).Distinct();
            foreach (var S1 in qu1)
            {
                Console.Write(S1 + "    ");
            }
            Console.WriteLine();

        }

        public static void Q2(this IEnumerable<IMDBData> data)
        {
            var qu2 = data.Where(x => x.Actor1.Contains("Vin Diesel") || x.Actor2.Contains("Vin Diesel") ||
                     x.Actor3.Contains("Vin Diesel") || x.Actor4.Contains("Vin Diesel")).Select(x => x.Director).Distinct();
            foreach (var S2 in qu2)
            {
                Console.Write(S2 + "    ");
            }
            Console.WriteLine();
        }
        public static IMDBData Q3(this IEnumerable<IMDBData> data)
        {
            var qu3 = data.Where(x => x.Year == 2016).OrderByDescending(x => x.Votes).First();
            return qu3;
        }
        public static void Q4(this IEnumerable<IMDBData> data)
        {
            var qu4 = data.Where(x => x.Director.Contains("Bryan Singer")).OrderByDescending(x => double.Parse(x.Revenue)).Select(x => new { Title = x.Title, Revenue = x.Revenue });
            foreach (var item in qu4)
            {
                Console.WriteLine("Title : " + item.Title + "," + "Revenue : " + item.Revenue);
            }
        }
        public static void Q5(this IEnumerable<IMDBData> data)
        {
            var qu5 = data.Where(x => x.Year == 2011).Select(x => double.Parse(x.Revenue)).Sum();
            Console.WriteLine(qu5);

        }
        public static void Q6(this IEnumerable<IMDBData> data)
        {
            var qu6 = data.Where(x => x.Genre == "Action" && x.Runtime > 120).OrderByDescending(x => double.Parse(x.Revenue)).Select(x => x.Title).Take(10);
            foreach (var item in qu6)
            {
                Console.WriteLine(item);
            }
        }
        public static void Q7(this IEnumerable<IMDBData> data)
        {
            var qu7 = data.Select(x => x.Title);
            foreach (var item in qu7)
            {
                if (item.Any(x => char.IsDigit(x)))
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void Q8(this IEnumerable<IMDBData> data)
        {
            var qu8 = data.Where(x => x.Actor1.Contains("Jennifer Lawrence") || x.Actor2.Contains("Jennifer Lawrence") ||
                      x.Actor3.Contains("Jennifer Lawrence") | x.Actor4.Contains("Jennifer Lawrence")).OrderBy(x => x.Year).OrderByDescending(x => x.Rating);
            var qu81 = data.Where(x => x.Actor1.Contains("Anne Hathaway") || x.Actor2.Contains("Anne Hathaway") ||
                    x.Actor3.Contains("Anne Hathaway") | x.Actor4.Contains("Anne Hathaway")).OrderBy(x => x.Year).OrderByDescending(x => x.Rating);
            Console.WriteLine("Jennifer Lawrence :");
            foreach (var item in qu8)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Anne Hathaway:");

            foreach (var item in qu81)
            {
                Console.WriteLine(item.Title);
            }

        }
        public static void Q9(this IEnumerable<IMDBData> data)
        {
            int countdarama = 0, countcomedy = 0;
            var qu9 = data.Where(x => x.Genre.Contains("Comedy") && double.Parse(x.Rating) > 8).Select(x => x.Title);
            var qu91 = data.Where(x => x.Genre.Contains("Drama") && double.Parse(x.Rating) > 8).Select(x => x.Title);
            foreach (var item in qu9)
            {
                Console.WriteLine(item);
                countcomedy++;
            }
            Console.WriteLine("Count of Comedy Movies : " + countcomedy);
            Console.WriteLine(); Console.WriteLine();
            foreach (var item in qu91)
            {
                Console.WriteLine(item);
                countdarama++;
            }
            Console.WriteLine("Count of Drama Movies : " + countdarama);

        }
        public static void Q10(this IEnumerable<IMDBData> data)
        {
            var qu10 = data.Where(x => float.Parse(x.Rating) < 7)
                .SelectMany(x => new List<string>() { x.Actor1, x.Actor2, x.Actor3, x.Actor4 })
                .GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).First();

            Console.WriteLine(qu10);

        }
    }

    public class IMDBData
    {
        public IMDBData(string line)
        {
            var toks = line.Split(',');
            Rank = int.Parse(toks[0]);
            Title = toks[1];
            Genre = toks[2];
            Director = toks[3];
            Actor1 = toks[4];
            Actor2 = toks[5];
            Actor3 = toks[6];
            Actor4 = toks[7];
            Year = int.Parse(toks[8]);
            Runtime = int.Parse(toks[9]);
            Rating = (toks[10]);
            Votes = int.Parse(toks[11]);
            Revenue = toks[12].ParseStringOrNull();
            Metascore = toks[13].ParseIntOrNull();
        }
        public int Rank;
        public string Title;
        public string Genre;
        public string Director;
        public string Actor1;
        public string Actor2;
        public string Actor3;
        public string Actor4;
        public int Year;
        public int Runtime;
        public string Rating;
        public int Votes;
        public string Revenue;
        public Nullable<int> Metascore;
    }
}

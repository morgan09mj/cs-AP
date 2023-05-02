using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines(@"D:\university\AP\c#\takalif\tamrin seri 7\3\zip\CSVParser\CSVParser\CSVParser\IMDB-Movie-Data.csv")
                .Skip(1)
                .Select(line => new IMDBData(line));
            Console.WriteLine($"The film with highest metascore : {data.GetHighestMetascore().Title}");
            // If necessary, you can use more than one extension method to calculate these answers.
            Console.WriteLine("QUESTION 1 :");
            data.Q1();
            Console.WriteLine("#########################################################");
            Console.WriteLine($"Question 1: {data.ExtensionMethodPlaceHolder()}");
            Console.WriteLine($"Question 2: {data.ExtensionMethodPlaceHolder()}");
            Console.WriteLine($"Question 3: {data.ExtensionMethodPlaceHolder()}");
            Console.WriteLine($"Question 4: {data.ExtensionMethodPlaceHolder()}");
            Console.WriteLine($"Question 5: {data.ExtensionMethodPlaceHolder()}");
            Console.WriteLine($"Question 6: {data.ExtensionMethodPlaceHolder()}");
            Console.WriteLine($"Question 7: {data.ExtensionMethodPlaceHolder()}");
            Console.WriteLine($"Question 8: {data.ExtensionMethodPlaceHolder()}");
            Console.WriteLine($"Question 9: {data.ExtensionMethodPlaceHolder()}");
            Console.WriteLine($"Question 10: {data.ExtensionMethodPlaceHolder()}");
            string a = Console.ReadLine();
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


        //soal 1
        public static void Q1(this IEnumerable<IMDBData> data)
        {
            var qu1 = data.Where(x => x.Runtime < 100).Select(y => y.Genre).Distinct();
            foreach (var item in qu1)
            {
                Console.Write(item + "    ");
            }
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

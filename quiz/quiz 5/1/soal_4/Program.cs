using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Digimon> digimonlist = File.ReadAllLines(@"D:\university\AP\c#\quiz\quiz 5\DigiDB_digimonlist.csv")
                .Skip(1)
                .Select(line => new Digimon(
                    int.Parse(line.Split(',')[0]),
                    line.Split(',')[1],
                    line.Split(',')[2],
                    line.Split(',')[3],
                    line.Split(',')[4],
                    int.Parse(line.Split(',')[5]),
                    int.Parse(line.Split(',')[6]),
                    int.Parse(line.Split(',')[7]),
                    int.Parse(line.Split(',')[8]),
                    int.Parse(line.Split(',')[9]),
                    int.Parse(line.Split(',')[10]),
                    int.Parse(line.Split(',')[11]),
                    int.Parse(line.Split(',')[12])))
                .ToList<Digimon>();
            printList(digimonlist, 5);
            // start coding from here

            Console.WriteLine("Question 1 :");
            digimonlist.Q1();
            Console.WriteLine("");

            Console.WriteLine("Question 2 :");
            digimonlist.Q2();
            Console.WriteLine("");
        }

        public static void printList(List<Digimon> digilist, int top)
        {
            int counter = 0;
            Digimon.printHeaders();
            foreach (Digimon i in digilist)
            {
                if (counter == top) break;
                counter++;
                i.print();
            }

        }

        public static void Q1(this IEnumerable<Digimon> data)
        {
            var qu1 = data.Where(x => x.Type == "Virus" && x.SP > 100).Select(y => y.DigimonName).Distinct();
            foreach (var S1 in qu1)
            {
                Console.Write(S1 + "    ");
            }
            Console.WriteLine();

        }

        public static void Q2(this IEnumerable<Digimon> data)
        {
            List<Digimon> qu1 = data.Where(x => x.Attribute == "Fire").Select(y => y.DigimonName).Distinct().ToList;
            foreach (var S1 in qu1)
            {
                Console.Write(S1 + "    ");
            }
            Console.WriteLine();

        }

        public class Digimon
        {
            public int Number;
            public string DigimonName;
            public string Stage;
            public string Type;
            public string Attribute;
            public int Memory;
            public int Equip_Slots;
            public int HP;
            public int SP;
            public int Atk;
            public int Def;
            public int Int;
            public int Spd;
            public Digimon(int Number,
            string DigimonName,
            string Stage,
            string Type,
            string Attribute,
            int Memory,
            int Equip_Slots,
            int HP,
            int SP,
            int Atk,
            int Def,
            int Int,
            int Spd)
            {
                this.Number = Number;
                this.DigimonName = DigimonName;
                this.Stage = Stage;
                this.Type = Type;
                this.Attribute = Attribute;
                this.Memory = Memory;
                this.Equip_Slots = Equip_Slots;
                this.HP = HP;
                this.SP = SP;
                this.Atk = Atk;
                this.Def = Def;
                this.Int = Int;
                this.Spd = Spd;
            }

            public void print()
            {
                Console.WriteLine(String.Format("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} {5,-10} {6,-16} {7,-6} {8,-6} {9,-6} {10,-6} {11,-6} {12,-6}\n",
            Number,
            DigimonName,
            Stage,
            Type,
            Attribute,
            Memory,
            Equip_Slots,
            HP,
            SP,
            Atk,
            Def,
             Int,
             Spd));
            }
            public static void printHeaders()
            {
                Console.WriteLine(String.Format("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} {5,-10} {6,-16} {7,-6} {8,-6} {9,-6} {10,-6} {11,-6} {12,-6}\n",
            "Number",
            "DigimonName",
            "Stage",
            "Type",
            "Attribute",
            "Memory",
            "Equip Slots",
            "HP",
            "SP",
            "Atk",
            "Def",
            "Int",
            "Spd"));
            }
        }
    }
}

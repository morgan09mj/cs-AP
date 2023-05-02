using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp2
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

            var question1 = digimonlist.Where(x => x.Type == "Virus" && x.SP > 100)
                                        .ToList();
            Console.WriteLine("____________________________________________________________________________________________________\n");
            Console.WriteLine("Question1:\n");
            PrintAllList(question1);

            var question2 = digimonlist.Where(n => n.Attribute == "Fire")
                        .Select(n => new { DigiName = n.DigimonName, Stage = n.Stage, Hp = n.HP, Atk = n.Atk })
                        .ToList();

            Console.WriteLine("____________________________________________________________________________________________________\n");
            Console.WriteLine("Question2:\n");
            foreach (var i in question2)
            {
                Console.WriteLine($"Diginame: { i.DigiName }, Stage: {i.Stage}, HP: {i.Hp}, ATK: {i.Atk}");
            }

            var question3 = digimonlist.GroupBy(x => x.Attribute)
                                        .Select(x => $"{ x.Key}: {x.Key.Count()}")
                                        .ToList();

            Console.WriteLine("____________________________________________________________________________________________________\n");
            Console.WriteLine("Question3:\n");
            foreach (var i in question3)
            {
                Console.WriteLine(i);
            }

            var question4 = digimonlist.Where(
                                                x =>
                                                  x.Atk > digimonlist.Average(y => y.Atk)
                                                || x.HP > digimonlist.Average(z => z.HP)
                                                || x.SP > digimonlist.Average(h => h.SP)
                                              )
                                        .ToList();
            Console.WriteLine("____________________________________________________________________________________________________\n");
            Console.WriteLine("Question4:\n");
            PrintAllList(question4);

            var question5 = digimonlist.Where(x => x.Type == "Free" && x.Memory == digimonlist.Max(y => y.Memory))
                                            .ToList();

            Console.WriteLine("____________________________________________________________________________________________________\n");
            Console.WriteLine("Question5:\n");
            PrintAllList(question5);
            var question6 = digimonlist.GroupBy(x => x.Stage)
                                        .Select(x => $"{ x.Key}: {x.Key.Count()}")
                                        .ToList();
            Console.WriteLine("____________________________________________________________________________________________________\n");
            Console.WriteLine("Question6:\n");
            foreach (var i in question6)
            {
                Console.WriteLine(i);
            }
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
        public static void PrintAllList(List<Digimon> digilist)
        {
            Digimon.printHeaders();
            foreach (Digimon i in digilist)
            {
                i.print();
            }
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_4
{

    class Media
    {
        protected int ID;
        protected string name;
        protected double geymat;
        protected int tedad;
        public Media(string na , double ge , int te)
        {
            if(ge >= 0 && te >= 0 && na != null)
            {
                name = na;
                geymat = ge;
                tedad = te;
            }
            Random rand = new Random();
            ID = rand.Next(0 , 10000);
        }
        public void namayesh_mohtava()
        {
            Console.WriteLine("name :" + name + "geymat :" + geymat);
            if(tedad != 0)
            {
                Console.WriteLine("mojud hast");
            }
            else
            {
                Console.WriteLine("mojud nist");
            }
        }


        public void sharje_mojudi(int ted)
        {
            tedad = tedad + ted;
        }
    }

    class Book : Media
    {
        protected string nevisande;
        protected int sale_enteshar;

        public Book(string nev , int sal , string na , double ge , int te) : base( na ,  ge , te)
        {
            nevisande = nev;
            sale_enteshar = sal;
            if(ge >= 0 && te >= 0 && na != null)
            {
                name = na;
                geymat = ge;
                tedad = te;
            }
        }

        public void namayesh_mohtava()
        {
            Console.WriteLine("name :" + name + "geymat :" + geymat);
            if(tedad != 0)
            {
                Console.WriteLine("mojud hast");
            }
            else
            {
                Console.WriteLine("mojud nist");
            }
            Console.WriteLine("nevisande : " + nevisande + "sale_enteshar : " + sale_enteshar);
        }


        public void kharid(int teda , double hazine_pardakhti)
        {
            if(teda <= tedad && hazine_pardakhti == geymat)
            {
                Console.WriteLine("kharid anjam shod");
                tedad = tedad - 1;
            }
            else
            {
                Console.WriteLine("emkan kharid vojud nadarad");
            }
        }
    }


    class Magazine : Book
    {
        private int mah_enteshar;
        private int tedad_safhe;
        private int mizan_forosh = 0;

        public Magazine (int mah , int tedad_sa , string nev , int sal , string na , double ge , int te) : base (nev ,  sal ,  na ,  ge ,  te)
        {
            nevisande = nev;
            sale_enteshar = sal;
            if(ge >= 0 && te >= 0 && na != null)
            {
                name = na;
                geymat = ge;
                tedad = te;
            }
            mah_enteshar = mah;
            tedad_safhe = tedad_sa;
        }
        
        public void namayesh_mohtava()
        {
            Console.WriteLine("name :" + name + "geymat :" + geymat);
            if(tedad != 0)
            {
                Console.WriteLine("mojud hast");
            }
            else
            {
                Console.WriteLine("mojud nist");
            }
            Console.WriteLine("nevisande : " + nevisande + "sale_enteshar : " + sale_enteshar);
            Console.WriteLine("mizan_forosh : " + mizan_forosh);
        }
    
        public void kharid(int teda , double hazine_pardakhti)
        {
            if(teda <= tedad && hazine_pardakhti == geymat)
            {
                Console.WriteLine("kharid anjam shod");
                mizan_forosh = mizan_forosh + 1;
                tedad = tedad - 1;
            }
            else
            {
                Console.WriteLine("emkan kharid vojud nadarad");
            }
            Console.WriteLine("mizan_forosh : " + mizan_forosh);
        }
    }

    enum noe
    {
        startegy , 
        fekry ,
        varzeshy
    }

    enum sabke
    {
        aval_shakhs ,
        sevom_shakhs
    }

    enum rade
    {
        kudakan ,
        nojavanan ,
        javanan
    }
    class Game : Media
    {
        protected noe noe_bazi;
        protected string sharh;
        protected sabke sabk;
        protected rade rade_seni;
        public Game (noe noe_ba , string sha , sabke sab , rade radee , string na , double ge , int te) : base (na ,  ge , te)
        {
            noe_bazi = noe_ba;
            sharh = sha;
            sabk = sab;
            rade_seni = radee;
            if(ge >= 0 && te >= 0 && na != null)
            {
                name = na;
                geymat = ge;
                tedad = te;
            }
        }
        public void namayesh_mohtava()
        {
            Console.WriteLine("name :" + name + "geymat :" + geymat);
            if(tedad != 0)
            {
                Console.WriteLine("mojud hast");
            }
            else
            {
                Console.WriteLine("mojud nist");
            }
            Console.WriteLine("noe bazi : " + noe_bazi + "sabk bazi : " + sabk);
        }

        public void kharid(int teda , double hazine_pardakhti)
        {
            if(teda <= tedad && hazine_pardakhti == geymat)
            {
                Console.WriteLine("kharid anjam shod");
                tedad = tedad - 1;
            }
            else
            {
                Console.WriteLine("emkan kharid vojud nadarad");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string nam = Console.ReadLine();
            double geyma = double.Parse(Console.ReadLine());
            int teda = int.Parse(Console.ReadLine());
            Media c = new Media(nam , geyma , teda);
            c.namayesh_mohtava();
            int tedad_mored_nazarrr = int.Parse(Console.ReadLine());
            c.sharje_mojudi(tedad_mored_nazarrr);
            string nevisande = Console.ReadLine();
            int sale_enteshar = int.Parse(Console.ReadLine());
            Book c2 = new Book(nevisande , sale_enteshar , nam , geyma , teda);
            int tedad_mored_nazarr = int.Parse(Console.ReadLine());
            double hazine_pa = double.Parse(Console.ReadLine());
            c2.kharid(tedad_mored_nazarr , hazine_pa);
            c2.namayesh_mohtava();
            int mah_enteshar = int.Parse(Console.ReadLine());
            int tedad_safhe = int.Parse(Console.ReadLine());
            Magazine c3 = new Magazine(mah_enteshar , tedad_safhe , nevisande , sale_enteshar , nam , geyma , teda);
            int tedad_mored_nazarrrr = int.Parse(Console.ReadLine());
            double hazine_pa = double.Parse(Console.ReadLine());
            c3.sharje_mojudi(tedad_mored_nazarrrr);
            c3.kharid()
        }
    }
}

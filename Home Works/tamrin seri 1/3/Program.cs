using System;

namespace _3
{
    class Program
    {
        public static int adad_afzayeshi = 2; 
        static bool khoshshans(int n)
        {
            int adad_morednazar = n;
            if(adad_afzayeshi > n)
                return true;
            if(n % adad_afzayeshi == 0)
                return false;     
            adad_morednazar = adad_morednazar - adad_morednazar / adad_afzayeshi;
            adad_afzayeshi++;
            return khoshshans(adad_morednazar);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(khoshshans(n))
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
        }
    }
}

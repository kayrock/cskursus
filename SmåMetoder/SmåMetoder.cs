using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmåMetoder
{
    class SmåMetoder
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);  //78.53

            Udskriv("Dette er en test"); //Dette er en test

            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns); //15000


            Console.Read();
        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(int radius)
        {
            return ((radius * radius) * System.Math.PI);
        }

        static void Udskriv(String txt)
        {
            Console.WriteLine();
        }

        static double Gennemsnit(int[] månedsløn)
        {
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];

            }

            return sum / månedsløn.Length;
        }




       

    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Funktionspointer_v2
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            sum = Beregner(1,10, Plus);
            Console.WriteLine("Plus: "+ sum);
            sum = Beregner(10,1, Minus);
            Console.WriteLine("Minus: " + sum);
            sum = Beregner(10, 2, Divider);
            Console.WriteLine("Divider: " + sum);
            sum = Beregner(10, 2, Gange);
            Console.WriteLine("Gange: " + sum);

            Console.Read();        }

        public static int Beregner(int a, int b, Func<int, int, int> funktion)
        {
            return funktion(a, b);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {

            return a - b;
        }

        public static int Divider(int a, int b)
        {

            return a / b;

        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyer
{
    class Program
    {
        static void Main(string[] args)
        {

            terninger t = new terninger();
            t.Terning1 = 3;
            t.Terning2 = 2;


            var slag = "Du slog: ["+t.Terning1+"]" + " og " + "["+t.Terning2+"]";

            Console.WriteLine(slag);
            Console.Read();
        }
    }
    class terninger
    {
        private int terning1;

        public int Terning1
        {
            get { return terning1; }
            set {
                if (terning1 >0 || terning1 >7)
                {
                    terning1 = 1;
                }

                terning1 = value; }
        }

        private int terning2;

        public int Terning2
        {
            get { return terning2; }
            set { terning2 = value; }
        }


    }
}

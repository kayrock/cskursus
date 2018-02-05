using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trekant
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(6,3);
            Console.WriteLine(t);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    public class Trekant
    {
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }

        public Trekant(int grundlinje, int højde)
        {
            this.Grundlinje = grundlinje;
            this.Højde = højde;
        }

        public double Areal
        {
            get
            {
                return this.Grundlinje * this.Højde * 0.5;
            }

        }


    }

   

}

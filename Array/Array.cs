using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Array
    {
        static void Main(string[] args)
        {


            int[] månedsløn = { 10000, 20000, 15000, 30000, 15000 };
            int sum = 0;

            for (int i = 0; i < månedsløn.Length; i++) 
            {
                //Læg alle sammen til
                sum += månedsløn[i];

                //Udskriv alle valuta
                Console.WriteLine(månedsløn[i]);
              
            }

            Console.WriteLine("Total ammount: " + sum);

            int gennemsnit = sum / månedsløn.Length;





            //Array med tilfældige månelønninger, udskriv disse samt en beregnet gennemsnit

            //int[] månedLøn = { 10000, 20000, 15000, 30000, 15000 };
            //double sum = 0;

            //for (int i = 0; i < månedLøn.Length; i++)
            //{
            //    //Console.WriteLine(månedLøn[i]);
            //    sum += månedLøn[i];
            //}

            //double gns = sum / månedLøn.Length;

            //for (int i = 0; i < månedLøn.Length; i++)
            //{
            //    Console.WriteLine(månedLøn[i]);
            //}
            //Console.WriteLine("Gennemsnit " + gns);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}

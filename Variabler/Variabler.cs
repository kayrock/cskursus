

namespace Variabler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   
        enum Filtyper {
            csv,
            pdf,
            txt
        }

        struct Person
        {
            public int Id;
           public string Navn;
        }

    class Variabler
    {
        static void Main(string[] args)
        {

            //Heltal punkt1
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;

            Console.WriteLine(heltal.ToString());


            //double punkt 2
            double kommaTal = 12.5;

            kommaTal++;
            kommaTal--;
            kommaTal *= 2;

            Console.WriteLine(kommaTal.ToString());

            //enum punkt 3

            var ft = Filtyper.csv;

            Console.WriteLine(ft.ToString());

            // dato punkt 4

            DateTime dato = DateTime.Now;

            Console.WriteLine(dato.ToString("ddMMyy"));

            // Struktur, punkt 5
            Person p;

            p.Id = 1;
            p.Navn = "Mikkel";

            Console.WriteLine(p.Navn);





            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }

    }
}

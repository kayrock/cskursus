﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    class String
    {
        static void Main(string[] args)
        {

            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            StringBuilder FullName = new StringBuilder( fornavn + " " + efternavn);
            Console.WriteLine(FullName);

            string navnStort =  FullName.ToString().ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = FullName.ToString().ToLower();
            Console.WriteLine(navnLille);

            string del = FullName.ToString().Substring(7, 4);
            Console.WriteLine(del);

            
            
           

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();



            }
        }
    }
}

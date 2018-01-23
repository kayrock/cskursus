using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Metoder
    {
        static void Main(string[] args)
        {

            // 10-tabel
            for (int x = 1; x < 11; x++)
            {
                for (int y = 1; y < 11; y++)
                {
                    string number = (x * y).ToString();

                    if ((x*y) > 50)
                    
                        Console.ForegroundColor = ConsoleColor.Red;
                        
                    
                    else
                    
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(number.PadLeft(5));
                

                }
                Console.WriteLine();
            }






            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}

using System;

namespace Module02_HelloWorld
{
    class Program
    {
        /// <summary>
        /// Denne metode...
        /// </summary>
        /// <param name="args">Dækker følgende</param>
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("Er det en god dag i dag ??");
            Console.WriteLine("Task J for JA og N for NEJ...");


            Vejr();
            

            Console.Write("1");
            Console.Write("2");
            Console.Write("3");

          
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        static void Vejr()
        {
            
            string kurt = Console.ReadLine();
            if (kurt == "J")
            {
                Console.WriteLine("Ja det syntes jeg også :-)");
            }

            else
            {
                Console.WriteLine("Nej det er meget trist, det har du ret i..");
            }

        }

        static void DebugDemo() {

            int i = 10;
            int u = 20;
            u = u + i;
            string name = "Mikkel";
            System.Console.WriteLine(name);
            string upperName = name.ToUpper();
            System.Console.WriteLine(upperName);

            for (int x = 0; x < 3; x++)
            {
                u += x;
            }

            Test1(5);

        }

        static void Test1(int i)
        {
            i++;
            Test2(i);
        }

        static void Test2(int i)
        {
            i--;
            Test3(i);
        }

        static void Test3(int i)
        {
            i++;
        }
    }
}

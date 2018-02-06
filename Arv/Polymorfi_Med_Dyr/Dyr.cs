using System;

namespace Polymorfi_Med_Dyr
{
    partial class Program
    {
        partial class Dyr
        {

            public string Navn { get; set; }

            static System.Random rnd = new Random();


            public virtual void SigNoget()
            {
                Console.WriteLine("Jeg er et dyr og hedder..." + Navn);
            }

            public static Dyr TilfældigtDyr()
            {
                string sti = @"x:\dyrenavne.txt";
                string[] navne = System.IO.File.ReadAllLines(sti);
                int index = rnd.Next(0, navne.Length);
                if (index % 2 == 0)
                {
                    return new Hund() { Navn = navne[index] };
                }
                else
                {
                    return new Kat() { Navn = navne[index] };
                }
                
            }
        }

        


    }
}

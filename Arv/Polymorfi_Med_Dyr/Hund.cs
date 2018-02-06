using System;

namespace Polymorfi_Med_Dyr
{
    partial class Program
    {

        partial class Dyr
        {
            public class Hund :Dyr
            {
                
                

                public override void SigNoget()
                {
                    Console.WriteLine("Jeg er en hund og hedder..." + Navn);
                }
            }
        }

        


    }
}
